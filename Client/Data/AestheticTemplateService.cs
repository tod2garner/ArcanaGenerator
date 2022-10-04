using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticTemplateService : BaseMaterialsTemplateService
    {
        private List<AestheticAdjectiveTemplate>? _adjectiveTemplates;
        private List<AestheticShapeTemplate>? _shapeTemplates;
        private List<TemplatePerDeliveryType>? _contextTemplates;

        #region Materials
        protected override void CreateMaterialTemplates()
        {
            _materialTemplates = new List<TemplatePerSchool>
            {
                new TemplatePerSchool("bones", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new TemplatePerSchool("animal claws", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("reptile scales", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("sea shells", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("animal teeth", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Divination }),
                new TemplatePerSchool("feathers", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation, SchoolOfMagic.Divination, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("fur", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("cobwebs", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("egg shells", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("insects", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("spiders", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("scorpions", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("snakes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),

                new TemplatePerSchool("water", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("liquid"),
                new TemplatePerSchool("foam", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("viscous liquid", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("energy", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("lightning", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("flames"),//--remove and move to adjectives?
                new TemplatePerSchool("embers"),
                new TemplatePerSchool("sparks", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("ice", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("snow", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("mist", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("smoke", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("shadows", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("lava", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),

                new TemplatePerSchool("ruby", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("sapphire", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("gold", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("silver", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("emerald", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("ivory", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("opal", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),

                new TemplatePerSchool("metal"),
                new TemplatePerSchool("iron", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("steel", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("copper", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("chains", new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("lead", new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),

                new TemplatePerSchool("stone", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("soil", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("dirt", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("dust", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("sand", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("granite", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("sandstone", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("limestone", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("gravel", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("pebbles", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("obsidian", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("onyx", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("quartz", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("pumice", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("glass", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),
                new TemplatePerSchool("clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("salt", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("coal", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("charcoal", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),

                new TemplatePerSchool("wood", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("tree bark", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("leaves and vines", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("branches", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("thorns", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("cactus needles", new List < SchoolOfMagic > { SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("ivy", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("pine needles", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("sap", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("grass", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("roots", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("seaweed", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("petals", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("algae", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("flowers", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("lichen", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("moss", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("fungus", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),

                new TemplatePerSchool("fabric", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("plaster", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("oil"),
                new TemplatePerSchool("grease", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("coins", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("pottery", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("ceramic", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("porcelain", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("leather", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("brick", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("mirrors", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("vinegar", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("wax", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("books", new List < SchoolOfMagic > { SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("buttons", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("thread", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("sawdust", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("lace", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("soap", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("paint", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("parchment", new List < SchoolOfMagic > { SchoolOfMagic.Divination, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("liquor", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Divination, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("rope", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("bubbles", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("ink", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("tar", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("letters", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new TemplatePerSchool("runes"),
            };
        }
        #endregion

        #region Adjectives
        public AestheticAdjectiveTemplate GetRandomAdjectiveTemplate(SchoolOfMagic school, DamageType? damageType = null)
        {
            var matchingTemplates = GetAdjectiveTemplates(school, damageType);

            var rng = new Random();
            var roll = rng.Next(matchingTemplates.Count);
            return matchingTemplates.ElementAt(roll);
        }

        private List<AestheticAdjectiveTemplate> GetAdjectiveTemplates(SchoolOfMagic school, DamageType? damageType = null)
        {
            if (_adjectiveTemplates == null)
                CreateAdjectiveTemplates();

            IEnumerable<AestheticAdjectiveTemplate> matches;
            if (_adjectiveTemplates == null)
            {
                throw new NullReferenceException("Aesthetic Adjective Templates were not created");
            }
            else if (damageType != null)
            {
                matches = _adjectiveTemplates.Where(t => t.DamageTypes.Any(d => d == damageType) || !t.DamageTypes.Any());
            }
            else
            {
                matches = (school == SchoolOfMagic.Any) ? _adjectiveTemplates : _adjectiveTemplates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school));
            }

            return matches.ToList();
        }

        private void CreateAdjectiveTemplates()
        {
            _adjectiveTemplates = new List<AestheticAdjectiveTemplate>
            {
                new AestheticAdjectiveTemplate("burning", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("flaming", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("fiery", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("boiling", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("roiling", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("searing", new List<DamageType>{ DamageType.Fire }),

                new AestheticAdjectiveTemplate("frozen", new List<DamageType>{ DamageType.Cold }),
                new AestheticAdjectiveTemplate("frigid", new List<DamageType>{ DamageType.Cold }),

                new AestheticAdjectiveTemplate("crude"),
                new AestheticAdjectiveTemplate("simple"),
                new AestheticAdjectiveTemplate("plain"),
                new AestheticAdjectiveTemplate("straight"),
                new AestheticAdjectiveTemplate("narrow"),
                new AestheticAdjectiveTemplate("broad"),
                new AestheticAdjectiveTemplate("rounded"),
                new AestheticAdjectiveTemplate("strange"),
                new AestheticAdjectiveTemplate("softened"),
                new AestheticAdjectiveTemplate("hardened"),
                new AestheticAdjectiveTemplate("solid"),
                new AestheticAdjectiveTemplate("thickened"),
                new AestheticAdjectiveTemplate("thick"),
                new AestheticAdjectiveTemplate("heavy"),
                new AestheticAdjectiveTemplate("mixed"),
                new AestheticAdjectiveTemplate("tangled"),
                new AestheticAdjectiveTemplate("tapered"),
                new AestheticAdjectiveTemplate("vibrant"),
                new AestheticAdjectiveTemplate("iridescent"),
                new AestheticAdjectiveTemplate("incandescent"),
                new AestheticAdjectiveTemplate("luminescent"),
                new AestheticAdjectiveTemplate("translucent"),
                new AestheticAdjectiveTemplate("sheer"),
                new AestheticAdjectiveTemplate("lustrous"),
                new AestheticAdjectiveTemplate("ornamental"),
                new AestheticAdjectiveTemplate("mercurial"),
                new AestheticAdjectiveTemplate("broken"),
                new AestheticAdjectiveTemplate("curved"),
                new AestheticAdjectiveTemplate("curled"),
                new AestheticAdjectiveTemplate("sinuous"),
                new AestheticAdjectiveTemplate("scented"),
                new AestheticAdjectiveTemplate("bulbous"),
                new AestheticAdjectiveTemplate("wriggling"),
                new AestheticAdjectiveTemplate("wrinkled"),
                new AestheticAdjectiveTemplate("gnarled"),
                new AestheticAdjectiveTemplate("squirming"),
                new AestheticAdjectiveTemplate("humming"),
                new AestheticAdjectiveTemplate("hissing"),
                new AestheticAdjectiveTemplate("crackling"),
                new AestheticAdjectiveTemplate("creaking"),
                new AestheticAdjectiveTemplate("cracked"),
                new AestheticAdjectiveTemplate("dissonant"),
                new AestheticAdjectiveTemplate("discordant"),
                new AestheticAdjectiveTemplate("divergent"),
                new AestheticAdjectiveTemplate("buzzing"),
                new AestheticAdjectiveTemplate("twinkling"),
                new AestheticAdjectiveTemplate("dancing"),
                new AestheticAdjectiveTemplate("intertwined"),
                new AestheticAdjectiveTemplate("interlocked"),
                new AestheticAdjectiveTemplate("pulsing"),
                new AestheticAdjectiveTemplate("twisted"),
                new AestheticAdjectiveTemplate("twirling"),
                new AestheticAdjectiveTemplate("throbbing"),
                new AestheticAdjectiveTemplate("osciallating"),
                new AestheticAdjectiveTemplate("undulating"),
                new AestheticAdjectiveTemplate("unfolding"),
                new AestheticAdjectiveTemplate("unwinding"),
                new AestheticAdjectiveTemplate("falling"),
                new AestheticAdjectiveTemplate("orbiting"),
                new AestheticAdjectiveTemplate("unbalanced"),
                new AestheticAdjectiveTemplate("unstable"),
                new AestheticAdjectiveTemplate("sculpted"),
                new AestheticAdjectiveTemplate("disjointed"),
                new AestheticAdjectiveTemplate("irregular"),
                new AestheticAdjectiveTemplate("shredded"),
                new AestheticAdjectiveTemplate("tattered"),
                new AestheticAdjectiveTemplate("flawless"),
                new AestheticAdjectiveTemplate("billowing"),
                new AestheticAdjectiveTemplate("flattened"),
                new AestheticAdjectiveTemplate("warped"),
                new AestheticAdjectiveTemplate("turbulent"),
                new AestheticAdjectiveTemplate("cascading"),
                new AestheticAdjectiveTemplate("bent"),
                new AestheticAdjectiveTemplate("perfect"),
                new AestheticAdjectiveTemplate("immaculate", new List<DamageType>{ DamageType.Radiant }, new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }),
                new AestheticAdjectiveTemplate("blessed", new List<DamageType>{ DamageType.Radiant }, new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }),
                new AestheticAdjectiveTemplate("cursed", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("coarse"),
                new AestheticAdjectiveTemplate("corrosive", new List<DamageType>{ DamageType.Acid }),
                new AestheticAdjectiveTemplate("venomous", new List<DamageType>{ DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("spiraling"),
                new AestheticAdjectiveTemplate("spinning"),
                new AestheticAdjectiveTemplate("lopsided"),
                new AestheticAdjectiveTemplate("serrated", new List<DamageType>{ DamageType.Piercing, DamageType.Slashing }),
                new AestheticAdjectiveTemplate("biting", new List<DamageType>{ DamageType.Piercing, DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("stinging", new List<DamageType>{ DamageType.Piercing, DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("steaming"),
                new AestheticAdjectiveTemplate("dried"),
                new AestheticAdjectiveTemplate("speckled"),
                new AestheticAdjectiveTemplate("impure", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("withered", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("malformed", new List<DamageType>{ DamageType.Necrotic }),
                new AestheticAdjectiveTemplate("pure"),
                new AestheticAdjectiveTemplate("refined"),
                new AestheticAdjectiveTemplate("crystalized"),
                new AestheticAdjectiveTemplate("crystalline"),
                new AestheticAdjectiveTemplate("sharpened"),
                new AestheticAdjectiveTemplate("razor-sharp", new List<DamageType>{ DamageType.Slashing }),
                new AestheticAdjectiveTemplate("shattered"),
                new AestheticAdjectiveTemplate("phantasmal", new List<DamageType>{ DamageType.Psychic }, new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new AestheticAdjectiveTemplate("enchanting", new List<DamageType>{ DamageType.Psychic }, new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("colorful"),
                new AestheticAdjectiveTemplate("patterned"),
                new AestheticAdjectiveTemplate("discolored"),
                new AestheticAdjectiveTemplate("colorless"),
                new AestheticAdjectiveTemplate("dark"),
                new AestheticAdjectiveTemplate("bright", new List<DamageType>{ DamageType.Radiant, DamageType.Fire }, new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("murky"),
                new AestheticAdjectiveTemplate("muted"),
                new AestheticAdjectiveTemplate("intricate"),
                new AestheticAdjectiveTemplate("compact"),
                new AestheticAdjectiveTemplate("shimmering"),
                new AestheticAdjectiveTemplate("melting"),
                new AestheticAdjectiveTemplate("sleek"),
                new AestheticAdjectiveTemplate("dull", new List<DamageType>{ DamageType.Bludgeoning, DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new AestheticAdjectiveTemplate("faded", new List<DamageType>{ DamageType.Bludgeoning, DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new AestheticAdjectiveTemplate("grimy", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new AestheticAdjectiveTemplate("pale"),
                new AestheticAdjectiveTemplate("forked"),
                new AestheticAdjectiveTemplate("crooked"),
                new AestheticAdjectiveTemplate("metallic"),
                new AestheticAdjectiveTemplate("hollow"),
                new AestheticAdjectiveTemplate("gilded", new List<DamageType>{ DamageType.Radiant }, new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new AestheticAdjectiveTemplate("foul smelling", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("acrid", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid, DamageType.Poison }),
                new AestheticAdjectiveTemplate("putrid", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("tarnished", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("gelatinous", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid, DamageType.Poison }),
                new AestheticAdjectiveTemplate("spectral"),
                new AestheticAdjectiveTemplate("ghostly", new List<DamageType>{ DamageType.Necrotic, DamageType.Psychic }, new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("ridged", new List<DamageType>{ DamageType.Slashing }),
                new AestheticAdjectiveTemplate("rigid"),
                new AestheticAdjectiveTemplate("gleaming", new List<DamageType>{ DamageType.Radiant, DamageType.Force, DamageType.Fire }, new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("glowing", new List<DamageType>{ DamageType.Radiant, DamageType.Force, DamageType.Fire }),
                new AestheticAdjectiveTemplate("shining", new List<DamageType>{ DamageType.Radiant, DamageType.Force, DamageType.Fire }, new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("writhing"),
                new AestheticAdjectiveTemplate("bulging"),
                new AestheticAdjectiveTemplate("bubbling"),
                new AestheticAdjectiveTemplate("leaking"),
                new AestheticAdjectiveTemplate("rotating"),
                new AestheticAdjectiveTemplate("swirling"),
                new AestheticAdjectiveTemplate("flowing"),
                new AestheticAdjectiveTemplate("floating"),
                new AestheticAdjectiveTemplate("suspended"),
                new AestheticAdjectiveTemplate("drifting"),
                new AestheticAdjectiveTemplate("gliding"),
                new AestheticAdjectiveTemplate("smooth"),
                new AestheticAdjectiveTemplate("rough"),
                new AestheticAdjectiveTemplate("jagged"),
                new AestheticAdjectiveTemplate("ragged"),
                new AestheticAdjectiveTemplate("moist"),
                new AestheticAdjectiveTemplate("bloodied", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("tainted", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("corrupted", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("filthy", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("delicate"),
                new AestheticAdjectiveTemplate("muddied"),
                new AestheticAdjectiveTemplate("elongated"),
                new AestheticAdjectiveTemplate("stunted"),
                new AestheticAdjectiveTemplate("sticky"),
                new AestheticAdjectiveTemplate("slimy", new List<DamageType>{ DamageType.Acid, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new AestheticAdjectiveTemplate("slanted"),
                new AestheticAdjectiveTemplate("blunt", new List<DamageType>{ DamageType.Bludgeoning }),
                new AestheticAdjectiveTemplate("blocky", new List<DamageType>{ DamageType.Bludgeoning }),
                new AestheticAdjectiveTemplate("chaotic"),
                new AestheticAdjectiveTemplate("eerie"),
                new AestheticAdjectiveTemplate("nightmarish", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("bloated"),
                new AestheticAdjectiveTemplate("decaying", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("distended"),
                new AestheticAdjectiveTemplate("disfigured", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("misshapen"),
                new AestheticAdjectiveTemplate("powdered"),
                new AestheticAdjectiveTemplate("deformed", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("mangled", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("expanding", new List<DamageType>{ DamageType.Bludgeoning, DamageType.Thunder, DamageType.Force }, new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new AestheticAdjectiveTemplate("contracting", new List<DamageType>{ DamageType.Force }, new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new AestheticAdjectiveTemplate("contorted"),
                new AestheticAdjectiveTemplate("convoluted"),
                new AestheticAdjectiveTemplate("engraved"),
                new AestheticAdjectiveTemplate("enlarged"),
                new AestheticAdjectiveTemplate("uneven"),
                new AestheticAdjectiveTemplate("angular"),
                new AestheticAdjectiveTemplate("concave"),
                new AestheticAdjectiveTemplate("layered"),
                new AestheticAdjectiveTemplate("soiled"),
                new AestheticAdjectiveTemplate("abrasive"),
                new AestheticAdjectiveTemplate("astral", new List<DamageType>{ DamageType.Radiant, DamageType.Force }, new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new AestheticAdjectiveTemplate("lethargic"),
                new AestheticAdjectiveTemplate("sluggish"),
                new AestheticAdjectiveTemplate("rune-etched"),
                new AestheticAdjectiveTemplate("beautiful", new List<DamageType>{ DamageType.Radiant, DamageType.Fire, DamageType.Cold }, new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("elegant", new List<DamageType>{ DamageType.Radiant, DamageType.Fire, DamageType.Cold }, new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
            };
        }
        #endregion

        #region Shapes

        public AestheticShapeTemplate GetRandomShapeTemplate(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            var deliveryToUse = (delivery == DeliveryType.AreaProjectile) ? DeliveryType.Projectile : delivery;
            var matchingTemplates = GetShapeTemplates(deliveryToUse, aoEShape);

            //Weight universal separately from others because quantity is very skewed (if not would nearly always see universal and rarely the others)
            var specificTemplates = matchingTemplates.Where(t => t.DeliveryType.HasValue).ToList();
            var universalTemplates = matchingTemplates.Where(t => !t.DeliveryType.HasValue).ToList();

            var rng = new Random();
            var templatesToPickFrom = (rng.NextDouble() > 0.6) ? universalTemplates : specificTemplates;
            var roll = rng.Next(templatesToPickFrom.Count());
            return templatesToPickFrom.ElementAt(roll);
        }

        private List<AestheticShapeTemplate> GetShapeTemplates(DeliveryType delivery, AreaOfEffectShape? aoEShape = null)
        {
            if (_shapeTemplates == null)
                CreateShapeTemplates();

            var matches = _shapeTemplates?.Where(t => t.DeliveryType == delivery || !t.DeliveryType.HasValue) ?? new List<AestheticShapeTemplate>();
            matches = matches.Where(t => t.AoEShape == aoEShape || !t.AoEShape.HasValue);

            return matches.ToList();
        }

        private void CreateShapeTemplates()
        {
            _shapeTemplates = new List<AestheticShapeTemplate>
            {
                new AestheticShapeTemplate(DeliveryType.None, "incantation", string.Empty),

                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} sprouts from your hand on contact"),
                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"Your hand is momentarily covered with {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Touch, "hand", string.Empty, $"On contact your hand creates a flash of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Touch, "gauntlet", "a gauntlet made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appears on your hand"),
                new AestheticShapeTemplate(DeliveryType.Touch, "crook", "a shepherd's crook made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appears in your hand"),

                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"The weapon is coated with {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"On impact the weapon creates a flash of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.Weapon, "weapon", string.Empty, $"The weapon momentarily takes on the appearance of {Aesthetic.DESCRIPTION_PLACEHOLDER}"),

                new AestheticShapeTemplate(DeliveryType.Projectile, "bolt", "a bolt of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "missile", "a missile of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "spike", "a spike made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "arrow", "an arrow made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "spear", "a spear made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "javelin", "a javelin made of"),
                new AestheticShapeTemplate(DeliveryType.Projectile, "shield", "a shield made of",  $"You throw {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "burst", "a burst of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "blast", "a blast of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "shockwave", "a shockwave caused by", $"You trigger {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "patch", "a patch of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "ripple", "ripples of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} roll throughout the target area"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, "rain", "raindrops made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} pour over the target area"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere, "explosion", "an explosion of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere, "bubble", "a giant bubble coated with"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Sphere, "cloud", "a cloud formed by droplets of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} takes shape in the target area"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "stream", "a stream of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "river", "a river of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "beam", "a beam of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "ray", "a ray of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "jet", "a jet of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "wave", "a wave of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "trail", "a trail of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appears along the ground of the target area"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "lance", "a lance made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} charges across the target area"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Line, "scythe", "a scythe made of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} flies along the target area"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "pool", "a pool of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "mire", "a mire made of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "shower", "a shower of", $"{Aesthetic.DESCRIPTION_PLACEHOLDER} rains down over the target area"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "fountain", "a fountain of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "geyser", "a geyser of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "cauldron", "a cauldron that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "ring", "a large ring made of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "column", "a column of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "pillar", "a pillar of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "beam", "a beam of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "tree", "a tree made of"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cylinder, "circle", "a glowing circle on the ground, paved with"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "head", "a head that breathes"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "mouth", "a mouth that breathes"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "face", "a face that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cone, "horn", "a horn that spews"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube, "window", "a window that spews"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Cube, "door", "a door that spews"),

                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Square, "canopy", "a canopy that drops"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Square, "square", "a glowing square on the ground, paved with"),
                new AestheticShapeTemplate(DeliveryType.AreaOfEffect, AreaOfEffectShape.Square, "holes", "holes on the ground, filled with"),

                //Universal templates - any delivery type            
                new AestheticShapeTemplate("ball", "a ball of"),
                new AestheticShapeTemplate("cube", "a cube of"),
                new AestheticShapeTemplate("disk", "a disk made of"),
                new AestheticShapeTemplate("ring", "a ring of"),
                new AestheticShapeTemplate("orb", "an orb made of"),
                new AestheticShapeTemplate("sphere", "a sphere made of"),
                new AestheticShapeTemplate("obelisk", "an obelisk made of"),
                new AestheticShapeTemplate("blade", "a blade made of"),
                new AestheticShapeTemplate("sword", "a sword made of"),
                new AestheticShapeTemplate("hammer", "a hammer made of"),
                new AestheticShapeTemplate("hook", "a hook made of"),
                new AestheticShapeTemplate("bowl", "a bowl filled with"),
                new AestheticShapeTemplate("net", "a net made of"),
                new AestheticShapeTemplate("crown", "a crown made of"),
                new AestheticShapeTemplate("diamond", "a diamond-shaped chunk of"),
                new AestheticShapeTemplate("star", "a star made of"),
                new AestheticShapeTemplate("wheel", "a wheel made of"),
                new AestheticShapeTemplate("scroll", "a scroll made of"), //buff and utility only?
                new AestheticShapeTemplate("globe", "a globe made of"),
                new AestheticShapeTemplate("bottle", "a bottle of"),
                new AestheticShapeTemplate("chalice", "a chalice made of"),
                new AestheticShapeTemplate("lantern", "a lantern made of"),

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
        #endregion

        #region Context
        public string GetRandomAestheticContext(DeliveryType deliveryType)
        {
            if (_contextTemplates is null)
                CreateCommonContextTemplates();

            if (_contextTemplates == null)
            {
                throw new NullReferenceException("Aesthetic Context Templates were not created");
            }

            var matchingTemplates = _contextTemplates.Where(x => x.DeliveryType == deliveryType).Select(t => t.Value).ToList();
            if (!matchingTemplates.Any())
                throw new NotImplementedException("No matching aesthetic context templates found for the given delivery type");

            return matchingTemplates.ElementAt(new Random().Next(matchingTemplates.Count));
        }

        private void CreateCommonContextTemplates()
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
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You create {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You summon {Aesthetic.DESCRIPTION_PLACEHOLDER} along the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You unleash {Aesthetic.DESCRIPTION_PLACEHOLDER} along the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} appear(s) across the target area"),
                new TemplatePerDeliveryType(DeliveryType.AreaOfEffect, $"You conjure {Aesthetic.DESCRIPTION_PLACEHOLDER} across the target area"),

                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER}"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You hurl {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"You throw {Aesthetic.DESCRIPTION_PLACEHOLDER} at the target"),
                new TemplatePerDeliveryType(DeliveryType.Projectile, $"{Aesthetic.DESCRIPTION_PLACEHOLDER} shoot(s) from your hand"),

                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that release(s) a burst of magic on impact"),
                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You throw {Aesthetic.DESCRIPTION_PLACEHOLDER} that release(s) a burst of magic on impact"),
                new TemplatePerDeliveryType(DeliveryType.AreaProjectile, $"You launch {Aesthetic.DESCRIPTION_PLACEHOLDER} that detonate(s) on impact"),

                new TemplatePerDeliveryType(DeliveryType.Weapon, $"On impact the weapon conjures {Aesthetic.DESCRIPTION_PLACEHOLDER} for a moment"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"On impact the weapon summons {Aesthetic.DESCRIPTION_PLACEHOLDER} over the target"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"Attacks with the weapon create {Aesthetic.DESCRIPTION_PLACEHOLDER} over the target"),
                new TemplatePerDeliveryType(DeliveryType.Weapon, $"Hits with the weapon cause {Aesthetic.DESCRIPTION_PLACEHOLDER} to appear over the target")
            };

        }
        #endregion
    }

}
