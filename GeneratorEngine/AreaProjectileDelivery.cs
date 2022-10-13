using System;
using System.Collections.Generic;

namespace GeneratorEngine
{
    public class AreaProjectileDelivery : Delivery
    {

        public ProjectileType ProjectileType;
        public Area Area;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add("AreaSize", Area.GetPowerRatingFactor());
            factors.Add(nameof(ProjectileType), ProjectileType.GetPowerRatingFactor());
            return factors;
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description = Description.Replace("AreaProjectile", $"{ProjectileType} projectile");

            switch (ProjectileType)
            {
                case ProjectileType.Bouncing:
                    Description += $" The projectile can harmlessly bounce off up to 1d4 surfaces. On the final impact it triggers a {Area.Size} ft {Area.Shape} area of effect.";
                    break;
                case ProjectileType.Chaining:
                    Description += $" The projectile can ricochet off an initial target by as much as 90 degrees to also hit a secondary target within range. On impact with the final target it triggers a {Area.Size} ft {Area.Shape} area of effect.";
                    break;
                case ProjectileType.Piercing:
                    Description += $" The projectile can pass through an initial target and continue in a straight line to hit a secondary target within range behind them. On impact with the final target it triggers a {Area.Size} ft {Area.Shape} area of effect.";
                    break;
                case ProjectileType.Splitting:
                    Description += $" The projectile shatters on contact with an initial target and splits into pieces. The shards continue forward and hit up to 1d3 secondary targets in range behind them. Impact with one of the final targets (not all) triggers a {Area.Size} ft {Area.Shape} area of effect.";
                    break;
                case ProjectileType.StraightLine:
                case ProjectileType.OverheadArcing:
                case ProjectileType.Meteor:
                case ProjectileType.GroundLevel:
                default:
                    Description += $" The projectile triggers a {Area.Size} ft {Area.Shape} area of effect on impact.";
                    break;
            }

            if(!DoesNotTargetCreatures && (ProjectileType == ProjectileType.Chaining || ProjectileType == ProjectileType.Piercing || ProjectileType == ProjectileType.Splitting))
            {
                Description += " Both the initial and secondary targets, as well as any creatures in the area of effect, can be affected by this spell.";
            }
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
