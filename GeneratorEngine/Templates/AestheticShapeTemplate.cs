using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class AestheticShapeTemplate
    {
        public string ShapeCore;
        public string ShapeDescription;
        public DeliveryType? DeliveryType;
        public AreaOfEffectShape? AoEShape;

        public AestheticShapeTemplate(string shapeCore, string description, DeliveryType? deliveryType = null, AreaOfEffectShape? aoEShape = null)
        {
            ShapeCore = shapeCore;
            ShapeDescription = description;
            DeliveryType = deliveryType;
            AoEShape = aoEShape;
        }
    }
}
