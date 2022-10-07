using System.Collections.Generic;

namespace GeneratorEngine
{
    public class DebuffEffect : EffectBase
    {
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        public RepeatType RepeatDebuff;
        public SavingThrowType? SavingThrowType;
        public RepeatType RetryResistType;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();

            if (Duration != Duration.Instant && Duration != Duration.OneRound && AttackOrSaveWhenCast != AttackOrSavingThrow.CannotMiss)
                factors.Add(nameof(RetryResistType), 1 / RetryResistType.GetPowerRatingFactor());//Invert value, opposite scaling from damage repeat

            factors.Add("CannotMiss", AttackOrSaveWhenCast.GetPowerRatingFactor());
            factors.Add(nameof(RepeatDebuff), RepeatDebuff.GetPowerRatingFactor());
            factors.Add(nameof(SavingThrowType), SavingThrowType.GetPowerRatingFactor());            
            return factors;
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();

            if (RepeatDebuff != RepeatType.None && Duration != Duration.Instant)
            {
                if (RepeatDebuff == RepeatType.Free)
                    Description += " On subsequent turns you may repeat this effect as a free action.";
                else
                    Description += $" On subsequent turns you may repeat this effect using your {RepeatDebuff}.";
            }
        }

        public string AttackOrSaveDescription()
        {
            string text;
            switch (AttackOrSaveWhenCast)
            {
                case AttackOrSavingThrow.AttackRoll:
                    text = "Make an attack roll for each target. On a hit they are affected.";
                    if (RetryResistType != RepeatType.None && SavingThrowType.HasValue)
                    {
                        if (RetryResistType == RepeatType.Free)
                            text += $" At the end of their turn they may attempt a [{SavingThrowType.Value}] ability check as a free action, ending the effect on a success.";
                        else
                            text += $" On their turn they may use their {RetryResistType} to attempt a [{SavingThrowType.Value}] ability check, ending the effect on a success.";
                    }
                    break;
                case AttackOrSavingThrow.SavingThrow:
                    var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
                    text = $"Targets must make a {savingThrow} saving throw. On a failure they are affected.";
                    if (RetryResistType != RepeatType.None)
                    {
                        if(RetryResistType == RepeatType.Free)
                            text += " At the end of their turn they may repeat the saving throw as a free action, ending the effect on a success.";
                        else
                            text += $" On their turn they may use their {RetryResistType} to repeat the saving throw, ending the effect on a success.";
                    }
                    break;
                case AttackOrSavingThrow.CannotMiss:
                default:
                    text = "This spell cannot miss. All targets are affected, with no chance for a saving throw.";
                    break;
            }
            return text;
        }
    }
}
