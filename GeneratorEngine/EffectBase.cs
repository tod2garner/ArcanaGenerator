using System;
using System.Linq;

namespace GeneratorEngine
{
    public abstract class EffectBase
    {
        public EffectType Type;

        public string Description;

        public double BasePowerRating;

        public Duration Duration;

        public virtual double GetPowerRating()
        {
            return BasePowerRating * (double)Duration / 100.0;
        }

        internal virtual void UpdateDescription()
        {
            Description = $"Any creature affected by this spell {Description}";
        }

        internal virtual void ScalePower(double scalingRatio)
        {
            if(scalingRatio < 1.0 && Duration != Duration.Instant)
            {
                var nextShorterDuration = Enum.GetValues(typeof(Duration)).Cast<Duration>().Where(e => (int)e < (int)Duration).OrderBy(e => e).First();
                Duration = nextShorterDuration;
            }
            else if(scalingRatio > 1.0 && Duration != Duration.OneMonth)
            {
                var nextLongerDuration = Enum.GetValues(typeof(Duration)).Cast<Duration>().Where(e => (int)e > (int)Duration).OrderBy(e => e).First();
                Duration = nextLongerDuration;
            }                
        }
    }
}
