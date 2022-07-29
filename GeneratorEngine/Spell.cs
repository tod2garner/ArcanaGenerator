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

        public void AdjustForTargetValueScore(double minScore, double maxScore)
        {
            //TODO - finish this
            //Scale cast time, concentration, ritual, components

            var powerRating = GetFinalPowerRating();
            if (powerRating > maxScore || powerRating < minScore)
            {
                var scalingRatio = powerRating > maxScore ? maxScore / powerRating : minScore / powerRating;
                Effect.ScalePower(scalingRatio);

                Delivery.ScalePower(GetFinalPowerRating(), minScore, maxScore);
            }

            Effect.UpdateDescription();
            Delivery.UpdateDescription();
        }
    }
}
