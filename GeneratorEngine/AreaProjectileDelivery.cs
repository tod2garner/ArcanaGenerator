using System;
using System.Collections.Generic;

namespace GeneratorEngine
{
    public class AreaProjectileDelivery : Delivery
    {
        //For projectiles that chain, split, etc into multiples stages the AoE occurs only at the final stage
        //TODO - add this note to the description

        public ProjectileType ProjectileType;
        public Area Area;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add("AreaSize", Area.GetLikelyNumberOfTargets());
            factors.Add(nameof(ProjectileType), ProjectileType.GetPowerRatingFactor());
            return factors;
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description = Description.Replace("AreaProjectile", $"{ProjectileType} AreaProjectile");
            Description += $" and a {Area.Size} ft {Area.Shape} area of effect";
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
