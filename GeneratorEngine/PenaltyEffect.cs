using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class PenaltyEffect : DebuffEffect
    {
        internal override void UpdateDescription()
        {
            if(Duration != Duration.Instant)
            {
                Description = $"{Description} This side effect lasts for {Duration}.";
            }
        }

        public double GetPowerRating()
        {
            return BasePowerRating * Duration.GetPowerRatingFactor();
        }
    }
}
