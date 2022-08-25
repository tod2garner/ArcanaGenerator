using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class GenericTemplate
    {
        public string Value;
        public List<SchoolOfMagic> Schools;

        public GenericTemplate(string value, List<SchoolOfMagic> schools)
        {
            Value = value;
            Schools = schools;
        }

        public GenericTemplate(string value)
        {
            Value = value;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any};
        }
    }
}
