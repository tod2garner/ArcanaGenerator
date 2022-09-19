using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorEngine
{
    public abstract class EffectBase
    {
        public EffectType Type;

        public string Description;

        public double BasePowerRating;

        public Duration Duration;

        public virtual Dictionary<string, double> GetPowerRatingFactors()
        {
            return new Dictionary<string, double>
            {
                { nameof(Duration), Duration.GetPowerRatingFactor() }
            };
        }

        internal virtual void UpdateDescription()
        {
            Description = $"Any creature affected by this spell {Description}";
        }

        internal virtual void ScalePower(double? scalingRatio, Duration? minDuration)
        {
            if (!scalingRatio.HasValue)
                return;

            if (Duration != Duration.Instant)
            {
                if (scalingRatio < 1.0 && (int)Duration > (int)(minDuration ?? Duration.OneRound)) //make it weaker
                {                    
                    var nextShorterDuration = Enum.GetValues(typeof(Duration)).Cast<Duration>().Where(e => (int)e < (int)Duration && e != Duration.Instant).OrderByDescending(e => e).First();

                    if ((int)nextShorterDuration >= (int)(minDuration ?? Duration.OneRound))
                        Duration = nextShorterDuration;
                }
                else if (scalingRatio > 1.0 && Duration != Duration.OneMonth) //make it stronger
                {
                    var nextLongerDuration = Enum.GetValues(typeof(Duration)).Cast<Duration>().Where(e => (int)e > (int)Duration).OrderBy(e => e).First();
                    Duration = nextLongerDuration;
                }
            }
        }
    }
}
