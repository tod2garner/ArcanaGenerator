using GeneratorEngine.Templates;
using System;

namespace GeneratorEngine.Generators
{
    public static class AestheticGenerator
    {
        public static Aesthetic GetRandomAesthetic(IDataTemplateService dataTemplateService, DeliveryType deliveryType, SchoolOfMagic school, DamageType? damageType, AreaOfEffectShape? aoEShape)
        {
            var shape = dataTemplateService.GetRandomAestheticShape(deliveryType, aoEShape);
            var adjective = (new Random().NextDouble() > 0.5) ? string.Empty : dataTemplateService.GetRandomAestheticAdjective(school, damageType).Adjective;
            var material = dataTemplateService.GetRandomAestheticMaterial(school).Value;

            string context = Aesthetic.DESCRIPTION_PLACEHOLDER;
            if(!shape.DeliveryType.HasValue) //Universal shape template
            {                
                switch (deliveryType)
                {
                    case DeliveryType.Touch:
                        context = $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in your hand";
                        break;
                    case DeliveryType.None:
                        context = $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) in the target's space";
                        break;
                    case DeliveryType.AreaOfEffect:
                        context = $"Magic fills the area, radiating from {Aesthetic.DESCRIPTION_PLACEHOLDER}";
                        break;
                    case DeliveryType.Projectile:
                        context = $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that disappear(s) on impact";
                        break;
                    case DeliveryType.AreaProjectile:
                        context = $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that release(s) a burst of magic on impact";
                        break;
                    case DeliveryType.Weapon:
                        context = $"On impact the weapon conjures {Aesthetic.DESCRIPTION_PLACEHOLDER} for a moment before vanishing";
                        break;
                    default:
                        throw new NotImplementedException("Unrecognized delivery type during aesthetic context generation");
                }
            }
            var isSingular = shape.ShapeDescription.StartsWith("a ") || shape.ShapeDescription.StartsWith("an ");
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
    }
}
