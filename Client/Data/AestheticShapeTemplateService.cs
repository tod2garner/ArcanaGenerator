using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticShapeTemplateService
    {
        protected List<AestheticShapeTemplate>? _templates;
        public AestheticShapeTemplate GetRandomTemplate(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            var deliveryToUse = (delivery == DeliveryType.AreaProjectile) ? DeliveryType.Projectile : delivery;
            var matchingTemplates = GetTemplates(deliveryToUse, aoEShape);

            //Weight universal separately from others because quanity is very skewed (if not would nearly always see universal and rarely the others)
            var specificTemplates = matchingTemplates.Where(t => t.DeliveryType.HasValue).ToList();
            var universalTemplates = matchingTemplates.Where(t => !t.DeliveryType.HasValue).ToList();

            var rng = new Random();
            var templatesToPickFrom = (rng.NextDouble() > 0.5) ? universalTemplates : specificTemplates;
            var roll = rng.Next(templatesToPickFrom.Count());
            return templatesToPickFrom.ElementAt(roll);
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
                new AestheticShapeTemplate(DeliveryType.None, "spell", string.Empty),

                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} sprouts from your hand on contact"),
                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"Your hand is momentarily covered with {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"On contact your hand creates a flash of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Touch, "gauntlet", "a gauntlet made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appears on your hand"),

                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"The weapon is coated with {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"On impact the weapon creates a flash of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"The weapon momentarily takes on the appearance of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),

                new AestheticShapeTemplate(DeliveryType.Projectile, "bolt", "a bolt of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "missile", "a missile of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "arrow", "an arrow made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "spear", "a spear made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "javelin", "a javelin made of"),
                                            
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "burst", "a burst of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "blast", "a blast of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "shockwave", "a shockwave caused by"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "patch", "a patch of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "rain", "raindrops made of"),//universal
                                            
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere, "explosion", "an explosion of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere, "cloud", "a cloud of droplets of"),
                                           
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "stream", "a stream of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "river", "a river of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "beam", "a beam of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "ray", "a ray of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "jet", "a jet of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "wave", "a wave of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "trail", "a trail of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "lance", "a lance made of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "scythe", "a scythe made of"),//universal
                                           
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "pool", "a pool of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "mire", "a mire made of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "shower", "a shower of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "fountain", "a fountain of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "cauldron", "a cauldron that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "circle", "a circle of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "ring", "a large ring made of"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "column", "a column of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "pillar", "a pillar of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "beam", "a beam of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "tree", "a tree made of"),
                                           
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "head", "a head that breathes"),//universal
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "mouth", "a mouth that breathes"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "face", "a face that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "horn", "a horn that spews"),//universal
                                           
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube, "window", "a window that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube, "door", "a door that spews"),
                
                //Universal templates - any delivery type
                //      TODO - limit effect type for some                
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
                new AestheticShapeTemplate("bottle", "a bottle of"),

                new AestheticShapeTemplate("chunks", "chunks of"),
                new AestheticShapeTemplate("globs", "globs of"),
                new AestheticShapeTemplate("orbs", "orbs made of"),
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
