using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class AestheticGenerator
    {
        private static List<TemplatePerDeliveryType> _contextTemplates = new List<TemplatePerDeliveryType>();

        public static Aesthetic GetRandomAesthetic(IDataTemplateService dataTemplateService, DeliveryType deliveryType, SchoolOfMagic school, DamageType? damageType, AreaOfEffectShape? aoEShape)
        {
            var shape = dataTemplateService.GetRandomAestheticShape(deliveryType, aoEShape);
            var adjective = (new Random().NextDouble() > 0.5) ? string.Empty : dataTemplateService.GetRandomAestheticAdjective(school, damageType).Adjective;
            var material = dataTemplateService.GetRandomAestheticMaterial(school).Value;

            string context = (shape.Context == string.Empty) ? GetContext(deliveryType, shape) : shape.Context;

            var isSingular = shape.ShapeDescription.StartsWith("a ") || shape.ShapeDescription.StartsWith("an ") || shape.ShapeDescription == string.Empty;
            context = isSingular ? context.Replace("(s)", "s") : context.Replace("(s)", String.Empty);

            return new Aesthetic
            {
                ShapeCore = shape.ShapeCore,
                ShapeDescription = shape.ShapeDescription,
                MaterialAdjective = adjective,
                MaterialDescription = material,
                Context = context
            };
        }

        private static string GetContext(DeliveryType deliveryType, AestheticShapeTemplate shape)
        {
            if (_contextTemplates.Count == 0)
                CreateCommonContextTemplates();

            var matchingTemplates = _contextTemplates.Where(x => x.DeliveryType == deliveryType).Select(t => t.Value).ToList();

            if(shape.DeliveryType == DeliveryType.AreaOfEffect)
            {
                matchingTemplates.AddRange(GetSpecificContextTemplatesForAoE(shape.AoEShape));
            }

            if(!matchingTemplates.Any())
                throw new NotImplementedException("No matching aesthetic context templates found for the given delivery type");

            return matchingTemplates.ElementAt(new Random().Next(matchingTemplates.Count));
        }

        private static void CreateCommonContextTemplates()
        {
            _contextTemplates = new List<TemplatePerDeliveryType>
            {
                new TemplatePerDeliveryType(DeliveryType.None, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in the target's space"),
                new TemplatePerDeliveryType(DeliveryType.None, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} suddenly appear(s) over the target"),

                new TemplatePerDeliveryType(DeliveryType.Touch, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in your hand"),
                new TemplatePerDeliveryType(DeliveryType.Touch, $"You summon {Aesthetic.DESCRIPTION_PLACEHOLDER} in your hand"),
                new TemplatePerDeliveryType(DeliveryType.Touch, $"You stretch out your hand and {Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in it"),

                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} that radiate(s) magic in the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You create {Aesthetic.DESCRIPTION_PLACEHOLDER} that warp(s) the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"Magic fills the area, radiating from {Aesthetic.DESCRIPTION_PLACEHOLDER}"),

                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You hurl {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} shoot(s) from your hand"),

                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that release(s) a burst of magic on impact"),
                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that detonate(s) on impact"),

                new TemplatePerDeliveryType(DeliveryType.Weapon, $"On impact the weapon conjures {Aesthetic.DESCRIPTION_PLACEHOLDER} for a moment"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"On impact the weapon summons {Aesthetic.DESCRIPTION_PLACEHOLDER} over the target"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"Attacks with the weapon create {Aesthetic.DESCRIPTION_PLACEHOLDER} over the target"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"Hits with the weapon cause {Aesthetic.DESCRIPTION_PLACEHOLDER} to appear over the target")
            };

        }

        private static List<string> GetSpecificContextTemplatesForAoE(AreaOfEffectShape? shape)
        {
            var areaOnlyContexts = new List<string>
            {
                $"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target area",
                $"You create {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target area",
            };

            switch (shape)
            {
                case AreaOfEffectShape.Line:
                    areaOnlyContexts.Add($"You summon {Aesthetic.DESCRIPTION_PLACEHOLDER} along the target area");
                    areaOnlyContexts.Add($"You unleash {Aesthetic.DESCRIPTION_PLACEHOLDER} along the target area");
                    areaOnlyContexts.Add($"{Aesthetic.DESCRIPTION_PLACEHOLDER} rushes across the target area");
                    break;
                case AreaOfEffectShape.Sphere:
                    areaOnlyContexts.Add($"{Aesthetic.DESCRIPTION_PLACEHOLDER} fills target area");
                    break;
                case AreaOfEffectShape.Cube:
                case AreaOfEffectShape.Square:
                case AreaOfEffectShape.Cone:
                    areaOnlyContexts.Add($"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} across the target area");
                    break;
                case AreaOfEffectShape.Cylinder:
                case null:
                default:
                    break;//Add nothing
            }

            return areaOnlyContexts;
        }
    }
}
