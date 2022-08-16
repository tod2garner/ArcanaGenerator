using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class RequiredMaterialsTemplate
    {
        public string Material;
        public List<SchoolOfMagic> Schools;

        public RequiredMaterialsTemplate(string material, List<SchoolOfMagic> schools)
        {
            Material = material;
            Schools = schools;
        }

        public RequiredMaterialsTemplate(string material)
        {
            Material = material;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any};
        }
    }
}
