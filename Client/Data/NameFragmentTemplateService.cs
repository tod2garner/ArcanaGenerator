using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class NameFragmentTemplateService
    {
        private List<TemplatePerSchool> _possesives = new();
        private List<TemplatePerEffectType> _emotions = new();
        private List<TemplatePerEffectType> _cores = new();
        private List<TemplatePerEffectType> _adjectives = new();

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

        private TemplatePerSchool GetRandomTemplate(SchoolOfMagic school, List<TemplatePerSchool> templates)
        {
            var rng = new Random();
            var templatesForGivenSchool = (school == SchoolOfMagic.Any) ? templates.ToList() : templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();

            var roll = rng.Next(templatesForGivenSchool.Count);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private TemplatePerSchool GetRandomTemplate(SchoolOfMagic school, EffectType effectType, List<TemplatePerEffectType> templates)
        {
            var rng = new Random();
            var templatesForGivenSchool = (school == SchoolOfMagic.Any) ? templates : templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school));
            var templatesForGivenEffect = templatesForGivenSchool.Where(s => s.EffectTypes == null || s.EffectTypes.Any(e => e == effectType)).ToList();

            var roll = rng.Next(templatesForGivenEffect.Count);
            return templatesForGivenEffect.ElementAt(roll);
        }

        private void CreatePossesivesList()
        {
            _possesives = new List<TemplatePerSchool>()
            {
                new TemplatePerSchool("Otiir's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Esol's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new TemplatePerSchool("Torill's", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Moku's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("Rinelle's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("Dar-il'dagn's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Alerrim's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Morak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("Luhtin's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Kloryl's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Baldric's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Wogar's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("Felzak's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Hargul's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Morthos's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Zarek's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Gorthu's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Arkadi's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Cildrax's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("Arakos's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Incerion's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Zoren's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),
                new TemplatePerSchool("Keothi's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("Lo-kag's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("Roondar's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Evzek's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Yarol's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Arnost's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Foscor's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Tarathiel's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("Lysantir's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new TemplatePerSchool("Utallash's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("Dyrnar's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Tortak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Dolmen's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Divination }),
                new TemplatePerSchool("Duinir's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Gelduin's", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new TemplatePerSchool("Elander's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("Ethren's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new TemplatePerSchool("Thallan's"),
                new TemplatePerSchool("Urilont's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("Olein's"),
                new TemplatePerSchool("Giocrin's"),
            };
        }

        private void CreateEmotionsList()
        {
            _emotions = new List<TemplatePerEffectType>()
            {
                new TemplatePerEffectType("Comfort", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Joy", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Delight", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Mercy"),
                new TemplatePerEffectType("Grace", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Curiousity", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Purity"),
                new TemplatePerEffectType("Zealotry"),
                new TemplatePerEffectType("Zeal"),
                new TemplatePerEffectType("Redemption", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Admiration", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Jealousy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Anxiety"),
                new TemplatePerEffectType("Awe"),
                new TemplatePerEffectType("Pain", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List<EffectType>{ EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Horror", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Clarity", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("Delight", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Hunger", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Anger"),
                new TemplatePerEffectType("Wrath", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Spite", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Scorn", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Hatred", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Sorrow", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Grief", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new TemplatePerEffectType("Pride", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Determination", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Bitterness"),
                new TemplatePerEffectType("Isolation"),
                new TemplatePerEffectType("Solitude"),
                new TemplatePerEffectType("Defiance"),
                new TemplatePerEffectType("Dread", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new TemplatePerEffectType("Indignation"),
                new TemplatePerEffectType("Discipline", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new TemplatePerEffectType("Darkness", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Greed"),
                new TemplatePerEffectType("Contempt"),
                new TemplatePerEffectType("Torment", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Woe", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Loneliness"),
                new TemplatePerEffectType("Fear", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Envy"),
                new TemplatePerEffectType("Insanity"),
                new TemplatePerEffectType("Anarchy"),
                new TemplatePerEffectType("Misery", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Disgust", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Anguish", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Suffering", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Loathing"),
                new TemplatePerEffectType("Nostalgia", new List < EffectType > { EffectType.Buff, EffectType.Utility }),
            };
        }

        private void CreateCoresList()
        {
            _cores = new List<TemplatePerEffectType>
            {
                new TemplatePerEffectType("incantation"),
                new TemplatePerEffectType("paradox"),
                new TemplatePerEffectType("theory"),
                new TemplatePerEffectType("premise"),
                new TemplatePerEffectType("thesis"),
                new TemplatePerEffectType("toil"),
                new TemplatePerEffectType("anomaly"),
                new TemplatePerEffectType("trespass"),
                new TemplatePerEffectType("tumult", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("pandemonium", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("bedlam", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),                
                new TemplatePerEffectType("blasphemy", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("bane", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("demise", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("doom", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("undoing", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("trial", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("crucible", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("burden", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("scourge", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("charm", new List < EffectType > { EffectType.Debuff, EffectType.Buff }),
                new TemplatePerEffectType("jinx", new List < EffectType > { EffectType.Debuff }),
                new TemplatePerEffectType("folly"),
                new TemplatePerEffectType("respite", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("defense", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("zenith"),
                new TemplatePerEffectType("pinnacle"),
                new TemplatePerEffectType("step", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("transposition", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("vision", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new TemplatePerEffectType("prophecy", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("foresight", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new TemplatePerEffectType("guidance", new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
            };
        }

        private void CreateAdjectivesList()
        {
            _adjectives = new List<TemplatePerEffectType>
            {
                new TemplatePerEffectType("warding", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("protective", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("exuberant", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("gleaming"),
                new TemplatePerEffectType("haunting", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("lucky"),
                new TemplatePerEffectType("fortuitous"),
                new TemplatePerEffectType("repulsive", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("profane", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("disturbing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("repugnant", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("revolting", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("collapsing"),
                new TemplatePerEffectType("extruded"),
                new TemplatePerEffectType("thin"),
                new TemplatePerEffectType("jumbled"),
                new TemplatePerEffectType("sudden"),
                new TemplatePerEffectType("rapid"),
                new TemplatePerEffectType("hidden"),
                new TemplatePerEffectType("silent"),
                new TemplatePerEffectType("arched"),
                new TemplatePerEffectType("sweeping"),
                new TemplatePerEffectType("demented"),
                new TemplatePerEffectType("extended"),
                new TemplatePerEffectType("consuming"),
                new TemplatePerEffectType("inflated"),
                new TemplatePerEffectType("mutilated"),
                new TemplatePerEffectType("frantic"),
                new TemplatePerEffectType("tense"),
                new TemplatePerEffectType("calm", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("wild"),
                new TemplatePerEffectType("ruined"),
                new TemplatePerEffectType("benign", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("cryptic"),
                new TemplatePerEffectType("curious"),
                new TemplatePerEffectType("whimsical"),
                new TemplatePerEffectType("enigmatic"),
                new TemplatePerEffectType("grotesque", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("erupting", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("imploding", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),

                new TemplatePerEffectType("rainbow"),
                new TemplatePerEffectType("blackened"),
                new TemplatePerEffectType("azure"),
                new TemplatePerEffectType("crimson"),
                new TemplatePerEffectType("scarlet"),
                new TemplatePerEffectType("celadon"),

                new TemplatePerEffectType("sharp", new List<EffectType>{ EffectType.Damage }),
                new TemplatePerEffectType("swift"),
                new TemplatePerEffectType("slow"),
                new TemplatePerEffectType("creeping"),
                new TemplatePerEffectType("looming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("swelling"),

                new TemplatePerEffectType("Whispering"),
                new TemplatePerEffectType("Muttering"),
                new TemplatePerEffectType("Weeping", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("Wailing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("Screaming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("Shrieking", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
            };
        }
    }
}
