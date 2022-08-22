using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticAdjectiveTemplateService
    {
        protected List<AestheticAdjectiveTemplate>? _templates;
        public AestheticAdjectiveTemplate GetRandomTemplate(SchoolOfMagic school, DamageType? damageType = null)
        {
            var templatesForGivenSchool = GetTemplates(school, damageType);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count - 1);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private List<AestheticAdjectiveTemplate> GetTemplates(SchoolOfMagic school, DamageType? damageType = null)
        {
            if (_templates == null)
                CreateTemplates();

            IEnumerable<AestheticAdjectiveTemplate> matches;
            if (_templates == null)
            {
                throw new NullReferenceException();
            }
            else if (damageType != null)
            {
                matches = _templates.Where(t => t.DamageTypes.Any(d => d == damageType) || !t.DamageTypes.Any());
            }
            else
            {
                matches = (school == SchoolOfMagic.Any) ? _templates : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school));
            }

            return matches.ToList();
        }

        private void CreateTemplates()
        {
            _templates = new List<AestheticAdjectiveTemplate>
            {
                //example material: iron, dust, feathers, cobwebs, chains, water, flames, embers, sparks

                new AestheticAdjectiveTemplate("burning", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("flaming", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("fiery", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("boiling", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("roiling", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("searing", new List<DamageType>{ DamageType.Fire }),
                //synonyms for hot
                new AestheticAdjectiveTemplate("frozen", new List<DamageType>{ DamageType.Cold }),
                new AestheticAdjectiveTemplate("frigid", new List<DamageType>{ DamageType.Cold }),                                
                //synonyms for cold
                //synonyms for sharp
                //synonyms for fast, slow, sluggish, swift
                //synonyms for large, huge, small, tiny, massive, giant, enlarged
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
                new AestheticAdjectiveTemplate("thin"),
                new AestheticAdjectiveTemplate("heavy"),
                new AestheticAdjectiveTemplate("mixed"),
                new AestheticAdjectiveTemplate("tangled"),
                new AestheticAdjectiveTemplate("jumbled"),
                new AestheticAdjectiveTemplate("tapered"),
                new AestheticAdjectiveTemplate("vibrant"),
                new AestheticAdjectiveTemplate("iridescent"),
                new AestheticAdjectiveTemplate("incandescent"),
                new AestheticAdjectiveTemplate("luminescent"),
                new AestheticAdjectiveTemplate("transparent"),//--illusion only?
                new AestheticAdjectiveTemplate("translucent"),
                new AestheticAdjectiveTemplate("sheer"),
                new AestheticAdjectiveTemplate("lustrous"),
                new AestheticAdjectiveTemplate("ornamental"),
                new AestheticAdjectiveTemplate("mercurial"),
                new AestheticAdjectiveTemplate("broken"),
                new AestheticAdjectiveTemplate("arched"),
                new AestheticAdjectiveTemplate("curved"),
                new AestheticAdjectiveTemplate("curling"),
                new AestheticAdjectiveTemplate("sinuous"),
                new AestheticAdjectiveTemplate("scented"),
                new AestheticAdjectiveTemplate("bulbous"),
                new AestheticAdjectiveTemplate("wriggling"),
                new AestheticAdjectiveTemplate("sweeping"),
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
                new AestheticAdjectiveTemplate("curling"),
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
                new AestheticAdjectiveTemplate("demented"),
                new AestheticAdjectiveTemplate("flattened"),
                new AestheticAdjectiveTemplate("extruded"), //??
                new AestheticAdjectiveTemplate("extended"),//??
                new AestheticAdjectiveTemplate("warped"),
                new AestheticAdjectiveTemplate("stretching"),
                new AestheticAdjectiveTemplate("turbulent"),
                new AestheticAdjectiveTemplate("cascading"),
                new AestheticAdjectiveTemplate("bent"),
                new AestheticAdjectiveTemplate("perfect"),
                new AestheticAdjectiveTemplate("immaculate"),
                new AestheticAdjectiveTemplate("blessed", new List<DamageType>{ DamageType.Radiant }),
                new AestheticAdjectiveTemplate("cursed", new List<DamageType>{ DamageType.Necrotic }),
                new AestheticAdjectiveTemplate("coarse"),
                new AestheticAdjectiveTemplate("corrosive", new List<DamageType>{ DamageType.Acid }),
                new AestheticAdjectiveTemplate("venomous", new List<DamageType>{ DamageType.Poison }),
                new AestheticAdjectiveTemplate("spiraled"),
                new AestheticAdjectiveTemplate("spiraling"),
                new AestheticAdjectiveTemplate("spinning"),
                new AestheticAdjectiveTemplate("lopsided"),
                new AestheticAdjectiveTemplate("serrated", new List<DamageType>{ DamageType.Piercing, DamageType.Slashing }),
                new AestheticAdjectiveTemplate("biting", new List<DamageType>{ DamageType.Piercing, DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("stinging", new List<DamageType>{ DamageType.Piercing, DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("steaming"),
                new AestheticAdjectiveTemplate("dried"),
                new AestheticAdjectiveTemplate("speckled"),
                new AestheticAdjectiveTemplate("impure", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }),
                new AestheticAdjectiveTemplate("withered", new List<DamageType>{ DamageType.Necrotic, DamageType.Poison }),
                new AestheticAdjectiveTemplate("malformed", new List<DamageType>{ DamageType.Necrotic }),
                new AestheticAdjectiveTemplate("pure"),
                new AestheticAdjectiveTemplate("refined"),
                new AestheticAdjectiveTemplate("inflated"),
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
                new AestheticAdjectiveTemplate("bright"),
                new AestheticAdjectiveTemplate("murky"),
                new AestheticAdjectiveTemplate("muted"),
                new AestheticAdjectiveTemplate("mutilated"),
                new AestheticAdjectiveTemplate("intricate"),
                new AestheticAdjectiveTemplate("compact"),
                new AestheticAdjectiveTemplate("shimmering"),
                new AestheticAdjectiveTemplate("melting"),
                new AestheticAdjectiveTemplate("sleek"),
                new AestheticAdjectiveTemplate("dull"),
                new AestheticAdjectiveTemplate("faded"),
                new AestheticAdjectiveTemplate("grimy"),
                new AestheticAdjectiveTemplate("pale"),
                new AestheticAdjectiveTemplate("forked"),
                new AestheticAdjectiveTemplate("crooked"),
                new AestheticAdjectiveTemplate("metallic"),
                new AestheticAdjectiveTemplate("hollow"),
                new AestheticAdjectiveTemplate("gilded"),
                new AestheticAdjectiveTemplate("foul smelling"),
                new AestheticAdjectiveTemplate("acrid"),
                new AestheticAdjectiveTemplate("putrid", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("tarnished", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("gelatinous", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid, DamageType.Poison }),
                new AestheticAdjectiveTemplate("spectral"),
                new AestheticAdjectiveTemplate("ghostly"),
                new AestheticAdjectiveTemplate("ridged", new List<DamageType>{ DamageType.Slashing }),
                new AestheticAdjectiveTemplate("rigid"),
                new AestheticAdjectiveTemplate("glowing"),
                new AestheticAdjectiveTemplate("shining"),
                new AestheticAdjectiveTemplate("writhing"),
                new AestheticAdjectiveTemplate("bulging"),
                new AestheticAdjectiveTemplate("bubbling"),
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
                new AestheticAdjectiveTemplate("exuberant"),
                new AestheticAdjectiveTemplate("filthy"),
                new AestheticAdjectiveTemplate("gleaming"),
                new AestheticAdjectiveTemplate("delicate"),
                new AestheticAdjectiveTemplate("jittery"),
                new AestheticAdjectiveTemplate("enigmatic"),
                new AestheticAdjectiveTemplate("nondescript"),
                new AestheticAdjectiveTemplate("muddied"),
                new AestheticAdjectiveTemplate("grotesquely shaped"),
                new AestheticAdjectiveTemplate("elongated"),
                new AestheticAdjectiveTemplate("stunted"),
                new AestheticAdjectiveTemplate("sticky"),
                new AestheticAdjectiveTemplate("slimy"),
                new AestheticAdjectiveTemplate("slanted"),
                new AestheticAdjectiveTemplate("blunt", new List<DamageType>{ DamageType.Bludgeoning }),
                new AestheticAdjectiveTemplate("blocky", new List<DamageType>{ DamageType.Bludgeoning }),
                new AestheticAdjectiveTemplate("frantic"),
                new AestheticAdjectiveTemplate("tense"),
                new AestheticAdjectiveTemplate("chaotic"),
                new AestheticAdjectiveTemplate("eerie"),
                new AestheticAdjectiveTemplate("nightmarish", new List<DamageType>{ DamageType.Necrotic }),
                new AestheticAdjectiveTemplate("bloated"),
                new AestheticAdjectiveTemplate("repulsive"),
                new AestheticAdjectiveTemplate("disturbing"),
                new AestheticAdjectiveTemplate("decaying", new List<DamageType>{ DamageType.Necrotic, DamageType.Acid }),
                new AestheticAdjectiveTemplate("disgusting"),
                new AestheticAdjectiveTemplate("distended"),
                new AestheticAdjectiveTemplate("disfigured"),
                new AestheticAdjectiveTemplate("misshapen"),
                new AestheticAdjectiveTemplate("deformed"),
                new AestheticAdjectiveTemplate("damaged"),
                new AestheticAdjectiveTemplate("mangled"),
                new AestheticAdjectiveTemplate("repugnant"),
                new AestheticAdjectiveTemplate("revolting"),
                new AestheticAdjectiveTemplate("expanding"),
                new AestheticAdjectiveTemplate("contracting"),
                new AestheticAdjectiveTemplate("collapsing"),
                new AestheticAdjectiveTemplate("erupting"),
                new AestheticAdjectiveTemplate("imploding"),
                new AestheticAdjectiveTemplate("contorted"),
                new AestheticAdjectiveTemplate("convoluted"),
                new AestheticAdjectiveTemplate("engraved"),
                new AestheticAdjectiveTemplate("uneven"),
                new AestheticAdjectiveTemplate("angular"),
                new AestheticAdjectiveTemplate("concave"),
                new AestheticAdjectiveTemplate("layered"),
                new AestheticAdjectiveTemplate("wild"),
                new AestheticAdjectiveTemplate("soiled"),
                new AestheticAdjectiveTemplate("abrasive"),
                new AestheticAdjectiveTemplate("astral"),
                new AestheticAdjectiveTemplate("lethargic"),
                new AestheticAdjectiveTemplate("rune-etched"),
                new AestheticAdjectiveTemplate("ruined"),//? - better word
                new AestheticAdjectiveTemplate("beautiful"),//? - better word
                new AestheticAdjectiveTemplate("elegant"),//? - better word
            };
        }

    }
}
