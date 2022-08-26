using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class AestheticShapeTemplate
    {
        public string ShapeCore;
        public string ShapeDescription;
        public string Context = string.Empty;
        public DeliveryType? DeliveryType;
        public AreaOfEffectShape? AoEShape;

        public AestheticShapeTemplate(string shapeCore, string description)
        {
            ShapeCore = shapeCore;
            ShapeDescription = description;
        }

        public AestheticShapeTemplate(DeliveryType? deliveryType, string shapeCore, string description) : this(shapeCore, description)
        {
            DeliveryType = deliveryType;
        }

        public AestheticShapeTemplate(DeliveryType? deliveryType, string shapeCore, string description, string context) : this(deliveryType, shapeCore, description)
        {
            Context = context;
        }

        public AestheticShapeTemplate(DeliveryType? deliveryType, AreaOfEffectShape? aoEShape, string shapeCore, string description) : this(deliveryType, shapeCore, description)
        {
            AoEShape = aoEShape;
        }

        public AestheticShapeTemplate(DeliveryType? deliveryType, AreaOfEffectShape? aoEShape, string shapeCore, string description, string context) : this(deliveryType, aoEShape, shapeCore, description)
        {
            Context = context;
        }
    }
}
