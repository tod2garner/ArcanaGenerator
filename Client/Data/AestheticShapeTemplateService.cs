using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticShapeTemplateService
    {
        protected List<AestheticShapeTemplate>? _templates;
        public AestheticShapeTemplate GetRandomTemplate(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            var matchingTemplates = GetTemplates(delivery, aoEShape);

            var rng = new Random();
            var roll = rng.Next(matchingTemplates.Count);
            return matchingTemplates.ElementAt(roll);
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
                new AestheticShapeTemplate("instant", "", DeliveryType.None),

                new AestheticShapeTemplate("hand", "the caster's hand is covered with", DeliveryType.Touch),
                new AestheticShapeTemplate("hand", "on contact the caster's hand creates a flash of", DeliveryType.Touch),
                new AestheticShapeTemplate("gauntlet", "a gauntlet made of", DeliveryType.Touch),

                new AestheticShapeTemplate("weapon", "the weapon is coated with", DeliveryType.Weapon),
                new AestheticShapeTemplate("weapon", "on impact the weapon creates a flash of", DeliveryType.Weapon),
                new AestheticShapeTemplate("weapon", "the weapon takes on the appearance of", DeliveryType.Weapon),

                new AestheticShapeTemplate("bolt", "a bolt of", DeliveryType.Projectile),
                new AestheticShapeTemplate("missile", "a missile of", DeliveryType.Projectile),
                new AestheticShapeTemplate("arrow", "an arrow made of", DeliveryType.Projectile),
                new AestheticShapeTemplate("spear", "a spear made of", DeliveryType.Projectile),
                new AestheticShapeTemplate("javelin", "a javelin made of", DeliveryType.Projectile),
                                            
                new AestheticShapeTemplate("burst", "a burst of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("blast", "a blast of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("shockwave", "a shockwave caused by", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("patch", "a patch of", DeliveryType.AreaOfEffect),
                new AestheticShapeTemplate("rain", "raindrops made of", DeliveryType.AreaOfEffect),
                                            
                new AestheticShapeTemplate("explosion", "an explosion of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere),
                new AestheticShapeTemplate("cloud", "a cloud of droplets of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere),
                                           
                new AestheticShapeTemplate("stream", "a stream of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("river", "a river of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("beam", "a beam of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("ray", "a ray of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("jet", "a jet of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("wave", "a wave of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("trail", "a trail of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("lance", "a lance made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                new AestheticShapeTemplate("scythe", "a scythe made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Line),
                                           
                new AestheticShapeTemplate("pool", "a pool of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("shower", "a shower of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("fountain", "a fountain of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("cauldron", "a cauldron that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("circle", "a circle of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("ring", "a large ring made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("column", "a column of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("pillar", "a pillar of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("beam", "a beam of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                new AestheticShapeTemplate("tree", "a tree made of", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder),
                                           
                new AestheticShapeTemplate("head", "a head that breathes", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("mouth", "a mouth that breathes", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("face", "a face that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                new AestheticShapeTemplate("horn", "a horn that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone),
                                           
                new AestheticShapeTemplate("window", "a window that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube),
                new AestheticShapeTemplate("door", "a door that spews", DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube),
                
                //Generics - for any delivery
                //      None: ___ appears in the target's space for a moment before vanishing
                //      touch: ___ sprout from the caster's hand
                //      weapon: on impact the weapon conjures ___ above the target's head
                //      projectile: the projectile is ___ that vanishes on impact
                //      Aoe projectile: the projectile is ___ that releases a burst of magic on impact
                //      Area: the area eminates/radiates from ___
                new AestheticShapeTemplate("ball", "a ball of"),
                new AestheticShapeTemplate("cube", "a cube of"),
                new AestheticShapeTemplate("disk", "a disk made of"),
                new AestheticShapeTemplate("shield", "a shield made of"), //TODO - buffs only?
                new AestheticShapeTemplate("orb", "an orb made of"),
                new AestheticShapeTemplate("sphere", "a sphere made of"),
                new AestheticShapeTemplate("blade", "a blade made of"),
                new AestheticShapeTemplate("sword", "a sword made of"),
                new AestheticShapeTemplate("hammer", "a hammer made of"),
                new AestheticShapeTemplate("hook", "a hook made of"),
                new AestheticShapeTemplate("crook", "a shepherd's crook made of"),//TODO - buffs and melee only?
                new AestheticShapeTemplate("bowl", "a bowl filled with"),
                new AestheticShapeTemplate("net", "a net made of"),
                new AestheticShapeTemplate("crown", "a crown made of"),
                new AestheticShapeTemplate("diamond", "a diamond-shaped chunk of"),
                new AestheticShapeTemplate("star", "a star made of"),
                new AestheticShapeTemplate("wheel", "a wheel made of"),
                new AestheticShapeTemplate("scroll", "a scroll made of"),
                new AestheticShapeTemplate("globe", "a globe made of"),
                new AestheticShapeTemplate("strand", "a strand of"),
                new AestheticShapeTemplate("bottle", "a bottle of"),

                new AestheticShapeTemplate("chunks", "chunks of"),
                new AestheticShapeTemplate("globs", "globs of"),
                new AestheticShapeTemplate("orbs", "orbs made of"),
                new AestheticShapeTemplate("bits", "bits of"),
                new AestheticShapeTemplate("streaks", "streaks of"),
                new AestheticShapeTemplate("flecks", "flecks of"),
                new AestheticShapeTemplate("clumps", "clumps of"),
                new AestheticShapeTemplate("clusters", "clusters of"),
                new AestheticShapeTemplate("trendrils", "tendrils made of"),
                new AestheticShapeTemplate("shards", "shards of"),
                new AestheticShapeTemplate("fragments", "fragments of"),
                new AestheticShapeTemplate("slices", "slices of"),
                new AestheticShapeTemplate("slivers", "slivers of"),

                new AestheticShapeTemplate("sigil", "an intangible sigil in the air made of"),
                new AestheticShapeTemplate("totem", "an intangible totem made of"),
                new AestheticShapeTemplate("apparation", "an intangible, lupine apparition made of"),
                new AestheticShapeTemplate("apparation", "an intangible, feline apparition made of"),
                new AestheticShapeTemplate("apparation", "an intangible, canine apparition made of"),
                new AestheticShapeTemplate("apparation", "an intangible, ursine apparition made of"),
                new AestheticShapeTemplate("apparation", "an intangible, avian apparition made of"),
                new AestheticShapeTemplate("apparation", "an intangible, skeletal apparition made of"),
                

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
