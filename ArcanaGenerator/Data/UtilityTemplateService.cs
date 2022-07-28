using GeneratorEngine;
using GeneratorEngine.Templates;
using System.Collections.Generic;

namespace ArcanaGenerator.Data
{
    public class UtilityTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Utility,
                    Description = "You instantly know if any spell from the same school of magic as this spell is cast within 100 ft of you. " +
                                    "You may choose to target a stationary point instead of yourself. If cast at Level 4 or higher, " +
                                    "you may end this spell early to block any one spell you detect that is of a lower level.",
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "If any footprints or animal tracks in the area were created within the past 24 hours then their outline glows. " +
                                    "The intensity of the glow increases with how recently they were created.",
                    IsAlwaysAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a set of tools for your use. They can be made from any material and take any shape, " +
                                    "but they must fit within a 5ft cube and have a combined value less than 100 gold pieces.",
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "Your boots or shoes are temporarily invulnerable to all damage. If you are not wearing any shoes or boots this spell has no effect.",
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "A softly glowing elbow-length glove appears on one of your hands (your choice) which is invulnerable to all damage.",
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.TenMinutes,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 10
                }
            };

            return templates;
        }
    }
}
