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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
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
                                    "This spell does not impact liquids in fully sealed containers, nor does it impact liquids within creatures or plants.",
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
                                    "This spell does not impact materials in fully sealed containers, solid materials heavier than 5 lbs, nor does it impact materials within creatures or plants.",
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
                                    "The ladder has a maximum length of 4d6 X 5ft and vanishes at the end of the spell duration.",
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
                new SpellTemplate //Shrieking spiders
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a swarm of ethereal spiders (or similar creatures) at your feet. You telepathically show them any image of your choice (real or imagined) and they will hunt for it. " +
                                    "The image can be of a creature, an object, a natural or architectural feature, etc. but the spiders will ignore intricate details. " +
                                    "They are intangible (cannot attack nor be attacked) as they skitter across surfaces, searching any area within range. " +
                                    "If they find anything that looks similar to the target image dozens of them will surround it and begin shrieking loudly (audible within 100ft).",
                    Names = new List<string> { "colony", "swarm", "throng" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    IsAlwaysRanged = true,
                    BaseValueScore = 4
                },
                new SpellTemplate //Fabricate memory
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You fabricate a wholey new, false memory to implant into a creature's mind. It does not replace any existing memory, but is mixed in with all the others. " +
                                    "The memory lacks continuity - they can't recall what happened right before or after it, or even where it lands in chronological order compared to the rest of their memories. " +
                                    "The same guidelines for believability provided in the spell Modify Memory apply here.",
                    Names = new List<string> { "implication", "insinuation", "misinformation" },
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Storm rain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You conjure a volley of energized arrows that arc high into the air before crashing to the ground. " +
                                    "The arrows magically avoid hitting creatures and instead stick into the ground (or other surfaces) where they remain for the duration. " +
                                    "When they impact, and as a bonus action on subsequent turns, arcs of lightning connect each of the arrows to every other arrow, " +
                                    "dealing [2-4][dice] lightning damage to any creatures in the target area.",
                    Names = new List<string> { "volley", "arrows", "storm" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Flicker strike
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You teleport up to 15ft to any visible, unoccupied point. If an enemy is within melee range of where you appear then you can immediately make a single melee weapon attack with +[3-8] force damage. " +
                                    "If the attack does not miss you can choose to sacrifice 1d6 HP to instantly teleport and attack again (it need not be the same target). " +
                                    "So long as you never miss you can move and attack up to 4 times, but the HP cost doubles each time.",
                    Names = new List<string> { "flickering", "frenzy", "nictation" },
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Leap slam
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You leap up to 20ft to any visible, unoccupied point and trigger a short-range shockwave on impact. " +
                                    "Any creature within 5ft suffers [3-4][dice] thunder damage. " +
                                    "At the time of casting you may choose to empower a single ally within 5ft of you to make the leap instead of doing it yourself, " +
                                    "but they must use their reaction to do so.",
                    Names = new List<string> { "leap", "crater", "jump" },
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Shield charge
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You imbue your shield with unstoppable power and charge up to 30ft in a straight line. " +
                                    "Any creatures in your path are pushed out of your way, suffer 2[dice] bludgeoning damage, and are knocked prone if they are Large or smaller in size. " +
                                    "Creatures that are Huge or larger in size interrupt your charge, stopping you short of the full movement. " +
                                    "This spell cannot be cast unless you are holding a shield.",
                    Names = new List<string> { "charge", "advance", "rush" },
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Shield bash
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You make a magically augmented spell attack with your shield that deals [3-5][dice] + [5-10] bludgeoning damage to a creature within 5ft of you. " +
                                    "It also triggers a shockwave that deals half damage to any creatures in a 15ft cone behind the main target, even if the main attack misses. " +
                                    "At the time of casting you may choose to empower an ally within 5ft of you to make the attack with their shield instead of doing it yourself, " +
                                    "but they must use their reaction to do so (they use your spell modifier for the attack roll). " +
                                    "This spell has no effect on creatures that are not already holding a shield.",
                    Names = new List<string> { "bash", "ram", "battering" },
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Consecrated path
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You leap up to 20ft to any visible, unoccupied point. A circle of glowing runes with a radius of [10-20@5]ft appears on the ground, centered on the point where you land. " +
                                    "The runes pulse for a moment, release a blinding flash, and then vainsh. Enemies within the circle must make a CON saving throw. " +
                                    "On a failure they suffer [2-3][dice] radiant damage and are blinded for one round. On a success they take half damage and are not blinded.",
                    Names = new List<string> { "consecration", "leap", "brilliance" },
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 60
                },
                new SpellTemplate //Bubble shield
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a translucent dome with a radius of [15-30@5]ft, centered on yourself. You and your allies inside of it take reduced damage from any attacks or spells that originate outside of the dome. " +
                                    "Roll [2-3]d4 once at the start of the spell to determine the amount of damage reduction. " +
                                    "Hostile creatures inside of the dome are slowed (their movement speed is halved). Creatures can pass through the surface of the dome freely without consequence.",
                    Names = new List<string> { "shield", "barrier", "dome" },
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Frost shield
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a translucent dome covered in frost with a radius of [15-30@5]ft, centered on yourself. The dome has [4-7][dice] HP. " +
                                    "The surface of the dome only allows one-way movement, away from you. Creatures and objects (including ranged attacks and spells) can exit the dome, " +
                                    "but nothing can physically enter the dome in the other direction. " +
                                    "If the dome is reduce to 0 HP it releases an icy backlash and the creature that destroyed it suffers [3-6][dice] cold damage; this spell then ends early.",
                    Names = new List<string> { "shield", "barrier", "dome" },
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Circle of power - added damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a circle on the ground with a radius of [10-20@5]ft, centered on yourself. It is filled with intricate runes that glow dimly. " +
                                    "You and any allies inside of it deal [3-6] bonus force damage with all weapon and spell attacks against enemies outside of the circle. " +
                                    "If you use your last remaining spell slot to cast this spell then the bonus damage is doubled." +
                                    "Enemies inside the circle have disadvantage on all melee attacks. ",
                    Names = new List<string> { "shield", "barrier", "dome" },
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.OneMinute,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //React to lightning damage - chain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature taking lightning damage you can use your reaction and enhance the lightning to chain new arcs from them to three other creatures of your choice within 20ft of them. " +
                                    "Each must make a DEX saving throw. On a failure they suffer the same amount of lightning damage as the original creature. On a success they take half damage.",
                    Names = new List<string> { "reach", "arc", "chaining" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //React to lightning damage - stun
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature taking lightning damage you can use your reaction to enhance the lightning and try to stun them. They must make a CON saving throw - if " +
                                    "the amount of the damage you are reacting to was more than half of their remaining HP then they make the save at disadvantage. " +
                                    "On a failure they suffer another 2[dice] + [5-10] lightning damage and are stunned for one round. On a success they suffer half damage and are slowed rather than stunned.",
                    Names = new List<string> { "shock", "jolt", "stun" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //React to cold damage - restrain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "When you see a creature take cold damage you can use your reaction to enhance the cold and cover them in ice, restraining them. " +
                                    "On their turn they can use an action to break free with a STR check vs your spell DC.",
                    Names = new List<string> { "restraint", "frostbite", "ice" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //React to cold damage - AoE + slow
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature take cold damage you can use your reaction to enhance the cold and trigger an explosion of ice " +
                                    "that deals half as much cold damage and slows any creatures within 15ft of the original creature.",
                    Names = new List<string> { "frigidity", "ice", "frost" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //React to fire damage - AoE
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature take fire damage you can use your reaction to enhance the fire and trigger a burst of flames " +
                                    "that deals the same amount of fire damage to any creatures within 10ft of the original creature.",
                    Names = new List<string> { "detonation", "ignition", "explosion" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 25
                },
                new SpellTemplate //React to piercing damage - redirect projectile
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature hit with a projectile that deals piercing damage you can use your reaction to empower the projectile to pierce through the target " +
                                    "and curve (no more than 90 degrees) towards another creature within 20ft of them. The original creature suffers an additional 2[dice] piercing damage. " +
                                    "The second target suffers the same damage plus half of the original damage that you reacted to.",
                    Names = new List<string> { "splinter", "shard", "sliver" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 35
                },
                new SpellTemplate //React to poisoned status - convert to instant damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "When you see a creature that is poisoned make a successful attack, but before the damage dice have been rolled, you can use your reaction " +
                                    "to accelerate the poisoning. They instantly suffer [4-6][dice] poison damage and must re-roll the attack, but after this they are no longer poisoned.",
                    Names = new List<string> { "oppression", "exploitation", "wringing" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //React to poisoned status - paralyze
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature become poisoned you can use your reaction to alter and enhance the poison. They must make a CON saving throw. " +
                                    "On a failure instead of becoming poisoned they are paralyzed for 1d3 rounds. " +
                                    "On a success they are not paralyzed, but they are slowed for 1d3 rounds in addition to being poisoned.",
                    Names = new List<string> { "necrosis", "toxin", "poison" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //React to thunder or bludg damage - ragdoll
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "When you see a creature take either thunder or bludgeoning damage you can use your reaction to increase the damage by 50%. " +
                                    "If the total after being enhanced is at least 20 damage (plus 20 for each creature size above medium) then they must make a STR saving throw. " +
                                    "On a failure the creature is thrown back 10ft per 10 points of damage taken and falls prone.",
                    Names = new List<string> { "ragdoll", "propulsion", "sling", "catapult" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Charmed to reveal themselves
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "Any creatures behind cover in the target area - or any that are hiding by other means - are charmed to reveal themselves. " +
                                    "They must instantly use their reaction to move away from cover and calmly walk 10ft towards you. They then make a WIS saving throw. " +
                                    "On a failure they remain docile and stationary for 1d4 rounds, but taking damage dispels the effect. " +
                                    "Creatures that are immune to charm effects are unaffected by this spell.",
                    Names = new List<string> { "beckoning", "revelation", "welcome" },
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Mass paralysis
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You release a radial blast of arcane energy that paralyzes every creature within [50-100@25]ft of you, including yourself and any allies. " +
                                    "If any creature within that range is immune to being paralyzed (ex: due to freedom of movement or similar) then this spell fails completely and no one is affected.",
                    Names = new List<string> { "shock", "paralysis", "tremor" },
                    MinimumDuration = Duration.OneMinute,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 70
                },
                new SpellTemplate //Mass pacifism
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You release a ripple of magic that washes over every creature within [50-150@25]ft of you and compels them to pacifism, including yourself and any allies. " +
                                    "Each creature is unable to deliberately damage any other creature. This spell bypasses immunity to charm effects.",
                    Names = new List<string> { "soothing", "tranquility", "harmony", "accord" },
                    MinimumDuration = Duration.OneMinute,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Mass sleep
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You unleash a pulse of magic that rapidly accelerates outward from you in a ring. Every creature within 1[dice] miles of you falls asleep for 2[dice] hours, including yourself and any allies. " +
                                    "Creatures that are immune to magical sleep (ex: those of elvish descent) are instead charmed to sit quietly and daydream - they are considered restrained and incapacitated. " +
                                    "This spell bypasses immunity to charm effects. Creatures cannot be roused by any non-magical means short of suffering damage equal to at least half of their maximum HP.",
                    Names = new List<string> { "opus", "masterstroke", "dormancy" },
                    MinimumCastTime = CastTime.OneHour,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 2000
                },
                new SpellTemplate //Numb to pain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by this spell is numb to any sensation of pain. They are unaware of any damage dealt to them unless one of their other senses (ex: sight or sound or pressure) makes it apparent. " +
                                    "If you are hidden from the target when you cast this spell they do not automatically realize they are under its effect (the numbness is not obvious to them).",
                    Names = new List<string> { "desensitization", "deadening", "numbness" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Blind trust
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by this spell will believe the next 2d6 words that you say to them, interpreting your message as an absolute fact. If it conflicts with their deeply held beliefs " +
                                    "(ex: 'you can fly', or 'your brother betrayed you', or 'that fire won't burn you') then they can make a WIS saving throw. On a success they resist the spell and form their own conclusions. " +
                                    "Creatures that are immune to being charmed are unaffected by this spell.",
                    Names = new List<string> { "trust", "deception", "persuasion" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 20
                },
                new SpellTemplate //Remove memory
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by this spell forgets the past [2-5][dice] minutes. They make a WIS saving throw. " +
                                    "On a success the gap in their memory is a blackout of obviously missing time. " +
                                    "On a failure they have no sense of the missing time, and feel as if they skipped instantly to the present from the last moment they recall.",
                    Names = new List<string> { "void", "oblivion", "amnesia" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Redirect away from area
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "Anytime a creature other than yourself enters the target area or ends their turn in the area they must make a WIS saving throw. " +
                                    "On a failure they are compelled (as if by the Suggestion spell - no self harm) to leave and instead travel to a specific visible point that you set at the time of casting. " +
                                    "When you cast this spell you may choose up to 2[dice] creatures to exclude from its effect.",
                    Names = new List<string> { "distraction", "redirection", "diversion" },
                    MinimumDuration = Duration.EightHours,
                    MinimumCastTime = CastTime.OneMinute,
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsRangeAlwaysSelf = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Lesser comprehend languages
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "Any creatures in the target area are able to understand simple ideas from any spoken language that they hear. The language barrier is reduced, but not eliminated completely. " +
                                    "This spell has no effect on creatures that do not already speak at least one language.",
                    Names = new List<string> { "comprehension", "intuition", "insight" },
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 10
                },
                new SpellTemplate //X-ray vision
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You select one of the following materials to be able to see through: wood, stone, metal, dirt, vegetation, crystal, or water. " +
                                    "Objects within [20-50@10]ft of you that are primarily made of that material become transparent to your eyes - including thin layers of paint, plaster, etc. that may be on them. " +
                                    "You can see their outlines lightly, but they are otherwise invisible. You may upcast this spell to choose one additional material per two extra spell levels.",
                    Names = new List<string> { "eyesight", "vision", "sight" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 10
                },
                new SpellTemplate //Track via glowing trails
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You choose on specific race (elf, gnome, etc) or creature type (beast, fiend, etc) to track. " +
                                    "For the spell duration you are able to visually see within [15-30@5]ft of you glowing lines in the air tracing paths where any such creatures have passed by within the past [2-12@2] hours. " +
                                    "The trails glow brighter the more recently they passed - for example, very bright if they passed less than a minute ago, and very faint if their passing was right at the limits of how far into the past this spell can reach.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 10
                },
                new SpellTemplate //Speak with object
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You touch one non-living, non-sentient object and speak to it. You are able to ask it [3-6] questions. The object is only able to provide yes or no answers, " +
                                    "and it has limited information. It is considered blind and deaf to its surroundings and has a warped sense of the passage of time. It can, however, give " +
                                    "answers about changes in temperature, pressure, and acceleration as well as details about its composition. If you ask a question that it does not " +
                                    "know the answer to then it will randomly reply with a yes or a no. Interestingly, this quirk of the spell has been utilized on more than one " +
                                    "occasion to provide a rock as an impartial tie-breaker in what otherwise would have been a stalemate negotation.",
                    Names = new List<string> { "inquiry", "query", "question" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Homing tracker
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You touch one object and for the spell duration you know where it is relative to you. " +
                                    "You are aware of both the direction and the approximate distance (ie. a few hundred feet or several miles) to the object's location. " +
                                    "The object need not stay stationary, but it must be 1 foot or larger in at least one dimension. This spell only works while you are on the same plane of existence as the object.",
                    Names = new List<string> { "datum", "anchor", "focal point" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 10
                },
                new SpellTemplate //Structural stress
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You are able to visually see a 'heat map' of how close non-living materials are to their breaking point. " +
                                    "Areas that are very near fracturing or buckling glow brightly like magma, while regions with moderate stress range from a yellow to a green hue. " +
                                    "Portions that are barely stressed have a faint blue glow.",
                    Names = new List<string> { "design", "strain", "stresses" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3
                },
                new SpellTemplate //Group vision
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "You conjure enough tea for 1d4 + 1 people. Each person who drinks may speak one question aloud. Once all have spoken, the participants experience a shared vision. " +
                                    "The DM makes a secret percentile roll to determine how much of the vision is accurate and how much is false or misleading (a 50 on the dice would result in roughly half being true and half being misleading). " +
                                    "The vision attempts to answer each of the questions asked, and might reach into the past or future to do so. At the DM's discretion a vision might be extremely vague, intensely vivid, jumbled and nonsensical, or a combination of these. " +
                                    "After experiencing such a vision, the participants are unaffected by this spell for a week.",
                    Names = new List<string> { "oracle", "prophecy", "foretelling" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate //Mimic ability
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Utility,
                    Description = "When you see a creature in range (either friend or foe) use an uncommon ability - such as a class feature, racial trait, or inherent talent - you may use your reaction to try mimicing that specific ability. " +
                                    "Depending on the complexity and power of the ability, the DM will select a DC for you to make an ability check against using your spellcasting modifier. Basic class features (like sneak attack, wildshape, etc) would have a relatively low DC but certain monster abilities may be nigh impossible to mimic successfully. " +
                                    "If you are successful you do not immediately copy them, but rather you hold in your mind the borrowed knowledge of how to do so. For the spell duration you have access to the ability on your turns, but this spell ends early after using it 1d4 times.",
                    Names = new List<string> { "mimicry", "imitation", "echo", "replica" },
                    IsAlwaysAReaction = true,
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Body swap from PoE
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You instantly teleport to an unoccupied, visible point within [15-30@5]ft and unleash a radial blast of dark energy, dealing [2-4][dice] necrotic damage to any creatures within 5ft. " +
                                    "If there are any corpses within 5ft of where you arrive then one of them crumbles to ashes, the damage is doubled, and you may roll a d6. On a 5 or 6 this casting does not consume a spell slot.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf= true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Poe Offering - Temp HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch a corpse within reach. It crumbles into dust and you instantly gain [2-3][dice] temporary HP. You may choose to gift the temp HP to an ally instead of keeping it, but you must be able to touch them before the end of your turn to transfer it. " +
                                    "Undead creatures that you created may be considered corpses for the purposes of this spell, but not undead of other origins.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //Poe Offering - Resistance
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch a corpse within reach. It crumbles into dust and you gain resistance to any damage from creatures of the same type. You may choose to gift the resistance to an ally instead of keeping it, but you must be able to touch them before the end of your turn to transfer it. " +
                                    "Undead creatures that you created may be considered corpses for the purposes of this spell, but not undead of other origins.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Poe Offering - Speed or Damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch a corpse within reach. It crumbles into dust and you may choose to gain either a +[15-30@5]ft bonus to your movement speed OR +[3-6] bonus necrotic damage to all attacks. " +
                                    "You may choose to gift the bonus to an ally instead of keeping it, but you must be able to touch them before the end of your turn to transfer it. " +
                                    "Undead creatures that you created may be considered corpses for the purposes of this spell, but not undead of other origins.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Poe Offering - AC for undead ally
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch a corpse within reach. It crumbles into dust as you extract its final vestiges of vitality. You may use it to grant an undead ally +2d4 AC, but you must be able to touch them before the end of your turn to do so. " +
                                    "Undead creatures that you created may be considered corpses for the purposes of this spell, but not undead of other origins.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Duplicate outfit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You recall a single creature that you have seen in the past [4-24@4] hours, and conjure a duplicate of their outfit at your feet. The replica includes each article of clothing and jewelry that was visible to you. " +
                                    "Each item is mundane even if the original has magical properties. The outfit is tangible and if inspected is truly made of the same materials and has the same quality of craftsmanship as the original. " +
                                    "The replica lasts for 2[dice] hours before dissolving into mist.",
                    Names = new List<string> { "replica", "outfit", "duplication" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Miniature demi-plane
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You create a small cupboard-sized door on a flat surface at least 2ft x 2ft in dimension. The surface need not remain stationary, but it must remain flat or the spell ends early. " +
                                    "While open it connects to a demi-plane that is an empty [3-6]ft cube, with sides made of stone. " +
                                    "When the spell ends the door vanishes and the demi-plane collapses. Anything left inside is teleported to a random location in the astral sea, or a similar plane at the DM's discretion.",
                    Names = new List<string> { "cupboard", "smuggling", "cabinet" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Conjure steeds
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure 1[dice] riding horses. At the end of the duration they slowly vanish over the span of one minute, allowing any riders time to quickly dismount.",
                    Names = new List<string> { "steed", "mount", "horses" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    IsAlwaysRanged = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Create carriage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You transform one small object into a carriage, cart, or similar horse-drawn vehicle, and two other small objects into horses to pull it. Each of the objects must be non-magical. " +
                                    "The vehicle has room for [4-6] medium sized creatures to ride in it. At the end of the duration each object slowly reverts to its original form over the span of one minute, allowing any riders time to quickly exit.",
                    Names = new List<string> { "carriage", "cart", "transport" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    IsAlwaysRanged = true,
                    BaseValueScore = 6
                },
                new SpellTemplate //Medium range teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You touch up to [3-5] creatures within 5ft of you (one of them may be yourself). If any are unwilling, you must make a melee spell attack to touch them. " +
                                    "Each is instantly teleported to a location of your choosing within 1 mile of where you stand. " +
                                    "Depending on your familiarity with the location, the teleportation may or may not be accurate - follow the rules provided in the 7th level spell 'Teleport'.",
                    Names = new List<string> { "transport", "transportation", "transference" },
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsRangeAlwaysSelf = true,
                    BaseValueScore = 80
                },
                new SpellTemplate //Graffiti
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure up to 2[dice] + 2 words on any visible surface in range. The letters can be up to [2-4]ft tall and in any style, color, and thickness. The words vanish at the end of the spell duration.",
                    Names = new List<string> { "graffiti", "verse", "sign" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    IsAlwaysRanged = true,
                    BaseValueScore = 2
                },
                new SpellTemplate //Waves on land
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You cause the ground to heave, buckle, and warp in the target area. The surface is not damaged or broken, but it moves like rough waves at sea. " +
                                    "The area is considered difficult terrain, and any creature that starts their turn standing on the ground in the area is knocked prone.",
                    Names = new List<string> { "waves", "roiling", "turbulence" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Improved earth bind
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by this spell has their flying speed reduced to 0 and instantly begins to free fall if they are airborne. Creatures that do not have a flying speed have their walking speed halved instead.",
                    Names = new List<string> { "gravity", "weight", "anchor" },
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Lesser animate object
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You animate up to [8-15] tiny objects within range. They cannot attack, move slowly and gently, and you can mentally command them as a free action on your turn. " +
                                    "The objects can perform fairly complex maneuvers, such as cleaning each other, packing themselves, or decluttering a table. " +
                                    "Each animated object has 1 HP, an AC of 1, ability scores of 1, and 5ft walking and hovering speed.",
                    Names = new List<string> { "animation", "compatriots", "animus" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 7
                },
                new SpellTemplate //Leftover feast - temp HP and no fear
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a table spread with what is clearly a half-eaten meal. There is enough food left for [3-6] humanoids to eat. Each must make a CON saving throw with a DC of 10. On a failure they are poisoned for 1d4 hours. " +
                                    "On a success they gain [3-4][dice] temporary HP and are immune to being poisoned or frightened for 24 hours. In either case, the food is sufficient to sustain them so that they will not get hungry again for 24 hours.",
                    Names = new List<string> { "leftovers", "afterthought", "meal", "banquet" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 60
                },
                new SpellTemplate //Leftover feast - poison resistance
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a table spread with what is clearly a half-eaten meal with food that is... less than fresh. There is enough food left for [3-6] humanoids to eat. Each must make a CON saving throw with a DC of 10. On a failure they are poisoned for 1d4 hours. " +
                                    "On a success they gain resistance to poison damage and a +10 bonus to CON saving throws for 24 hours. In either case, the food is sufficient to sustain them so that they will not get hungry again for 24 hours.",
                    Names = new List<string> { "leftovers", "afterthought", "meal", "banquet" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Spectral feast - bonus to AC or exhaustion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You conjure a table spread with an oddly spectral meal of ghostly dishes. There is enough food left for [4-12] humanoids to eat. Each must make a CON saving throw with a DC of [12-15]. On a failure they suffer 1 point of exhaustion. " +
                                    "On a success they gain a +[2-5] bonus to AC and are immune to being charmed for 24 hours. In either case, the food is sufficient to sustain them so that they will not get hungry again for 24 hours.",
                    Names = new List<string> { "feast", "meal", "banquet" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 100
                },
                new SpellTemplate //Multiplying illusions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure [2-3] identical soundless illusions - each similar to that created by the spell Silent Image. " +
                                    "However, any time one of them is touched by a creature, you may use your reaction to make it vanish and create two more copies at unoccupied points within 10ft of it. " +
                                    "No more than [6-10] copies can exist at once, after which the oldest copy disappears to allow for a new copy.",
                    Names = new List<string> { "image", "multiplication", "duplication", "duplicity" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 25
                },
                new SpellTemplate //Nimble Illusion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure a complete illusion of a creature as described by the spell Major Image, but it is exceptionally nimble. " +
                                    "It attempts to dodge attacks reflexively (without you needing to command it) and is considered to have an AC of [16-19]. Attacks that miss do not reveal it to be an illusion.",
                    Names = new List<string> { "specter", "apparition", "image" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Tangible illusion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure a soundless illusion as described by the spell Silent Image, but you imbue it with limited tangibility. " +
                                    "It can respond to physical contact 1d4 times as if it were solid. After that it behaves like typical illusions and any physical contact passes through it.",
                    Names = new List<string> { "image", "illusion", "deception" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 25
                },
                new SpellTemplate //Multi-stage Illusion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure a complete illusion as described by the spell Major Image, but you may also choose a second stage that is automatically triggered " +
                                    "(no action required by you) the first time anything touches it. For example, an illusion that looks like a human might instantly change to appear spectral as the second stage. " +
                                    "Any creature that triggers this change with their touch suffers [2-4][dice] psychic damage, but you may choose at the time casting to make the transition non-damaging if you prefer.",
                    Names = new List<string> { "specter", "apparition", "image" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Split illusions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure a complete illusion as described by the spell Major Image, but may choose to split it into smaller identical duplicates upon creation instead of having a single larger illusion. " +
                                    "You may choose to make either 3d4 tiny copies or 2d4 small copies. Each of the copies must remain within the target area. If you use your action to move or animate the illusion you can select up to 2 copies to control each turn.",
                    Names = new List<string> { "specters", "apparitions", "images" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Hide worth
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You hold any small non-magical container in your hands and create an illusion to hide the value of its contents. Gold coins may look like copper, rare gems like iron ore, etc. " +
                                    "The illusion is layered onto the individual items, such that even if they are picked up individually the false appearance remains. The container cannot be larger than [1-3]ft in any dimension.",
                    Names = new List<string> { "smuggling", "devaluation", "concealer" },
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate //Object only invisibility
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You touch up to 2d4 items, each being no larger than [3-10]ft in any dimension, and make them invisible. This spell fails for any object that is being worn or carried by an unwilling creature.",
                    Names = new List<string> { "smuggling", "concealment", "concealer" },
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Fixed illusion - goblin
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure an illusion of a single goblin, complete with appropriate sounds and smells. It is 3ft tall, wears rags, and holds a spear. " +
                                    "You cannot alter the appearance of the goblin, but you may control its behavior as an action on your turn.",
                    Names = new List<string> { "goblin", "decoy", "diversion" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Fixed illusion - old man
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You conjure an illusion of an elderly human man, complete with appropriate sounds and smells. He is 6ft tall but hunched, frail and thin, has grey hair and dark skin, wears commoner's clothing, and holds a walking stick. " +
                                    "You cannot alter the appearance of the human, but you may control his behavior as an action on your turn.",
                    Names = new List<string> { "elder", "decoy", "sire", "diversion" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Retaliate as you fall unconscious - instant damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "When you are reduced to 0 HP you may use your reaction just before you fall unconscious to deal [5-8][dice] + [10-40@10] " +
                                    "necrotic damage to a visible creature in range. You will, however, have disadvantage on your first death saving throw.",
                    Names = new List<string> { "vengance", "retaliation", "demise" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Retaliate as you fall unconscious - damage per failed death save
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "When you are reduced to 0 HP you may use your reaction just before you fall unconscious to tie a visible creature's fate to yours. " +
                                    "Whenever you fail a death saving throw they suffer [2-3][dice] + [5-10] necrotic damage and if you die they are stunned for 1d3 rounds.",
                    Names = new List<string> { "demise", "fate", "revenge" },
                    IsAlwaysAReaction = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 40
                },
                new SpellTemplate //Unearth from poe
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "Any creature affected by the spell staggers as a humanoid skelton bursts from the ground nearby, rockets forward like a projectile, and crashes violently into them. " +
                                    "They must make a DEX saving throw. On a failure they suffer [2-3][dice] piercing damage and [3-4][dice] necrotic damage. Half damage on a success. " +
                                    "The skeletal remains do not vanish, and can be used in other spells (like animate dead) on subsequent turns.",
                    Names = new List<string> { "unearthing", "unburial", "return" },
                    IsAlwaysInstant= true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Consume undead minions to empower another
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch two undead minions that are under your control - each crumbles to dust and is destroyed instantly, leaving extracted energy in your hand. " +
                                    "You may then touch a 3rd undead creature under your control and empower it. Choose one of the following bonuses: " +
                                    "+[1-3] AC for [2-3] days, OR +[10-20@5]ft of movement speed indefinitely, OR gain climbing speed equal to its walking speed for [4-7] days, OR gain a [20-40@5]ft flying speed for 1 hour. " +
                                    "A creature cannot be empowered by this spell more than once. Doing so will replace the old effect with the new (the bonuses cannot stack).",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate //Permanent duplicate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You touch one non-magical item and instantly create a permanent duplicate of it at your feet. This spell fails if the item is worth more than [100-250@50] gold, " +
                                    "or if the object is larger than [3-6]ft in any dimension.",
                    Names = new List<string> { "duplicate", "duplication", "replica" },
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 60
                },
                new SpellTemplate //Infest food
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You select any or all food in the target area, and conjure insects in the center of the selected food. The insects are not visible at first, but rapidly begin to burrow outward and eventually reveal themselves. " +
                                    "Any creature that ingests one or more of the insects must make a CON saving throw. On a success they are poisoned for 1[dice] hours. " +
                                    "On a failure they are similarly poisoned and also suffer [1-2][dice] necrotic damage. If this damage reduces a humanoid to 0 HP " +
                                    "you may use your reaction to take control of them for the spell duration as they are puppeted by a swarm of insects - use the stat block for a zombie. " +
                                    "You can control no more than [2-4] creatures simultaneously in this way.",
                    Names = new List<string> { "meal", "feast", "swarm" },
                    IsAlwaysRanged = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneHour,
                    DoesNotTargetCreatures = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Mind swap
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Utility,
                    Description = "You transfer the consciousness of two humanoids into each other's body. They retain their abilities, memories, and personality - all of their stats remain the same except that " +
                                    "their HP, STR, DEX, and CON are swapped. Any equipment and items being held remain with the original body, and are not automatically exchanged. " +
                                    "Unwilling creatures can make a WIS or INT saving throw to resist (their choice), and if either creature makes the save then this spell fails.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 30
                },
                new SpellTemplate //Summon raging spirit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You hold a lantern or similarly sized hollow container in your hands and summon a tiny raging spirit to be sealed within it for [8-16@2] hours. " +
                                    "If it is not unleashed before that time then the item disintegrates into ash. The container is considered a magical item, and you cannot create another while this one exists. " +
                                    "A creature holding the vessel may use their action to unleash the raging spirit and command it to attack a visible creature. The spirit takes its turn in the initiative order immediately after the one who released it. " +
                                    "It has a flying speed of [80-150@10]ft and no other stats, as it is not considered a creature (similar to the spell Spirit Guardians). " +
                                    "The spirit is intangible and cannot be targeted by most attacks or spells (although banishment and similar abilities will work). " +
                                    "On each turn it moves to be inside of its target's space and once there deals [4-13] necrotic damage per turn. The spirit is not visible while occupying a victim's space. " +
                                    "If at any point a creature is reduced to 0 HP within [30-60@10]ft of the raging spirit then that creature is killed and the spirit vanishes permanently. " +
                                    "At the start of each of its turns, other than its first, the spirit has a 50% chance to switch targets to the next nearest creature (regardless of if they are friend or foe).",
                    Names = new List<string> { "vessel", "spirit", "haunt" },
                    IsAlwaysInstant = true,
                    DoesNotTargetCreatures = true,
                    MinimumCastTime = CastTime.OneHour,
                    IsRangeAlwaysSelf = true,
                    BaseValueScore = 1000
                },
                new SpellTemplate //Stone to flesh
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You touch a stone surface and transmute a portion of it into a lifeless humanoid body. A 5ft cube of the stone is transformed, with the new body curled up in the center surrounded by water. " +
                                    "If done carelessly, depending on the geometry of the remaining stone, the missing cube may trigger a cave-in. " +
                                    "You may choose the appearance of the body (race, age, stature, etc) including mimicking someone that you are familiar with. " +
                                    "The body cannot be resurrected as no soul was ever bound to it.",
                    Names = new List<string> {  },//--------------------TODO
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 50
                },
                new SpellTemplate //Steal heart (ala temple of doom)
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Utility,
                    Description = "You reach out and make a melee spell attack against a humanoid you can touch within 5ft. On a hit your hand passes through any armour or clothing, into their chest, and grasps their heart. " +
                                    "If the target has less than 50 HP you literally steal their heart, but may choose to keep them alive despite its absence. " +
                                    "While you hold their heart they cannot willingly make weapon attacks against you. Destroying their heart will kill them instantly. " +
                                    "If the target has 50 HP or more they instead suffer [3-5][dice] + [10-18@2] necrotic damage and your hand is pushed back out.",
                    Names = new List<string> { "doom", "theft", "heart", "grasp" },
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 100
                },
                new SpellTemplate //Rot, moss, mold, decay
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "Any objects in the target area that are not being worn or held by a creature being to decay at an accelerated rate. " +
                                    "Moss and mold cover any surfaces where moisture allows for it while dust coats any dry surfaces. Food, vegetation, and similar oganic material rots. Non-organic objects wear out in a matter of moments. " +
                                    "Clothing becomes threadbare, ropes become frayed, etc. Any remains of deceased creatures in the area are reduced to skeletons.",
                    Names = new List<string> { "decay", "decomposition", "rot" },
                    IsAlwaysInstant = true,
                    IsAlwaysAoE = true,
                    DoesNotTargetCreatures = true,
                    BaseValueScore = 3
                },
                new SpellTemplate //Spray rot
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You reach out your hand and create a spray of rot and filth seemingly out of nowhere. The stream of chunks and fluid smells like curdled death and coats any portion of the target area you choose. " +
                                    "Tracks can be completely covered by the mess, and any perception checks made within 10ft of the affected area suffer a -[6-10] penalty.",
                    Names = new List<string> {  },//--------------------TODO
                    IsRangeAlwaysSelf = true,
                    IsAlwaysAoE = true,
                    DoesNotTargetCreatures = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Buoyant
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You make up to 1[dice] objects in the target area buoyant, no matter what their typical density is. This spell cannot target creatures nor objects that are larger than [5-10]ft in any dimension.",
                    Names = new List<string> { "buoy", "lift", "floatation" },
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Weight change
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You choose up to 1[dice] visible objects in the target area and either double or halve their weight. Their size and appearance remains unchanged. " +
                                    "Each object can be up to [3-8]ft in any dimension at most. This spell cannot target objects being worn or carried by creatures.",
                    Names = new List<string> { "burden", "weight", "load" },
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3
                },
                new SpellTemplate //Color change
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You choose up to [3-5] visible objects in range and change their color. Each object can be up to 2[dice] feet in any dimension at most - objects larger than this are unaffected.",
                    Names = new List<string> {  },//--------------------TODO
                    DoesNotTargetCreatures = true,
                    IsAlwaysRanged = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 8
                },
                new SpellTemplate //Delayed transform - object
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You touch an object and trigger a delayed transformation. The object can be no larger than [2-5]ft in any dimension (both before and after being changed). You can change it into any other non-living, non-magical object, " +
                                    "but the transformation doesn't happen until 5[dice] minutes after you finish casting the spell. The DM makes this roll in secret. This spell cannot target an object being worn or carried by a creature at the time of casting.",
                    Names = new List<string> {  },//--------------------TODO
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 30
                },
                new SpellTemplate //Delayed polymorph
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You cast a variation of the 4th level spell Polymorph where the transformation is delayed. The creature makes their saving throw immediately, but if they fail " +
                                    "the transformation doesn't happen until 3[dice] minutes after you finish casting the spell. The DM makes this roll in secret.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 50
                },
                new SpellTemplate //Temporary glue
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You reach out to tap a surface within reach and conjure a tiny orb of resin-like material the size of your fingertip. The material stays soft for 6 seconds and then instantly hardens. " +
                                    "Once hardened the material will cling to anything stuck to it with the strength of a steel chain.",
                    Names = new List<string> { "adhesive", "glue", "resin", "grasp", "link" },
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate //Modify written words
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You touch a surface with writing on it and may either add or remove up to 2[dice] words. The change is masked, rearranging the adjacent words and matching the handwriting such that the change is not obvious. " +
                                    "A creature can detect the modification with a successful Investigation check vs your spell DC.",
                    Names = new List<string> { "edit", "forgery", "revision" },
                    DoesNotTargetCreatures = true,
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Fiendish polymorph
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You cast a variation of the 4th level spell Polymorph where the new form must be a Fiend rather than a Beast, and the challenge rating limitation is halved.",
                    Names = new List<string> { "devil", "demon", "descent" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,                    
                    BaseValueScore = 50
                },
                new SpellTemplate //Resize clothing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You touch up to [3-5] non-magical articles of clothing and instantly resize them. This spell cannot target objects being worn by a creature. " +
                                    "You may either change the clothing with specific dimensional edits in mind, or you can modify them to automatically fit a nearby visible creature or yourself." +
                                    "In the process of altering the clothing you may also choose to remove any blood, stains, rips, or tears that are smaller than 1ft. " +
                                    "At the time of casting you may choose to suffer 1[dice] piercing damage in order to triple the amount of items you may edit.",
                    Names = new List<string> { "tailor", "stitching", "alteration" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 2
                },
                new SpellTemplate //Hurricane breath, objects only
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You take a deep breath and then exhale, releasing a blast of hurricane-force wind in a [25-50@5]ft cone. The wind lasts for 6 seconds, wreaking havoc on objects in the area. " +
                                    "Loose objects are blown away. Temporary structures crumble to pieces before blowing away. Wood framed structures collapse. Steel framed structures bend and warp. Only solid stone structures remain intact. " +
                                    "Creatures are completely unaffected by the wind itself, as are any objects they are wearing or carrying, but will feel the effects of the debris around them. At the DM's discretion, depending on the nature of the debris, " +
                                    "creatures in the area may be required to make a DEX saving throw to avoid suffering [2-6][dice] either piercing or bludgeoning damage. In the event of a structural collapse they may be required to make a STR saving throw to avoid being restrained.",
                    Names = new List<string> { "breath", "exhale", "hurricane", "turbulence", "wind" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,                    
                    BaseValueScore = 70
                },
                new SpellTemplate //Smoke elevator
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You select a point in range on the ground. A 10ft diameter column of smoke centered on that point begins to rise into the air. " +
                                    "The height of the column of smoke starts at essentially 0 but increases by 10ft each round, up to a maximum of [50-100@10]ft. " +
                                    "Any creature in the smoke is harmlessly lifted up at a rate of 10ft per round. Wind has no effect on the smoke - it rises straight vertically at a steady rate no matter the weather. " +
                                    "The smoke does obscure vision, but it can be breathed without issue.",
                    Names = new List<string> { "uplift", "smoke", "column" },
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                //    Type = EffectType.Utility,
                //    Description = "",
                //    Names = new List<string> {  },//--------------------TODO
                //    BaseValueScore = 5
                //},
                //*************************************************************************
                /*      
                 * Next up
                        instant swamp
                        instant desert - mundane plant life crumbles to dust
                        Necro - condense remains into a tiny object for later animation		
                        evocation - yeet a willing creature, multiple saving throws. one for  stunned, prone 	
	                        target creature within 150 ft
	                        target location visible within 500 ft
                        frozen slide	
                        cave of wonders style head/rising up out of the ground..	
                        steal voice, bonus to deception checks while using it (ala Ursala)
                        summon wooden boat, can fit up to 1d6 + 2 medium creatures.	
                        temporary animation - necro - lasts for only 1d4 rounds - must be recent, intead of new stat block use original with fixed penalty	
                        animate beast - necro - use original stat block, fixed penalty	
                        animate monstrosity or abberation - necro - original stat block, no penalty		
                        animate giant - necro - original stat block with penalty	
                        animate incomplete remains	 - necro
                        command undead - temporarily take control, only if low INT
                        detonate one undead under your control as an explosion 
                        only affects undead creatures with INT less than 7. Temporarily restore their intellect from when they were alive.
                        detonate and desecrate (single cast? delayed explosion)
                        ground shakes with each step, create difficult terrain with shockwaves along the path the walk
                        frost blink 
                        flame dash 
                        plague bearer 
                        smoke mine 
                        withering step 
                        lightning warp                        
                * Transmute
                        polymorph a willing creature into a small object that weighs 1/10th their normal weight 
                        transmutation - counterfeit coins, from copper to gold, change lasts for 2d8 days, can change image on the coins too
                        utility - drunk or sober (no effect on undead, elementals, constructs)                        
                        instant door - range of touch
                        reduce object size but same weight
                * Necromancy                            
                        delayed, undetectable poison (or difficult to detect)	
                        transform a permanent skeleton or zombie you control into a ghostly variant of the same	
                        ritual to sacrifice max HP until next long rest interchange for one of the following: immune to poison, no need to breathe, 50 percent chance after death save to gain 3d6 HP, necrotic damage heals you and healing spells damage you. Roll randomly, can be cast multiple times to stack different effects	                        
                        curse item 	
                        statis AoE center on self - outside of AoE 1d8 hours pass, by inside only minutes. Barrier like wall of force prevents anything from passing in the meantime	
	                        another version with days instead of hours?
	                        another version that doesn't center of self, smaller time range to trap enemies  
                * Evocation
                        searing bond, 1d3 stationary points and yourself, bonus action to replace one
                        variant of contingency, lasts only 1 hour but multiple creatures benefit (common triggering condition and spell for all), spell level not more than half this spell
                        improve cordon of arrows 
                        pick a 1st level spell you know. Each time the target successfully hits with a weapon attack (once per turn) the spell is automatically triggered without using a spell slot or components. The spell automatically targets the creature that was hit, but any AoE effects still have an area.	                                                             
                * 
                 * Illusion, Divination? 
                       remote spell casting - channel for ally to allow them to project a spell very long range
                            one version with scrying spell to pick see target
                            one version where you create a beacon on a target that the chosen ally can send thh spell to, like a homing missile
                       subtractive illusion / partial invisibility
                       Directional scent (false illusion)
                       sending with higher word limit or an extra "volley" back and forth
                       huge AoE alarm, but with a specific trigger spoken phrase (know when someone says your name) and instantly know where in AoE trigger occurred
                       illusion - rainbow that starts above you and reaches towards a goal within 10 miles	
                * PoE
                        spell whose damage scales based on the amount of depleted spell slots you have (or undeleted)	
	                        mana mine
	                        sticky grenade, channels for more damage
                        chain hook - damage and pull yourself to the target, always ranged	
	                    circle of enlightenment - any school, plus effective spell levels for that school
                        throw a shadow of a melee weapon, chain to up to 3 targets within 10ft of the last	
	                        damage plus debuff
                        shatter a metallic weapon and hurl the shards, damage plus debuff	
	                        range of self, non magic weapon
	                        blade blast, ranged aoe	
                * Other
                        at least one per school utility - interact with environment, climate, or social
                        instantly gain the benefits of a long rest, but your max HP is reduced to 1 for 24 hours, and can't be affected by this spell again for 3 days	
                        ten minutes for a long rest, but also 1d4 points of Exhaustion	
                        instant short rest, but Max HP is reduced but 1d8 per character level for 24 hours. if reduced to 0, instead reduce to 1 and take 1d4 points of Exhaustion	
                        honey I shrunk the kids - all abilities also scaled down (esp spells), physical damage taken x10	
                 */
            };

            return templates;
        }
    }
}
