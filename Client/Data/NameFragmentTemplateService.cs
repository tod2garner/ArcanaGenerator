using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class NameFragmentTemplateService
    {
        private List<GenericTemplate> _possesives = new();
        private List<GenericTemplate> _emotions = new();

        public string GetRandomNamePossesive(SchoolOfMagic school)
        {
            if (_possesives.Count == 0)
                CreatePossesivesList();

            return GetRandomGenericTemplate(school, _possesives).Value;
        }

        public string GetRandomNameEmotion(SchoolOfMagic school)
        {
            if (_emotions.Count == 0)
                CreateEmotionsList();

            return GetRandomGenericTemplate(school, _emotions).Value;
        }

        public string GetRandomNameCore(SchoolOfMagic school, EffectType effectType) 
        {
            return "*core*";
        }

        public string GetRandomNameAdjective(SchoolOfMagic school, EffectType effectType)
        {
            return "*descriptive*";
        }

        private GenericTemplate GetRandomGenericTemplate(SchoolOfMagic school, List<GenericTemplate> templates)
        {
            var rng = new Random();
            var templatesForGivenSchool = (school == SchoolOfMagic.Any) ? templates.ToList() : templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            
            var roll = rng.Next(templatesForGivenSchool.Count);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private void CreatePossesivesList()
        {
            _possesives = new List<GenericTemplate>()
            {
                new GenericTemplate("Otiir's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new GenericTemplate("Esol's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new GenericTemplate("Torill's", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new GenericTemplate("Moku's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new GenericTemplate("Rinelle's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new GenericTemplate("Dar-il'dagn's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
                new GenericTemplate("Alerrim's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion }),
                new GenericTemplate("Morak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new GenericTemplate("Luhtin's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new GenericTemplate("Kloryl's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation }),      
                new GenericTemplate("Baldric's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation }),      
                new GenericTemplate("Wogar's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy }),      
                new GenericTemplate("Felzak's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Transmutation }),      
                new GenericTemplate("Hargul's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),      
                new GenericTemplate("Morthos's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),      
                new GenericTemplate("Zarek's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),      
                new GenericTemplate("Gorthu's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation }),      
                new GenericTemplate("Arkadi's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration }),      
                new GenericTemplate("Cildrax's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration }),      
                new GenericTemplate("Arakos's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),      
                new GenericTemplate("Incerion's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation }),      
                new GenericTemplate("Zoren's", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),      
                new GenericTemplate("Keothi's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),      
                new GenericTemplate("Lo-kag's", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new GenericTemplate("Roondar's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new GenericTemplate("Evzek's", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Illusion }),
                new GenericTemplate("Yarol's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Transmutation }),
                new GenericTemplate("Arnost's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Evocation }),
                new GenericTemplate("Fosco's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation }),
                new GenericTemplate("Tarathiel's", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment }),
                new GenericTemplate("Lysantir's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new GenericTemplate("Utallash's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplate("Dyrnar's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Abjuration }),
                new GenericTemplate("Tortak's", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplate("Dolmen's", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Divination }),
                new GenericTemplate("Duinir's", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new GenericTemplate("Gelduin's"),
                new GenericTemplate("Elander's"),
                new GenericTemplate("Ethren's"),
                new GenericTemplate("Thallan's"),
                new GenericTemplate("Urilont's"),
                new GenericTemplate("Olein's"),
                new GenericTemplate("Giocrin's"),
            };
        }

        private void CreateEmotionsList()
        {
            _emotions = new List<GenericTemplate>()
            {
                new GenericTemplate("Comfort"),
                new GenericTemplate("Joy"),
                new GenericTemplate("Delight"),
                new GenericTemplate("Mercy"),             
                new GenericTemplate("Grace"),                
                new GenericTemplate("Purity"),                
                new GenericTemplate("Vitality"),                
                new GenericTemplate("Zealotry"),                
                new GenericTemplate("Zeal"),                
                new GenericTemplate("Redemption"),                
                new GenericTemplate("Admiration"),           
                new GenericTemplate("Jealousy", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),           
                new GenericTemplate("Anxiety"),           
                new GenericTemplate("Awe"),           
                new GenericTemplate("Pain", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),           
                new GenericTemplate("Horror", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),           
                new GenericTemplate("Clarity", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),                
                new GenericTemplate("Delight"),
                new GenericTemplate("Hunger"),
                new GenericTemplate("Precision"),
                new GenericTemplate("Anger"),
                new GenericTemplate("Wrath"),
                new GenericTemplate("Spite"),
                new GenericTemplate("Scorn"),
                new GenericTemplate("Hatred"),
                new GenericTemplate("Sorrow"),                
                new GenericTemplate("Grief"),                
                new GenericTemplate("Despair", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment }),                
                new GenericTemplate("Doubt", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion }),                
                new GenericTemplate("Truth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),            
                new GenericTemplate("Pride"),
                new GenericTemplate("Determination"),
                new GenericTemplate("Bitterness"),
                new GenericTemplate("Isolation"),
                new GenericTemplate("Defiance"),
                new GenericTemplate("Dread"),
                new GenericTemplate("Malevolence", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new GenericTemplate("Indignation"),
                new GenericTemplate("Discipline"),                
                new GenericTemplate("Corruption", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new GenericTemplate("Darkness"),
                new GenericTemplate("Greed"),
                new GenericTemplate("Contempt"),
                new GenericTemplate("Torment"),
                new GenericTemplate("Woe"),
                new GenericTemplate("Loneliness"),
                new GenericTemplate("Fear"),
                new GenericTemplate("Envy"),
                new GenericTemplate("Misery"),
                new GenericTemplate("Disgust"),
                new GenericTemplate("Anguish"),
                new GenericTemplate("Suffering"),
                new GenericTemplate("Loathing"),
                new GenericTemplate("Nostalgia"),
            };
        }

        //Core - Vision, Prophecy, Guidance, Foresight (for divination utility)
        //hunter / hunting (adjective... or core?)
        //warding, protective adjective


        /*
         * Adjectives that were removed from this list. TODO: relocate these to the name adjective list
         * exuberant
         * gleaming
         * jittery
         * lucky
         * repulsive
         * disturbing                 
         * repugnant
         * revolting
         * collapsing
         * extruded
         * thin
         * jumbled
         * transparent ??
         * arched
         * sweeping
         * curling
         * demented
         * extended
         * spiraled
         * inflated
         * mutilated
         * frantic
         * tense
         * calm
         * wild
         * ruined
         * 
         * rainbow (use as noun or adj?)
         * 
         * hot
         * cold
         * sharp
         * fast
         * slow
         * swift
         * large
         * small
         * giant
         * 
         * //move to adjectives for jarunds?
                new GenericTemplate("Whispering"),
                new GenericTemplate("Muttering"),
                new GenericTemplate("Weeping"),
                new GenericTemplate("Wailing"),
                new GenericTemplate("Screaming"),
                new GenericTemplate("Shrieking"),
         */
    }
}
