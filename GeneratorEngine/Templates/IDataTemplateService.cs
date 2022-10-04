using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine.Templates
{
    public interface IDataTemplateService
    {
        SpellTemplate GetRandomSpellTemplate(EffectType effectType, SchoolOfMagic school);
        AestheticShapeTemplate GetRandomAestheticShape(DeliveryType deliveryType, AreaOfEffectShape? aoEShape = null);
        AestheticAdjectiveTemplate GetRandomAestheticAdjective(SchoolOfMagic school, DamageType? damageType = null);
        TemplatePerSchool GetRandomAestheticMaterial(SchoolOfMagic school);
        string GetRandomAestheticContext(DeliveryType deliveryType);
        string GetRandomRequiredMaterialComponent(SchoolOfMagic school);
        string GetRandomNameCore(SchoolOfMagic school, EffectType effectType);
        string GetRandomNameAdjective(SchoolOfMagic school, EffectType effectType);
        string GetRandomNameEmotion(SchoolOfMagic school, EffectType effectType);
        string GetRandomNamePossesive(SchoolOfMagic school);
    }
}
