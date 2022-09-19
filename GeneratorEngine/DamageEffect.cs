using System;
using System.Collections.Generic;

namespace GeneratorEngine
{
    public class DamageEffect : EffectBase
    {
        public DamageType DamageType;
        public int NumberOfDice;
        public DiceSize DiceSize;
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        public SavingThrowType? SavingThrowType;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            BasePowerRating = NumberOfDice * (int)DiceSize;

            var factors = base.GetPowerRatingFactors();
            factors.Add(nameof(DamageType), DamageType.GetPowerRatingFactor());
            factors.Add("CannotMiss", AttackOrSaveWhenCast.GetPowerRatingFactor());
            factors.Add(nameof(SavingThrowType), SavingThrowType.GetPowerRatingFactor());
            return factors;
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
                var maxDice = new Random().Next(9, 13);
                NumberOfDice = Math.Min(maxDice, (int)Math.Ceiling(scalingRatio.Value * NumberOfDice));
            };
        }
    }
}
