using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class NameFragmentTemplateService
    {
        private List<GenericTemplatePerSchool> _possesives = new();
        private List<GenericTemplatePerSchool> _emotions = new();
        private List<GenericTemplatePerEffectType> _cores = new();
        private List<GenericTemplatePerEffectType> _adjectives = new();

        public string GetRandomNamePossesive(SchoolOfMagic school)
        {
            if (_possesives.Count == 0)
                CreatePossesivesList();

            return GetRandomTemplate(school, _possesives).Value;
        }

        public string GetRandomNameEmotion(SchoolOfMagic school)
        {
            if (_emotions.Count == 0)
                CreateEmotionsList();

            return GetRandomTemplate(school, _emotions).Value;
        }

        public string GetRandomNameCore(SchoolOfMagic school, EffectType effectType)
        {
            if (_cores.Count == 0)
                CreateCoresList();

            return GetRandomTemplate(school, effectType, _cores).Value;
        }

        public string GetRandomNameAdjective(SchoolOfMagic school, EffectType effectType)
        {
            if (_adjectives.Count == 0)
                CreateAdjectivesList();

            return GetRandomTemplate(school, effectType, _adjectives).Value;
        }

        private GenericTemplatePerSchool GetRandomTemplate(SchoolOfMagic school, List<GenericTemplatePerSchool> templates)
        {
            var rng = new Random();
            var templatesForGivenSchool = (school == SchoolOfMagic.Any) ? templates.ToList() : templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            
            var roll = rng.Next(templatesForGivenSchool.Count);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private GenericTemplatePerSchool GetRandomTemplate(SchoolOfMagic school, EffectType effectType, List<GenericTemplatePerEffectType> templates)
        {
            var rng = new Random();
            var templatesForGivenSchool = (school == SchoolOfMagic.Any) ? templates : templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school));
            var templatesForGivenEffect = templatesForGivenSchool.Where(s => s.EffectTypes == null || s.EffectTypes.Any(e => e == effectType)).ToList();

            var roll = rng.Next(templatesForGivenEffect.Count);
            return templatesForGivenEffect.ElementAt(roll);
        }

        private void CreatePossesivesList()
        {
            _possesives = new List<GenericTemplatePerSchool>()
            {
                new GenericTemplatePerSchool("Otiir's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new GenericTemplatePerSchool("Esol's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new GenericTemplatePerSchool("Torill's", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Moku's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new GenericTemplatePerSchool("Rinelle's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new GenericTemplatePerSchool("Dar-il'dagn's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new GenericTemplatePerSchool("Alerrim's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new GenericTemplatePerSchool("Morak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new GenericTemplatePerSchool("Luhtin's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Kloryl's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation }),      
                new GenericTemplatePerSchool("Baldric's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation }),      
                new GenericTemplatePerSchool("Wogar's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy }),      
                new GenericTemplatePerSchool("Felzak's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Transmutation }),      
                new GenericTemplatePerSchool("Hargul's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),      
                new GenericTemplatePerSchool("Morthos's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),      
                new GenericTemplatePerSchool("Zarek's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),      
                new GenericTemplatePerSchool("Gorthu's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation }),      
                new GenericTemplatePerSchool("Arkadi's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration }),      
                new GenericTemplatePerSchool("Cildrax's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration }),      
                new GenericTemplatePerSchool("Arakos's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),      
                new GenericTemplatePerSchool("Incerion's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation }),      
                new GenericTemplatePerSchool("Zoren's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),      
                new GenericTemplatePerSchool("Keothi's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),      
                new GenericTemplatePerSchool("Lo-kag's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new GenericTemplatePerSchool("Roondar's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerSchool("Evzek's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Illusion }),
                new GenericTemplatePerSchool("Yarol's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerSchool("Arnost's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Fosco's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Tarathiel's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment }),
                new GenericTemplatePerSchool("Lysantir's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new GenericTemplatePerSchool("Utallash's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerSchool("Dyrnar's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Abjuration }),
                new GenericTemplatePerSchool("Tortak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Dolmen's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Divination }),
                new GenericTemplatePerSchool("Duinir's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new GenericTemplatePerSchool("Gelduin's"),
                new GenericTemplatePerSchool("Elander's"),
                new GenericTemplatePerSchool("Ethren's"),
                new GenericTemplatePerSchool("Thallan's"),
                new GenericTemplatePerSchool("Urilont's"),
                new GenericTemplatePerSchool("Olein's"),
                new GenericTemplatePerSchool("Giocrin's"),
            };
        }

        private void CreateEmotionsList()
        {
            _emotions = new List<GenericTemplatePerSchool>()
            {
                new GenericTemplatePerSchool("Comfort"),
                new GenericTemplatePerSchool("Joy"),
                new GenericTemplatePerSchool("Delight"),
                new GenericTemplatePerSchool("Mercy"),             
                new GenericTemplatePerSchool("Grace"),                
                new GenericTemplatePerSchool("Curiousity"),                
                new GenericTemplatePerSchool("Purity"),                
                new GenericTemplatePerSchool("Vitality"),                
                new GenericTemplatePerSchool("Zealotry"),                
                new GenericTemplatePerSchool("Zeal"),                
                new GenericTemplatePerSchool("Redemption"),                
                new GenericTemplatePerSchool("Admiration"),           
                new GenericTemplatePerSchool("Jealousy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),           
                new GenericTemplatePerSchool("Anxiety"),           
                new GenericTemplatePerSchool("Awe"),           
                new GenericTemplatePerSchool("Pain", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),           
                new GenericTemplatePerSchool("Horror", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),           
                new GenericTemplatePerSchool("Clarity", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),                
                new GenericTemplatePerSchool("Delight"),
                new GenericTemplatePerSchool("Hunger"),
                new GenericTemplatePerSchool("Precision"),
                new GenericTemplatePerSchool("Anger"),
                new GenericTemplatePerSchool("Wrath"),
                new GenericTemplatePerSchool("Spite"),
                new GenericTemplatePerSchool("Scorn"),
                new GenericTemplatePerSchool("Hatred"),
                new GenericTemplatePerSchool("Sorrow"),                
                new GenericTemplatePerSchool("Grief"),                
                new GenericTemplatePerSchool("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),                
                new GenericTemplatePerSchool("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),                
                new GenericTemplatePerSchool("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),            
                new GenericTemplatePerSchool("Pride"),
                new GenericTemplatePerSchool("Determination"),
                new GenericTemplatePerSchool("Bitterness"),
                new GenericTemplatePerSchool("Isolation"),
                new GenericTemplatePerSchool("Defiance"),
                new GenericTemplatePerSchool("Dread"),
                new GenericTemplatePerSchool("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplatePerSchool("Indignation"),
                new GenericTemplatePerSchool("Discipline"),                
                new GenericTemplatePerSchool("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerSchool("Darkness"),
                new GenericTemplatePerSchool("Greed"),
                new GenericTemplatePerSchool("Contempt"),
                new GenericTemplatePerSchool("Torment"),
                new GenericTemplatePerSchool("Woe"),
                new GenericTemplatePerSchool("Loneliness"),
                new GenericTemplatePerSchool("Fear"),
                new GenericTemplatePerSchool("Envy"),
                new GenericTemplatePerSchool("Misery"),
                new GenericTemplatePerSchool("Disgust"),
                new GenericTemplatePerSchool("Anguish"),
                new GenericTemplatePerSchool("Suffering"),
                new GenericTemplatePerSchool("Loathing"),
                new GenericTemplatePerSchool("Nostalgia"),
            };
        }

        private void CreateCoresList()
        {
            _cores = new List<GenericTemplatePerEffectType>
            {
                new GenericTemplatePerEffectType("paradox"),
                new GenericTemplatePerEffectType("theory"),
                new GenericTemplatePerEffectType("thesis"),
                new GenericTemplatePerEffectType("hunt"),
                new GenericTemplatePerEffectType("bane"),
                new GenericTemplatePerEffectType("demise"),
                new GenericTemplatePerEffectType("doom"),
                new GenericTemplatePerEffectType("undoing"),
                new GenericTemplatePerEffectType("folly"),
                new GenericTemplatePerEffectType("respite"),
                new GenericTemplatePerEffectType("defense", new List<SchoolOfMagic>{ SchoolOfMagic.Any }, new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("mire"),
                new GenericTemplatePerEffectType("zenith"),
                new GenericTemplatePerEffectType("pinnacle"),
                new GenericTemplatePerEffectType("step", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("transposition", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("vision", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new GenericTemplatePerEffectType("prophecy", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("foresight", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new GenericTemplatePerEffectType("guidance", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
            };
        }

        private void CreateAdjectivesList()
        {
            _adjectives = new List<GenericTemplatePerEffectType>
            {
                new GenericTemplatePerEffectType("warding"),
                new GenericTemplatePerEffectType("protective"),
                new GenericTemplatePerEffectType("exuberant"),
                new GenericTemplatePerEffectType("gleaming"),
                new GenericTemplatePerEffectType("jittery"),
                new GenericTemplatePerEffectType("haunting"),
                new GenericTemplatePerEffectType("lucky"),
                new GenericTemplatePerEffectType("repulsive"),
                new GenericTemplatePerEffectType("disturbing"),
                new GenericTemplatePerEffectType("repugnant"),
                new GenericTemplatePerEffectType("revolting"),
                new GenericTemplatePerEffectType("collapsing"),
                new GenericTemplatePerEffectType("extruded"),
                new GenericTemplatePerEffectType("thin"),
                new GenericTemplatePerEffectType("jumbled"),
                new GenericTemplatePerEffectType("obvious"),
                new GenericTemplatePerEffectType("hidden"),
                new GenericTemplatePerEffectType("arched"),
                new GenericTemplatePerEffectType("sweeping"),
                new GenericTemplatePerEffectType("demented"),
                new GenericTemplatePerEffectType("extended"),
                new GenericTemplatePerEffectType("inflated"),
                new GenericTemplatePerEffectType("mutilated"),
                new GenericTemplatePerEffectType("frantic"),
                new GenericTemplatePerEffectType("tense"),
                new GenericTemplatePerEffectType("calm"),
                new GenericTemplatePerEffectType("wild"),
                new GenericTemplatePerEffectType("ruined"),
                new GenericTemplatePerEffectType("benign"),
                new GenericTemplatePerEffectType("cryptic"),
                new GenericTemplatePerEffectType("curious"),
                new GenericTemplatePerEffectType("whimsical"),

                new GenericTemplatePerEffectType("rainbow"),
                new GenericTemplatePerEffectType("blackened"),
                new GenericTemplatePerEffectType("blue"),
                new GenericTemplatePerEffectType("red"),
                new GenericTemplatePerEffectType("green"),

                new GenericTemplatePerEffectType("hot"),
                new GenericTemplatePerEffectType("cold"),
                new GenericTemplatePerEffectType("sharp"),
                new GenericTemplatePerEffectType("swift"),
                new GenericTemplatePerEffectType("slow"),
                new GenericTemplatePerEffectType("looming"),
                new GenericTemplatePerEffectType("giant"),

                new GenericTemplatePerEffectType("Whispering"),
                new GenericTemplatePerEffectType("Muttering"),
                new GenericTemplatePerEffectType("Weeping"),
                new GenericTemplatePerEffectType("Wailing"),
                new GenericTemplatePerEffectType("Screaming"),
                new GenericTemplatePerEffectType("Shrieking"),
            };
        }
    }
}
