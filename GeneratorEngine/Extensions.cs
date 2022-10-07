using System;
using System.Globalization;

namespace GeneratorEngine
{
    internal static class Extensions
    {
        /// <summary>
        /// Rounds the given value to the given tolerance.
        /// </summary>
        /// <example>
        /// 23.RoundToNearest(5) = 25
        /// 23.RoundToNearest(10) = 20
        /// </example>
        public static double RoundToNearest(this double valueToRound, double tolerance) => Math.Round(valueToRound / tolerance) * tolerance;

        /// <summary>
        /// Capitalizes the first letter of each word in the string (except 'of')
        /// </summary>
        public static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Replace("Of", "of");
        }

        public static string ToUpperFirstCharOnly(this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public static double GetPowerRatingFactor(this CastTime castTime)
        {
            switch (castTime)
            {
                case CastTime.BonusAction:
                    return 1.5;
                case CastTime.OneMinute:
                    return 0.5;
                case CastTime.OneHour:
                    return 0.1;
                case CastTime.Action:
                case CastTime.Reaction:
                default:
                    return 1.0;
            };
        }

        public static double GetPowerRatingFactor(this Duration duration)
        {
            switch (duration)
            {             
                case Duration.OneMinute:
                    return 3.0;
                case Duration.TenMinutes:
                    return 5.0;
                case Duration.OneHour:
                    return 10.0;
                case Duration.EightHours:
                    return 20.0;
                case Duration.UntilNextShortRest:
                    return 30.0;
                case Duration.UntilNextLongRest:
                    return 40.0;
                case Duration.OneDay:
                    return 50.0;
                case Duration.OneMonth:
                    return 100.0;
                case Duration.Instant:
                case Duration.OneRound:
                default:
                    return 1.0;
            }
        }

        public static double GetPowerRatingFactor(this AttackOrSavingThrow attackOrSave)
        {
            switch (attackOrSave)
            {                
                case AttackOrSavingThrow.CannotMiss:
                    return 2.5;
                case AttackOrSavingThrow.AttackRoll:
                case AttackOrSavingThrow.SavingThrow:
                default:
                    return 1.0;
            };
        }

        public static double GetPowerRatingFactor(this SavingThrowType? throwType)
        {
            if(throwType.HasValue)
            {
                switch (throwType.Value)
                {
                    case SavingThrowType.INT:
                        return 1.25;
                    case SavingThrowType.STR:
                    case SavingThrowType.CON:
                        return 0.9;
                    case SavingThrowType.WIS:
                    case SavingThrowType.CHA:
                    case SavingThrowType.DEX:
                    default:
                        return 1.0;
                };
            }
            return 1.0;
        }

        public static double GetPowerRatingFactor(this ProjectileType projectileType)
        {
            switch (projectileType)
            {   
                case ProjectileType.GroundLevel:
                    return 0.8;
                case ProjectileType.Bouncing:
                    return 1.25;
                case ProjectileType.Chaining:                    
                case ProjectileType.Piercing:
                    return 2.0;
                case ProjectileType.Splitting:
                    return 3.0;
                case ProjectileType.StraightLine:
                case ProjectileType.OverheadArcing:
                case ProjectileType.Meteor:
                default:
                    return 1.0;
            };
        }

        public static double GetPowerRatingFactor(this DamageType damageType)
        {
            switch (damageType)
            {                
                case DamageType.Necrotic:                    
                case DamageType.Fire:
                    return 1.3;
                case DamageType.Cold:                    
                case DamageType.Lightning:                    
                case DamageType.Thunder:                    
                case DamageType.Acid:                    
                case DamageType.Poison:
                    return 1.5;
                case DamageType.Psychic:
                    return 1.6;
                case DamageType.Radiant:                    
                case DamageType.Force:
                    return 2.0;
                case DamageType.Piercing:
                case DamageType.Slashing:
                case DamageType.Bludgeoning:
                default:
                    return 1.0;
            };
        }

        public static double GetPowerRatingFactor(this RepeatType repeatType)
        {
            switch (repeatType)
            {                
                case RepeatType.Action:
                    return 1.5;
                case RepeatType.BonusAction:
                    return 2.0;
                case RepeatType.Free:
                    return 3.0;
                case RepeatType.None:
                default:
                    return 1.0;
            }
        }
    }
}
