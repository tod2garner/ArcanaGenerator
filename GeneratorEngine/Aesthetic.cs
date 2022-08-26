using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class Aesthetic
    {
        public string ShapeCore;
        public string ShapeDescription;
        public string MaterialAdjective;
        public string MaterialDescription;
        public string Context;

        public const string DESCRIPTION_PLACEHOLDER = "DESCRIPTION";
        public string CombinedDescription() => Context.Replace(DESCRIPTION_PLACEHOLDER, BaseDescription().Trim()).ToUpperFirstCharOnly();
        public string BaseDescription() => $"{ShapeDescription} {MaterialAdjective} {MaterialDescription}";

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

    }
}
