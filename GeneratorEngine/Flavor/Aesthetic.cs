using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Flavor
{
    public class Aesthetic
    {
        //Examples:
        //a ball of swirling flames
        //a stream of burning metal 
        //a beam of metallic leaves
        //a jet of frozen chains
        //a cloud of icy insects
        //a pool of jagged tar
        //a ray of foul smelling bubbles
        //a lupine spirit made of writhing dirt
        //a blade made of translucent granite

        public string ShapeDescription;
        public string MaterialDescription;
        public string MaterialType;

        public string CombinedDescription => $"{ShapeDescription} of {MaterialDescription} {MaterialType}";

        //Generator: 
        /*
         * AestheticShapeTemplate: Shape, Delivery Type, nullable AoE shape(s)?, projectile types?
         * AdjectiveTemplate: Adjective, DamageTypes, Schools (uses damage types when present, otherwise uses schools as a backup)
         * MaterialTemplate: Material, Schools
         */


    }
}
