using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class DebuffEffect : EffectBase
    {
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        public SavingThrowType? SavingThrowType;

        public override Dictionary<string, double> GetPowerRatingFactors()
        {
            var factors = base.GetPowerRatingFactors();
            factors.Add("CannotMiss", AttackOrSaveWhenCast.GetPowerRatingFactor());
            factors.Add(nameof(SavingThrowType), SavingThrowType.GetPowerRatingFactor());
            return factors;
        }

        public string AttackOrSaveDescription()
        {
            var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
            return $"{AttackOrSaveWhenCast}{savingThrow}";
        }
    }
}
