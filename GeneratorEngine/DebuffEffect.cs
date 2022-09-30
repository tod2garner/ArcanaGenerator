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
            switch (AttackOrSaveWhenCast)
            {
                case AttackOrSavingThrow.AttackRoll:
                    return "Make an attack roll for each target. On a hit they are affected.";
                case AttackOrSavingThrow.SavingThrow:
                    var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
                    return $"Targets must make a {savingThrow} saving throw. On a failure they are affected.";
                case AttackOrSavingThrow.CannotMiss:
                default:
                    return "This spell cannot miss. All targets are affected, with no chance for a saving throw.";
            }
        }
    }
}
