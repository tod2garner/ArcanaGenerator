using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class NameFragmentTemplateService
    {
        private List<GenericTemplatePerSchool> _possesives = new();
        private List<GenericTemplatePerEffectType> _emotions = new();
        private List<GenericTemplatePerEffectType> _cores = new();
        private List<GenericTemplatePerEffectType> _adjectives = new();

        public string GetRandomNamePossesive(SchoolOfMagic school)
        {
            if (_possesives.Count == 0)
                CreatePossesivesList();

            return GetRandomTemplate(school, _possesives).Value;
        }

        public string GetRandomNameEmotion(SchoolOfMagic school, EffectType effectType)
        {
            if (_emotions.Count == 0)
                CreateEmotionsList();

            return GetRandomTemplate(school, effectType, _emotions).Value;
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
            _emotions = new List<GenericTemplatePerEffectType>()
            {
                new GenericTemplatePerEffectType("Comfort", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Joy", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Delight", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Mercy"),             
                new GenericTemplatePerEffectType("Grace"),                
                new GenericTemplatePerEffectType("Curiousity", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),                
                new GenericTemplatePerEffectType("Purity"),                
                new GenericTemplatePerEffectType("Vitality", new List<EffectType>{ EffectType.Buff }),                
                new GenericTemplatePerEffectType("Zealotry"),                
                new GenericTemplatePerEffectType("Zeal"),                
                new GenericTemplatePerEffectType("Redemption", new List<EffectType>{ EffectType.Buff }),                
                new GenericTemplatePerEffectType("Admiration", new List<EffectType>{ EffectType.Buff }),           
                new GenericTemplatePerEffectType("Jealousy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),           
                new GenericTemplatePerEffectType("Anxiety"),           
                new GenericTemplatePerEffectType("Awe"),           
                new GenericTemplatePerEffectType("Pain", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List<EffectType>{ EffectType.Debuff, EffectType.Damage }),           
                new GenericTemplatePerEffectType("Horror", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),           
                new GenericTemplatePerEffectType("Clarity", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),                
                new GenericTemplatePerEffectType("Delight", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Hunger"),
                new GenericTemplatePerEffectType("Precision"),
                new GenericTemplatePerEffectType("Anger"),
                new GenericTemplatePerEffectType("Wrath"),
                new GenericTemplatePerEffectType("Spite"),
                new GenericTemplatePerEffectType("Scorn"),
                new GenericTemplatePerEffectType("Hatred"),
                new GenericTemplatePerEffectType("Sorrow"),                
                new GenericTemplatePerEffectType("Grief"),                
                new GenericTemplatePerEffectType("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),                
                new GenericTemplatePerEffectType("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),                
                new GenericTemplatePerEffectType("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),            
                new GenericTemplatePerEffectType("Pride"),
                new GenericTemplatePerEffectType("Determination"),
                new GenericTemplatePerEffectType("Bitterness"),
                new GenericTemplatePerEffectType("Isolation"),
                new GenericTemplatePerEffectType("Defiance"),
                new GenericTemplatePerEffectType("Dread"),
                new GenericTemplatePerEffectType("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplatePerEffectType("Indignation"),
                new GenericTemplatePerEffectType("Discipline"),                
                new GenericTemplatePerEffectType("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerEffectType("Darkness"),
                new GenericTemplatePerEffectType("Greed"),
                new GenericTemplatePerEffectType("Contempt"),
                new GenericTemplatePerEffectType("Torment"),
                new GenericTemplatePerEffectType("Woe"),
                new GenericTemplatePerEffectType("Loneliness"),
                new GenericTemplatePerEffectType("Fear"),
                new GenericTemplatePerEffectType("Envy"),
                new GenericTemplatePerEffectType("Misery"),
                new GenericTemplatePerEffectType("Disgust"),
                new GenericTemplatePerEffectType("Anguish"),
                new GenericTemplatePerEffectType("Suffering"),
                new GenericTemplatePerEffectType("Loathing"),
                new GenericTemplatePerEffectType("Nostalgia"),
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
                new GenericTemplatePerEffectType("defense", new List<EffectType>{ EffectType.Buff }),
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
                new GenericTemplatePerEffectType("warding", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("protective", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("exuberant"),
                new GenericTemplatePerEffectType("gleaming"),
                new GenericTemplatePerEffectType("jittery"),
                new GenericTemplatePerEffectType("haunting", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("lucky"),
                new GenericTemplatePerEffectType("repulsive", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("disturbing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("repugnant", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("revolting", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
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
                new GenericTemplatePerEffectType("consuming"),
                new GenericTemplatePerEffectType("inflated"),
                new GenericTemplatePerEffectType("mutilated"),
                new GenericTemplatePerEffectType("frantic"),
                new GenericTemplatePerEffectType("tense"),
                new GenericTemplatePerEffectType("calm", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("wild"),
                new GenericTemplatePerEffectType("ruined"),
                new GenericTemplatePerEffectType("benign", new List<EffectType>{ EffectType.Buff }),
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
                new GenericTemplatePerEffectType("sharp", new List<EffectType>{ EffectType.Damage }),
                new GenericTemplatePerEffectType("swift"),
                new GenericTemplatePerEffectType("slow"),
                new GenericTemplatePerEffectType("looming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("swelling"),

                new GenericTemplatePerEffectType("Whispering"),
                new GenericTemplatePerEffectType("Muttering"),
                new GenericTemplatePerEffectType("Weeping", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("Wailing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("Screaming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("Shrieking", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
            };
        }
    }
}
