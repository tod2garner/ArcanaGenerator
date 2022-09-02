using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class EffectGenerator
    {
        private static readonly Random Rnd = new Random();

        internal static EffectBase GenerateEffect(SpellTemplate template, SchoolOfMagic school, DeliveryType deliveryType)
        {
            switch (template.Type)
            {
                case EffectType.Damage:
                    return CreateDamageEffect(school, deliveryType);
                case EffectType.Buff:
                    return CreateBuffEffect(template);
                case EffectType.Debuff:
                    return CreateDebuffEffect(template, deliveryType);
                case EffectType.Utility:
                    return CreateUtilityEffect(template);
                case EffectType.Penalty:
                    return GeneratePenaltyEffect(template, double.PositiveInfinity);
                default:
                    throw new NotImplementedException();
            }
        }

        private static DamageEffect CreateDamageEffect(SchoolOfMagic school, DeliveryType deliveryType)
        {
            var attackOrSave = GenerateAttackOrSave(deliveryType);

            return new DamageEffect
            {
                Type = EffectType.Damage,
                BasePowerRating = 0,//not set here, calculated based on dice later
                AttackOrSaveWhenCast = attackOrSave,
                SavingThrowType = GenerateSavingThrowType(attackOrSave, EffectType.Damage),
                DamageType = GenerateDamageType(school),
                Duration = GenerateDuration(EffectType.Damage, Duration.Instant, Duration.TenMinutes),
                DiceSize = GetRandomWeightedDiceSize(),
                NumberOfDice = 1, //default here, will be scaled later based on desired value score
                Description = string.Empty //not set here, will be created after dice are set                
            };
        }

        private static DebuffEffect CreateDebuffEffect(SpellTemplate template, DeliveryType deliveryType)
        {
            var minDuration = template.MinimumDuration ?? Duration.Instant;
            var maxDuration = (template.IsAlwaysInstant) ? Duration.Instant : Duration.OneMonth;
            var attackOrSave = GenerateAttackOrSave(deliveryType);

            return new DebuffEffect
            {
                Type = EffectType.Debuff,
                AttackOrSaveWhenCast = attackOrSave,
                SavingThrowType = GenerateSavingThrowType(attackOrSave, EffectType.Debuff),
                BasePowerRating = template.BaseValueScore,
                Duration = GenerateDuration(EffectType.Debuff, minDuration, maxDuration),
                Description = RollDynamicValuesInDescription(template.Description)
            };
        }

        private static BuffEffect CreateBuffEffect(SpellTemplate template)
        {
            var minDuration = template.MinimumDuration ?? Duration.Instant;
            var maxDuration = (template.IsAlwaysInstant) ? Duration.Instant : Duration.OneMonth;

            return new BuffEffect 
            { 
                Type = EffectType.Buff,
                Duration = GenerateDuration(EffectType.Buff, minDuration, maxDuration),
                BasePowerRating = template.BaseValueScore,
                Description = RollDynamicValuesInDescription(template.Description)
            };
        }

        private static UtilityEffect CreateUtilityEffect(SpellTemplate template)
        {
            var minDuration = template.MinimumDuration ?? Duration.Instant;
            var maxDuration = (template.IsAlwaysInstant) ? Duration.Instant : Duration.OneMonth;

            return new UtilityEffect
            {
                Type = EffectType.Utility,
                Duration = GenerateDuration(EffectType.Utility, minDuration, maxDuration),
                BasePowerRating = template.BaseValueScore,
                Description = RollDynamicValuesInDescription(template.Description)
            };
        }

        public static PenaltyEffect GeneratePenaltyEffect(SpellTemplate template, double maxPowerRating)
        {
            //TODO - both Penalty and Debuff templates if score is high enough?

            var minDuration = template.MinimumDuration ?? Duration.Instant;
            var maxDuration = Duration.OneMonth;
            if(template.IsAlwaysInstant)
            {
                maxDuration = Duration.Instant;
            }
            else
            {
                var maxDurationScore = maxPowerRating / template.BaseValueScore * 100;
                maxDuration = (maxDurationScore < 100) ? Duration.Instant : Enum.GetValues(typeof(Duration)).Cast<Duration>().Where(e => (double)e <= maxDurationScore).OrderByDescending(e => e).First();
            }

            var penalty = new PenaltyEffect
            {
                Type = EffectType.Penalty,
                Duration = GenerateDuration(EffectType.Penalty, minDuration, maxDuration),
                AttackOrSaveWhenCast = AttackOrSavingThrow.CannotMiss,
                Description = RollDynamicValuesInDescription(template.Description),
                BasePowerRating = template.BaseValueScore
            };

            return penalty;
        }

        private static AttackOrSavingThrow GenerateAttackOrSave(DeliveryType deliveryType)
        {   
            var canBeAttack = new List<DeliveryType> { DeliveryType.Touch, DeliveryType.Projectile, DeliveryType.Weapon }.Any(x => x == deliveryType);
            var canBeSave = new List<DeliveryType> { DeliveryType.None, DeliveryType.Touch, DeliveryType.Projectile, DeliveryType.AreaOfEffect, DeliveryType.AreaProjectile }.Any(x => x == deliveryType);

            var roll = Rnd.Next(100);
            if (roll > 45 && canBeSave || roll > 5 && !canBeAttack)
                return AttackOrSavingThrow.SavingThrow; // 55%
            else if (roll > 5 && canBeAttack)
                return AttackOrSavingThrow.AttackRoll;// 40%
            else
                return AttackOrSavingThrow.CannotMiss;// 5%
        }

        private static SavingThrowType? GenerateSavingThrowType(AttackOrSavingThrow attackOrSavingThrow, EffectType effectType)
        {
            if (attackOrSavingThrow == AttackOrSavingThrow.CannotMiss || attackOrSavingThrow == AttackOrSavingThrow.AttackRoll)
                return null;

            var options = new List<(SavingThrowType type, int rollThreshold)>();
            if (effectType == EffectType.Damage)
            {
                options.Add((SavingThrowType.INT, 90));   // 10%
                options.Add((SavingThrowType.WIS, 80));   // 10%
                options.Add((SavingThrowType.CHA, 60));   // 10%
                options.Add((SavingThrowType.STR, 50));   // 20%
                options.Add((SavingThrowType.CON, 30));   // 20%
                options.Add((SavingThrowType.DEX, 0));    // 30%
            }
            else if (effectType == EffectType.Debuff)
            {
                options.Add((SavingThrowType.INT, 90));   // 10%
                options.Add((SavingThrowType.STR, 80));   // 10%
                options.Add((SavingThrowType.CON, 60));   // 10%
                options.Add((SavingThrowType.DEX, 50));   // 20%
                options.Add((SavingThrowType.CHA, 30));   // 20%
                options.Add((SavingThrowType.WIS, 0));    // 30%
            }
            else
            {
                throw new NotImplementedException("Unrecognized effect type for saving throw.");
            }

            var roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.type;
            }

            return SavingThrowType.DEX;
        }

        private static DamageType GenerateDamageType(SchoolOfMagic school)
        {
            var options = new List<(DamageType type, int rollThreshold)>();
            switch (school)
            {
                case SchoolOfMagic.Abjuration:
                    options.Add((DamageType.Radiant, 90));      // 10%
                    options.Add((DamageType.Force, 80));        // 10%
                    options.Add((DamageType.Bludgeoning, 0));   // 80%
                    break;
                case SchoolOfMagic.Conjuration:
                    options.Add((DamageType.Thunder, 95));      // 5%
                    options.Add((DamageType.Lightning, 90));    // 5%
                    options.Add((DamageType.Cold, 80));         // 10%
                    options.Add((DamageType.Fire, 70));         // 10%
                    options.Add((DamageType.Slashing, 60));     // 10%
                    options.Add((DamageType.Piercing, 50));     // 10%
                    options.Add((DamageType.Bludgeoning, 40));  // 10%
                    options.Add((DamageType.Poison, 20));       // 20%
                    options.Add((DamageType.Acid, 0));          // 20%
                    break;
                case SchoolOfMagic.Divination:
                    options.Add((DamageType.Force, 90));        // 10%
                    options.Add((DamageType.Radiant, 60));      // 30%
                    options.Add((DamageType.Slashing, 40));     // 20%
                    options.Add((DamageType.Piercing, 20));     // 20%
                    options.Add((DamageType.Bludgeoning, 0));   // 20%
                    break;
                case SchoolOfMagic.Enchantment:
                    options.Add((DamageType.Necrotic, 90));     // 10%
                    options.Add((DamageType.Psychic, 0));       // 90%
                    break;
                case SchoolOfMagic.Evocation:
                    options.Add((DamageType.Force, 90));        // 10%
                    options.Add((DamageType.Slashing, 80));     // 5%
                    options.Add((DamageType.Piercing, 75));     // 5%
                    options.Add((DamageType.Bludgeoning, 70));  // 10%
                    options.Add((DamageType.Thunder, 60));      // 10%
                    options.Add((DamageType.Lightning, 40));    // 20%
                    options.Add((DamageType.Cold, 20));         // 20%
                    options.Add((DamageType.Fire, 0));          // 20%
                    break;
                case SchoolOfMagic.Illusion:
                    options.Add((DamageType.Radiant, 90));      // 10%
                    options.Add((DamageType.Psychic, 0));       // 90%
                    break;
                case SchoolOfMagic.Necromancy:
                    options.Add((DamageType.Piercing, 90));      // 10%
                    options.Add((DamageType.Slashing, 90));      // 10%
                    options.Add((DamageType.Necrotic, 0));       // 80%
                    break;
                case SchoolOfMagic.Transmutation:
                    options.Add((DamageType.Slashing, 80));     // 20%
                    options.Add((DamageType.Piercing, 60));     // 20%
                    options.Add((DamageType.Bludgeoning, 40));  // 20%
                    options.Add((DamageType.Poison, 20));       // 20%
                    options.Add((DamageType.Acid, 0));          // 20%
                    break;
                case SchoolOfMagic.Any:
                default:
                    options.Add((DamageType.Bludgeoning, 0));
                    break;
            }

            var roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.type;
            }

            return DamageType.Bludgeoning;
        }

        private static Duration GenerateDuration(EffectType effectType, Duration minDuration, Duration maxDuration)
        {
            var options = new List<(Duration value, int rollThreshold)>();

            if (effectType == EffectType.Damage)
            {
                options.Add((Duration.TenMinutes, 90)); // 10%   TODO - only if repeat like call lightning or witch bolt
                options.Add((Duration.OneMinute, 80));  // 10%
                options.Add((Duration.Instant, 0));     // 80%
            }
            else if (effectType == EffectType.Penalty)
            {
                options.Add((Duration.OneDay, 95));             //  5%
                options.Add((Duration.UntilNextLongRest, 90));  //  5%
                options.Add((Duration.UntilNextShortRest, 80)); // 10%
                options.Add((Duration.EightHours, 75));         //  5%
                options.Add((Duration.OneHour, 65));            // 10%
                options.Add((Duration.TenMinutes, 40));         // 25%
                options.Add((Duration.OneMinute, 20));          // 20%
                options.Add((Duration.OneRound, 5));            // 15%
                options.Add((Duration.Instant, 0));             //  5%
            }
            else
            {
                options.Add((Duration.OneMonth, 99));           //  1%
                options.Add((Duration.OneDay, 97));             //  2%
                options.Add((Duration.UntilNextLongRest, 95));  //  2%
                options.Add((Duration.UntilNextShortRest, 90)); //  5%
                options.Add((Duration.EightHours, 85));         //  5%
                options.Add((Duration.OneHour, 75));            // 10%
                options.Add((Duration.TenMinutes, 50));         // 25%
                options.Add((Duration.OneMinute, 30));          // 20%
                options.Add((Duration.OneRound, 15));           // 15%
                options.Add((Duration.Instant, 0));             // 15%
            }

            int roll = Rnd.Next(100);
            var result = Duration.Instant;
            foreach (var choice in options)
            {
                if (roll >= choice.rollThreshold)
                {
                    result = choice.value;
                    break;
                }                    
            }

            if((int) result > (int) maxDuration)
            {
                result = maxDuration;
            }
            else if((int)result < (int)minDuration)
            {
                result = minDuration;
            }

            return result;
        }

        private static DiceSize GetRandomWeightedDiceSize()
        {
            var options = new List<(DiceSize value, int rollThreshold)>
            {
                (DiceSize.d12, 85),// 15
                (DiceSize.d10, 65),// 20
                (DiceSize.d8, 45), // 25
                (DiceSize.d6, 20), // 20
                (DiceSize.d4, 0)   // 20
            };

            int roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.value;
            }

            return DiceSize.d6;
        }

        /// <summary>
        /// Searches for text between square brackets and replaces it with rolled values
        /// </summary>
        /// <remarks>
        /// Replaces [dice] with a random dice size.
        /// Replaces [3-8] with an integer between 3 and 8 (inclusive).
        /// Replaces [15-30@5] with a value between 15 and 30 using an increment of 5.
        /// </remarks>
        private static string RollDynamicValuesInDescription(string text)
        {
            if (!text.Contains("[") || !text.Contains("]"))
                return text;

            var remainingText = text;
            var result = string.Empty;

            while (remainingText.Length > 0)
            {
                var startIndex = remainingText.IndexOf('[');
                var endIndex = remainingText.IndexOf(']');

                if (startIndex == -1 || endIndex == -1)
                {
                    result += remainingText;
                    break;
                }
                else
                {
                    var valueToRoll = remainingText.Substring(startIndex + 1, endIndex - startIndex - 1);

                    var roll = (valueToRoll == "dice") ? GetRandomWeightedDiceSize().ToString()
                                                       : RollSpecificValue(valueToRoll);

                    result += remainingText.Substring(0, startIndex) + roll;
                    remainingText = remainingText.Substring(endIndex + 1);
                }
            }

            return result;
        }

        /// <summary>
        /// Takes a value in the format of "x-y@z" and rolls a value between x and y at increments of z
        /// </summary>
        private static string RollSpecificValue(string input)
        {
            var parameters = input.Split(new char[] { '-', '@' }, 3);

            if (parameters.Length < 2)
                return input;

            var low = int.Parse(parameters[0]);
            var high = int.Parse(parameters[1]);

            var roll = new Random().Next(low, high + 1);

            if (parameters.Length > 2)
            {
                var increment = int.Parse(parameters[2]);
                return ((double)roll).RoundToNearest(increment).ToString();
            }
            else
                return roll.ToString();
        }
    }
}
