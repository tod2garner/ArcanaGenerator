using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class TemplatePerDeliveryType
    {
        public DeliveryType DeliveryType;
        public string Value;

        public TemplatePerDeliveryType(DeliveryType deliveryType, string value)
        {
            DeliveryType = deliveryType;
            Value = value;
        }
    }
}
