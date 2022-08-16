using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class BuffTemplateService : BaseSpellTemplateService
    {
        protected override List<SpellTemplate> CreateTemplates()
        {
            var templates = new List<SpellTemplate>
            {
                new SpellTemplate
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any },
                    Type = EffectType.Buff,
                    Description = "has advantage on saving throws against all spells from the same school of magic as this spell.",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 3
                },
                new SpellTemplate // AC one hit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a 2d4 bonus AC for the duration, but if they are hit this spell ends early.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate // AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +3 bonus AC for the duration.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate // Temp HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 3d6 Temporary HP.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10
                },
                new SpellTemplate // Temp HP+
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 3d10 Temporary HP.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 15
                },
                new SpellTemplate // Max HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 4d4 HP and Maximum HP for the spell duration.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 4
                },
                new SpellTemplate // Max HP+
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 4d8 HP and Maximum HP for the spell duration.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8
                },
                new SpellTemplate //Resist crit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can resist critical hits - they are treated as normal hits instead.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Resist physical
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Physical damage. The caster can choose between Piercing, Slashing, and Bludgeoning.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Change incoming damage type
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can use a reaction anytime they suffer damage during the spell duration to change damage they receive from one type to another. For example: if hit with lightning damage, treat it as bludgeoning damage instead.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Heal via damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "can choose one damage type to temporarily heal instead of harm them.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 60
                },
                new SpellTemplate //Resist elements
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Elemental damage. The caster can choose between Fire, Cold, Lightning, and Thunder.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Undead resistance
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains resistance to Necrotic damage but becomes vulnerable to Radiant damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Link to split damage among allies
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "shares damage taken with all other friendly creatures affected by this spell. The total damage is split evenly " +
                                    "between them - for odd amounts the remainder goes to the original target. Example: for 21 damage split among 4 creatures " +
                                    "the original target takes 6 points and the other creatures each take 5 points.",
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Melee reflect damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is coated by a shimmering film. Whenever they are hit by a melee attack the damage is reduced by 2d6 and " +
                                    "a lash of energy strikes back at the attacker, dealing the double amount prevented as Force damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Melee thorns
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily covered by metallic quills. Whenever they are hit by a melee attack the attacker suffers 3d10 + 5 Piercing damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Ranged reflect damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "is temporarily surrounded by an irregular bubble shaped like their body. Whenever they would be hit by a ranged projectile attack the " +
                                    "projectile is deflected and turned back towards the attacker. The original attack roll is used vs the attackers AC to determine if it hits. " +
                                    "After deflecting 1d6 attacks the spell ends early.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Accuracy
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +2 bonus to all attack rolls (accuracy, not damage).",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Accuracy once per turn
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +4 bonus to their first attack roll on their turn (accuracy only, not damage).",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Initiative
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +2d6 bonus to initiative.",
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Truesight
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation, SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "gains true-sight.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Added weapon damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains +1d12 damage to all weapon attacks. The type of the added damage matches that from the weapon.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added fire damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +3d10 fire damage to one attack per round.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Added cold damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +3d6 cold damage to one attack per round.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 9
                },
                new SpellTemplate //Added thunder damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +3d8 thunder damage to one attack per round.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added lightning damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +2d12 lightning damage to one attack per round.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added acid damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +4d4 acid damage to one attack per round.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added melee necrotic damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains +1d10 necrotic damage to all melee attacks.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added melee radiant damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "gains +2d6 radiant damage to all melee attacks.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added poison damage to weapons
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains +1d8 poison damage to weapon attacks.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 6
                },
                new SpellTemplate //Percent bonus force damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "deals and extra 50% of all damage from weapon attacks as added force damage.",
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Lesser critical hits
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can deal semi-critical hits with attack rolls greater than 16 but less than 20 on the dice. " +
                                    "Semi-criticals do not deal double dice damage - instead you deal an extra 50% of the dice damage.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8
                },
                new SpellTemplate //Hover speed
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a hovering speed equal to their walking speed. They cannot fully fly but can hover up to 3 ft above any solid or liquid surface.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Low elevation flight
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a flying speed equal to their walking speed, but are limited to an elevation no more than 10 ft above ground level.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 9
                },
                new SpellTemplate //Death ward, healing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. Next time they fall unconscious they instantly regain 4d8 + 8 HP and can stand up. This spell then ends early.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. Next time they fall unconscious they instantly regain 1 HP, stand up, and may teleport to a visible, unoccupied point up to 15 ft away. This spell then ends early.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, temp AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. Next time they fall unconscious they instantly regain 1 HP, stand up, and gain a +10 bonus to AC until the end of their next turn. This spell then ends early.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. Next time they fall unconscious they instantly regain 1 HP, stand up, and a blast of energy deals 5d10 radiant damage to any enemies within 15 ft. This spell then ends early.",
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Escalating temp HP while stationary
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 2d8 temp HP at the start of their turn. If they stay in the same location (i.e. do not move and are not moved by exterior forces) then this effect repeats at the start of each turn, with the temp HP stacking.",
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Healed but restrained
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "regains 3d4 + 3 HP but has their movement speed reduced to 0 for 1d3 rounds.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Healed but blinded
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "regains 3d6 + 3 HP but is blinded for 1d3 rounds.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Healed but paralyzed
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "regains 8d6 + 8 HP but is paralyzed for 1d3 rounds.",
                    IsAlwaysInstant = true,
                    BaseValueScore = 25,
                },
            };

            return templates;
        }
    }
}
