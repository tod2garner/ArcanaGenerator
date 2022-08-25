using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class GenericTemplatePerSchool
    {
        public string Value;
        public List<SchoolOfMagic> Schools;

        public GenericTemplatePerSchool(string value, List<SchoolOfMagic> schools)
        {
            Value = value;
            Schools = schools;
        }

        public GenericTemplatePerSchool(string value)
        {
            Value = value;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any};
        }
    }
}
