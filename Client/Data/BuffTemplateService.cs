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
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "gains [2-5][dice] Temporary HP.",
                    Names = new List<string>{ "fascimile", "vitality", "sustenance", "vigor", "ardour" },
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
                new SpellTemplate //Added psychic damage 
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "gains +[2-4][dice] psychic damage to one attack per round.",
                    Names = new List<string> {  },//-------------TODO
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
                    Description = "is temporarily protected from death by a healing ward. The next time they fall unconscious they instantly regain [2-4]d8 + 8 HP and may instantly stand up. This spell then ends early.",
                    Names = new List<string> { "ward", "redemption", "reclamation" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, teleport
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death by a fleeting ward. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and may teleport to a visible, unoccupied point up to [15-30@5] ft away. This spell then ends early.",
                    Names = new List<string> { "escape", "getaway", "disappearance" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, temp AC
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death by a defensive ward. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and gain a +[8-12] bonus to AC until the end of their next turn. This spell then ends early.",
                    Names = new List<string> { "aegis", "bulwark", "refuge" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, invisible
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death by an invisible ward. The next time they would fall unconscious they instantly regain 1 HP, become invisible, " +
                                    "and an illusuory duplicate appears in their space that falls prone on the ground (it 'plays dead' and does not move). " +
                                    "The invisibility and the illusion both last until the end of their next turn. This spell then ends early.",
                    Names = new List<string> { "escape", "trickery", "elusion" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Death ward, damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is temporarily protected from death by an explosive ward. The next time they fall unconscious they instantly regain 1 HP, stand up, " +
                                    "and a blast of energy deals [3-6]d10 radiant damage to any enemies within 15 ft. This spell then ends early.",
                    Names = new List<string> { "paroxysm", "retribution", "detonation" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
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
                    Description = "gains [2-3][dice] Temporary HP and is immune to Charm effects for the spell duration.",
                    Names = new List<string> { "ward", "aplomb", "heroism" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 8,
                },
                new SpellTemplate //Immume to Psychic damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "is immune to Psychic damage, but has their INT reduced by 2d4 for the spell duration. " +
                                    "If their INT is lower than 4 they are unable to communicate verbally or understand any spoken language (but can still understand body language and gestures).",
                    Names = new List<string> { "ignorance", "stupor", "idiocy" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10,
                },
                new SpellTemplate //Immume to fear
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "is immune to Fear effects and has their movement speed increased by 10ft, but suffers a -[1-3] penalty to AC for the spell duration.",
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
                    BaseValueScore = 8
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
                    BaseValueScore = 10
                },
                new SpellTemplate //Move speed bonus
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +[15-30@5]ft bonus to their movement speed.",
                    Names = new List<string> { "acceleration", "haste", "speed" },
                    MinimumDuration = Duration.OneMinute,
                    IsAlwaysAoE = true,
                    BaseValueScore = 10
                },
                new SpellTemplate //Partial haste
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "is magically accelerated. Each turn they may choose one of the following bonuses: " +
                                    "(A) Gain one extra weapon attack, " +
                                    "(B) Gain an extra [25-40@5]ft of movement speed, or " +
                                    "(C) Any movement does not trigger attacks of opportunity.",
                    Names = new List<string> { "acceleration", "haste", "speed" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Move speed carry over
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "can carry over any unused movement to their next turn. This can stack up to 3x their typical move speed.",
                    Names = new List<string> { "acceleration", "haste", "speed" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //360 degree vision
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "sprouts an extra pair of eyes on the back of their head, and can see in both directions simultaneously. " +
                                    "They cannot be flanked and gain a +[5-10] bonus to passive perception and perception checks related to vision.",
                    Names = new List<string> { "eye", "oculus", "vision" },
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 1
                },
                new SpellTemplate //WIS replacing DEX
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "may choose to use either their WIS or INT modifier instead of DEX for any dexterity ability checks (stealth, slight of hand, etc.)",
                    Names = new List<string> { "plan", "cleverness", "wit" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate //Multiple reactions
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "may use [2-3] reactions per round and has advantage on any attacks of opportunity that they make.",
                    Names = new List<string> { "reflex", "impulse", "intuition" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 5
                },
                new SpellTemplate //Ranged oppportunity attacks
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "may use their reaction to make opportunity attacks with a ranged weapon whenever a creature first enters " +
                                    "their weapon range or ends a turn within range. They still only have one reaction per round, but they do have advantage on any attacks of opportunity that they make",
                    Names = new List<string> { "hunt", "stalking", "reach" },
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 2
                },
                new SpellTemplate //Undead fortitude
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is granted undead fortitude for the spell duration. If they are reduced to zero HP roll 1d10. " +
                                    "On a 6 or higher they regain 1 HP instead of falling unconscious.",
                    Names = new List<string> { "fortitude", "undeath", "resurgence" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 30
                },
                new SpellTemplate //Vampiric weapon attacks
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is empowered to steal health with their weapon attacks. On successful hits they regain half of the damage dealt as HP.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Movement speed vamp
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is able to steal movement speed with their melee attacks. " +
                                    "On successful hits their target's move speed is reduced by 5ft and their speed is increased by the same amount. This effect can stack up to 4 times.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //AC vamp
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is able to steal stamina with their melee attacks." +
                                    "On successful hits their target's AC is reduced by 1 and their AC is increased by the same amount. This effect can stack up to 3 times.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Spell drain
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is able to drain arcane energy with their melee attacks." +
                                    "On successful hits their target expends one spell slot uselessly, starting with their lowest available, but not more than once per round.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Nearby creatures frightened
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "radiates a terrifying aura. Any enemy that begins a turn within [5-15@5]ft of the target must succeed on a WIS saving throw or become frightened of them.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Intimidate bonus action
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "is empowered to appear more intimidating. For the spell duration they may Intimidate as a bonus action with a +[5-10] bonus to the ability check.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8
                },
                new SpellTemplate //Stationary duplicates
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is surrounded by 1d3 illusory duplicates of themself. On their turns the target may instantly swap places with a duplicate as a bonus action. " +
                                    "At the time casting you choose where the illusions appear, but each must be in a visible point within [10-25@5]ft of the target. " +
                                    "The illusions mimic the target's behavior, but move in-place (they are stationary but animated).",
                    Names = new List<string> { "fragmentation", "duplication", "deception" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Bonus to searching skills
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "gains a +[5-10] bonus to Insight, Perception, and Investigation checks" +
                                    "When the spell ends the target suffers an equal penalty for double the spell duration (even if the spell is ended early).",
                    Names = new List<string> { "hunt", "search", "eye", "vision" },
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 5
                },
                new SpellTemplate //Bonus to athletic skills
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "gains a +[5-10] bonus to Acrobatics and Athletics checks" +
                                    "When the spell ends the target suffers an equal penalty for double the spell duration (even if the spell is ended early).",
                    Names = new List<string> { "sinew", "muscle", "brawn" },
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3
                },
                new SpellTemplate //Bonus to social skills
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "gains a +[5-10] bonus to Persuasion, Intimidation, and Deception checks for the spell duration. " +
                                    "When the spell ends the target suffers an equal penalty for double the spell duration (even if the spell is ended early).",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.TenMinutes,
                    BaseValueScore = 3
                },
                new SpellTemplate //Trade in movement
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "may choose each turn to exchange their full movement for either one extra weapon attack or a +1 bonus to AC for that round.",
                    Names = new List<string> { "stand", "stance", "anchor" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 6
                },
                new SpellTemplate //Blink instead of walking
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "is able to use their movement to teleport in 10ft increments instead of walking, but only to visible, unoccupied points. " +
                                    "For example, a creature with a 25ft walking speed could use their movement on their turn to teleport 10ft from their original location, then another 10ft from that point, and finally another 5ft for the last of their movment." +
                                    "When moving in this way they do not trigger attacks of opportunity.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 8
                },
                new SpellTemplate //Immune to non-magic damage but cannot move
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "is immune to non-magical damage, but their speed is reduced to 0 and they cannot be moved by any means for the spell duration. " +
                                    "The effect ends early if they take any action other than the dodge action.",
                    Names = new List<string> { "sanctuary", "shield", "anchor" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Immune to elemental damage but vulnerable to all other damage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "is immune to one type of elemental damage that you choose (fire, cold, lightning, and thunder) for 1d3 rounds, but vulnerable to all others for one hour.",
                    Names = new List<string> {  },//--------------------TODO,
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    BaseValueScore = 75
                },
                new SpellTemplate //Invlunerable, then unconscious
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "is immune to all damage for 1d4 rounds, but after their turn on the final round they instantly drop to 0 HP, fall unconscious, and fail 1 death saving throw. " +
                                    "If they are protected by Death Ward (or any similar magical effect) they are reduced to 1 HP and become vulnerable to all damage for 1 hour at the end of the final turn.",
                    Names = new List<string> {  },//--------------------TODO
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    BaseValueScore = 100
                },
                new SpellTemplate //Death ward - curse attacker
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "is protected from death by a vengeful ward. The next time they would fall unconscious due to taking damage from a creature, instead they avoid the damage completely and " +
                                    "the creature that damaged them must succeed on a CON save or be Poisoned, Slowed, Blinded, and Deafened for 1d4 rounds. This spell then ends early.",
                    Names = new List<string> { "vengence", "retaliation", "backlash" },
                    MinimumDuration = Duration.TenMinutes,
                    IsNeverAoE = true,
                    BaseValueScore = 5
                },
                new SpellTemplate //Dim light bonuses
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "gains a +[3-7] bonus to any ability checks made in dim light or darkness. " +
                                    "If cast at Level 6 or higher the bonus also applies to saving throws, as well as one attack per round. " +
                                    "This spell can only be cast under moonlight.",
                    Names = new List<string> { "darkness", "void", "shadow", "dusk" },
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.OneHour,
                    BaseValueScore = 4
                },
                new SpellTemplate //Blood rage
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy },
                    Type = EffectType.Buff,
                    Description = "loses 2[dice] HP every round at the start of their turn but gains an equal bonus to all single-target damage rolls.",
                    Names = new List<string> { "fury", "savagery", "rage" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 10
                },
                new SpellTemplate //Molten shell
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "is protected by a glowing ward and gains [2-4][dice] Temporary HP for the spell duration. " +
                                    "If this Temp. HP is depleted before the spell ends, the ward explodes and unleashes a blast that deals [3-4][dice] fire damage to any enemies within [5-10]ft.",
                    Names = new List<string> { "ward", "shell", "retribution" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 25
                },
                new SpellTemplate //Shield throw
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "is able to throw their shield like a homing missile (no attack roll required, it cannot miss). " +
                                    "This spell has no effect on creatures that are not already holding a shield. " +
                                    "Each turn as an action they may throw their shield at up to 3 targets within 30ft of them. " +
                                    "The shield bounces between the targets, dealing 2[dice] bludgeoning damage to each, and then instantly reappears in their hand.",
                    Names = new List<string> { "shield", "throw", "discus" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Tempest shield
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration },
                    Type = EffectType.Buff,
                    Description = "has their shield covered by straps made of lightning for the spell duration and they gain a +[1-2] bonus to AC. " +
                                    "This spell has no effect on a creature that is not already holding a shield. " +
                                    "Any time a melee attack misses them (is lower than their AC) a jolt of lightning strikes their attacker, dealing [2-4][dice] lightning damage.",
                    Names = new List<string> { "tempest", "shield", "jolt" },
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Horror shield
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Type = EffectType.Buff,
                    Description = "has their shield transformed to look like an effigy of horror, covered with a swirling pool of faces. " +
                                    "This spell has no effect on a creature that is not already holding a shield. " +
                                    "Any time a melee attack targets them the attacker must make a WIS saving throw. " +
                                    "On a failure the attacker suffers [2-3][dice] psychic damage and has disadvantage on the attack. " +
                                    "Attackers that are immune to fear or that do not rely on sight automatically succeed.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    IsNeverAoE = true,
                    BaseValueScore = 20
                },
                new SpellTemplate //Empowered punches
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Type = EffectType.Buff,
                    Description = "has their unarmed strikes magically enhanced. Once per turn they may deal [2-4][dice] bonus bludgeoning damage with an unarmed strike. " +
                                    "Additionally, if the enemy they hit is Large or smaller in size it is knocked back [10-20@5]ft.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Thunder punches
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "has their unarmed strikes magically enhanced. Once per turn they may deal [3-6][dice] bonus thunder damage with an unarmed strike. " +
                                    "This strike deals double damage to structures or constructs made of wood or stone.",
                    Names = new List<string> {  },//--------------------TODO
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 15
                },
                new SpellTemplate //Shadow punches
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is able to 'throw' fleeting shadows of themselves at enemies with their punches and kicks. " +
                                    "Their unarmed attacks gain a +[5-15]ft bonus to reach and deal [1-2][dice] bonus psychic damage.",
                    Names = new List<string> { "shadow", "echo", "shade" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 20
                },
                new SpellTemplate //Explosive arrow
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Type = EffectType.Buff,
                    Description = "has their ranged weapon attacks magically enhanced. Once per turn they may augment a ranged weapon attack with an adhesive material that sticks to the target. " +
                                    "The attack does not deal any extra damage on-hit, but after one full round (at the end of the attacker's next turn) the material explodes, " +
                                    "dealing 2[dice] fire damage to the target and any creatures within 5ft of them. " +
                                    "If the attacker hits a target coated with this adhesive again before it has time to detonate then the explosion is delayed for one additional round and the damage is doubled. " +
                                    "This doubling can escalate up to 4 times at most.",
                    Names = new List<string> { "inferno", "ignition", "detonation" },
                    MinimumDuration = Duration.OneMinute,
                    BaseValueScore = 30
                },
                new SpellTemplate //Infernal blow
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
                    Type = EffectType.Buff,
                    Description = "has their melee weapon attacks magically enhanced. Once per turn they may deal [2-4][dice] bonus fire damage with a melee weapon attack. " +
                                    "If the hit reduces a creature to 0 HP then the target explodes in a burst of flames that deals [2-4][dice] fire damage to all creatures within 15ft other than the original attacker.",
                    Names = new List<string> { "inferno", "execution", "detonation" },
                    MinimumDuration = Duration.OneRound,
                    BaseValueScore = 15
                },
                new SpellTemplate //Recharge spell slots
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation, SchoolOfMagic.Divination },
                    Type = EffectType.Buff,
                    Description = "regains a number of expended spell slots whose combined spell level is equal to 1d8 + half this spell's level (rounded up). " +
                                    "However, none of the spell slots recharged may be of a higher level than this spell. " +
                                    "Example: if cast at 5th level the target regains up to 1d8 + 3 combined spell levels' worth of spell slots. " +                                    
                                    "This spell has no effect on a creature without spell slots. " +
                                    "Once a creature benefits from this spell they are unaffected by it for 3 days.",
                    Names = new List<string> { "transfer", "synergy", "recharge" },
                    IsAlwaysInstant = true,
                    IsNeverAoE = true,
                    IsAlwaysRanged = true,
                    BaseValueScore = 15
                },
                new SpellTemplate //False scrying information
                {
                    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Illusion },
                    Type = EffectType.Buff,
                    Description = "is protected from divination magic (scrying, arcane eye, and similar spells) in a unique way. " +
                                    "Rather than preventing scrying, such a spell appears successful to the caster " +
                                    "but you may choose false information to 'reveal' in place of the target's true location, appearance, etc.",
                    Names = new List<string> { "guise", "deception", "mask", "pretense" },
                    MinimumCastTime = CastTime.OneMinute,
                    MinimumDuration = Duration.OneDay,
                    BaseValueScore = 2
                },
                //new SpellTemplate //
                //{
                //    Schools = new List<SchoolOfMagic> { SchoolOfMagic.Evocation },
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
