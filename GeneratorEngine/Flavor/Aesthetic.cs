using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Flavor
{
    public class Aesthetic
    {
        public string DeliveryDescription;// (ex: jet, beam, ball)
        public string Color;
        public string MaterialDescription;// (ex: burning, swirling, writhing)
        public string MaterialType;

        public string CombinedDescription => $"{DeliveryDescription} of {Color}, {MaterialDescription} {MaterialType}";

        //TODO - move to generator

        //DeliveryTypes
        //   Combine with range types? Self, Melee, Ranged
        /*
           Touch
           None
           AreaOfEffect
           Projectile
           AreaProjectile
           Weapon
         * 
         */
    }
}
