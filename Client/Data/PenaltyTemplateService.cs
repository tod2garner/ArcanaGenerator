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
                    Description = "Smoke billows from your shoulders, falling to the ground behind you like a cloak before fading away.",
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
                    Description = "A powerful smell of rot and decay from an invisible source fills the area around you ([15-30@5] ft radius).",
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
                    Description = "A loud, booming noise echoes from below your feet. The sound is clearly audible for a distance of [30-60@10] ft.",
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
                    Description = "You suffer a intense surge of vertigo. Your movement speed is reduced by [5-15@5] ft.",
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
                    Description = "An extensive numbness fills your mind. You must make a saving throw (DC 15) using your spell casting modifier - on " +
                                    "a failure you are unable to concentrate on any spells for 1d4 rounds.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are struck by a backlash of magical energy and become vulnerable to physical damage. Roll 1d4 to determine the type. \n" +
                                    "4 = Piercing, 3 = Slashing, 2 = Bludgeoning, and 1 indicates all three.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are struck by a backlash of magical energy and become vulnerable to elemental damage. Roll 1d4 to determine the type. \n" +
                                    "4 = Fire, 3 = Cold, 2 = Lightning, and 1 = Thunder.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You immediately lose 2[dice] HP when you cast this spell.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 9
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You immediately are knocked prone after casting this spell and your Max HP is reduced by 1[dice] until your next rest.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 12
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Penalty,
                    Description = "A small patch of flowers sprouts at your feet.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Penalty,
                    Description = "All vegetation within 10ft of you withers instantly.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 1.0
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You stagger with a severe limp and suffer a -[1-3] penalty to AC.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 9
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "After casting this spell you must make a CON saving throw. On a failure your hair falls out (if you have any) " +
                                    "and you remain bald until the end of your next long rest, at which point your hair is magically restored.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 2.0
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "The hair on your head instantly grows 2d8 inches longer.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 2.0
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "One article of clothing that you a wearing (chosen at random by the DM) is instantly bleached.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 2.0
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your skin takes on the appearance of tree bark.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your hair (if you have any) is transformed into clusters of leaves.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 0.25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "One of your eyes is temporarily sealed shut. You lack depth perception and have disadvantage on vision-based perception checks.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Your skin turns an unusual color. Roll 1d6 to determine between red, orange, yellow, green, blue, and purple.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are temporarily transformed into a different player race. " +
                                    "Roll 1d10 to determine between human, dwarf, elf, dragonborn, halfling, gnome, tiefling, goliath, orc, and goblin.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are temporarily restrained by invisible bands - your movement speed is reduced to 0 ft.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You suffer a sudden wave of nausea and become poisoned.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "A random tiny animal (DM's choice based on local ecology, CR of 0) appears on your shoulder. It is neither friendly nor hostile to you.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "After casting this spell you must make an INT saving throw. On a failure you lose one extra spell slot, " +
                                    "using the lowest available (need not match the level used for this spell).",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10.0
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are masked by an illusion to appear like a grotesque montrosity.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Penalty,
                    Description = "You are ignited and take 1[dice] fire damage instantly and again at the start of each turn, unless you use a bonus action to put out the flames.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "Anytime that you attempt to quiet your mind you are overwhelmed by anxiety. You are unable to benefit from short rests for 2d6 hours.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Penalty,
                    Description = "You are imbued with intense insomnia and are unable to benefit from a long rest for 2d8 hours.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                /*
                    ring of [material] at your feet
                    literally able to throw on clothing, lol
                 */
            };

            return templates;
        }
    }
}
