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
        private readonly AestheticTemplateService aestheticService;
        private readonly NameFragmentTemplateService nameFragmentService;
        private readonly ReactionConditionService reactionService;

        public DataTemplateService(BuffTemplateService buffTemplateService,
                                    DebuffTemplateService debuffTemplateService,
                                    UtilityTemplateService utilityTemplateService,
                                    PenaltyTemplateService penaltyTemplateService,
                                    RequiredMaterialsTemplateService requiredMaterialsTemplateService,
                                    AestheticTemplateService aestheticTemplateService,
                                    NameFragmentTemplateService nameFragmentTemplateService,
                                    ReactionConditionService reactionConditionService)
        {
            buffService = buffTemplateService;
            debuffService = debuffTemplateService;
            utilityService = utilityTemplateService;
            penaltyService = penaltyTemplateService;
            requiredMaterialsService = requiredMaterialsTemplateService;
            aestheticService = aestheticTemplateService;
            nameFragmentService = nameFragmentTemplateService;
            reactionService = reactionConditionService;
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

        public AestheticShapeTemplate GetRandomAestheticShape(DeliveryType deliveryType, AreaOfEffectShape? aoEShape = null)
        {
            return aestheticService.GetRandomShapeTemplate(deliveryType, aoEShape);
        }

        public AestheticAdjectiveTemplate GetRandomAestheticAdjective(SchoolOfMagic school, DamageType? damageType = null)
        {
            return aestheticService.GetRandomAdjectiveTemplate(school, damageType);
        }

        public TemplatePerSchool GetRandomAestheticMaterial(SchoolOfMagic school)
        {
            return aestheticService.GetRandomMaterialTemplate(school);
            
        }

        public string GetRandomAestheticContext(DeliveryType deliveryType)
        {
            return aestheticService.GetRandomAestheticContext(deliveryType);
        }

        public string GetRandomRequiredMaterialComponent(SchoolOfMagic school)
        {
            return requiredMaterialsService.GetRandomMaterialTemplate(school).Value;
        }

        public string GetRandomNameCore(SchoolOfMagic school, EffectType effectType)
        {
            return nameFragmentService.GetRandomNameCore(school, effectType);
        }

        public string GetRandomNameAdjective(SchoolOfMagic school, EffectType effectType)
        {
            return nameFragmentService.GetRandomNameAdjective(school, effectType);
        }

        public string GetRandomNamePossesive(SchoolOfMagic school)
        {
            return nameFragmentService.GetRandomNamePossesive(school);
        }

        public string GetRandomNameEmotion(SchoolOfMagic school, EffectType effectType)
        {
            return nameFragmentService.GetRandomNameEmotion(school, effectType);
        }

        public string GetRandomReactionCondition(SchoolOfMagic school)
        {
            return reactionService.GetRandomReactionCondition(school);
        }
    }
}
