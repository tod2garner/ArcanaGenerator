using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public interface IDataTemplateService
    {
        SpellTemplate GetRandomSpellTemplate(EffectType effectType, SchoolOfMagic school);
        RequiredMaterialsTemplate GetRandomRequiredMaterialsTemplate(SchoolOfMagic school);
    }
}
