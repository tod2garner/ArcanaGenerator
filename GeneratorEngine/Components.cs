using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class Components
    {
        public bool Verbal; 
        
        public bool Somatic;

        public bool Material;

        public string RequiredMaterials;

        public string ToAbbreviation()
        {
            return (Verbal || Somatic || Material) ? $"{(Verbal ? "V" : "")}{(Somatic ? "S" : "")}{(Material ? "M" : "")}" : "None";
        }

        public string SummarizeIncludingSpecificMaterials()
        {
            if (RequiredMaterials == string.Empty)
                return ToAbbreviation();
            else
                return ToAbbreviation() + " - " + RequiredMaterials;
        }
    }
}
