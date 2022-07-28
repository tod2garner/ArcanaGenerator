using GeneratorEngine;
using GeneratorEngine.Templates;
using System.Collections.Generic;

namespace ArcanaGenerator.Data
{
    public class PenaltyTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Smoke billows from the caster's shoulders, falling to the ground behind them like a cloak before drifting away.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 0.1
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster temporarily becomes color blind.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster's eyes become filed with a glowing light.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster's hands both begin glowing brightly.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster's footprints are filled with small harmless, heatless flames.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A powerful smell of rot and decay from an invisible source fills the area around the caster (20 ft radius).",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 1
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster suffers a sudden wave of nausea and has disadvantage CON saving throws.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster suffers a sudden headache and has disadvantage INT saving throws and INT related skill checks.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster suffers a series of intense muscle cramps and has disadvantage DEX saving throws and DEX related skill checks.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster suffers from temporary memory loss. You forget everything from the past 2d12 hours except the most recent 5 minutes.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A loud, booming noise echoes from below the caster's feet. The sound is clearly audible for a distance of 50 ft.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A bright flash of light appears just above the caster's head. The light is clearly visible to any creature within line of sight.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster suffers a intense surge of vertigo. Their movement speed is reduced by 10 ft.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster's eyesight is temporarily impaired. They sporadically see spots and blurs between moments of clear vision. " +
                                    "Their movement speed is halved and they automatically fail perception checks. Other actions can still be performed normally.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster is temporarily struck mute and cannot speak.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "An extensive numbness fills the caster's mind. They must make a saving throw (DC 15) using their spell casting modifier - on" +
                                    "a failure they are unable to concentrate on any other spells.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster is struck by a backlash of magical energy and becomes vulnerable to physical damage. Roll 1d4 to determine the extent.\n" +
                                    "4 = Piercing, 3 = Slashing, 2 = Bludgeoning, and 1 indicates all three.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster is struck by a backlash of magical energy and becomes vulnerable to elemental damage. Roll 1d4 to determine the type.\n" +
                                    "4 = Fire, 3 = Cold, 2 = Lightning, and 1 = Thunder.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster immediately loses 2d6 HP when they cast this spell.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 9
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The caster staggers with a severe limp and suffers a penalty of -2 AC.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 9
                }
            };

            return templates;
        }
    }
}
