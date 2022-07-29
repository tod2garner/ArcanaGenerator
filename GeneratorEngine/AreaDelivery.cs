using System;

namespace GeneratorEngine
{
    public class AreaDelivery : Delivery
    {
        public Area Area;
        public bool DoesAreaPersistForDuration;

        public override double GetPowerRatingModifier()
        {
            return base.GetPowerRatingModifier() * Area.GetLikelyNumberOfTargets();
        }

        internal override void UpdateDescription()
        {
            base.UpdateDescription();
            Description += $" and a {Area.Size} ft {Area.Shape} area";
        }
    }
}
