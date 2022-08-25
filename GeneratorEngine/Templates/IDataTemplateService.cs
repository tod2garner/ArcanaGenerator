using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public interface IDataTemplateService
    {
        SpellTemplate GetRandomSpellTemplate(EffectType effectType, SchoolOfMagic school);
        Aesthetic GetRandomAesthetic(DeliveryType deliveryType, SchoolOfMagic school, DamageType? damageType, AreaOfEffectShape? aoEShape);
        string GetRandomRequiredMaterialComponent(SchoolOfMagic school);
        string GetRandomNameCore(SchoolOfMagic school, EffectType effectType);
        string GetRandomNameAdjective(SchoolOfMagic school, EffectType effectType);
        string GetRandomNamePossesive(SchoolOfMagic school);
        string GetRandomNameEmotion(SchoolOfMagic school);
    }
}
