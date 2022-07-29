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
                    Description = "has advantage on saving throws against all spells from the same school of magic as this spell.",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains a 2d4 bonus AC for the duration, but if they are hit this spell ends early.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains a +3 bonus AC for the duration.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains 3d4 Temporary HP.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains 3d8 Temporary HP.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "can resist critical hits - they are treated as normal hits instead.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Physical damage. The caster can choose between Piercing, Slashing, and Bludgeoning.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can use a reaction to change damage they receive from one type to another. For example: when hit with lightning damage, treat it as bludgeoning damage instead.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "can choose one damage type to temporarily heal instead of harm them.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 60
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Elemental damage. The caster can choose between Fire, Cold, Lightning, and Thunder.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains resistance to Necrotic damage but becomes vulnerable to Radiant damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "shares damage taken with all other friendly creatures affected by this spell. The total damage is split evenly " +
                                    "between them - for odd amounts the remainder goes to the original target. Example: for 21 damage split among 4 creatures " +
                                    "the original target takes 6 points and the other creatures each take 5 points.",
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is coated by a shimmering film. Whenever they are hit by a melee attack the damage is reduced by 2d6 and " +
                                    "a lash of energy strikes back at the attacker, dealing the double amount prevented as Force damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily covered by metallic quills. Whenever they are hit by a melee attack the attacker suffers 3d10 + 5 Piercing damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "is temporarily surrounded by an irregular bubble shaped like their body. Whenever they would be hit by a ranged projectile attack the " +
                                    "projectile is deflected and turned back towards the attacker. The original attack roll is used vs the attackers AC to determine if it hits. " +
                                    "After deflecting 1d6 attacks the spell ends early.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                }
            };

            return templates;
        }
    }
}
