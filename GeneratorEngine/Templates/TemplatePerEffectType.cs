using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public class TemplatePerEffectType : TemplatePerSchool
    {
        public List<EffectType> EffectTypes;

        public TemplatePerEffectType(string value) : base(value)
        {
            EffectTypes = null;
        }

        public TemplatePerEffectType(string value, List<EffectType> effectTypes) : base(value)
        {
            EffectTypes = effectTypes;
        }

        public TemplatePerEffectType(string value, List<SchoolOfMagic> schools) : base(value, schools)
        {
            EffectTypes = null;
        }

        public TemplatePerEffectType(string value, List<SchoolOfMagic> schools, List<EffectType> effectTypes) : base(value, schools)
        {
            EffectTypes = effectTypes;
        }
    }
}
