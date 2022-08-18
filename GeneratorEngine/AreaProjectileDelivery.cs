using System;

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
            return base.GetPowerRatingModifier() * Area.GetLikelyNumberOfTargets() * ((double)ProjectileType / 100.0);
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description = Description.Replace("AreaProjectile", $"{ProjectileType} AreaProjectile");
            Description += $" and an {Area.Size} ft {Area.Shape} area of effect";
        }

        internal override void ScalePower(double? scalingRatio)
        {
            if (!scalingRatio.HasValue)
                return;

            if (scalingRatio < 1.0 && Area.Size > 15) //make it weaker
            {
                Area.Size = Math.Max(15, scalingRatio.Value * Area.Size);
            }
            else if (scalingRatio > 1.0 && Area.Size < 60) //make it stronger
            {
                Area.Size = Math.Min(60, scalingRatio.Value * Area.Size);
            }

            base.ScalePower(scalingRatio);
        }
    }
}
