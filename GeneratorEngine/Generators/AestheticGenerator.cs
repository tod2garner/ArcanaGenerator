using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class AestheticGenerator
    {
        public static Aesthetic GetRandomAesthetic(IDataTemplateService dataTemplateService, 
                                                    DeliveryType deliveryType, 
                                                    SchoolOfMagic school, 
                                                    DamageType? damageType,
                                                    AreaOfEffectShape? aoEShape, 
                                                    ProjectileType? projectileType)
        {
            var shape = dataTemplateService.GetRandomAestheticShape(deliveryType, aoEShape);
            var adjective = (new Random().NextDouble() > 0.5) ? string.Empty : dataTemplateService.GetRandomAestheticAdjective(school, damageType).Adjective;
            var material = dataTemplateService.GetRandomAestheticMaterial(school).Value;

            string context = shape.Context;
            if(string.IsNullOrEmpty(context))
            {
                if(projectileType.HasValue && projectileType.Value == ProjectileType.Meteor)
                    context = $"You call {Aesthetic.DESCRIPTION_PLACEHOLDER} from the sky, falling like a meteor.";
                else
                    context = dataTemplateService.GetRandomAestheticContext(deliveryType);
            }                

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
    }
}
