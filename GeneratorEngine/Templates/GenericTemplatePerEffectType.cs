using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class GenericTemplatePerEffectType : GenericTemplatePerSchool
    {
        public List<EffectType> EffectTypes;

        public GenericTemplatePerEffectType(string value) : base(value)
        {
            EffectTypes = null;
        }

        public GenericTemplatePerEffectType(string value, List<EffectType> effectTypes) : base(value)
        {
            EffectTypes = effectTypes;
        }

        public GenericTemplatePerEffectType(string value, List<SchoolOfMagic> schools) : base(value, schools)
        {
            EffectTypes = null;
        }

        public GenericTemplatePerEffectType(string value, List<SchoolOfMagic> schools, List<EffectType> effectTypes) : base(value, schools)
        {
            EffectTypes = effectTypes;
        }
    }
}
