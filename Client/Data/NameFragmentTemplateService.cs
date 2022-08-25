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
                new GenericTemplatePerEffectType("Grace", new List<EffectType>{ EffectType.Buff }),
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
                new GenericTemplatePerEffectType("Hunger", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Precision"),
                new GenericTemplatePerEffectType("Anger"),
                new GenericTemplatePerEffectType("Wrath", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Spite", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Scorn", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Hatred", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Sorrow", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Grief", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),
                new GenericTemplatePerEffectType("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),
                new GenericTemplatePerEffectType("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new GenericTemplatePerEffectType("Pride", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Determination", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Bitterness"),
                new GenericTemplatePerEffectType("Isolation"),
                new GenericTemplatePerEffectType("Solitude"),
                new GenericTemplatePerEffectType("Defiance"),
                new GenericTemplatePerEffectType("Dread", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplatePerEffectType("Indignation"),
                new GenericTemplatePerEffectType("Discipline", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplatePerEffectType("Darkness", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Greed"),
                new GenericTemplatePerEffectType("Contempt"),
                new GenericTemplatePerEffectType("Torment", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Woe", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Loneliness"),
                new GenericTemplatePerEffectType("Fear", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Envy"),
                new GenericTemplatePerEffectType("Insanity"),
                new GenericTemplatePerEffectType("Misery", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Disgust", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Anguish", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Suffering", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("Loathing"),
                new GenericTemplatePerEffectType("Nostalgia", new List < EffectType > { EffectType.Buff, EffectType.Utility }),
            };
        }

        private void CreateCoresList()
        {
            _cores = new List<GenericTemplatePerEffectType>
            {
                new GenericTemplatePerEffectType("paradox"),
                new GenericTemplatePerEffectType("theory"),
                new GenericTemplatePerEffectType("premise"),
                new GenericTemplatePerEffectType("thesis"),
                new GenericTemplatePerEffectType("toil"),
                new GenericTemplatePerEffectType("anomaly"),
                new GenericTemplatePerEffectType("aim"),
                new GenericTemplatePerEffectType("hunt", new List < EffectType > { EffectType.Debuff, EffectType.Damage , EffectType.Utility }),
                new GenericTemplatePerEffectType("persuit", new List < EffectType > { EffectType.Debuff, EffectType.Damage , EffectType.Utility }),
                new GenericTemplatePerEffectType("blasphemy", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("bane", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("demise", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("doom", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("undoing", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("trial", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("crucible", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("burden", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("scourge", new List < EffectType > { EffectType.Debuff, EffectType.Damage }),
                new GenericTemplatePerEffectType("charm", new List < EffectType > { EffectType.Debuff, EffectType.Buff }),
                new GenericTemplatePerEffectType("jinx", new List < EffectType > { EffectType.Debuff }),
                new GenericTemplatePerEffectType("folly"),
                new GenericTemplatePerEffectType("respite", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("defense", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("zenith"),
                new GenericTemplatePerEffectType("pinnacle"),
                new GenericTemplatePerEffectType("step", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("transposition", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("vision", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new GenericTemplatePerEffectType("prophecy", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility }),
                new GenericTemplatePerEffectType("foresight", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new GenericTemplatePerEffectType("guidance", new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
            };
        }

        private void CreateAdjectivesList()
        {
            _adjectives = new List<GenericTemplatePerEffectType>
            {
                new GenericTemplatePerEffectType("warding", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("protective", new List<EffectType>{ EffectType.Buff }),
                new GenericTemplatePerEffectType("exuberant", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new GenericTemplatePerEffectType("gleaming"),
                new GenericTemplatePerEffectType("jittery"),
                new GenericTemplatePerEffectType("haunting", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("lucky"),
                new GenericTemplatePerEffectType("repulsive", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("profane", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("disturbing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("repugnant", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("revolting", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("collapsing"),
                new GenericTemplatePerEffectType("extruded"),
                new GenericTemplatePerEffectType("thin"),
                new GenericTemplatePerEffectType("jumbled"),
                new GenericTemplatePerEffectType("sudden"),
                new GenericTemplatePerEffectType("rapid"),
                new GenericTemplatePerEffectType("hidden"),
                new GenericTemplatePerEffectType("silent"),
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
                new GenericTemplatePerEffectType("enigmatic"),
                new GenericTemplatePerEffectType("nondescript"),
                new GenericTemplatePerEffectType("grotesque", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("erupting", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new GenericTemplatePerEffectType("imploding", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),

                new GenericTemplatePerEffectType("rainbow"),
                new GenericTemplatePerEffectType("blackened"),
                new GenericTemplatePerEffectType("blue"),
                new GenericTemplatePerEffectType("red"),
                new GenericTemplatePerEffectType("green"),

                new GenericTemplatePerEffectType("sharp", new List<EffectType>{ EffectType.Damage }),
                new GenericTemplatePerEffectType("swift"),
                new GenericTemplatePerEffectType("slow"),
                new GenericTemplatePerEffectType("creeping"),
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
