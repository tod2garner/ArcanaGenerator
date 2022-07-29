using GeneratorEngine;
using GeneratorEngine.Templates;
using System.Collections.Generic;

namespace ArcanaGenerator.Data
{
    public class DebuffTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Debuff,
                    Description = "has disadvantage on saving throws against all spells from the same school of magic as this spell",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back 5 ft",
                    IsAlwaysInstant = true,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is Poisoned",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is slowed - their movement speed is cut in half",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Restrained",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked Prone",
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is pulled closer by 15 ft",
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back 15 ft",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Deafened",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Blinded",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is magically compelled to Fear you",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Charmed to consider you a friend (but is not compelled to obey you)",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes one point of Exhaustion (but never more than 3 points from this spell)",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "falls asleep",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is Stunned",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Paralyzed",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 40
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "goes berserk and must use their action on each turn to attack the nearest visible creature",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 40
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "is temporarily petrified (only becomes permanent if not resisted before the end of the spell duration)",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "experiences a delayed teleportation that is triggered at the end of the spell's duration " +
                                    "back to the point where they used to be when it was cast (or the nearest unoccupied space). " +
                                    "This spell cannot cross between planes. When they are teleported they suffer 2d8 psychic damage",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
            };

            return templates;
        }
    }
}
