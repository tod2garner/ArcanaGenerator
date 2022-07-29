using GeneratorEngine;
using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;

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

        //TODO - use this to display all possible templates on another page
        //public Task<List<SpellTemplate>> GetRandomSpellTemplatesAsync(DateTime startDate)
        //{
        //    //var rng = new Random();
        //    //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    //{
        //    //    Date = startDate.AddDays(index),
        //    //    TemperatureC = rng.Next(-20, 55),
        //    //    Summary = Summaries[rng.Next(Summaries.Length)]
        //    //}).ToArray());
        //}

        public RequiredMaterialsTemplate GetRandomRequiredMaterialsTemplate(SchoolOfMagic school)
        {
            return requiredMaterialsService.GetRandomTemplate(school);
        }
    }
}
