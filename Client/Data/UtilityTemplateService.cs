using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
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
                    Description = "You instantly know if any spell from the same school of magic as this spell is cast within [50-200@50] ft of you. " +
                                    "You may choose to target a stationary point instead of yourself. If cast at Level 4 or higher, " +
                                    "you may end this spell early to block any one spell you detect that is of a lower level.",
                    Names = new List<string> { "vigil", "vigilance", "alarm" },
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "If any footprints or animal tracks in the area were created within the past [12-48@12] hours then their outline glows. " +
                                    "The intensity of the glow increases with how recently they were created.",
                    Names = new List<string> { "hunt", "persuit", "chase" },
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
                                    "but they must fit within a 5ft cube and have a combined value less than [50-150@50] gold pieces.",
                    Names = new List<string> { "tools", "equipment", "utensils" },
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "Your boots or shoes are temporarily invulnerable to all damage. If you are not wearing any shoes or boots this spell has no effect.",
                    Names = new List<string> { "step", "tread", "pace" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "A softly glowing elbow-length glove appears on one of your hands (your choice) which is invulnerable to all damage.",
                    Names = new List<string> { "glove", "hand", "grasp" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.TenMinutes,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate//Cover
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "A half-sphere appears that is just large enough to provide you with cover. The translucent surface blocks all projeciles, " +
                                    "but is intangible to creatures and other objects like melee weapons.",
                    Names = new List<string> { "dome", "barrier", "cover" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate//Counterspell and turn back to caster
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "When you see a creature cast a spell with a range greater than 5 ft. you may attempt to intervene and turn it back on them. " +
                                    "If the spell is of a lower level than this spell it is redirected to target the original caster. " +
                                    "If the spell level is equal to or great than this spell then make an ability check using your " +
                                    "spellcasting modifier to redirect it. The DC equals 10 + the spell's level.",
                    Names = new List<string> { "counter", "parry", "riposte" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAReaction = true,
                    BaseValueScore = 30
                },
                new SpellTemplate//Take damage for ally
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "When you see a creature taking damage you may transfer up to [2-4][dice] of the damage to yourself instead. " +
                                    "The remainder of the damage is still dealt to the original target.",
                    Names = new List<string> { "sacrifice", "interposition", "intervention" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAReaction = true,
                    BaseValueScore = 25
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You teleport a single object in your hands that weighs less than 10 lbs. to any unoccupied location on the ground",
                    Names = new List<string> { "transposal", "transferecne", "conveyance" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You permanently conjure 1 cubic foot of ice, sand, gravel, or ash",
                    Names = new List<string> { "alluvium", "deposit", "residue" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You permanently conjure 1[dice] harmless insects (beetles, ants, flies, larvae, moths, etc.)",
                    Names = new List<string> { "nuisance", "pests", "vexation" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You permanently conjure a tiny snake that is hostile to everyone, including you",
                    Names = new List<string> { "ophidian", "serpent" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a jet of ink or paint that splashes on impact",
                    Names = new List<string> { "dye", "chroma", "stain" },
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 0.5
                },
                new SpellTemplate//Fog cloud
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure a thick cloud of swirling vapor that obscures line of sight",
                    Names = new List<string> { "veil", "mist", "gloom", "nebula" },
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 1
                },
                new SpellTemplate//River
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a rushing river of fluid that appears and disappears from nothingness at its start and end. " +
                                    "You may select any visible point within range as the start and end points, and the fluid flows downhill in a " +
                                    "straight line between the two. The torrent can be up to [10-30@5] ft wide and 10 ft deep, held back at the " +
                                    "sides as if by invisible river banks. Creatures caught in the torrent have their swimming speed (if " +
                                    "they have any) reduced by half and are swept downstream at a rate of 20 ft per round. If cast at Level 6 " +
                                    "or higher the caster may use a bonus action to reverse the direction of flow, even to flow uphill.",
                    Names = new List<string> { "torrent", "river", "overflow" },
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3
                },
                new SpellTemplate//Translator services
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You conjure a spirit to assist with translation with a specific language. " +
                                    "The spirit will only translate and will not speak of itself or converse with you directly.",
                    Names = new List<string> { "elucidation", "utterance", "articulation" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate//Shuffle creatures
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "Every creature in the area of effect is teleported to swap locations with another creature in the area. " +
                                    "Outside of combat the teleportation is random. During combat each creature moves to the location of the " +
                                    "next creature in initiative order, in a cycle so the last creature moves to the location of the first.",
                    Names = new List<string> { "shuffle", "turmoil", "disarray" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 6
                },
                new SpellTemplate //Respite, stasis
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You teleport a visible unconscious creature to your feet (or the nearest unoccupied space) and put them into a brief stasis. " +
                                    "They are not fully stabilized, but for the next 1d4 rounds they do not need to make death saving throws (they neither pass nor fail). " +
                                    "After the rounds of stasis have passesd they must resume making death saving throws as normal.",
                    Names = new List<string> { "stasis", "respite", "suspension" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You teleport a visible willing creature to your side or the nearest unoccupied space.",
                    Names = new List<string> { "extraction", "extrication", "invitation" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 15
                },
                new SpellTemplate//Delayed teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "After casting this spell a delayed teleportation is triggered at the end of the spell's duration " +
                                    "back to the point where you cast it (or the nearest unoccupied space). However, this spell " +
                                    "cannot cross between planes. When cast at Level 6 or higher 2 other willing creatures can be targeted.",
                    Names = new List<string> { "recollection", "return", "retraction" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate//Destroy object
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You deal [2-5][dice] + 10 Force damage to a stationary non-living object. This spell cannot target creatures.",
                    Names = new List<string> { "fragmentation", "dissolution", "severance", "schism" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate//Douse flames
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "A rush of cold air surges across target area. All non-magical flames in the area are instantly doused and all non-living heated objects are cooled to room temperature.",
                    Names = new List<string> { "squall", "gale", "gust" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate //Lesser wall of force
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "An invisible, impenetrable surface appears in an unoccupied location within range. It takes the shape of a flat surface made up of [2-4]d4 panels, each 5 ft square, " +
                                    "and each contiguous with at least one other panel. The surface is 1 inch thick and lasts for the duration. Nothing can physically pass through the surface and it is immune to all damage.",
                    Names = new List<string> { "barrier", "blockade", "barricade" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneRound,
                    IsAlwaysRanged = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Sound barrier
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You create an faint line on the ground within range, up to [30-100@10]ft long. An invisible surface extends 10ft vertically from the line. This surface blocks any sounds and smells " +
                                    "from passing through it in one direction of your choosing.",
                    Names = new List<string> { "secrecy", "stillness", "seclusion" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Repel water
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "All water and water-based liquids in the target area are repelled and slowly pushed to the edges of the area of effect. " +
                                    "Note that this spell does not impact liquids in fully sealed containers, nor does it impact liquids within creatures or plants.",
                    Names = new List<string> { "desert", "dehydration", "desiccation" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Repel heat
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "Any loose materials (solids, liquids, and gases) that are dangerously hot (heated enough to cause burns) are repelled and slowly pushed to the edges of the area of effect. " +
                                    "Note that this spell does not impact materials in fully sealed containers, solid materials heavier than 5 lbs, nor does it impact materials within creatures or plants.",
                    Names = new List<string> { "buffer", "repellent", "mitigation" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Summon 9ft tall grass
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You choose a visible point on the ground within range and starting at that point 9ft tall grass appears and rapidly spreads along the ground for [2-3][dice] X 10ft in all directions. " +
                                   "It rounds corners and spreads up or down cliffs, but stops at pooled liquids.",
                    Names = new List<string> { "verdure", "grass", "growth", "meadow" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 3
                },
                new SpellTemplate //Conjure quicksand
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "The ground within the area of effect becomes quicksand. Any creatures in the area, or that end their turn in the area, must make a CON saving throw. " +
                                    "On a failure they suffer an escalating debuff that increases by one level, and on a success the intensity decreases by one level. " +
                                    "Level 1 = Up to the knees, Movement speed reduced to 5ft. Level 2 = Up to the waist, Restrained. Level 3 = Up to the neck, Paralyzed.",
                    Names = new List<string> { "mire", "quicksand", "quagmire" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 2
                },
                new SpellTemplate //Vine ladder
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You conjure a rough, rope-style ladder made of vines and branches, hanging from a visible location in range. " +
                                    "The ladder has a maximum length of 4d6 X 5ft and for the spell duration before vanishing.",
                    Names = new List<string> { "ladder", "reach", "vine" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Create false footprints
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You create false footprints or animal tracks of any variety within the area of effect, which last for [12-48@12]hrs. " +
                                    "The false prints cannot completely replace your own tracks, but can be used to make them harder to detect.",
                    Names = new List<string> { "track", "imprint", "fraud" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate //Giant mushroom
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You conjure a giant mushroom, which sprouts from any surface in range - ground, roof, or wall. The mushroom can be up to [10-30@5]ft tall, [15-25@5]ft wide in any direction, and vanishes when the spell ends. " +
                                    "Any creatures in the space where it appears are harmlessly lifted or held by it.",
                    Names = new List<string> { "fungus", "mushroom", "mycelium" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Resurrection by consuming magical item(s)
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "To cast this spell you must be holding one or more magical items worth at least [800-1500@100] GP. " +
                                    "These items are consumed in order to resurrect a creature within [5-15@5]ft of you that has been dead for less than 5 days.",
                    Names = new List<string> { "rebirth", "revival", "resurgence", "quickening" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Glimpse local past accelerated
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You see a vision of the past 2d4 hours in your immediate vicinity, accelerated rapidly. You are blind to your surroundings for 5 minutes while you see this glimpse of the past. " +
                                    "In the vision you stand in the same spot where you currently stand and cannot move except to turn in a circle and observe. The experience is purely visual - your other senses (hearing, smell, etc.) remain in the present.",
                    Names = new List<string> { "reminiscence", "remonition", "vision" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Scrying on the past
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You cast a variation of the scrying spell where you are able to look into the past by specifing an exact date and time of day to observe. " +
                                    "This spell can reach no more than 1 year into the past and the vision has a maximum duration of 5 minutes. During that 5 minutes, however, " +
                                    "you may change the date and time you observe (but not the target) up to 1d3 times. For example, you could jump back 10 days prior or skip ahead by an hour.",
                    Names = new List<string> { "vision", "history", "antiquity" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 30
                },
                new SpellTemplate //Secret light
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You cast a variation of the light spell where the light created is visible only to you and up to [2-5] other creatures that you select at the time of casting.",
                    Names = new List<string> { "secrecy", "illumination", "discernment" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Selective darkness
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You cast a variation of the darkness spell where the darkness created is transparent to you and up to 1d3 other creatures " +
                                    "that you select at the time of casting (each can still see the outline of the affected area).",
                    Names = new List<string> { "cloak", "penumbra", "shadow", "eclipse" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Reactionary darkness
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "After taking damage you can use your reaction cast a varation of the darkness spell where the darkness created is transparent to you.",
                    Names = new List<string> { "cloak", "veil", "shadow", "shroud" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysAReaction = true,
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Smell emotions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You are able to smell the emotions of any creature within 15ft of you. As an action you can make an insight check " +
                                    "with a +10 bonus. If they are within 5ft of you then you also make the check with advantage.",
                    Names = new List<string> { "snout", "instinct", "aroma" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Count heartbeats
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You are instantly aware of the number of beating hearts within [60-120@20] ft of you. You also have a rough idea of the location of any beating hearts within 20 ft of you.",
                    Names = new List<string> { "pulse", "inquest", "sanguinity" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Census on immediate vicinity
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a piece of parchment with writing on it that lists out the number of sentient creatures within [60-120@20] ft of you, sorted by their general race or type. Large numbers of creatures will be rounded. " +
                                    "For example: 30 humans, 20 elves, 1 fiend, and 2 monstrosities. Creatures with less than 3 for INT are not included on the list, and creatures that are magically obscured (i.e. by shapeshifting or invisibility) " +
                                    "will not be revealed if the spell/ability hiding it is of a higher level than this spell.",
                    Names = new List<string> { "census", "enumeration", "register" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Create a flare or beacon
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You create either a beacon at your feet or a flare overhead. A beacon lasts 30 minutes but is stationary on the ground. A flare vanishes after 6 seconds but can be launched " +
                    "up to 60 ft directly vertically into the air. Either creates a brilliant light of any color you choose, but not so intense as to deal any damage or impair vision.",
                    Names = new List<string> { "beacon", "lodestar", "cynosure" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Organize or disorganize
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "In a matter of seconds you can either clean/organize or toss/disorganize any portion of the target area. " +
                                    "This acts like a larger scale variation of the soil/clean abilitly of prestidigitation.",
                    Names = new List<string> { "catalyst", "spur", "entropy" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 2
                },
                new SpellTemplate //Reaction invisibility
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "Whenever you take damage that causes you to fall below half health, you may use your reaction to cast mass invisibility. " +
                                    "This invisibility applies to all creatures in the area of effect - yourself, friend, foe, and stranger alike - and " +
                                    "ends early for any creature that makes an attack or casts a spell.",
                    Names = new List<string> { "escape", "disappearance", "exit" },
                    MinimumDuration = Duration.OneRound,
                    IsAlwaysAReaction = true,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    BaseValueScore = 5,
                },
                new SpellTemplate //Pocket of invisibility
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You create a pocket of invisiblity that extends outward from yourself and conceals all creatures (friend and foe) within the area of effect. " +
                                    "Objects in the area remain visible unless they are being carried by an invisible creature. The area of effect moves with you, " +
                                    "but the spell ends early if you move faster than half speed, make an attack, or cast a spell.",
                    Names = new List<string> { "veil", "cloak", "shroud" },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    DoesNotTargetCreatures = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Immune to fall damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by this spell is immune to fall damage, but cannot use reactions or bonus actions.",
                    Names = new List<string> { "dive", "descent", "meteor" },
                    MinimumDuration = Duration.OneMinute,                    
                    BaseValueScore = 4
                },
                new SpellTemplate //Anti-magic field with limits
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You create a variation of the Anti-Magic Field spell such that most (but not all) magic is suppressed in the target area. " +
                                    "Non-permanent magical effects are suppressed if they are of a lower level than this spell. " +
                                    "Summoned creatures are temporarily banished if this spell's level is higher than the creature's CR. " +
                                    "Enchanted items act as if they were mundane unless created by magic of a higher level than this spell. " +
                                    "Spells cannot be cast in the area of effect unless they are of a higher level than this spell. Dieties are unaffected by this spell.",
                    Names = new List<string> { "supression", "foil", "opposition" },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 30,
                },
                new SpellTemplate //Anti-magic pulse
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You relase a pulse that suppresses all magic in the target area. The effects are similar to an anti-magic field, but last for only a few seconds. " +
                                    "Non-permanent magical effects are dispelled if they are of a lower level than this spell. Otherwise they are suppressed for one round. " +
                                    "Enchanted items cease to function for one round. Summoned creatures are banished for one round.",
                    Names = new List<string> { "supression", "foil", "pulse" },
                    IsAlwaysInstant = true,
                    IsAlwaysAoE = true,
                    DoesNotTargetCreatures = true,                    
                    BaseValueScore = 30,
                },
                new SpellTemplate //Steal healing as a reaction
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "When you see a creature begin to regain HP from any source you may use your reaction to steal the healing, such that instead you regain that HP and they get nothing.",
                    IsAlwaysInstant = true,
                    IsAlwaysAReaction = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    Names = new List<string> { "theft", "siphon", "larceny" },
                    BaseValueScore = 10
                },
                new SpellTemplate //Custom compass
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You conjure a customized compass. It does not point north. Instead you may choose to have it either point to location where you created it " +
                                    "or point others to you (no matter where you move). You may also choose a key word that must be spoken for the compass to work, otherwise it simply spins in circles. " +
                                    "At the end of the duration the compass dissolves into mist.",
                    Names = new List<string> { "compass", "guide", "path" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.EightHours,                    
                    BaseValueScore = 1
                },
                new SpellTemplate //Charm little beasts
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You charm all of the beasts that have a CR less than 1 in the target area. You may convey one simple idea to them, and they will obey according to their level of intelligence.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Truth through pain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You suffer 1[dice] psychic damage each time a target creature intentionally tells a lie. " +
                                    "At the time of casting you may choose to double the damge you take in order to omit all spell components (such that the casting cannot be detected by non-magical means).",
                    Names = new List<string> { "truth", "insight", "intuition" },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Righteous fire
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You are covered in flames that cannot be put out by non-magical means. The burning empowers you, but also damages you and any nearby enemies. " +
                                    "You gain a +[10-20@5]ft bonus to your movement speed and a +[3-5] bonus to your spell casting modifier while you are ignited. " +
                                    "All enemies within [10-20@5]ft of you suffer [2-4][dice] + [8-16@2] fire damage at the start of their turn every round. " +
                                    "You suffer half as much fire damage - which bypasses resistances - at the start of your turn every round, " +
                                    "until the burning would make your HP fall below zero. At that point you are instead reduced to 1 HP, the flames vanish, and this spell ends. " +
                                    "Any creature that successfully dispels this effect suffers [4-8][dice] Fire damage.",
                    Names = new List<string> { "conflagration", "immolation", "inferno" },
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 70
                },
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                //    Type = EffectType.Utility,
                //    Description = "",
                //    Names = new List<string> {  },//--------------------TODO
                //    BaseValueScore = 5
                //},
                //*************************************************************************
                /*            
                 *  Divination
                        runes that glow when long distance twins hear a specific word 
                        Lesser comprehend languages, very simple ideas only
                        x-ray one material wood or stone or crystal or metal (including paint and plaster on walls or ceilings)
                        track via recent body heat path, one specific race or creature type
                        utility track object - range of touch, plant object and wait
                        speak with object - blind and deaf, only temp and pressure and acceleration
                        oddly prepared - pull from your pocket or pack one item worth less than 20gp. A glimpse of the future promoted you to purchase it for this occasion. Retroactively deduct the price from your funds
                        structural - visual heat map of how close non-living materials are to their breaking point
                        conjure tea - enough for 1d4+1 people. Each gets a free attempt at scrying. DM makes a secret roll : 50-50 odds that vision is false, if more than one person targets the same thing they have the same vision (one DM roll instead of multiple)
                        mimic ability (like sneak attack or wild shape) as reaction or share one of your own with 1d6 other creatures.
                            each gets a single use and then forgets
                            if used for a spell, it must be a lower level than this spell  
                *  Conjuration
                        conjure [2-4] riding horses for [dice] hours. upcast for 2 extra horses per additional spell level.
                        duplicate or replicate an outfit utility, tangible not an illusion
                        temporary portable hole utility, non-exploding (collapses instead)
                        medium range teleport, 1 mile
                        temporary graffiti
                        Lesser animate objects
                        AoE difficult terrain and fall prone (no save) at the start of turn if touching the ground
                        better earth bind - effect for non flying creatures too (restrained?)
                        feast of left overs - table with partially eaten food appears, enough for 2d6+1 people to have a meal. Each makes a CON save, On a failure, poisoned for 2 hours. On a success, immune to charm effects and gain 2d12 Temp HP 
                            other feast ideas - damage resistance paired with vulnerability, gamble AC bonus or a point of Exhaustion
                *  Illusion
                        multiplying illusion - start with 3, more appear whenever one is touched 
                        nimble - DC and only disappears if hit
                        ghostly second stage if touched
                        tangible illusions - 1d4 pysical interactions
                        fixed illusion (preset shapes & sounds)
                        subtractive illusion / partial invisibility
                        object invisibility
                        Directional scent (false illusion)
                        hide worth - illusion or transmutation - gold coins to copper temporarily, and gems into common minerals
                        split illusions - 3d4 copies of the same illusion, less than 6 inches in any dimension
                        split illusion - 2d6 copies, less than 3ft
                * Necro
                        reaction - as you fall unconscious - tie the target's fate to your own, whenever you fail a death saving throw they take necrotic damage and if you die they are stunned for 1d3 rounds - is always instant (to avoid concentration requirements)
                        reaction - as you fall unconscious deal [5-8][dice] + [10-40@10] necrotic damage to one visible targt in range
                        bodyswap - teleport, if you consume a corpse at the target location deal damage and does not use the spell slot	
                        consume a corpse (turned to dust) to gain temp HP	
                        consume a corpse (turned to dust) to heal an ally	
	                        buffs? speed, resistance, damage?
                        unearth from poe, remains burst from the ground and deal damage in a line?	
                        statis AoE center on self - outside of AoE 1d8 hours pass, by inside only minutes. Barrier like wall of force prevents anything from passing in the meantime	
	                        another version with days instead of hours?
	                        another version that doesn't center of self, smaller time range to trap enemies 
                        consume two undead minions under your control to grant a permanent bonus to a 3rd minion	
	                        limited vampiric damage or bonus AC or double walking speed
	                        new creature counts as two for maintenance (ie from animate or create dead spells)
                        summon raging spirit - long cast time, store in a vessel (lantern or similar)	
                        rot, moss, mold, wear out objects	(non-damaging, non-creature objects only)
                        spray curdled milk, rotten fruit, etc (aesthetic or utility? prevent tracking, distraction charm to drive victims away )	
                        curse item 	
                        delayed, undetectable poison (or difficult to detect)	
                        temporary animation - lasts for only 1d4 rounds - must be recent, intead of new stat block use original with fixed penalty	
                        animate beast - use original stat block, fixed penalty	
                        animate monstrosity or abberation - original stat block, no penalty		
                        animate giant - original stat block with penalty	
                        animate incomplete remains	
                        change remains to be purely skeletal	
                        only affects undead creatures with INT less than 7. Temporarily restore their intellect from when they were alive.
                        transform a permanent skeleton or zombie you control into a ghostly variant of the same	
                        ritual to sacrifice max HP until next long rest interchange for one of the following: immune to poison, no need to breathe, 50 percent chance after death save to gain 3d6 HP, necrotic damage heals you and healing spells damage you. Roll randomly, can be cast multiple times to stack different effects	
                * Evocation
                        searing bond, 1d3 stationary points and yourself, bonus action to replace one
                        variant of contingency, lasts only 1 hour but multiple creatures benefit (common triggering condition and spell for all), spell level not more than half this spell
                        improve cordon of arrows 
                        lesser demi plane (maybe on scale of a portable hole with a 1hr duration?
                        sending with higher word limit or an extra "volley" back and forth
                        huge AoE alarm, but with a specific trigger spoken phrase (know when someone says your name) and instantly know where in AoE trigger occurred
                        frost blink and flame dash and plague bearer and smoke mine and withering step and lightning warp
                        gamble spell slots for self, spend X slot, roll dice to see if you get back more or less, then immune to effects until long rest
                        ground shakes with each step, create difficult terrain with shockwaves along the path the walk
                        pick a 1st level spell you know. Each time the target successfully hits with a weapon attack (once per turn) the spell is automatically triggered without using a spell slot or components. The spell automatically targets the creature that was hit, but any AoE effects still have an area.	                                                             
                * Enchanment
                        targets location not creatures - anyone that approaches is compelled to instead travel to a different point you choose	
                        mass sleep, friend foe and self in large AOE, elves cannot enter the area	
                        mass paralysis, no save, friend and foe and self, fails for all if any are immune to paralysis 	
                        mass pacifism, no save, friend and foe and self, bypasses immunity to charm effects	
                        numb, can't feel pain, unaware of damage	
                        remove memory of the past 2d6 minutes, blackout missing time on successful save, skipped time on a fail?	
                        will believe the next 4d6 words you speak, but must understand the language	
	                        you are invincible, that fire isn't hot, you can fly
                * Transmute
                        make an object buoyant
                        weight half or double
                        color change
                        Delayed effect transformation
                        temporary glue
                        add or remove 2d6 words on a paper document you hold, matching handwriting, Investigation vs modifier to catch it
                        add any name you choose to any list of at least 10 names - always ranged
                        polymorph a willing creature into a small object that weighs 1/10th their normal weight
                        like polymorph, but fiend instead of beast
                        resize clothing utility - must be fabric, not armor - tailor alterations rapidly 
                        transmutation - counterfeit coins, from copper to gold, change lasts for 2d8 days, can change image on the coins too
                        utility - drunk or sober (no effect on undead, elementals, constructs)
                        instant swamp
                        instant desert - mundane plant life crumbles to dust
                        instant door - range of touch
                        reduce object size but same weight
                * 
                 * Illusion, Divination? 
                       remote spell casting - channel for ally to allow them to project a spell very long range
                            one version with scrying spell to pick see target
                            one version where you create a beacon on a target that the chosen ally can send thh spell to, like a homing missile
                * Other
                       at least one per school utility - interact with environment, climate, or social
                 */
            };

            return templates;
        }
    }
}
