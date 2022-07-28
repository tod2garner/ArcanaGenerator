using System;

namespace GeneratorEngine
{
    public class AreaProjectileDelivery : Delivery
    {
        //maybe two deliveries insyead of combined?

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
            Description += $" and an {Area.Size} ft {Area.Shape} area";
        }
    }
}
