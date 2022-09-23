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
                new TemplatePerEffectType("Comfort", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Joy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Mercy", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Grace", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Curiousity", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Purity", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Zealotry", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Zeal", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Redemption", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Admiration", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Loyalty", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Devotion", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("Jealousy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Anxiety", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Awe", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Pain", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List<EffectType>{ EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Horror", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Clarity", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }, new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Delight", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }, new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Hunger", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Anger", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Wrath", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Spite", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Scorn", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Hatred", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Sorrow", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Grief", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }, new List <EffectType> { EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Pride", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Determination", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Bitterness", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Regret"),
                new TemplatePerEffectType("Isolation", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff }),
                new TemplatePerEffectType("Solitude"),
                new TemplatePerEffectType("Defiance", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new TemplatePerEffectType("Dread", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Malice", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Indignation"),
                new TemplatePerEffectType("Discipline", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Darkness", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Greed", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Contempt", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Torment", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Woe", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Loneliness", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Fear", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Envy", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Insanity", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy }),
                new TemplatePerEffectType("Vanity", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("Anarchy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Misery", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Disgust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Anguish", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Suffering", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Loathing", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("Nostalgia", new List <EffectType> { EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("Efficiency", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }, new List <EffectType> { EffectType.Utility }),
            };
        }

        private void CreateCoresList()
        {
            _cores = new List<TemplatePerEffectType>
            {
                new TemplatePerEffectType("incantation"),
                new TemplatePerEffectType("paradox"),
                new TemplatePerEffectType("dilemma"),
                new TemplatePerEffectType("theory"),
                new TemplatePerEffectType("opus"),
                new TemplatePerEffectType("premise"),
                new TemplatePerEffectType("thesis"),
                new TemplatePerEffectType("anomaly"),
                new TemplatePerEffectType("trespass", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("epiphany"),
                new TemplatePerEffectType("creed"),
                new TemplatePerEffectType("maxim"),
                new TemplatePerEffectType("tenet"),
                new TemplatePerEffectType("hubris"),
                new TemplatePerEffectType("solstice"),
                new TemplatePerEffectType("charge"),
                new TemplatePerEffectType("burden", new List <EffectType> { EffectType.Debuff }),
                new TemplatePerEffectType("chant", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("vestige", new List <SchoolOfMagic> { SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("pretext", new List <SchoolOfMagic> { SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("tumult", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("pandemonium", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("bedlam", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("blasphemy", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("bane", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("demise", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("doom", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }, new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("undoing", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("trial", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("crucible", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("burden", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("scourge", new List <EffectType> { EffectType.Debuff, EffectType.Damage }),
                new TemplatePerEffectType("jinx", new List <EffectType> { EffectType.Debuff }),
                new TemplatePerEffectType("folly"),
                new TemplatePerEffectType("respite", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("fury", new List<EffectType>{ EffectType.Damage }),
                new TemplatePerEffectType("zenith"),
                new TemplatePerEffectType("pinnacle"),
                new TemplatePerEffectType("step", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("transposition", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("omen", new List <SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Necromancy }),
                new TemplatePerEffectType("vision", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new TemplatePerEffectType("prophecy", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility }),
                new TemplatePerEffectType("foresight", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
            };
        }

        private void CreateAdjectivesList()
        {
            _adjectives = new List<TemplatePerEffectType>
            {
                new TemplatePerEffectType("warding", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("protective", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("exuberant", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("gleaming"),
                new TemplatePerEffectType("haunting", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("lucky", new List<SchoolOfMagic> { SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new TemplatePerEffectType("grand", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new TemplatePerEffectType("fortuitous", new List<SchoolOfMagic> { SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Utility, EffectType.Buff }),
                new TemplatePerEffectType("repulsive", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("profane", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("disturbing", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("repugnant", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("revolting", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("collapsing", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation }),
                new TemplatePerEffectType("extruded", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new TemplatePerEffectType("thin", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new TemplatePerEffectType("jumbled", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new TemplatePerEffectType("surreal", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("sudden"),
                new TemplatePerEffectType("rapid"),
                new TemplatePerEffectType("hidden", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Divination }),
                new TemplatePerEffectType("silent", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("arched", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerEffectType("sweeping", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerEffectType("demented", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),
                new TemplatePerEffectType("extended", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerEffectType("consuming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("inflated", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }),
                new TemplatePerEffectType("mutilated", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("frantic", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment }),
                new TemplatePerEffectType("calm", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("wild"),
                new TemplatePerEffectType("ruined", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerEffectType("benign", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }, new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("cryptic"),
                new TemplatePerEffectType("curious", new List<EffectType>{ EffectType.Buff, EffectType.Utility }),
                new TemplatePerEffectType("whimsical", new List<EffectType>{ EffectType.Buff }),
                new TemplatePerEffectType("enigmatic"),
                new TemplatePerEffectType("grotesque", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("erupting", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("imploding", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("umbral", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy }, new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("seething", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),

                new TemplatePerEffectType("blackened", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerEffectType("azure"),
                new TemplatePerEffectType("crimson"),
                new TemplatePerEffectType("scarlet"),

                new TemplatePerEffectType("sharp", new List<EffectType>{ EffectType.Damage }),
                new TemplatePerEffectType("swift"),
                new TemplatePerEffectType("creeping"),
                new TemplatePerEffectType("looming", new List<EffectType>{ EffectType.Damage, EffectType.Debuff }),
                new TemplatePerEffectType("swelling", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation }),

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
