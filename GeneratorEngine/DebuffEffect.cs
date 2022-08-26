using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class DebuffEffect : EffectBase
    {
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        public SavingThrowType? SavingThrowType;

        public override double GetPowerRating()
        {            
            return base.GetPowerRating() * ((double)AttackOrSaveWhenCast / 100.0);
        }

        public string AttackOrSaveDescription()
        {
            var savingThrow = SavingThrowType.HasValue ? $" [{SavingThrowType.Value}]" : string.Empty;
            return $"{AttackOrSaveWhenCast}{savingThrow}";
        }
    }
}
