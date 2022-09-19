using System;
using System.Collections.Generic;

namespace GeneratorEngine
{
    public class AreaDelivery : Delivery
    {
        public Area Area;
        public bool DoesAreaPersistForDuration;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add("AreaSize", Area.GetLikelyNumberOfTargets());
            return factors;
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
            else if (scalingRatio > 1.0 && Area.Size < 30) //make it stronger
            {
                newAreaSize = Math.Min(30, scalingRatio.Value * Area.Size);
            }

            scalingRatio *= Area.Size / newAreaSize;
            Area.Size = newAreaSize.RoundToNearest(5);
            base.ScalePower(scalingRatio);
        }
    }
}
