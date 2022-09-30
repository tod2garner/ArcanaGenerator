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
            Description = Description.Replace("Projectile", $"{ProjectileType} projectile");


            switch (ProjectileType)
            {
                case ProjectileType.Bouncing:
                    Description += $" The projectile can harmlessly bounce off up to 1d4 surfaces before impact.";
                    break;
                case ProjectileType.Chaining:
                    Description += $" The projectile can ricochet off an initial target by as much as 90 degrees to hit a secondary target within range.";
                    break;
                case ProjectileType.Piercing:
                    Description += $" The projectile can pass through an initial target and continue in a straight line to hit a secondary target within range behind them.";
                    break;
                case ProjectileType.Splitting:
                    Description += $" The projectile shatters on contact with an initial target and splits into pieces. The shards continue forward and hit up to 1d3 secondary targets in range behind them.";
                    break;
                case ProjectileType.StraightLine:
                case ProjectileType.OverheadArcing:
                case ProjectileType.Meteor:
                case ProjectileType.GroundLevel:
                default:                    
                    break;//Nothing added for these.
            }

            if (!DoesNotTargetCreatures && (ProjectileType == ProjectileType.Chaining || ProjectileType == ProjectileType.Piercing || ProjectileType == ProjectileType.Splitting))
            {
                Description += " Both the initial and secondary targets can be affected by this spell.";
            }
        }

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add(nameof(ProjectileType), ProjectileType.GetPowerRatingFactor());
            return factors;
        }
    }
}
