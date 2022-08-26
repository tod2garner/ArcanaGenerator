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
                    Description = "You instantly know if any spell from the same school of magic as this spell is cast within 100 ft of you. " +
                                    "You may choose to target a stationary point instead of yourself. If cast at Level 4 or higher, " +
                                    "you may end this spell early to block any one spell you detect that is of a lower level.",
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
                    Description = "If any footprints or animal tracks in the area were created within the past 24 hours then their outline glows. " +
                                    "The intensity of the glow increases with how recently they were created.",
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
                                    "but they must fit within a 5ft cube and have a combined value less than 100 gold pieces.",
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
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.TenMinutes,
                    MinimumCastTime = CastTime.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "A half-sphere appears that is just large enough to provide you with cover. The translucent surface blocks all projeciles, " +
                                    "but is intangible to creatures and other objects like melee weapons.",
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "When you see a creature cast a spell with a range greater than 5 ft. you may attempt to intervene and turn it back on them. " +
                                    "If the spell is of a lower level than this spell it is redirected to target the original caster. " +
                                    "If the spell level is equal to or great than this spell then make an ability check using your " +
                                    "spellcasting modifier to redirect it. The DC equals 10 + the spell's level.",
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    IsAlwaysAReaction = true,
                    BaseValueScore = 30
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "When you see a creature taking damage you may transfer up to 3d10 of the damage to yourself instead. " +
                                    "The remainder of the damage is still dealt to the original target.",
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
                    Description = "You permanently conjure 1 cubic foot of ice, gravel, or ash",
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
                    Description = "You permanently conjure 1d6 harmless insects (beetles, ants, flies, larvae, moths, etc.)",
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
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 0.5
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a thick cloud of swirling vapor that obscures line of sight",
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 1
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a rushing river of fluid that appears and disappears from nothingness at its start and end. " +
                                    "You may select any visible point within range as the start and end points, and the fluid flows downhill in a " +
                                    "straight line between the two. The torrent can be up to 20 ft wide and 10 ft deep, held back at the " +
                                    "sides as if by invisible river banks. Creatures caught in the torrent have their swimming speed (if " +
                                    "they have any) reduced by half and are swept downstream at a rate of 20 ft per round. If cast at Level 6 " +
                                    "or higher the caster may use a bonus action to reverse the direction of flow, even to flow uphill.",
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
                                    "next creature in initiate order, in a cycle so the last creature moves to the location of the first.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 6
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You teleport a visible unconscious creature to your feet, or the nearest unoccupied space.",
                    IsNeverAoE = true,
                    IsAlwaysInstant = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 10
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You teleport a visible willing creature to your side, or the nearest unoccupied space.",
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
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate//Destroy object
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You deal 3d8 + 10 Force damage to a stationary non-living object. This spell cannot target creatures.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate//Douse flames
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "A rush of cold air surges across target area. All non-magical flames in the area are instantly doused and all non-living objects are cooled to room temperature.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
                new SpellTemplate //Lesser wall of force
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "An invisible, impenetrable surface appears in an unoccupied location within range. It takes the shape of a flat surface made up of 2d4 panels, each 5 ft square, " +
                                    "and each contiguous with at least one other panel. The plane is 1 inch thick and lasts for the duration. Nothing can physically pass through the plane and it is immune to all damage.",
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
                    Description = "You create an faint line on the ground within range, up to 100ft long. An invisible surface extends 10ft vertically from the line. This surface blocks any sounds and smells " +
                                    "from passing through it in one direction of your choosing.",
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
                    Description = "All water (and water-based liquids) is repelled and pushed to the edges of the area of effect. Note that this spell does not impact liquids in fully sealed containers, nor " +
                                    "does it impact liquids within creatures or plants.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Repel heat
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "Any loose materials - including solids, liquids, and gases - that are dangerously hot (heated enough to cause burns) are repelled and pushed to the edges of the area of effect. " +
                                    "Note that this spell does not impact materials in fully sealed containers, solid materials heavier than 5 lbs, nor does it impact materials within creatures or plants.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Summon 9ft tall grass
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion },
                    Type = EffectType.Utility,
                    Description = "You choose a visible point on the ground within range and starting at that point 9ft tall grass appears and rapidly spreads along the ground for 2d8 X 10ft in all directions. " +
                                   "It rounds corners and spreads up or down cliffs, but stops at pooled liquids.",
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Conjure quicksand
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "The ground within the area of effect becomes quicksand. Any creatures in the area, or that end their turn in the area, must make a CON saving throw. " +
                                    "On a failure they suffer an escalating debuff that increases by one level, and on a success the intensity decreases by one level. " +
                                    "Level 1 = Up to the knees, Movement speed reduced to 5ft. Level 2 = Up to the waist, Restrained. Level 3 = Up to the neck, Paralyzed.",
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
                    Description = "You conjure a rough, rope-style ladder made of vines and branches, hanging from a visible location in range. The ladder has a maximum length of 4d6 X 5ft and for the spell duration before vanishing.",
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
                    Description = "You create false footprints or animal tracks of any variety within the area of effect, which last for 48hrs. The false prints cannot completely replace your own tracks, but can be used to make them harder to detect.",
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
                    Description = "You conjure a giant mushroom, which sprouts from any surface in range - ground, roof, or wall. The mushroom can be up to 15ft tall, 20ft wide in any direction, and vanishes when the spell ends. " +
                                    "Any creatures in the space where it appears are harmlessly lifted or held by it.",
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
                    Description = "To cast this spell you must be holding one or more magical items worth at least 900 GP. These items are consumed in order to resurrect a creature within 10ft of you that has been dead for less than 5 days.",
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
                    Description = "You cast a varation of the light spell where the light created is visible only to you and up to 1d4 other creatures that you select at the time of casting.",
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Selective darkness
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You cast a varation of the darkness spell where the darkness created is transparent to you and up to 1d3 other creatures that you select at the time of casting (each can still see the outline of the affected area).",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysRanged = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Smell emotions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Utility,
                    Description = "You are able to smell the emotions of any creature within 15ft of you. As an action you can make an insight check with a +10 bonus. If they are within 5ft of you then you also make the check with advantage.",
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
                    Description = "You are instantly aware of the number of beating hearts within 100 ft of you. You also have a rough idea of the location of any beating hearts within 20 ft of you.",
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
                    Description = "You conjure a piece of parchment with writing on it that lists out the number of sentient creatures within 100 ft of you, sorted by their general race or type. Large numbers of creatures will be rounded. " +
                                    "For example: 30 humans, 20 elves, 1 fiend, and 2 monstrosities. Creatures with less than 3 for INT are not included on the list, and creatures that are magically obscured (i.e. by shapeshifting or invisibility) " +
                                    "will not be revealed if the spell/ability hiding it is of a higher level than this spell.",
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsRangeAlwaysSelf = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Create a flare or beacon
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You create either a beacon at your feet or a flare overhead. A beacon lasts 30 minutes but is stationary on the ground. A flare vanishes after 6 seconds but can be launched " +
                    "up to 60 ft directly vertically into the air. Either creates a brilliant light of any color you choose, but not so intense as to deal any damage or impair vision.",
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
                    Description = "In a matter of seconds you can either clean/organize or toss/disorganize any portion of the area within range. " +
                                    "This acts like a larger scale variation of the soil/clean abilitly of prestidigitation.",
                    DoesNotTargetCreatures = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 2
                },
            };

            return templates;
        }
    }
}
