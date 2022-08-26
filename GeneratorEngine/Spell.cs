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

        public double GetFinalPowerRating()
        {
            return Math.Round(Effect.GetPowerRating() * Delivery.GetPowerRatingModifier() * MiscPowerRatingModifier() - (CasterPenaltyCost?.GetPowerRating() ?? 0));
        }

        public string GetSpellLevelSummary()
        {
            int low;
            int high;
            var power = GetFinalPowerRating();

            if(power < 30)
            {
                low = 0;
                high = 2;
            }
            else if (power < 60)
            {
                low = 1;
                high = 4;
            }
            else if (power < 100)
            {
                low = 3;
                high = 6;
            }
            else if (power < 200)
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

        internal double MiscPowerRatingModifier()
        {
            var ritualFactor = Ritual ? 2.0 : 1.0;
            var concentrationFactor = (!RequiresConcentration && Effect.Duration != Duration.Instant && Effect.Duration != Duration.OneRound) ? 3.0 : 1.0;
            return concentrationFactor * ritualFactor;//TODO - add cast time & components
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
            var powerRating = GetFinalPowerRating();
            if (powerRating > maxScore)           
                return maxScore / powerRating;            
            else if (powerRating < minScore)            
                return minScore / powerRating;            
            else
                return null;
        }
    }
}
