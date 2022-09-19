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

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add(nameof(ProjectileType), ProjectileType.GetPowerRatingFactor());
            return factors;
        }
    }
}
