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

        public double GetPowerRatingFactor()
        {
            var count = (Verbal ? 1 : 0) + (Somatic ? 1 : 0) + (Material ? 1 : 0);
            if (count == 0)
                return 1.5;
            else if (count == 1)
                return 1.1;
            else
                return 1.0;
        }
    }
}
