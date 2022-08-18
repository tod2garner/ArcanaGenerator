using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Flavor
{
    public class Aesthetic
    {
        public string ShapeDescription;
        public string MaterialDescription;
        public string MaterialType;

        public string CombinedDescription => $"{ShapeDescription} of {MaterialDescription} {MaterialType}";

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


        //Generator: Generic Templates - for any delivery (null in template)
        //      None: ___ appears in the target's space for a moment before vanishing
        //      touch: ___ appears in the caster's hand
        //      weapon: on impact the weapon conjures ___ above the target's head
        //      projectile: the projectile is ___ that vanishes on impact
        //      Aoe projectile: the projectile is ___ that releases a burst of magic on impact
        //      Area: the area eminates/radiates from ___


    }
}
