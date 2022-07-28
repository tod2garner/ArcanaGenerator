﻿using GeneratorEngine.Templates;
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
            return new DamageEffect
            {
                Type = EffectType.Damage,
                BasePowerRating = 0,//not set here, calculated based on dice later
                AttackOrSaveWhenCast = GenerateAttackOrSave(deliveryType),
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

            return new DebuffEffect
            {
                Type = EffectType.Debuff,
                AttackOrSaveWhenCast = GenerateAttackOrSave(deliveryType),
                BasePowerRating = template.BaseValueScore,
                Description = template.Description,
                Duration = GenerateDuration(EffectType.Debuff, minDuration, maxDuration)
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
                Description = template.Description,
                //TargetPenaltyCost
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
                Description = template.Description
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
                Description = template.Description,
                BasePowerRating = template.BaseValueScore
            };

            return penalty;
        }

        private static AttackOrSavingThrow GenerateAttackOrSave(DeliveryType deliveryType)
        {
            var canBeAttack = deliveryType == DeliveryType.Touch || deliveryType == DeliveryType.Weapon || deliveryType == DeliveryType.Projectile;
            var roll = Rnd.Next(100);
            if (roll > 95)
                return AttackOrSavingThrow.CannotMiss;// 5%
            else if (roll > 55 && canBeAttack)
                return AttackOrSavingThrow.AttackRoll;// 40%
            else
                return AttackOrSavingThrow.SavingThrow; // 55%
        }

        private static DamageType GenerateDamageType(SchoolOfMagic school)
        {
            var roll = Rnd.Next(100);

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
                if (roll > choice.rollThreshold)
                    result = choice.value;
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
                (DiceSize.d12, 90),// 10
                (DiceSize.d10, 70),// 20
                (DiceSize.d8, 30), // 40
                (DiceSize.d6, 10), // 20
                (DiceSize.d4, 0)   // 10
            };

            int roll = Rnd.Next(100);
            foreach (var choice in options)
            {
                if (roll > choice.rollThreshold)
                    return choice.value;
            }

            return DiceSize.d6;
        }
    }
}
