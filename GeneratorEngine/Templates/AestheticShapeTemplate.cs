using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class AestheticShapeTemplate
    {
        public string Description;
        public DeliveryType DeliveryType;
        public AreaOfEffectShape? AoEShape;

        public AestheticShapeTemplate(string description, DeliveryType deliveryType, AreaOfEffectShape? aoEShape = null)
        {
            Description = description;
            DeliveryType = deliveryType;
            AoEShape = aoEShape;
        }
    }
}
