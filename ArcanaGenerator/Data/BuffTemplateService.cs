using GeneratorEngine;
using GeneratorEngine.Templates;
using System.Collections.Generic;

namespace ArcanaGenerator.Data
{
    public class BuffTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Buff,
                    Description = "has advantage on saving throws against all spells from the same school of magic as this spell",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 4
                }
            };

            return templates;
        }
    }
}
