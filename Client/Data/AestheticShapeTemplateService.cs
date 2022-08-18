using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticShapeTemplateService
    {
        protected List<AestheticShapeTemplate>? _templates;
        public AestheticShapeTemplate GetRandomTemplate(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            var templatesForGivenSchool = GetTemplates(delivery, aoEShape);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count - 1);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private List<AestheticShapeTemplate> GetTemplates(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            if (_templates == null)
                CreateTemplates();

            var matches = _templates?.Where(t => t.DeliveryType == delivery || !t.DeliveryType.HasValue) ?? new List<AestheticShapeTemplate>();
            matches = matches.Where(t => t.AoEShape == aoEShape || !t.AoEShape.HasValue);

            return matches.ToList();
        }

        private void CreateTemplates()
        {
            _templates = new List<AestheticShapeTemplate>
            {
                new AestheticShapeTemplate("", DeliveryType.None),

                new AestheticShapeTemplate("the caster's hand is covered with", DeliveryType.Touch),
                new AestheticShapeTemplate("on contact the caster's hand creates a flash of", DeliveryType.Touch),

                new AestheticShapeTemplate("the weapon is coated with", DeliveryType.Weapon),
                new AestheticShapeTemplate("on impact the weapon creates a flash of", DeliveryType.Weapon),
                new AestheticShapeTemplate("the weapon takes on the appearance of", DeliveryType.Weapon),

                new AestheticShapeTemplate("a bolt of", DeliveryType.Projectile),
                new AestheticShapeTemplate("an arrow made of", DeliveryType.Projectile),
                new AestheticShapeTemplate("a spear made of", DeliveryType.Projectile),

                new AestheticShapeTemplate("an explosion of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("a burst of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("a blast of", DeliveryType.AreaOfEffect),

                new AestheticShapeTemplate("a cloud made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere),

                new AestheticShapeTemplate("a stream of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a beam of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a ray of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a jet of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a wave of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),

                new AestheticShapeTemplate("a pool of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a fountain of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a circle of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a large ring made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                
                //Generics - for any delivery
                //      None: ___ appears in the target's space for a moment before vanishing
                //      touch: ___ appears in the caster's hand
                //      weapon: on impact the weapon conjures ___ above the target's head
                //      projectile: the projectile is ___ that vanishes on impact
                //      Aoe projectile: the projectile is ___ that releases a burst of magic on impact
                //      Area: the area eminates/radiates from ___
                new AestheticShapeTemplate("a ball of"),
                new AestheticShapeTemplate("a blade made of"),

                new AestheticShapeTemplate("a intangible sigil in the air made of"),
                new AestheticShapeTemplate("an intangible, spectral totem made of"),
                new AestheticShapeTemplate("an intangible, lupine spirit made of"),
                new AestheticShapeTemplate("an intangible, feline spirit made of"),
                new AestheticShapeTemplate("an intangible, canine spirit made of"),
                new AestheticShapeTemplate("an intangible, fiendish spirit made of"),
                new AestheticShapeTemplate("an intangible, ursine spirit made of"),
                

        //AestheticShapeTemplate per DeliveryTypes
        /*    
            brands (like poe)
            totems
            winter orb style
            hydrosphere style
         */
            };
        }

    }
}
