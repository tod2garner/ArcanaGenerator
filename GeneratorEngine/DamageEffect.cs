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
        public RepeatType RepeatDamage;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            BasePowerRating = NumberOfDice * (int)DiceSize;

            var factors = base.GetPowerRatingFactors();
            factors.Add(nameof(RepeatDamage), RepeatDamage.GetPowerRatingFactor());
            factors.Add(nameof(DamageType), DamageType.GetPowerRatingFactor());
            factors.Add("CannotMiss", AttackOrSaveWhenCast.GetPowerRatingFactor());
            factors.Add(nameof(SavingThrowType), SavingThrowType.GetPowerRatingFactor());
            return factors;
        }

        public string AttackOrSaveDescription()
        {
            switch (AttackOrSaveWhenCast)
            {
                case AttackOrSavingThrow.AttackRoll:
                    return "Make an attack roll for each target. On a hit they are affected.";
                case AttackOrSavingThrow.SavingThrow:
                    var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
                    return $"Targets must make a {savingThrow} saving throw. On a failure they are fully affected. On a success they take half damage.";
                case AttackOrSavingThrow.CannotMiss:
                default:
                    return "This spell cannot miss. All targets are affected, with no chance for a saving throw.";
            }
        }

        internal override void UpdateDescription()
        {
            Description = $"Any creature affected by this spell suffers {NumberOfDice}{DiceSize} {DamageType} damage.";

            if(RepeatDamage != RepeatType.None && Duration != Duration.Instant)
            {
                if (RepeatDamage == RepeatType.Free)
                    Description += " This damage is repeated automatically at the end of their turn for the duration of the spell.";
                else
                    Description += $" On subsequent turns you may repeat this effect using your {RepeatDamage}.";
            }
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
