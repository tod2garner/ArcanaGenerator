using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class NameFragment
    {
        public enum FragmentType
        {            
            Root,       //noun - either shape from aesthetic or random lookup
            Possesive,  //specific name (ex: Tasha's) - random lookup
            Adjective,  //either from aesthetic or random lookup
            Emotion     //noun - random lookup    
        }

        public string Value;
        public FragmentType Type;
    }
}
