using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class PenaltyEffect : DebuffEffect
    {
        internal override void UpdateDescription()
        {
            var describeDuration = (Duration == Duration.Instant) ? "an Instant" : Duration.ToString();
            Description = $"{Description} This side effect lasts for {describeDuration}.";            
        }
    }
}
