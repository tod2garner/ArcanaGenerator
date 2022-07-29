using System;

namespace GeneratorEngine
{
    public class Delivery
    {
        public DeliveryType Type;
        public RangeType RangeType;
        public double RangeDistance; //Always 0 when RangeType == self        
        public int NumberOfTargets; //Always 1 when RangeType == self
        public bool DoesNotTargetCreatures;
        public string Description;

        public virtual double GetPowerRatingModifier()
        {
            var modifierForRange = 1.0;
            if(RangeDistance >= 5)
            {
                modifierForRange = 0.3 * Math.Log(RangeDistance);//Varies from 0.5 to 1.5 between 5ft and 150ft
            }

            return (double)NumberOfTargets * modifierForRange;
        }

        internal virtual void UpdateDescription()
        {
            //TODO - improve
            var typeOfTargets = (Type == DeliveryType.AreaOfEffect || Type == DeliveryType.AreaProjectile || DoesNotTargetCreatures) ? "location(s)" : "creature(s)";
            var targetingText = NumberOfTargets > 0 ? $"Can target {NumberOfTargets} {typeOfTargets}." : "";
            var deliveryTypeText = (Type == DeliveryType.None) ? "Instant effect" : $"{Type} delivery";
            
            Description = $"{targetingText} {deliveryTypeText} with a range of {RangeDistance} ft.";
        }

        internal void ScalePower(double powerRating, double minScore, double maxScore)
        {
            //TODO - scale range distance, AoE size, etc
        }
    }
}
