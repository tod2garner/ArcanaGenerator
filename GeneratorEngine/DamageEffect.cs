﻿using System;

namespace GeneratorEngine
{
    public class DamageEffect : EffectBase
    {
        public DamageType DamageType;
        public int NumberOfDice;
        public DiceSize DiceSize;
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        public SavingThrowType? SavingThrowType;

        public override double GetPowerRating()
        {
            BasePowerRating = NumberOfDice * (int) DiceSize * DamageType.GetPowerRatingFactor() * AttackOrSaveWhenCast.GetPowerRatingFactor();
            return base.GetPowerRating();
        }

        public string AttackOrSaveDescription()
        {
            var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
            return $"{AttackOrSaveWhenCast}{savingThrow}";
        }

        internal override void UpdateDescription()
        {
            Description = $"Any creature affected by this spell suffers {NumberOfDice}{DiceSize} {DamageType} damage.";
        }

        internal override void ScalePower(double? scalingRatio, Duration? minDuration)
        {
            if (!scalingRatio.HasValue)
                return;

            if(scalingRatio < 1.0 && NumberOfDice > 1) //make it weaker
            {
                NumberOfDice = Math.Max(1, (int)Math.Floor(scalingRatio.Value * NumberOfDice));
            }
            else if(scalingRatio > 1.0) //make it stronger
            {
                NumberOfDice = Math.Min(12, (int)Math.Ceiling(scalingRatio.Value * NumberOfDice));
            };
        }
    }
}
