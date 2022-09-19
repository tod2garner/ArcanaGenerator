using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine
{
    public class Spell
    {
        public string Name;

        public SchoolOfMagic School;

        public Components Components;

        public CastTime CastTime;

        public EffectBase Effect;

        public Delivery Delivery;

        public Aesthetic Aesthetic;

        public bool RequiresConcentration;

        public bool Ritual;

        public PenaltyEffect CasterPenaltyCost;

        public Dictionary<string, double> PowerRatingFactors;

        public double FinalPowerRating
        {
            get
            {
                var result = Effect?.BasePowerRating ?? 0;

                if (PowerRatingFactors is null)
                    return result;

                foreach (var factor in PowerRatingFactors)
                {
                    result *= factor.Value;
                }

                return Math.Ceiling(result - (CasterPenaltyCost?.GetPowerRating() ?? 0));
            }
        }

        public void UpdatePowerRatingFactors()
        {
            PowerRatingFactors = new Dictionary<string, double>();

            var factors = new List<KeyValuePair<string, double>>();
            factors.AddRange(Effect.GetPowerRatingFactors());
            factors.AddRange(Delivery.GetPowerRatingFactors());
            factors.AddRange(GetMiscPowerRatingFactors());

            foreach(var f in factors)
            {
                if (f.Value != 1)
                    PowerRatingFactors.Add(f.Key, Math.Round(f.Value, 2));
            }
        }

        public string GetSpellLevelSummary()
        {
            int low;
            int high;
            var power = FinalPowerRating;

            if(power < 40)
            {
                low = 0;
                high = 2;
            }
            else if (power < 80)
            {
                low = 1;
                high = 4;
            }
            else if (power < 160)
            {
                low = 3;
                high = 6;
            }
            else if (power < 320)
            {
                low = 6;
                high = 9;
            }
            else
            {
                low = 7;
                high = 10;
            }

            return $"Up to DM - between {low} and {high}+ suggested";
        }

        internal Dictionary<string, double> GetMiscPowerRatingFactors()
        {
            var ritualFactor = Ritual ? 2.0 : 1.0;
            var concentrationFactor = (!RequiresConcentration && Effect.Duration != Duration.Instant && Effect.Duration != Duration.OneRound) ? 3.0 : 1.0;     
            return new Dictionary<string, double>
            {
                { nameof(Ritual), ritualFactor },
                { "NoConcentration", concentrationFactor },
                { nameof(CastTime), CastTime.GetPowerRatingFactor() },
                { nameof(Components), Components.GetPowerRatingFactor() },
            };
        }

        public void AdjustForTargetValueScore(Templates.SpellTemplate spellTemplate, double minScore, double maxScore)
        {
            //recalculate scaling ratio after each round of changes
            Effect.ScalePower(CalculateScalingRatio(minScore, maxScore), spellTemplate.MinimumDuration);
            Delivery.ScalePower(CalculateScalingRatio(minScore, maxScore));

            Effect.UpdateDescription();
            Delivery.UpdateDescription();
        }

        private double? CalculateScalingRatio(double minScore, double maxScore)
        {
            UpdatePowerRatingFactors();
            var powerRating = FinalPowerRating;
            if (powerRating > maxScore)           
                return maxScore / powerRating;            
            else if (powerRating < minScore)            
                return minScore / powerRating;            
            else
                return null;
        }
    }
}
