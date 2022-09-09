using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class DebuffTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate //TODO - remove this filler once there is at least one template per school
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Debuff,
                    Description = "has disadvantage on saving throws against all spells from the same school of magic as this spell",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back [5-30@5] ft",
                    Names = new List<string> { "pulse", "rebuke", "surge", "ram" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is Poisoned",
                    Names = new List<string> { "toxin", "venom", "poison" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is slowed - their movement speed is cut in half",
                    Names = new List<string> { "lethargy", "torpor", "fatigue", "apathy" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Restrained",
                    Names = new List<string> { "prison", "restraint", "control", "hold", "snare" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked Prone",
                    Names = new List<string> { "trip", "trap", "impact" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is pulled closer by [10-20@5] ft",
                    Names = new List<string> { "grasp", "lure", "hook", "claw" },
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is pulled closer by [10-25@5] ft and restrained",
                    Names = new List<string> { "grasp", "hook", "hunt", "snare" },
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back [10-35@5] ft and falls prone",
                    Names = new List<string> { "rebuke", "ram", "impact" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is Deafened",
                    Names = new List<string> { "deafness", "silence", "suppression" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is Blinded",
                    Names = new List<string> { "blindness", "mask", "void" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Fear you
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is magically compelled to Fear you",
                    Names = new List<string> { "terror", "intimidation", "fear" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Fear everyone
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is magically compelled to Fear every creature within sight at the moment the spell is cast. Friend, foe, and stranger alike, they are afraid of everyone.",
                    Names = new List<string> { "paranoia", "terror", "torment" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 25
                },
                new SpellTemplate //Charm
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Charmed to consider you a friend (but is not compelled to obey you)",
                    Names = new List<string> { "embrace", "humor", "companion", "siren" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Friends abound
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Charmed to consider every creature within sight at the moment the spell is cast - friend, foe, and stranger alike - to be a close friend.",
                    Names = new List<string> { "kindness", "friend", "affability" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 20
                },
                new SpellTemplate //Exhaustion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes one point of Exhaustion (but never more than 3 points from this spell)",
                    Names = new List<string> { "siphon", "exhaustion", "enervation" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Sleep
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "falls asleep and drops prone to the ground",
                    Names = new List<string> { "sleep", "slumber", "rest" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate //Coma
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "falls into a deep coma. They drop prone to the ground and cannot be roused by non-magical means. Taking damage will not wake them",
                    Names = new List<string> { "repose", "coma", "trance", "oblivion" },
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
                    Names = new List<string> { "narcolepsy", "sleep", "torpor" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 20
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is Stunned",
                    Names = new List<string> { "daze", "stupor", "jolt" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "is Paralyzed",
                    Names = new List<string> { "paralysis", "hold", "palsy" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 40
                },
                new SpellTemplate //Berserk
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "goes berserk and must use their action on each turn to attack the nearest visible creature",
                    Names = new List<string> { "fury", "rampage", "rage" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 25
                },
                new SpellTemplate //Pacifist
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is compelled to pacifism - they cannot intentionally deal damage to any sentient creature",
                    Names = new List<string> { "pacifism", "peace", "tranquility" },
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
                    Names = new List<string> { "confusion", "daze", "hesitation" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Petrify
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "is temporarily petrified (only becomes permanent if not resisted before the end of the spell duration)",
                    Names = new List<string> { "petrification", "tomb", "fossil" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate //Forced return teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "experiences a delayed teleportation that is triggered at the end of the spell's duration " +
                                    "back to the point where they used to be when it was cast (or the nearest unoccupied space). " +
                                    "This spell cannot cross between planes. When they are teleported they suffer [2-4][dice] psychic damage",
                    Names = new List<string> { "recollection", "return", "whiplash" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Reduce accuracy
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "suffers a -[1-3] penalty to all attack rolls (accuracy, not damage).",
                    Names = new List<string> { "distraction", "interference", "haze" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Accuracy once per turn
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "suffers a -[4-6] penalty to their first attack roll on their turn (accuracy only, not damage).",
                    Names = new List<string> { "distraction", "interference", "haze" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Initiative penalty
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "suffers a -1[dice] penalty to initiative.",
                    Names = new List<string> { "delay", "lethargy", "hindrance" },
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Damage reduction
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has their damage - from any of their actions, abilities, spells, etc. - reduced by [2-4]d4 as a flat amount " +
                                    "(roll once and use that value for the full spell duration).",
                    Names = new List<string> { "weakness", "frailty", "debility" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - bleeding with movement
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes 1[dice] slashing damage and is lacerated. On their turn if they move they take an addition 1[dice] damage per 10ft moved " +
                                    "from blood loss as the wounds open and bleeding is worsened. Creatures that do not bleed are unaffected by this spell.",
                    Names = new List<string> { "laceration", "wound", "slash" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - psychic with spells
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "has a glowing collar appear around their neck. On their turn if they cast any spell they take 1[dice] psychic damage per spell level. " +
                                    "If they use a magical ability that is not a spell they take 2[dice] psychic damage.",
                    Names = new List<string> { "collar", "restraint", "neuralgia" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Triggered Damage - fire with weapon attacks
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "has a burning collar appear around their neck. On their turn if they make any weapon attack they take 1[dice] fire damage per attack.",
                    Names = new List<string> { "collar", "brand", "bridle" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Drop whatever they hold
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is forced to drop one object they are holding or grasping. If that object weighs less than 10 lbs then it is flung 5 + 1d10 feet in a random direction.",
                    Names = new List<string> { "blast", "impact", "jolt" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Dropped for fall damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is teleported vertically [20-40@10] ft into the air and immediately free falls at a magically accelerated rate (faster than typical gravity). " +
                                    "Unless they have a flying speed they rapidly plummet, fall prone, and suffer the typical fall damage plus an additional [3-5]d6 bludgeoning damage. " +
                                    "This spell fails if there is not open air for the full distance overhead (i.e. if the ceiling is too low for unobstructed teleportation).",
                    Names = new List<string> { "nosedive", "plunge", "cliff" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Disguise foe
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "is disguised with an illusion of your choosing, within the limits of the Disguise Self spell - except that it can apply to humanoid creatures instead of yourself. " +
                                    "The target is not aware of the illusion, but can realize it is being treated differently by others with a successful insight check vs your spell save DC.",
                    Names = new List<string> { "veil", "charade", "veneer" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5,
                },
                new SpellTemplate //Hearing things
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is distracted by noises that no one else can hear. You choose the nature of the sounds, but the volume is no louder than normal speaking volume. The target has disadvantage " +
                                    "on Perception, Insight, and Investigation checks. If you are hidden when you cast this spell you may choose to increase the cast time by one minute and omit all spell components " +
                                    "(making the casting undetectable by non-magical means).",
                    Names = new List<string> { "tinnitus"  },//-------------------- names -------------------- TODO
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysRanged = true,                    
                    BaseValueScore = 3,
                },
                new SpellTemplate //Taunted
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is taunted by you. They cannot target anyone other than you with attacks unless they make a successful WIS save. " +
                                    "They also automatically fail any Insight and Perception checks that are unrelated to your actions.",
                    Names = new List<string> { "taunt", "duel", "confrontation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Leash
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is anchored by chains to a point you can see within range. They cannot move more than [10-20@5]ft from the anchor point, " +
                                    "but they are able to move normally within that limit. The restraints are immune to damage and can only be escaped by teleportation. " +
                                    "This spell has no effect on creatures that are Huge or larger in size.",
                    Names = new List<string> { "leash", "tether", "fetter" },
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Arcane duel
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "cannot use their spells or magical abilities to target anyone other than you.",
                    Names = new List<string> { "duel", "match", "confrontation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Misfortune
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is cursed with sporadic misfortune. Any time they roll a 5 or lower on the dice (excluding modifiers) for any roll using a d20 (attack, save, etc.) " +
                                    "they are stunned until the end of their next turn while they deal with an unlucky coincidence.",
                    Names = new List<string> { "misfortune", "coincidence", "tribulation" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                /*                 
                 *  
                 */
                //*************************************************************************
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                //    Type = EffectType.Debuff,
                //    Description = "",
                //    Names = new List<string> {  },//--------------------TODO
                //    BaseValueScore = 5
                //},
            };

            return templates;
        }
    }
}
