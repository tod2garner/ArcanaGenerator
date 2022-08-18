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
            if(_templates == null)
            {
                throw new NullReferenceException();
            }
            else if(damageType != null)
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
                new AestheticAdjectiveTemplate("boiling", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("roiling", new List<DamageType>{ DamageType.Fire }),
                //synonyms for hot
                new AestheticAdjectiveTemplate("frozen", new List<DamageType>{ DamageType.Cold }),                                
                //synonyms for cold
                //synonyms for sharp
                //synonyms for fast, slow, sluggish, lethargic
                //synonyms for large, huge, small, tiny, massive
                new AestheticAdjectiveTemplate("vibrant"),
                new AestheticAdjectiveTemplate("iridescent"),
                new AestheticAdjectiveTemplate("incandescent"),
                new AestheticAdjectiveTemplate("luminescent"),
                new AestheticAdjectiveTemplate("translucent"),
                new AestheticAdjectiveTemplate("mercurial"),
                new AestheticAdjectiveTemplate("broken"),
                new AestheticAdjectiveTemplate("arched"),
                new AestheticAdjectiveTemplate("curved"),
                new AestheticAdjectiveTemplate("scented"),
                new AestheticAdjectiveTemplate("globular"),
                new AestheticAdjectiveTemplate("wriggling"),
                new AestheticAdjectiveTemplate("wrinkled"),
                new AestheticAdjectiveTemplate("gnarled"),
                new AestheticAdjectiveTemplate("squirming"),
                new AestheticAdjectiveTemplate("humming"),
                new AestheticAdjectiveTemplate("hissing"),
                new AestheticAdjectiveTemplate("dissonant"),
                new AestheticAdjectiveTemplate("discordant"),
                new AestheticAdjectiveTemplate("divergent"),
                new AestheticAdjectiveTemplate("buzzing"),                
                new AestheticAdjectiveTemplate("twinkling"),
                new AestheticAdjectiveTemplate("pulsing"),
                new AestheticAdjectiveTemplate("twisted"),
                new AestheticAdjectiveTemplate("throbbing"),
                new AestheticAdjectiveTemplate("unbalanced"),
                new AestheticAdjectiveTemplate("unstable"),
                new AestheticAdjectiveTemplate("sculpted"),
                new AestheticAdjectiveTemplate("disjointed"),
                new AestheticAdjectiveTemplate("shredded"),               
                new AestheticAdjectiveTemplate("tattered"),
                new AestheticAdjectiveTemplate("flawless"),                
                new AestheticAdjectiveTemplate("billowing"),       
                new AestheticAdjectiveTemplate("demented"),               
                new AestheticAdjectiveTemplate("warped"),
                new AestheticAdjectiveTemplate("turbulent"),
                new AestheticAdjectiveTemplate("bent"),
                new AestheticAdjectiveTemplate("perfect"),
                new AestheticAdjectiveTemplate("celestial"),
                new AestheticAdjectiveTemplate("demonic"),
                new AestheticAdjectiveTemplate("coarse"),
                new AestheticAdjectiveTemplate("corrosive"),//acid damage
                new AestheticAdjectiveTemplate("venomous"),//poison damage
                new AestheticAdjectiveTemplate("spiraled"),
                new AestheticAdjectiveTemplate("lopsided"),
                new AestheticAdjectiveTemplate("serrated"),              
                new AestheticAdjectiveTemplate("steaming"),
                new AestheticAdjectiveTemplate("dried"),
                new AestheticAdjectiveTemplate("speckled"),
                new AestheticAdjectiveTemplate("impure"),                
                new AestheticAdjectiveTemplate("crystalized"),
                new AestheticAdjectiveTemplate("crystalline"),
                new AestheticAdjectiveTemplate("sharpened"),
                new AestheticAdjectiveTemplate("shattered"),
                new AestheticAdjectiveTemplate("phantasmal", new List<DamageType>{ DamageType.Psychic }, new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),                                
                new AestheticAdjectiveTemplate("enchanting", new List<DamageType>{ DamageType.Psychic }, new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new AestheticAdjectiveTemplate("colorful"),
                new AestheticAdjectiveTemplate("colorless"),
                new AestheticAdjectiveTemplate("dark"),
                new AestheticAdjectiveTemplate("bright"),
                new AestheticAdjectiveTemplate("murky"),                
                new AestheticAdjectiveTemplate("intricate"),
                new AestheticAdjectiveTemplate("compact"),
                new AestheticAdjectiveTemplate("shimmering"),
                new AestheticAdjectiveTemplate("sleek"),                
                new AestheticAdjectiveTemplate("dull"),
                new AestheticAdjectiveTemplate("faded"),
                new AestheticAdjectiveTemplate("pale"),
                new AestheticAdjectiveTemplate("forked"),
                new AestheticAdjectiveTemplate("metallic"),
                new AestheticAdjectiveTemplate("gilded"),
                new AestheticAdjectiveTemplate("foul smelling"),
                new AestheticAdjectiveTemplate("acrid"),
                new AestheticAdjectiveTemplate("putrid"),
                new AestheticAdjectiveTemplate("spectral"),
                new AestheticAdjectiveTemplate("ghostly"),
                new AestheticAdjectiveTemplate("glowing"),
                new AestheticAdjectiveTemplate("shining"),
                new AestheticAdjectiveTemplate("writhing"),
                new AestheticAdjectiveTemplate("rotating"),
                new AestheticAdjectiveTemplate("swirling"),
                new AestheticAdjectiveTemplate("floating"),
                new AestheticAdjectiveTemplate("smooth"),
                new AestheticAdjectiveTemplate("rough"),
                new AestheticAdjectiveTemplate("jagged"),
                new AestheticAdjectiveTemplate("moist"),                
                new AestheticAdjectiveTemplate("bloodied", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("tainted", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("corrupted", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new AestheticAdjectiveTemplate("exuberant"),
                new AestheticAdjectiveTemplate("filthy"),
                new AestheticAdjectiveTemplate("sickly"),//>>??
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
                new AestheticAdjectiveTemplate("blunt"),//- bludg
                new AestheticAdjectiveTemplate("blocky"),//- bludg
                new AestheticAdjectiveTemplate("frantic"),
                new AestheticAdjectiveTemplate("tense"),
                new AestheticAdjectiveTemplate("skittish"),//???
                new AestheticAdjectiveTemplate("chaotic"),
                new AestheticAdjectiveTemplate("eerie"),
                new AestheticAdjectiveTemplate("nightmarish"),
                new AestheticAdjectiveTemplate("bloated"),
                new AestheticAdjectiveTemplate("repulsive"),
                new AestheticAdjectiveTemplate("disturbing"),
                new AestheticAdjectiveTemplate("repugnant"),
                new AestheticAdjectiveTemplate("revolting"),
                new AestheticAdjectiveTemplate("wild"),
                new AestheticAdjectiveTemplate("soiled"),
                new AestheticAdjectiveTemplate("abrasive"),
                new AestheticAdjectiveTemplate("lethargic"),
                new AestheticAdjectiveTemplate("strange"),
                new AestheticAdjectiveTemplate("rune-etched"),
                new AestheticAdjectiveTemplate("ruined"),//? - better word
                new AestheticAdjectiveTemplate("beautiful"),//? - better word
                new AestheticAdjectiveTemplate("elegant"),//? - better word
            };
        }

    }
}
