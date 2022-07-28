using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class SpellTemplate
    {
        public List<SchoolOfMagic> Schools;

        public EffectType Type;

        public string Description;

        public double BaseValueScore;


        //Effect restrictions
        public bool IsAlwaysInstant;
        public Duration? MinimumDuration;
        public CastTime? MinimumCastTime;
        //Delivery restrictions
        public bool IsAlwaysAoE;
        public bool IsNeverAoE;
        public bool IsRangeAlwaysSelf;
        public bool DoesNotTargetCreatures;//Move to new subclass for utility?        
    }
}
