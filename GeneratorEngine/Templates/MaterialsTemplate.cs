using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class MaterialsTemplate
    {
        public string Material;
        public List<SchoolOfMagic> Schools;

        public MaterialsTemplate(string material, List<SchoolOfMagic> schools)
        {
            Material = material;
            Schools = schools;
        }

        public MaterialsTemplate(string material)
        {
            Material = material;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any};
        }
    }
}
