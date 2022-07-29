using GeneratorEngine;
using GeneratorEngine.Templates;
using System.Collections.Generic;

namespace ArcanaGenerator.Data
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
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration },
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
                    Description = "You permanently conjure a tiny snake that is hostile to you",
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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
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
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Utility,
                    Description = "You conjure a spirit to assist with translation with a specific language. " +
                                    "The spirit will only translate and will not speak of itself or converse with you directly.",
                    IsRangeAlwaysSelf = true,
                    IsNeverAoE = true,
                    DoesNotTargetCreatures = true,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate
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
                    BaseValueScore = 15
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
                new SpellTemplate
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
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "You deal 3d8 + 10 Force damage to a stationary non-living object. This spell cannot target creatures.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Utility,
                    Description = "A rush of cold air surges across target area. All non-magical flames in the area are instantly doused and all non-living objects are cooled to room temperature.",
                    DoesNotTargetCreatures = true,
                    IsAlwaysAoE = true,
                    IsAlwaysInstant = true,
                    BaseValueScore = 3
                },
            };

            return templates;
        }
    }
}
