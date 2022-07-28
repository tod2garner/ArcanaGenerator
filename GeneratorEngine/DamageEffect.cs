using System;
using System.Collections.Generic;
using System.Text;

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
            BasePowerRating = NumberOfDice * (int) DiceSize * ((double)DamageType / 100.0) * ((double)AttackOrSaveWhenCast / 100.0);
            return base.GetPowerRating();
        }

        internal override void UpdateDescription()
        {
            Description = $"Any creature affected by this spell suffers {NumberOfDice}{DiceSize} {DamageType} damage.";
        }

        internal override void ScalePower(double scalingRatio)
        {
            if(scalingRatio < 1.0)
            {
                //TODO
            }
            else if(scalingRatio > 1.0)
            {
                //TODO
            };
        }
    }
}
