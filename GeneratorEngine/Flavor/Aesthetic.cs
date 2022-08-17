using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Flavor
{
    public class Aesthetic
    {
        //Examples:
        //a ball of green, swirling flames
        //a stream of burning metal 
        //a beam of metallic leaves
        //a jet of frozen chains
        //a cloud of icy insects
        //a pool of blue tar
        //a ray of foul smelling bubbles
        //a feline spirit made of black, writhing dirt

        public string ShapeDescription;
        public string Color;
        public string MaterialDescription;
        public string MaterialType;
        public string DeliveryDescription;

        public string CombinedDescription => $"{ShapeDescription} of {Color}, {MaterialDescription} {MaterialType} {DeliveryDescription}";

        //Generator: 
        /*
         * %chance for color (not always there)
         * AestheticShapeTemplate: Description, Delivery Type, nullable AoE shape(s)?, projectile types?
         * MaterialTemplate: Description, Schools
         */


        //AestheticShapeTemplate per DeliveryTypes
        /*
           Touch - shape always "hand is covered with"
           None - no shape, but  at the end "... appears on the target(s)"
           AreaOfEffect - templates
           Projectile - templates
           AreaProjectile - templates
           Weapon - shape always "weapon is covered with"
         * 
         */
    }
}
