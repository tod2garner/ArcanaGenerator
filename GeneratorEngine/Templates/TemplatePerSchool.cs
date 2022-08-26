using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class TemplatePerSchool
    {
        public string Value;
        public List<SchoolOfMagic> Schools;

        public TemplatePerSchool(string value, List<SchoolOfMagic> schools)
        {
            Value = value;
            Schools = schools;
        }

        public TemplatePerSchool(string value)
        {
            Value = value;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any};
        }
    }
}
