using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class DataTemplateService : IDataTemplateService
    {
        private readonly BuffTemplateService buffService;
        private readonly DebuffTemplateService debuffService;
        private readonly UtilityTemplateService utilityService;
        private readonly PenaltyTemplateService penaltyService;
        private readonly RequiredMaterialsTemplateService requiredMaterialsService;

        private readonly AestheticShapeTemplateService aestheticShapeService;
        private readonly AestheticMaterialsTemplateService aestheticMaterialsService;
        private readonly AestheticAdjectiveTemplateService aestheticAdjectiveService;

        public DataTemplateService(BuffTemplateService buffTemplateService,
                                    DebuffTemplateService debuffTemplateService,
                                    UtilityTemplateService utilityTemplateService,
                                    PenaltyTemplateService penaltyTemplateService,
                                    RequiredMaterialsTemplateService requiredMaterialsTemplateService,
                                    AestheticShapeTemplateService aestheticShapeTemplateService,
                                    AestheticMaterialsTemplateService aestheticMaterialsTemplateService,
                                    AestheticAdjectiveTemplateService aestheticAdjectiveTemplateService)
        {
            buffService = buffTemplateService;
            debuffService = debuffTemplateService;
            utilityService = utilityTemplateService;
            penaltyService = penaltyTemplateService;
            requiredMaterialsService = requiredMaterialsTemplateService;
            aestheticShapeService = aestheticShapeTemplateService;
            aestheticMaterialsService = aestheticMaterialsTemplateService;
            aestheticAdjectiveService = aestheticAdjectiveTemplateService;
        }

        public SpellTemplate GetRandomSpellTemplate(EffectType effectType, SchoolOfMagic school)
        {
            return effectType switch
            {
                EffectType.Buff => buffService.GetRandomTemplate(school),
                EffectType.Debuff => debuffService.GetRandomTemplate(school),
                EffectType.Utility => utilityService.GetRandomTemplate(school),
                EffectType.Penalty => penaltyService.GetRandomTemplate(school),
                EffectType.Damage => new SpellTemplate
                {
                    Type = EffectType.Damage,
                    Schools = new List<SchoolOfMagic> { school }
                },
                _ => throw new NotImplementedException(),
            };
        }

        public int CountTemplates(EffectType effectType, SchoolOfMagic school)
        {
            return effectType switch
            {
                EffectType.Buff => buffService.CountTemplates(school),
                EffectType.Debuff => debuffService.CountTemplates(school),
                EffectType.Utility => utilityService.CountTemplates(school),
                EffectType.Penalty => penaltyService.CountTemplates(school),
                EffectType.Damage => 0,
                _ => throw new NotImplementedException(),
            };
        }

        public Task<List<SpellTemplate>> GetTemplatesAsync(EffectType effectType, SchoolOfMagic school)
        {
            return Task.FromResult(effectType switch
            {
                EffectType.Buff => buffService.GetTemplatesPerSchool(school),
                EffectType.Debuff => debuffService.GetTemplatesPerSchool(school),
                EffectType.Utility => utilityService.GetTemplatesPerSchool(school),
                EffectType.Penalty => penaltyService.GetTemplatesPerSchool(school),
                EffectType.Damage => new List<SpellTemplate>(),
                _ => throw new NotImplementedException(),
            });
        }

        public Aesthetic GetRandomAesthetic(DeliveryType deliveryType, SchoolOfMagic school, DamageType? damageType, AreaOfEffectShape? aoEShape)
        {
            return new Aesthetic
            {
                ShapeDescription = aestheticShapeService.GetRandomTemplate(deliveryType, aoEShape).ShapeDescription,
                MaterialAdjective = aestheticAdjectiveService.GetRandomTemplate(school, damageType).Adjective,
                MaterialDescription = aestheticMaterialsService.GetRandomTemplate(school).Value
            };
        }

        public string GetRandomRequiredMaterialComponent(SchoolOfMagic school)
        {
            return requiredMaterialsService.GetRandomTemplate(school).Value;
        }
    }
}
