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
                new AestheticShapeTemplate("a gauntlet made of", DeliveryType.Touch),

                new AestheticShapeTemplate("the weapon is coated with", DeliveryType.Weapon),
                new AestheticShapeTemplate("on impact the weapon creates a flash of", DeliveryType.Weapon),
                new AestheticShapeTemplate("the weapon takes on the appearance of", DeliveryType.Weapon),

                new AestheticShapeTemplate("a bolt of", DeliveryType.Projectile),
                new AestheticShapeTemplate("an arrow made of", DeliveryType.Projectile),
                new AestheticShapeTemplate("a spear made of", DeliveryType.Projectile),

                new AestheticShapeTemplate("a burst of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("a blast of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("a patch of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("raindrops made of", DeliveryType.AreaOfEffect),

                new AestheticShapeTemplate("an explosion of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere),
                new AestheticShapeTemplate("a cloud made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere),

                new AestheticShapeTemplate("a stream of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a river of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a beam of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a ray of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a jet of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a wave of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a trail of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a lance made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("a scythe made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),

                new AestheticShapeTemplate("a pool of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a shower of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a fountain of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a cauldron that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a circle of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a large ring made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a column of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a pillar of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a beam of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("a tree made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),

                new AestheticShapeTemplate("a head that breathes", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("a mouth that breathes", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("a face that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("a horn that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),

                new AestheticShapeTemplate("a window that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube),
                new AestheticShapeTemplate("a door that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube),
                
                //Generics - for any delivery
                //      None: ___ appears in the target's space for a moment before vanishing
                //      touch: ___ sprout from the caster's hand
                //      weapon: on impact the weapon conjures ___ above the target's head
                //      projectile: the projectile is ___ that vanishes on impact
                //      Aoe projectile: the projectile is ___ that releases a burst of magic on impact
                //      Area: the area eminates/radiates from ___
                new AestheticShapeTemplate("a ball of"),
                new AestheticShapeTemplate("a cube of"),
                new AestheticShapeTemplate("a disk made of"),
                new AestheticShapeTemplate("an orb made of"),
                new AestheticShapeTemplate("a blade made of"),
                new AestheticShapeTemplate("a sword made of"),
                new AestheticShapeTemplate("a hammer made of"),
                new AestheticShapeTemplate("a hook made of"),
                new AestheticShapeTemplate("a shepherd's crook made of"),
                new AestheticShapeTemplate("a bowl filled with"),
                new AestheticShapeTemplate("a net made of"),
                new AestheticShapeTemplate("a crown made of"),
                new AestheticShapeTemplate("a diamon shaped chunk of"),
                new AestheticShapeTemplate("a star made of"),
                new AestheticShapeTemplate("a wheel made of"),
                new AestheticShapeTemplate("a scroll made of"),
                new AestheticShapeTemplate("a globe made of"),
                new AestheticShapeTemplate("a strand of"),
                new AestheticShapeTemplate("a bottle of"),

                new AestheticShapeTemplate("chunks of"),
                new AestheticShapeTemplate("globs of"),
                new AestheticShapeTemplate("orbs made of"),
                new AestheticShapeTemplate("bits of"),
                new AestheticShapeTemplate("streaks of"),
                new AestheticShapeTemplate("flecks of"),
                new AestheticShapeTemplate("clumps of"),
                new AestheticShapeTemplate("clusters of"),
                new AestheticShapeTemplate("tendrils made of"),
                new AestheticShapeTemplate("shards of"),
                new AestheticShapeTemplate("fragments of"),
                new AestheticShapeTemplate("slices of"),
                new AestheticShapeTemplate("slivers of"),

                new AestheticShapeTemplate("an intangible sigil in the air made of"),
                new AestheticShapeTemplate("an intangible totem made of"),
                new AestheticShapeTemplate("an intangible, lupine apparition made of"),
                new AestheticShapeTemplate("an intangible, feline apparition made of"),
                new AestheticShapeTemplate("an intangible, canine apparition made of"),
                new AestheticShapeTemplate("an intangible, ursine apparition made of"),
                new AestheticShapeTemplate("an intangible, avian apparition made of"),
                new AestheticShapeTemplate("an intangible, skeletal apparition made of"),
                

                //TODO
                /*    
                    brands (like poe)
                    winter orb style
                    hydrosphere style
                    */
            };
        }

    }
}
