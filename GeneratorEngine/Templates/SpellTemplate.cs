using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class SpellTemplate
    {
        public List<SchoolOfMagic> Schools;

        public EffectType Type;

        public string Description;

        public List<string> Names;

        public double BaseValueScore;


        //Effect restrictions
        public bool IsAlwaysInstant;
        public Duration? MinimumDuration;
        public CastTime? MinimumCastTime;
        public bool IsAlwaysAReaction;
        public bool IsRepeatable;
        //Delivery restrictions
        public bool IsAlwaysAoE;
        public bool IsNeverAoE;
        public bool IsRangeAlwaysSelf;
        public bool IsAlwaysRanged;
        public bool DoesNotTargetCreatures;
    }
}
