using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class ProjectileDelivery : Delivery
    {
        public ProjectileType ProjectileType;

        public override double GetPowerRatingModifier()
        {
            return base.GetPowerRatingModifier() * ((double)ProjectileType / 100.0);
        }
    }
}
