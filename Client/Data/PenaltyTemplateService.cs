using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
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
                    Description = "Smoke billows from your shoulders, falling to the ground behind them like a cloak before drifting away.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 0.1
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You temporarily become color blind.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your eyes become filled with a glowing light.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your hands both begin glowing brightly.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your footprints are filled with small harmless, heatless flames.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A powerful smell of rot and decay from an invisible source fills the area around you (20 ft radius).",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 1
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer a sudden wave of nausea and have disadvantage CON saving throws.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer a sudden headache and have disadvantage INT saving throws and INT related skill checks.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer a series of intense muscle cramps and have disadvantage DEX saving throws and DEX related skill checks.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer from temporary memory loss. You forget everything from the past 2d12 hours except the most recent 5 minutes.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A loud, booming noise echoes from below your feet. The sound is clearly audible for a distance of 50 ft.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A bright flash of light appears just above your head. The light is clearly visible to any creature within line of sight.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer a intense surge of vertigo. Your movement speed is reduced by 10 ft.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your eyesight is temporarily impaired. You sporadically see spots and blurs between moments of clear vision. " +
                                    "Your movement speed is halved and you automatically fail perception checks. Other actions can still be performed normally.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are temporarily struck mute and cannot speak.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "An extensive numbness fills your mind. You must make a saving throw (DC 15) using your spell casting modifier - on" +
                                    "a failure you are unable to concentrate on any other spells.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are struck by a backlash of magical energy and become vulnerable to physical damage. Roll 1d4 to determine the extent.\n" +
                                    "4 = Piercing, 3 = Slashing, 2 = Bludgeoning, and 1 indicates all three.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are struck by a backlash of magical energy and become vulnerable to elemental damage. Roll 1d4 to determine the type.\n" +
                                    "4 = Fire, 3 = Cold, 2 = Lightning, and 1 = Thunder.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You immediately lose 2d6 HP when you cast this spell.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 9
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You stagger with a severe limp and suffer a penalty of -2 AC.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 9
                }
            };

            return templates;
        }
    }
}
