using System;

namespace GeneratorEngine
{
    public class Delivery
    {
        public DeliveryType Type;
        public RangeType RangeType;
        public double RangeDistance;       
        public int NumberOfTargets;
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
            var targetingText = NumberOfTargets > 0 ? $"Can target {NumberOfTargets} {typeOfTargets}. " : "";
            var deliveryTypeText = (Type == DeliveryType.None) ? "Instant effect" : $"{Type} delivery";
            var rangeText = (RangeType == RangeType.Self) ? "self" : $"{RangeDistance} ft.";

            if (Type == DeliveryType.Weapon)
            {
                var doubleOrTypical = RangeType == RangeType.Melee ? string.Empty : " double";
                rangeText += $" or{doubleOrTypical} the weapon's typical range, whichever is smaller";
            }                
            
            Description = $"{targetingText}{deliveryTypeText} with a range of {rangeText}";
        }

        internal virtual void ScalePower(double? scalingRatio)
        {
            if (!scalingRatio.HasValue)
                return;

            if (scalingRatio < 1.0) //make it weaker
            {
                if(scalingRatio < (NumberOfTargets - 1) / NumberOfTargets)
                {
                    var newNumberOfTargets = Math.Max(1, (int) Math.Floor(scalingRatio.Value * NumberOfTargets));
                    scalingRatio *= (NumberOfTargets / newNumberOfTargets);
                    NumberOfTargets = newNumberOfTargets;
                }

                if (scalingRatio < 1.0 && RangeType == RangeType.Distance) // still not weak enough after # target change
                {
                    RangeDistance = Math.Max(15, scalingRatio.Value * RangeDistance);
                }
            }
            else if (scalingRatio > 1.0) //make it stronger
            {
                if(scalingRatio > 2.0 && RangeType != RangeType.Self)
                {
                    var maxTargets = (Type == DeliveryType.AreaOfEffect || Type == DeliveryType.AreaProjectile || Type == DeliveryType.Touch || RangeType == RangeType.Melee) ? 3 : 8;
                    var newNumberOfTargets = Math.Min(maxTargets, (int)Math.Ceiling(scalingRatio.Value * NumberOfTargets));
                    scalingRatio *= (NumberOfTargets / newNumberOfTargets);
                    NumberOfTargets = newNumberOfTargets;
                }

                if (scalingRatio > 1.0 && RangeType == RangeType.Distance) // still not strong enough after # target change
                {
                    RangeDistance = Math.Min(150, scalingRatio.Value * RangeDistance);                    
                }
            }
            RangeDistance = RangeDistance.RoundToNearest(5);
        }

    }
}
