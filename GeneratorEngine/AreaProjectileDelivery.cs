﻿using System;

namespace GeneratorEngine
{
    public class AreaProjectileDelivery : Delivery
    {
        //For projectiles that chain, split, etc into multiples stages the AoE occurs only at the final stage
        //TODO - add this note to the description

        public ProjectileType ProjectileType;
        public Area Area;

        public override double GetPowerRatingModifier()
        {
            return base.GetPowerRatingModifier() * Area.GetLikelyNumberOfTargets() * ProjectileType.GetPowerRatingFactor();
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
