using GeneratorEngine.Templates;
using GeneratorEngine;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System;

namespace SpellGenerator.Client.Data
{
    public class ReactionConditionService
    {
        protected List<TemplatePerSchool>? _conditions;
        public string GetRandomReactionCondition(SchoolOfMagic school)
        {
            var templatesForGivenSchool = GetTemplates(school);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count);
            return templatesForGivenSchool.ElementAt(roll).Value;
        }

        protected List<TemplatePerSchool> GetTemplates(SchoolOfMagic school)
        {
            if (_conditions == null)
                CreateListOfConditions();

            if (_conditions == null)
                throw new NullReferenceException("Reaction conditions were not created");

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _conditions.ToList() : _conditions.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        private void CreateListOfConditions()
        {
            _conditions = new List<TemplatePerSchool>()
            {
                new TemplatePerSchool("Before you make a saving throw"),
                new TemplatePerSchool("After you make a saving throw"),
                new TemplatePerSchool("When you succeed on a saving throw to resist a hostile spell", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("Before an ally takes damage", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("When an attack targets you, but before the DM declares if it hits or misses"),
                new TemplatePerSchool("When an attack misses you"),
                new TemplatePerSchool("After you suffer at least 10 damage"),
                new TemplatePerSchool("When a creature enters your melee reach"),
                new TemplatePerSchool("When you drop below half of your Max HP"),
                new TemplatePerSchool("When your health falls below 10 HP"),
                new TemplatePerSchool("When you see a creature drop to 0 HP", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("After rolling initiative", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new TemplatePerSchool("When you see a creature become charmed or frightened by an ally", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("When you see a creature become restrained or grappled by an ally", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation }),
                new TemplatePerSchool("When a creature that you are fighting moves into your line of sight"),
                new TemplatePerSchool("When you lose concentration on another spell", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation }),
            };
                            
            //    when you see a creature suffer X damage            
        }
    }
}
