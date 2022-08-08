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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is pulled closer by 15 ft and restrained",
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 20
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back 25 ft and falls prone",
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is Deafened",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
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
                new SpellTemplate //Exhaustion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes one point of Exhaustion (but never more than 3 points from this spell)",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Sleep
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "falls asleep and drops prone to the ground",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate //Coma
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "falls into a deep coma. They drop prone to the ground and cannot be roused by normal means. Taking damage will not wake them",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 60
                },
                new SpellTemplate //Narcolepsy (partial sleep)
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "experiences random bursts of narcolepsy, during which they fall asleep mid-action. " +
                                    "They do not drop prone or drop what they are holding. " +
                                    "At the start of their turn roll 1d6 to determine what portion of their turn they miss: " +
                                    "1-2 = Cannot move this turn. " +
                                    "3-4 = Cannot use bonus actions or reactions this round. " +
                                    "5-6 = Cannot take an action this turn.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 20
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "is Paralyzed",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 40
                },
                new SpellTemplate //Berserk
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "goes berserk and must use their action on each turn to attack the nearest visible creature",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 25
                },
                new SpellTemplate //Pacifist
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is compelled to pacifism - they cannot intentionally deal damage to any sentient creature",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 25
                },
                new SpellTemplate //Lesser confusion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "experiences a flash of confusion. At the start of their turn they take a random action, but afterwards " +
                                    "they may use their movement and any bonus actions normally. Roll 1d4 to determine their action: " +
                                    "1 = They use their action to dash in a random direction, " +
                                    "2 = They waste their action doing nothing, " +
                                    "3 = They drop prone on the ground, " +
                                    "4 = They move to make a melee attack against the nearest visible creature. ",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Petrify
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "is temporarily petrified (only becomes permanent if not resisted before the end of the spell duration)",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate //Forced return teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "experiences a delayed teleportation that is triggered at the end of the spell's duration " +
                                    "back to the point where they used to be when it was cast (or the nearest unoccupied space). " +
                                    "This spell cannot cross between planes. When they are teleported they suffer 2d8 psychic damage",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Accuracy
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers a -2 penalty to all attack rolls (accuracy, not damage).",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Accuracy once per turn
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers a -4 penalty to their first attack roll on their turn (accuracy only, not damage).",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Initiative
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "suffers a -1d12 penalty to initiative.",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Damage reduction
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has their damage - from any of their actions, abilities, spells, etc. - reduced by 3d4 as a flat amount " +
                                    "(roll once and use that value for the full spell duration).",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - bleeding with movement
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes 1d6 slashing damage and is lacerated. On their turn if they move they take an addition 1d4 damage per 10ft moved " +
                                    "from blood loss as the wounds open and bleeding is worsened. Creatures that do not bleed are unaffected by this spell.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - psychic with spells
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "has a glowing collar appear around their neck. On their turn if they cast any spell they take 1d6 psychic damage per spell level. " +
                                    "If they use a magical ability that is not a spell they take 2d12 psychic damage.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - fire with weapon attacks
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "has a burning collar appear around their neck. On their turn if they make any weapon attack they take 1d8 fire damage per attack.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Drop whatever they hold
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is forced to drop one object they are holding or grasping. If that object weighs less than 10 lbs then it is flung 5 + 1d10 feet in a random direction.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Dropped for fall damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is teleported vertically 20 ft into the air and immediately begins to free fall at a magically accelerated rate (faster than typical gravity). " +
                                    "Unless they have a flying speed they plummet, fall prone, and suffer triple the typical fall damage for 6d6 bludgeoning damage. " +
                                    "This spell fails if there is not open air for the full 20 ft overhead (i.e. if the ceiling is too low for unobstructed teleportation).",
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
            };

            return templates;
        }
    }
}
