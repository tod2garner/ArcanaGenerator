using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class DeliveryGenerator
    {
        private static readonly Random Rnd = new Random();

        internal static Delivery GenerateDelivery(SpellTemplate template)
        {
            var cannotHaveRangeOfSelf = template.IsNeverAoE && (template.Type == EffectType.Damage || template.Type == EffectType.Debuff);
            var rangeType = GenerateRangeType(cannotHaveRangeOfSelf, template.IsRangeAlwaysSelf, template.IsAlwaysRanged);
            var deliveryType = GenerateDeliveryType(template.Type, rangeType, template.IsAlwaysAoE, template.IsNeverAoE);
            var rangeDistance = GenerateRangeDistance(template.Type, rangeType);

            switch (deliveryType)
            {
                case DeliveryType.None:
                case DeliveryType.Touch:
                case DeliveryType.Weapon:
                    return new Delivery
                    {
                        Type = deliveryType,
                        RangeType = rangeType,
                        RangeDistance = rangeDistance,
                        NumberOfTargets = 1, 
                        DoesNotTargetCreatures = template.DoesNotTargetCreatures
                    };
                case DeliveryType.AreaOfEffect:
                    return new AreaDelivery
                    {
                        Type = deliveryType,
                        RangeType = rangeType,
                        RangeDistance = rangeDistance, 
                        Area = GenerateArea(),
                        DoesAreaPersistForDuration = Rnd.NextDouble() > 0.5,
                        NumberOfTargets = 1,
                        DoesNotTargetCreatures = template.DoesNotTargetCreatures
                    };
                case DeliveryType.Projectile:
                    return new ProjectileDelivery
                    {
                        Type = deliveryType,
                        RangeType = rangeType,
                        RangeDistance = rangeDistance,                         
                        ProjectileType = GenerateProjectileType(),
                        NumberOfTargets = 1,
                        DoesNotTargetCreatures = template.DoesNotTargetCreatures
                    };
                case DeliveryType.AreaProjectile:
                    return new AreaProjectileDelivery
                    {
                        Type = deliveryType,
                        RangeType = rangeType,
                        RangeDistance = rangeDistance,
                        Area = GenerateArea(),
                        ProjectileType = GenerateProjectileType(),
                        NumberOfTargets = 1,
                        DoesNotTargetCreatures = template.DoesNotTargetCreatures
                    };
                default:
                    throw new NotImplementedException();
            }
        }

        private static DeliveryType GenerateDeliveryType(EffectType effectType, RangeType rangeType, bool isAlwaysAoE, bool isNeverAoE)
        {
            var roll = Rnd.Next(100);
            var options = new List<(DeliveryType type, int rollThreshold)>();
            var isOffsenseType = effectType == EffectType.Damage || effectType == EffectType.Debuff;
            if (rangeType == RangeType.Self)
            {
                if (isOffsenseType)
                {
                    options.Add((DeliveryType.AreaOfEffect, 0));  // 100%
                }
                else
                {
                    options.Add((DeliveryType.AreaOfEffect, 40)); // 60%
                    options.Add((DeliveryType.None, 0));          // 40%
                }
            }
            else if (rangeType == RangeType.Melee)
            {
                if (isOffsenseType)
                {
                    options.Add((DeliveryType.Weapon, 90));       // 10%
                    options.Add((DeliveryType.AreaOfEffect, 60)); // 30%
                    options.Add((DeliveryType.Touch, 0));         // 60%
                }
                else
                {
                    options.Add((DeliveryType.AreaOfEffect, 70)); // 30%
                    options.Add((DeliveryType.Touch, 0));         // 70%
                }
            }
            else
            {
                if (isOffsenseType)
                {
                    options.Add((DeliveryType.Weapon, 95));         //  5%
                    options.Add((DeliveryType.Projectile, 65));     // 15% 
                    options.Add((DeliveryType.AreaProjectile, 45)); // 20% 
                    options.Add((DeliveryType.AreaOfEffect, 30));   // 30%
                    options.Add((DeliveryType.None, 0));            // 30%
                }
                else
                {
                    options.Add((DeliveryType.AreaOfEffect, 60));  // 40%
                    options.Add((DeliveryType.None, 0));           // 60%
                }
            }

            if(isAlwaysAoE)
            {
                options = options.Where(o => o.type == DeliveryType.AreaOfEffect || o.type == DeliveryType.AreaProjectile).ToList();
            }
            else if(isNeverAoE)
            {
                options = options.Where(o => o.type != DeliveryType.AreaOfEffect && o.type != DeliveryType.AreaProjectile).ToList();
            }

            if(options.Count == 0)
                throw new ArgumentException("No option for delivery type found");

            foreach (var choice in options)
            {
                if (roll >= choice.rollThreshold)
                    return choice.type;
            }

            return options.Last().type;
        }

        private static RangeType GenerateRangeType(bool isRangeNeverSelf, bool isRangeAlwaysSelf, bool isAlwaysRanged)
        {
            if (isRangeAlwaysSelf)
                return RangeType.Self;

            if (isAlwaysRanged)
                return RangeType.Distance;

            var roll = Rnd.Next(100);
            if (roll > 80 && !isRangeNeverSelf)
                return RangeType.Self; // 20%
            else if (roll > 60)
                return RangeType.Melee; // 20%            
            else
                return RangeType.Distance; // 60%
        }

        private static double GenerateRangeDistance(EffectType effectType, RangeType rangeType)
        {
            if (rangeType == RangeType.Self)
                return 0;
            else if (rangeType == RangeType.Melee)
                return 5;

            var roll = Rnd.Next(100);
            if (roll > 98 && effectType == EffectType.Utility)
                return 5280.0;// 2%
            else if (roll > 95 && effectType == EffectType.Utility)
                return 500.0; // 3%
            else if (roll > 90)
                return 150.0; // 5%
            else if (roll > 80)
                return 100.0; // 10%
            else if (roll > 50)
                return 60.0; // 30%
            else if (roll > 30)
                return 30.0; // 20%
            else if (roll > 10)
                return 15.0; // 20%
            else
                return 10.0; // 10%
        }

        private static Area GenerateArea()
        {
            var shape = GenerateAreaShape();
            return new Area
            {
                Shape = shape,
                Size = GenerateAreaSize(shape)
            };
        }

        private static double GenerateAreaSize(AreaOfEffectShape shape)
        {
            var options = new List<(double value, int rollThreshold)>();

            if (shape == AreaOfEffectShape.Line)
            {
                options.Add((120.0, 90));   //10%
                options.Add((60.0, 80));    //10%
                options.Add((40.0, 60));    //20%
                options.Add((20.0, 20));    //40%
                options.Add((15.0, 0));     //20%
            }
            else if(shape == AreaOfEffectShape.Sphere || shape == AreaOfEffectShape.Cylinder)
            {
                options.Add((20.0, 75));    //25%
                options.Add((15.0, 25));    //50%
                options.Add((10.0, 0));     //25%
            }
            else
            {
                options.Add((40.0, 90));    //10%
                options.Add((30.0, 80));    //10%
                options.Add((25.0, 60));    //20%
                options.Add((20.0, 40));    //20%
                options.Add((15.0, 20));    //20%
                options.Add((10.0, 0));     //20%
            }

            int roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.value;
            }

            return 10.0;
        }

        private static AreaOfEffectShape GenerateAreaShape()
        {
            var options = new List<(AreaOfEffectShape value, int rollThreshold)>
            {
                (AreaOfEffectShape.Square, 90),   // 10%
                (AreaOfEffectShape.Line, 80),     // 10%
                (AreaOfEffectShape.Cone, 65),     // 15%
                (AreaOfEffectShape.Cylinder, 50), // 15%
                (AreaOfEffectShape.Cube, 25),     // 25%
                (AreaOfEffectShape.Sphere, 0),    // 25%
            };

            int roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.value;
            }

            return AreaOfEffectShape.Sphere;
        }

        private static ProjectileType GenerateProjectileType()
        {
            var options = new List<(ProjectileType value, int rollThreshold)>
            {
                (ProjectileType.Splitting, 95),     //  5%
                (ProjectileType.Piercing, 90),      //  5%
                (ProjectileType.Chaining, 85),      //  5%
                (ProjectileType.GroundLevel, 80),   // 10%
                (ProjectileType.Bouncing, 70),      // 10%
                (ProjectileType.Meteor, 60),        // 10%
                (ProjectileType.OverheadArcing, 30),// 30%
                (ProjectileType.StraightLine, 0),   // 30%
            };

            int roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.value;
            }

            return ProjectileType.StraightLine;
        }
    }
}
