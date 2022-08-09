using GeneratorEngine;
using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArcanaGenerator.Data
{
    public class DataTemplateService : IDataTemplateService
    {
        private readonly BuffTemplateService buffService;
        private readonly DebuffTemplateService debuffService;
        private readonly UtilityTemplateService utilityService;
        private readonly PenaltyTemplateService penaltyService;
        private readonly RequiredMaterialsTemplateService requiredMaterialsService;

        public DataTemplateService(BuffTemplateService buffTemplateService,
                                    DebuffTemplateService debuffTemplateService,
                                    UtilityTemplateService utilityTemplateService,
                                    PenaltyTemplateService penaltyTemplateService,
                                    RequiredMaterialsTemplateService requiredMaterialsTemplateService)
        {
            buffService = buffTemplateService;
            debuffService = debuffTemplateService;
            utilityService = utilityTemplateService;
            penaltyService = penaltyTemplateService;
            requiredMaterialsService = requiredMaterialsTemplateService;
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

        public RequiredMaterialsTemplate GetRandomRequiredMaterialsTemplate(SchoolOfMagic school)
        {
            return requiredMaterialsService.GetRandomTemplate(school);
        }
    }
}
