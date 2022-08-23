using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class ProjectileDelivery : Delivery
    {
        public ProjectileType ProjectileType;

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description = Description.Replace("Projectile", $"{ProjectileType} Projectile");
        }

        public override double GetPowerRatingModifier()
        {
            return base.GetPowerRatingModifier() * ((double)ProjectileType / 100.0);
        }
    }
}
