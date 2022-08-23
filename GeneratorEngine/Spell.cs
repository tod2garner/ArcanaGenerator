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

        internal double MiscPowerRatingModifier()
        {
            return 1.0;//TODO - add cast time, components, concentration, ritual
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
