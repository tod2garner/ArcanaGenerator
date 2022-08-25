using System;

namespace GeneratorEngine
{
    public class AreaDelivery : Delivery
    {
        public Area Area;
        public bool DoesAreaPersistForDuration;

        public override double GetPowerRatingModifier()
        {
            return base.GetPowerRatingModifier() * Area.GetLikelyNumberOfTargets();
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description += $" and a {Area.Size} ft {Area.Shape} area";
        }

        internal override void ScalePower(double? scalingRatio)
        {
            if (!scalingRatio.HasValue)
                return;

            if (scalingRatio < 1.0) //make it weaker
            {
                Area.Size = Math.Max(15, RoundToNearest(scalingRatio.Value * Area.Size, 5));
            }
            else if (scalingRatio > 1.0) //make it stronger
            {
                Area.Size = Math.Min(60, RoundToNearest(scalingRatio.Value * Area.Size, 5));
            }

            base.ScalePower(scalingRatio);
        }


        private double RoundToNearest(double valueToRound, double tolerance) => Math.Round(valueToRound / tolerance) * tolerance;
    }
}
