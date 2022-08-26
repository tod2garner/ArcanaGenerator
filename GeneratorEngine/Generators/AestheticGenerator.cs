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

            string context = (shape.Context == string.Empty) ? GetContext(deliveryType) : shape.Context;

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

        private static string GetContext(DeliveryType deliveryType)
        {
            if (_contextTemplates.Count == 0)
                CreateContextTemplates();

            var matchingTemplates = _contextTemplates.Where(x => x.DeliveryType == deliveryType).ToList();

            if(!matchingTemplates.Any())
                throw new NotImplementedException("No matching aesthetic context templates found for the given delivery type");

            return matchingTemplates.ElementAt(new Random().Next(matchingTemplates.Count)).Value;
        }

        private static void CreateContextTemplates()
        {
            _contextTemplates = new List<TemplatePerDeliveryType>
            {
                new TemplatePerDeliveryType(DeliveryType.None, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in the target's space"),
                new TemplatePerDeliveryType(DeliveryType.Touch, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in your hand"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} that radiate(s) magic in an area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"Magic fills the area, radiating from {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You hurl {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} shoot(s) from your hand"),
                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that release(s) a burst of magic on impact"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"On impact the weapon conjures {Aesthetic.DESCRIPTION_PLACEHOLDER} for a moment")
            };
        }
    }
}
