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
                new SpellTemplate // AC one hit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +2d4 bonus to AC for the duration, but if they are hit this spell ends early.",
                    Names = new List<string>{ "shield", "buckler", "aegis", "screen" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate // AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +[1-3] bonus to AC for the duration.",
                    Names = new List<string>{ "shield", "buckler", "aegis", "screen" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate // Temp HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains [2-5][dice] Temporary HP.",
                    Names = new List<string>{ "fascimile", "vitality", "sustenance", "vigor", "ardour" , "Half-Life" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 10
                },
                new SpellTemplate // Max HP
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains [3-5][dice] HP and Maximum HP for the spell duration.",
                    Names = new List<string>{ "cure", "balm", "salve", "remedy" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 4
                },
                new SpellTemplate //Resist crit
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "gains resistance to critical hits - they are treated as normal hits instead.",
                    Names = new List<string>{ "vigilance", "anticipation", "resilience" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Resist physical
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Physical damage. The caster can choose between Piercing, Slashing, and Bludgeoning.",
                    Names = new List<string>{ "fortitude", "endurance", "resolve" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Change incoming damage type
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can use a reaction anytime they suffer damage during the spell duration to change damage they receive from one type to another.",
                    Names = new List<string>{ "adaptation", "conversion", "acclimation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Heal via damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "can choose one damage type to temporarily heal instead of harm them.",
                    Names = new List<string>{ "absorption", "immersion", "assimilation", "appropriation" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 80
                },
                new SpellTemplate //Resist elements
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains resistance to one type of Elemental damage. The caster can choose between Fire, Cold, Lightning, and Thunder.",
                    Names = new List<string>{ "aegis", "ward", "aurora" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Undead resistance
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains resistance to Necrotic damage but becomes vulnerable to Radiant damage.",
                    Names = new List<string>{ "interment", "void", "oblivion", "corruption" },
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
                    Names = new List<string>{ "bond", "link", "chain" },
                    IsAlwaysAoE = true,
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Melee reflect damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is coated by a shimmering film. Whenever they are hit by a melee attack the damage is reduced by [1-3][dice] and " +
                                    "a lash of energy strikes back at the attacker, dealing the double amount prevented as Force damage.",
                    Names = new List<string>{ "reflection", "echo", "rebuke", "retaliation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Melee thorns
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily covered by metallic quills. Whenever they are hit by a melee attack the attacker suffers [2-3][dice] + 5 Piercing damage.",
                    Names = new List<string>{ "quills", "bristles", "spines", "thistle" },
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
                    Names = new List<string>{ "bubble", "reckoning", "retribution" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Accuracy
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +[1-3] bonus to all attack rolls (accuracy, not damage).",
                    Names = new List<string> { "aim", "hunt", "precision", "guidance" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Accuracy once per turn
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +[3-5] bonus to their first attack roll on their turn (accuracy only, not damage).",
                    Names = new List<string> { "persuit", "precision", "focus", "guidance" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5
                },
                new SpellTemplate //Initiative
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +2d6 bonus to initiative.",
                    Names = new List<string> { "vigil", "alarm", "vigilance" },
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 2
                },
                new SpellTemplate //Truesight
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "gains true-sight.",
                    Names = new List<string> { "epiphany", "awakening", "discernment", "enlightenment" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added flat weapon damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains +[2-4] damage to all weapon attacks. The type of the added damage matches that of the weapon.",
                    Names = new List<string> { "empowerment", "might", "potency", "brawn", "sinew" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added dice weapon damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains +1[dice] damage to all weapon attacks. The type of the added damage matches that of the weapon.",
                    Names = new List<string> { "might", "impetus", "brawn", "travail" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added fire damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] fire damage to one attack per round.",
                    Names = new List<string> { "incinerator", "ignition", "kindling" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 12
                },
                new SpellTemplate //Added cold damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] cold damage to one attack per round.",
                    Names = new List<string> { "frostbite", "winter", "numbness" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 9
                },
                new SpellTemplate //Added thunder damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] thunder damage to one attack per round.",
                    Names = new List<string> { "resonance", "reverberation", "overtone" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added lightning damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] lightning damage to one attack per round.",
                    Names = new List<string> { "shock", "jolt", "storm" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added acid damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] acid damage to one attack per round.",
                    Names = new List<string> { "bile", "corrosion", "deterioration", "attrition" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10
                },
                new SpellTemplate //Added melee necrotic damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains +[1-2][dice] necrotic damage to all melee attacks.",
                    Names = new List<string> { "siphon", "infection", "oblivion", "decay" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added melee radiant damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "gains +[1-2][dice] radiant damage to all melee attacks.",
                    Names = new List<string> { "illumination", "brilliance", "manifestation" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Added poison damage to weapons
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains +[1-3][dice] poison damage to weapon attacks.",
                    Names = new List<string> { "infection", "maisma", "contamination", "ichor", "putrefaction" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8
                },
                new SpellTemplate //Percent bonus force damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "deals and extra 50% of all damage from weapon attacks as added force damage.",
                    Names = new List<string> { "obliteration", "destruction", "annihilation" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Lesser critical hits
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can deal semi-critical hits with attack rolls greater than 16 but less than 20 on the dice. " +
                                    "Semi-criticals do not deal double dice damage - instead you deal an extra 50% of the dice damage.",
                    Names = new List<string> { "exploitation", "oppression", "manipulation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8
                },
                new SpellTemplate //Hover speed
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a hovering speed equal to their walking speed. They cannot fully fly but can hover up to 3 ft above any solid or liquid surface.",
                    Names = new List<string> { "levitation", "breeze", "gust" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Low elevation flight
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a flying speed equal to their walking speed, but are limited to an elevation no more than 10 ft above ground level.",
                    Names = new List<string> { "updraft", "flight", "zephyr" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 9
                },
                new SpellTemplate //Death ward, healing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. The next time they fall unconscious they instantly regain [2-4]d8 + 8 HP and may instantly stand up. This spell then ends early.",
                    Names = new List<string> { "ward", "redemption", "reclamation" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and may teleport to a visible, unoccupied point up to [15-30@5] ft away. This spell then ends early.",
                    Names = new List<string> { "escape", "getaway", "disappearance" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, temp AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and gain a +[8-12] bonus to AC until the end of their next turn. This spell then ends early.",
                    Names = new List<string> { "aegis", "bulwark", "refuge" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and a blast of energy deals [3-6]d10 radiant damage to any enemies within 15 ft. This spell then ends early.",
                    Names = new List<string> { "paroxysm", "retribution", "detonation" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Escalating temp HP while stationary
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains 2[dice] temp HP at the start of their turn. If they stay in the same location (i.e. do not move and " +
                                    "are not moved by exterior forces) then this effect repeats at the start of each turn, with the temp HP stacking until the end of the spell duration.",
                    Names = new List<string> { "ward", "barricade", "bastion", "shell" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Healed but restrained
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "regains 3[dice] + 3 HP but has their movement speed reduced to 0 for 1d3 rounds.",
                    Names = new List<string> { "restraint", "snare", "arrest" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Healed but blinded
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "regains 3[dice] + 3 HP but is blinded for 1d3 rounds.",
                    Names = new List<string> { "repose", "respite", "blindness" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Healed but paralyzed
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "regains 8[dice] + 8 HP but is paralyzed for 1d3 rounds.",
                    Names = new List<string> { "solitude", "statuary", "paralysis" },
                    IsAlwaysInstant = true,
                    BaseValueScore = 25,
                },
                new SpellTemplate //Appear friendly
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is considered friendly by creatures with INT lower than 5 that are of a single type (beast, undead, etc) which you choose at the time of casting.",
                    Names = new List<string> { "guise", "mask", "welcome" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5,
                },
                new SpellTemplate //Immume to charm
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "is immune to Charm effects for the spell duration.",
                    Names = new List<string> { "ward", "aplomb", "bulwark" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 5,
                },
                new SpellTemplate //Immume to Psychic damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "is immune to Psychic damage, but has their INT reduced by 2d4 for the spell duration.",
                    Names = new List<string> { "ignorance", "stupor", "idiocy" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Immume to Psychic damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "is immune to Fear effects, but suffers a -[1-3] penalty to AC for the spell duration.",
                    Names = new List<string> { "recklessness", "daring", "bravery" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Disguise companion
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is disguised with an illusion of your choosing, within the limits of the Disguise Self spell - except that it can apply to any willing humanoid (not only yourself).",
                    Names = new List<string> { "guise", "charade", "pretense", "veneer" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3,
                },
                new SpellTemplate //Selective invisibility
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "becomes invisible to all creatures, except 1d6 creatures that you select at the time of casting. The invisibility ends early for the target if they make an attack or cast a spell.",
                    Names = new List<string> { "concealer", "invisibility", "veil" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Phasing
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "becomes incorporeal while moving but not when stationary. While in motion they can pass through objects and creatures, but must end their movement in an unoccupied space each turn. " +
                                    "Their movement does not trigger attacks of opportunity. They can still interact normally and be targeted normally while not in motion (i.e. with attacks, spells, etc).",
                    Names = new List<string> { "phasing", "motion", "transience"  },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Taunting
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "gains a +[1-3] bonus to AC and becomes a focal point for adversaries. Enemies that can see them cannot target anyone else with attacks unless they make a successful WIS save.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Nullify
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "has one non-permanent magical ailment removed. If the ailment was created by magic of a level that is higher than this spell then the DC is 15 + the difference between spell levels",
                    Names = new List<string> { "nullification", "purification", "restoration" },
                    IsAlwaysInstant = true,                    
                    BaseValueScore = 10
                },
                new SpellTemplate //Flat damage reduction
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "has all incoming damage reduced by [2-10] for the spell duration.",
                    Names = new List<string> { "armor", "hide", "plate" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 6
                },
                new SpellTemplate //regeneration per turn
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "regenerates 1[dice] HP at the start of their turn each round, but their movement speed is reduced by [5-15@5]ft.",
                    Names = new List<string> { "regeneration", "resurgence", "renewal" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 7
                },
                new SpellTemplate //regeneration per turn while defensive
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "regenerates [2-3][dice] HP at the start of their turn each round. " +
                                    "However, this effect ends early if they make any attacks or cast any spells that deal damage.",
                    Names = new List<string> { "regeneration", "repair", "renewal" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Recover spell slot
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "regains a single spent spell slot, starting with the lowest level spent, any time they roll a 7 on any dice used for an attack or saving throw. " +
                                    "This spell has no effect on a creature without spell slots.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate //Add CON to STR melee
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can add their CON modifier to any strength-based melee attack and damage rolls (in addition to their STR modifier), " +
                                    "but their AC is reduce by their CON modifier for the duration.",
                    Names = new List<string> { "muscle", "brawn", "thew" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //AC bonus while stationary
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains a +[1-2] bonus to AC, but this effect ends early if they move at all.",
                    Names = new List<string> { "defiance", "trance", "blockade" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Damage bonus while stationary
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "gains a +[2-8] bonus to all Damage rolls, but this effect ends early if they move at all.",
                    Names = new List<string> { "defiance", "trance", "blockade" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //AC bonus while defensive
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "gains a +[4-8] bonus to AC, but this effect ends early if they attack or cast a spell",
                    Names = new List<string> { "shell", "sanctuary", "refuge" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                /* 
                 * 
                */
                //*************************************************************************
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration },
                //    Type = EffectType.Buff,
                //    Description = "",
                //    Names = new List<string> {  },//--------------------TODO
                //    BaseValueScore = 5
                //},
            };

            return templates;
        }
    }
}
