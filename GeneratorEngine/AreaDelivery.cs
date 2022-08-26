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

            var newAreaSize = Area.Size;
            if (scalingRatio < 1.0) //make it weaker
            {
                newAreaSize = Math.Max(15, scalingRatio.Value * Area.Size);
            }
            else if (scalingRatio > 1.0) //make it stronger
            {
                newAreaSize = Math.Min(60, scalingRatio.Value * Area.Size);
            }

            scalingRatio *= Area.Size / newAreaSize;
            Area.Size = newAreaSize.RoundToNearest(5);
            base.ScalePower(scalingRatio);
        }
    }
}
