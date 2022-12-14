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
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked back [5-30@5] ft",
                    Names = new List<string> { "pulse", "rebuke", "surge", "ram" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 4
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is Poisoned",
                    Names = new List<string> { "toxin", "venom", "poison" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 4
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration },
                    Type = EffectType.Debuff,
                    Description = "is Restrained",
                    Names = new List<string> { "prison", "restraint", "control", "hold", "snare" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 7
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is knocked Prone",
                    Names = new List<string> { "trip", "trap", "impact" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is pulled closer by [10-20@5] ft",
                    Names = new List<string> { "grasp", "lure", "hook", "claw" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
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
                    IsRepeatable = true,
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
                    IsRepeatable = true,
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
                    Description = "is magically Frightened of you.",
                    Names = new List<string> { "terror", "intimidation", "fear" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Fear everyone
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is magically Frightened of every creature within sight at the moment the spell is cast. Friend, foe, and stranger alike, they are afraid of everyone.",
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
                new SpellTemplate //Delayed suggestion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is Charmed to consider you a friend for 2d4 minutes. At the end of that time you may give them a single mental suggestion telepathically which they are compelled to obey, subject to the limitations described in the 2nd level 'Suggestion' spell. " +
                                    "You need not remain near them for the full time span, nor is it necessary for them to remain in your line of sight for you to give the mental command. " +
                                    "The target is not automatically aware that you are the source of the suggestion, but may realize it with either an Insight or Intelligence check vs your spell save DC, with advantage at the DM's discretion. " +
                                    "This spell has no effect on creatures that are immune to being charmed.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    BaseValueScore = 40
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
                    IsRepeatable = true,
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
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
                    IsRepeatable = true,
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "is distracted by noises that no one else can hear. You choose the nature of the sounds, but the volume is no louder than normal speaking volume. The target has disadvantage " +
                                    "on Perception, Insight, and Investigation checks. If you are hidden when you cast this spell you may choose to increase the cast time by one minute and omit all spell components " +
                                    "(making the casting undetectable by non-magical means).",
                    Names = new List<string> { "tinnitus", "thrum", "diversion"  },
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
                    BaseValueScore = 5
                },
                new SpellTemplate //Seal ability short term
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "has one of their abilities or spells sealed for 1d4 rounds, such that they cannot use it. " +
                                    "You roll a percentile dice when you cast this spell - there is a 50% chance you can pick which ability is sealed and a 50% chance for the DM to pick one randomly. " +
                                    "If you do get to choose, you can only pick abilities that you have seen the target use.",
                    Names = new List<string> { "seal", "oblivion", "amnesia" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Seal ability long term
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "has one of their abilities or spells sealed for the spell duration, such that they cannot use it. You pick which ability to seal, " +
                                    "but the DM also chooses one of your own abilities to be sealed while the spell is active. You can only pick abilities that you have seen the target use.",
                    Names = new List<string> { "seal", "oblivion", "amnesia" },
                    MinimumDuration = Duration.UntilNextShortRest,
                    IsNeverAoE = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Lateral gravity
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is suddenly pulled sideways as gravity pivots laterally for only them. You choose which cardinal direction (it must be perpendicular to typical gravity), and for the duration they are pulled at a rate of 30 ft per round. " +
                                    "If there is a fixed object within their reach - including uneven terrain - they may grasp onto it to avoid falling sideways.",
                    Names = new List<string> { "pull", "fall", "gravitas", "gravity" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Partial banishment
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration },
                    Type = EffectType.Debuff,
                    Description = "is partially banished. They take no damage but are temporarily disabled as you force part of their body to a harmless demi-plane. No wound is created (i.e. no blood loss, etc). " +
                                    "Instead a glowing plane appears at the point of pseudo-amputation. Roll a percentile dice to determine what portion of their body is banished: " +
                                    "60-99 = one leg, " +  //40%
                                    "30-59 = one arm, " +  //30%
                                    "20-29 = two legs, " + //10%
                                    "10-19 = two arms, " + //10%
                                    "0-9 = one head. " +  //10%
                                    "This spell has no effect on creatures that have no limbs or are incorporeal.",
                    Names = new List<string> { "banishment", "detachment", "severance", "scattering" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 20
                },   
                new SpellTemplate //Reduce Max HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers [3-8][dice] necrotic damage and has their Maximum HP reduced by the same amount until their next Long Rest.",
                    Names = new List<string> { "withering", "wilting", "desiccation" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Escalating reduced Max HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has their Maximum HP reduced by [2-3][dice] once per hour for the duration of this spell.",
                    Names = new List<string> { "withering", "wilting", "desiccation" },
                    MinimumDuration = Duration.OneDay,
                    BaseValueScore = 2
                },
                new SpellTemplate //No healing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "cannot regain HP for the spell's duration.",
                    Names = new List<string> { "infection", "contamination", "disorder" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate //No healing spells, and healer takes damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "cannot be healed by spells, and any caster that tries to heal this target suffers the amount of healing as Necrotic damage.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Steal healing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has any healing stolen from them for the duration. Any time they would regain HP from any source instead you regain that HP and they get nothing. " +
                                    "This spell ends early after stealing [20-60@5] HP worth of healing.",
                    MinimumDuration = Duration.OneMinute,
                    Names = new List<string> { "theft", "siphon", "larceny" },
                    BaseValueScore = 15
                },
                new SpellTemplate //Damage and raise as a skeleton
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "takes [5-8][dice] acid damage + [25-40@5] necrotic damage. A humanoid killed by this spell rises at the start of your next turn as a skeleton that is permanently under your command, following your verbal orders to the best of its ability.",
                    Names = new List<string> { "dissolution", "liquefaction", "demise", "decomposition" },
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    BaseValueScore = 60
                },
                new SpellTemplate //Damage based on your missing HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers necrotic damage equal to how much of your own HP is missing. If the target is killed, 1d4 chance to not use a spell slot for the casting.",
                    Names = new List<string> { "vengence", "revenge", "retaliation" },
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Vampiric spell attack - single target
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers [4-8][dice] necrotic damage and you regain HP equal to half the damage dealt.",
                    Names = new List<string> { "harvest", "vampirism", "drain", "reaping" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Vampiric spell attack - AoE
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "suffers [2-6][dice] necrotic damage and you regain [1-2] HP per creature damaged.",
                    Names = new List<string> { "harvest", "vampirism", "drain", "reaping" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    IsAlwaysAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Harvest buffs
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has all non-permanent beneficial effects instantly removed and suffers [2-4][dice] necrotic damage per beneficial effect removed. " +
                                    "For the purposes of this spell 'non-permanent' refers to any effect with a set duration after which it automatically expires.",
                    Names = new List<string> { "harvest", "scouring", "bleaching", "void" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //Harvest curses
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has all non-permanent ailments, curses, and other debuffs instantly removed, but they suffer [4-6][dice] necrotic damage per negative effect removed. " +
                                    "For the purposes of this spell 'non-permanent' refers to any effect with a set duration after which it automatically expires.",
                    Names = new List<string> { "harvest", "scouring", "bleaching", "void" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 8
                },
                new SpellTemplate //Chaotic curse
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is striken with a chaotic curse that changes each round. At the start of each of their turns roll 1d8 to determine the effect for that round: " +
                                        "1 = blinded, " +
                                        "2 = mute and deaf, " +
                                        "3 = slowed (half speed), " +
                                        "4 = restrained, " +
                                        "5 = poisoned, " +
                                        "6 = frightened of you, and " +
                                        "7 = pacifism (cannot willing deal damage), " +
                                        "8 = stunned.",
                    Names = new List<string> { "chaos", "entropy", "curse" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //Reduce speed and AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "has their movement speed reduced by [5-20@5]ft and suffers a -1d3 penalty to AC for the spell duration.",
                    Names = new List<string> { "lethargy", "torpor", "mire" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 25
                },
                new SpellTemplate //Reduce speed and accuracy
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "has their movement speed reduced by [5-20@5]ft and suffers a -[2-5] penalty to all attack rolls (accuracy, not damage) for the spell duration",
                    Names = new List<string> { "lethargy", "torpor", "mire" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 20
                },
                new SpellTemplate //Reduce speed and no bonus actions or reactions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "has their movement speed reduced by [5-15@5]ft and is unable to use reactions or bonus actions for the spell duration.",
                    Names = new List<string> { "lethargy", "torpor", "mire" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Feel your pain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is cursed to feel your pain. Each time you suffer damage they also suffer the same damage at half value.",
                    Names = new List<string> { "empathy", "mark", "bond" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Doom
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is marked for death. Lines of black sigils appear on the target's hands and neck. After 4d8 + 12 hours they instantly die. " +
                                    "This can be prevented only by removing the curse or by personally killing a humanoid before the time expires. " +
                                    "The target instinctively knows this fact the moment that they are marked, as well as how much time they have. " +
                                    "The black sigils spread as the time grows shorter, covering their entire body when their doom is met, and vanishing if it is avoided." +
                                    " Undead, fiends, and celestials are not affected by this spell.",
                    Names = new List<string> { "doom", "omen", "ruin" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 150
                },
                new SpellTemplate //Steal STR or DEX or CON
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has their stamina stolen by you. Select either STR, DEX, or CON when you cast this spell. " +
                                    "The target's ability score is reduced by 2d4 and yours is increased by the same amount.",
                    Names = new List<string> { "theft", "siphon", "larceny" },
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 25
                },
                new SpellTemplate //Feeble body
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "has their STR and CON ability scores reduced to 1.",
                    Names = new List<string> { "weakness", "frailty", "fragility" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 30
                },
                new SpellTemplate //Improved bane
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "must subtract 1[dice] from all attack rolls, saving throws, and ability checks.",
                    Names = new List<string> { },//--------------------TODO
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Shared suffering
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is linked to share their suffering with any creatures you choose in the target area. " +
                                    "Anytime they take damage every linked creature also suffers the same damage at half value (this is not recursive). " +
                                    "This spell fails if there are less than two visible creatures in the target area.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Penalty to AC for friend, foe, and self
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "has their AC reduced by [4-8]. This applies to ALL creatures in the target area - including yourself and your allies along with any enemies or strangers.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    DoesNotTargetCreatures = true,//Location effect
                    BaseValueScore = 10
                },
                new SpellTemplate //Vulnerable to physical
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "becomes vulnerable to one type of physical damage that you choose: Piercing, Slashing, or Bludgeoning.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Vulnerable to elemental
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "becomes vulnerable to one type of elemental damage that you choose: Fire, Cold, Lightning, or Thunder.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Vulnerable to dark
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Debuff,
                    Description = "becomes vulnerable to one of the following types of damage that you choose: Necrotic, Acid, or Poison.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Vulnerable to light
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "becomes vulnerable to one of the following types of damage that you choose: Psychic, Radiant, or Force",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Ignite proliferation
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "takes [2-4][dice] fire damage and is ignited. While still burning they panic and instantly (during your turn) run 15ft in a random direction (roll 1d4). " +
                                    "Any creature within 5ft of them at any point along their path must make a DEX save. On a failure the adjacent creatures is also ignited, and suffers this same effect - potentially causing a chain reaction as they also are burned, panic, and run. " +
                                    "By the start of their next turn the flames die down and dissipate. Creatures that are immune to magical fear do not panic or run, but still suffer the fire damage.",
                    Names = new List<string> { "proliferation", "ignition", "blaze" },
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Random damage type and dice count
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "suffers chaotic damage of a random type. The size of the damage dice is a [dice], but the quantity changes with each casting. Roll 2d8 to determine the quantity of damage dice to use. " +
                                    "Then roll 1d8 to determine the damage type: Bludgeoning, Fire, Cold, Lightning, Thunder, Acid, Poison, or Force.",
                    Names = new List<string> { "chaos", "entropy", "chance", "gamble" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //Hallucination
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "begins to hallucinate. Up to 2d4 entities appear that no one else can see, but that are vivid to all of the target's senses (sight, sound, smell, touch, etc). " +
                                    "You choose the appearance of the entities, up to [10-20@5]ft in any dimension, at the time of casting. You may change their behavior each round as a bonus action on your turn. " +
                                    "If they appear to act in a violent way the target suffers [2-4][dice] psychic damage, but experiences it as the appropriate imagined damage type. " +
                                    "Instead of simply attacking you may choose to have them perform more complex actions, such as carrying on a conversation, but doing so requires your full action rather than a bonus action.",
                    Names = new List<string> { "hallucination", "visitation", "visitors" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Illusory smell
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "is overwhelmed by an illusory scent. You may choose any smell, and can make it seem either directional or ubiquitous. " +
                                    "At worst, the smell can be odious enough to cause the poisoned condition on a failed CON save.",
                    Names = new List<string> { "scent", "stench", "odor", "miasma" },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Insomnia
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "experiences insomnia or nightmares (your choice) such that they can gain no benefit from a long rest for [3-4]d12 + [6-18@2] hours.",
                    Names = new List<string> { "restlessness", "insomnia", "sleeplessness" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Blurred vision
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "has their vision impaired, such that everything becomes blurry the farther away it is from them. " +
                                    "They suffer a -5 penalty to melee attacks, a -10 penalty to ranged attacks, and automatically fail sight-related perception checks. " +
                                    "Creatures that do not rely on sight are immune to this spell.",
                    Names = new List<string> { "haze", "murk", "blur", "bleariness" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Ragdoll slam
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is picked up and slammed repeatedly into the ground, suffering [4-8][dice] bludgeoning damage, and then thrown up to [10-20@5]ft in a direction you choose. " +
                                    "This spell has no effect on creatures that are Huge or larger.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Lesser power word kill, leave at 1 HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "that has less than [40-60@10] HP is instantly reduced to 1 HP and slowed until the end of their next turn. If their health is not below the threshold then they are slowed but suffer no damage.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Lesser power word kill, caster takes damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "that has less than [40-60@10] HP is instantly reduced to 0 HP, but you lose [1-2][dice] HP for each creature killed.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Reduce HP by half, caster takes damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "suffers Force damage equal to half of their remaining HP (the DM may or may not reveal the exact amount). However, if the total damage dealt exceeds 50 HP, then you must make a CON saving throw. " +
                                    "On a failure the strain causes you to suffer [4-6][dice] + 20 force damage that cannot be resisted. On a success you take half damage.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Perceive all creatures as having the same face
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "begins to hallucinate such that all creatures look like they have the same face to them. You may choose what the face looks like. Creatures wearing clothing also appear to all be wearing identical attire (again your choice), but " +
                                    "any tools or weapons they are holding are unchanged.",
                    Names = new List<string> { "anonymity", "obscurity", "visage"  },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysRanged = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //Aura of madness
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "is masked by an illusion to appear awkward, disturbing, and/or insane to those around them. They suffer a -10 penalty to all CHA related ability checks (persuasion, intimidation, performance, etc). " +
                                    "The creature is unaware of the illusion, but can realize that it is being treated differently by succeeding on an Insight check vs your spell save DC. " +
                                    "Other creatures can see through the illusion by succeeding on an Investigation check vs your spell save DC.",
                    Names = new List<string> { "mortification", "discomposure", "awkwardness" },
                    MinimumDuration = Duration.TenMinutes,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Word swap
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "has up to 1d4 specific words they hear switched by you for the duration. Each time they hear one of the chosen words, from any source, it is replaced in their mind such that they hear a different word of your choosing. " +
                                    "You choose which new word will replace each forbidden word at the time of casting. The target is unaware of the deception, but can realize the communication is off by succeeding on an Insight check vs your spell save DC.",
                    Names = new List<string> { "exchange", "switch", "trade", "swap" },
                    MinimumDuration = Duration.TenMinutes,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Babel
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "forgets all languages that they normally know, and instantly know a single random language instead. They roll 1d10 to determine the language: Dwarvish, Elvish, Giant, Gnomish, Goblin, Halfling, Orc, Draconic, Sylvan, or Undercommon. " +
                                    "This spell has no effect on creatures that do not know a spoken language.",
                    Names = new List<string> { "babeling", "tumult", "tongue" },
                    MinimumDuration = Duration.OneHour,
                    IsAlwaysAoE = true,
                    BaseValueScore = 3
                },
                new SpellTemplate //Blurt
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "blurts out 2d4 words of your choosing. If you are hidden from the target then the number of words is doubled.",
                    Names = new List<string> { "confession", "exclamation", "interjection" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Taboo
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is unable to utter 2d4 specific words of your choosing. If you are hidden from the target then roll one extra dice to determine the number of words.",
                    Names = new List<string> { "taboo", "muzzle", "suppression" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate //Must speak lies
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is unable to directly verbalize any fact that they believe is true - they must speak vaguely, tell lies, or remain silent.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate //Freeze or flee
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "panics and either freezes or flees. On their turn they can only use their action to Dodge or Dash. " +
                                    "This spell has no effect on creatures that are immune to magical fear.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Pied piper
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is compelled to follow you at a distance. They cannot willing move farther than 30ft from you, nor closer than 5ft from you, " +
                                    "and must use their movement to stay in that range. While outside that range they must use their action to dash and attempt to follow you. " +
                                    "Creatures that are immune to being charmed cannot be effected by this spell.",
                    Names = new List<string> { "beckoning", "piper", "lure" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8
                },
                new SpellTemplate //Siren call
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "is compelled use their movement get as close to you as possible and cannot willingly move farther from you. " +
                                    "While more than 10ft from you they must use also their action to dash and attempt to reach you. " +
                                    "Creatures that are immune to being charmed cannot be effected by this spell.",
                    Names = new List<string> { "beckoning", "siren", "lure" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 4
                },
                new SpellTemplate //Prone and unable to stand
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Debuff,
                    Description = "is knocked prone and is unable to stand upright for the spell duration - they may still crawl however. The spell can only affect humanoid creatures.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Storm call
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is marked with an obvious, glowing sigil. It causes no damage while this spell is active and simply remains bound to the target, moving with them. " +
                                    "At the end of the spell duration, however, they suffer [10-20@2] thunder damage plus 2[dice] lightning damage as a massive bolt of lightning strikes the sigil from above them. " +
                                    "On each of your turns that passes without the spell ending you may use a bonus action to increase the eventual lightning damage by 2 dice. " +
                                    "You may instead choose to end this spell early (triggering the damage) as a bonus action. This spell can target a stationary location rather than a creature.",
                    Names = new List<string> { "capacitor", "static", "bolt", "storm", "thunder" },
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Infernal cry
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is covered with a layer of ash for the spell duration. If they are reduced to 0 HP then the ash explodes, dealing [2-4][dice] + [5-10] fire damage to all creatures within 10ft. " +
                                    "This can trigger a chain reaction if the explosion reduces another creature covered in ash to 0 HP.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration= Duration.OneMinute,
                    IsAlwaysAoE = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Profane bloom
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is cursed in a unique manner. If they are killed during the spell duration then their body detonates, dealing [3-5][dice] + [8-15] necrotic damage to all creatures within 10ft. " +
                                    "This can trigger a chain reaction if the explosion kills a similarly cursed creature.",
                    Names = new List<string> { "desecration", "omen", "doom", "depravation" },
                    MinimumDuration= Duration.OneMinute,
                    IsAlwaysAoE = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //Variant of mind spike - interrogation
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "suffers a debilitating migraine as you burrow into their thoughts. Doing so requires your full attention - this spell ends early if you move at all or use your action for anything other than continuing this spell. " +
                                    "The target is stunned for 1d3 rounds and each round you may use your action to pry for one specific fact. On each attempt you make a contested INT check vs the target. " +
                                    "On a success you get a glimpse of what they know about the desired fact - no more than a quick image or a single sentence. If they do not know the fact that you seek, instead you get a random glimpse into their mind. " +
                                    "On a failure you learn nothing.",
                    Names = new List<string> { "interrogation", "migraine", "interview" },
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Restrained - including magical movement and teleportation
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Debuff,
                    Description = "is restrained. Additionally, they cannot be physically relocated by anyone other than you. " +
                                    "Magical movement such as teleportation fails completely. Finally, they cannot shift between planes for the spell duration.",
                    Names = new List<string> { "anchor", "bond", "root" },
                    MinimumDuration= Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Chained - take damage if they try to teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Debuff,
                    Description = "has their legs bound together with chains such that their movement speed is reduced to 5ft. The chains are immune to damage. " +
                                    "If the target attempts to teleport or otherwise escape using magic (ie. misty step, planeshift, etherealness) it fails and they suffer 2[dice] force damage. " +
                                    "This spell can only affect humanoids.",
                    Names = new List<string> { "chains", "bands", "cords" },
                    MinimumDuration= Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Puppet
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Debuff,
                    Description = "loses control of their limbs. You take control of them following the rules for the spell Dominate Person, except that you can only manipulate their arms and legs. " +
                                    "They remain aware of their senses and can speak normally, but can do little else for the spell duration. This spell can only affect humanoids.",
                    Names = new List<string> { "puppet", "marionette", "puppetry" },
                    MinimumDuration= Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //Forced recollection
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is forced to experience a vision from their past. The vision lasts for 1d4 rounds. You cannot control what memory they see, but the mind is naturally drawn to emotional events. " +
                                    "While experiencing the vision they are deaf and blind to their current surroundings. This spell cannot affect mindless creatures or creatures with INT less than 4.",
                    Names = new List<string> { "memory", "recollection", "remembrance" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Holy damage - extra vs evil, less vs good alignments
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Divination },
                    Type = EffectType.Debuff,
                    Description = "is illuminated by a brilliant light and suffers [2-4][dice] + [5-10] radiant damage. Creatures with an evil alignment take double damage. Creatures with a good alignment take half damage. Celestial creatures take no damage.",
                    Names = new List<string> { "devotion", "light", "purity" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //Evil damage - extra vs good, less vs evil alignments
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Debuff,
                    Description = "is engulfed in black flames and suffers [2-4][dice] + [5-10] necrotic damage. Creatures with a good alignment take double damage. Creatures with an evil alignment take half damage. Undead creatures take no damage.",
                    Names = new List<string> { "darkness", "corruption", "depravity" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Chaotic damage - extra vs lawful, less vs chaotic alignments
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Debuff,
                    Description = "is ravaged by a pulse of chaotic turbulence and suffers [2-4][dice] + [5-10] force damage. Creatures with a lawful alignment take double damage. Creatures with a chaotic alignment take half damage. Demonic creatures take no damage.",
                    Names = new List<string> { "darkness", "corruption", "depravity" },
                    IsAlwaysInstant = true,
                    IsRepeatable = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //Orderly damage - extra vs chaotic, less vs lawful alignments
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion },
                    Type = EffectType.Debuff,
                    Description = "is briefly encased in rapidly growing crystals. The crystalline layer shatters after 5 seconds and they suffer [2-4][dice] + [5-10] psychic damage. Creatures with a chaotic alignment take double damage. Creatures with a lawful alignment take half damage. Constructs take no damage.",
                    Names = new List<string> { "darkness", "corruption", "depravity" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 25
                },
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
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
