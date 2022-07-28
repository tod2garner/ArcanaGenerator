using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class BuffEffect : EffectBase
    {
        //Duration is never instant
        //Delivery is never projectile or weapon

        public PenaltyEffect TargetPenaltyCost;

        public override double GetPowerRating()
        {
            return base.GetPowerRating() - (TargetPenaltyCost?.GetPowerRating() ?? 0);
        }
    }
}
