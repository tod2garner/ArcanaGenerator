using GeneratorEngine.Templates;
using System;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class SpellGenerator
    {
        private static readonly Random Rnd = new Random();

        public static Spell CreateSpell(IDataTemplateService dataTemplateService)
        {
            var effectType = GenerateEffectType();
            var spellTemplate = dataTemplateService.GetRandomSpellTemplate(effectType);

            var school = spellTemplate.Schools.ElementAt(Rnd.Next(0, spellTemplate.Schools.Count - 1));
            if(school == SchoolOfMagic.Any)
                school = GetRandomSchool();

            var delivery = DeliveryGenerator.GenerateDelivery(spellTemplate);
            var effect = EffectGenerator.GenerateEffect(spellTemplate, school, delivery.Type);

            var theSpell = new Spell
            {
                School = school,
                Effect = effect,
                Delivery = delivery,
                CastTime = GenerateCastTime(effectType),
                Components = GenerateComponents(dataTemplateService, school),
                RequiresConcentration = DetermineConcentration(effect.Duration),
                Ritual = DetermineRitual(effectType),
                CasterPenaltyCost = null,
                Name = "Create name generator"
            };

            //TODO - get minValue and maxValue from inputs
            var minValue = Rnd.Next(50);
            var maxValue = minValue + Rnd.Next(1000);

            theSpell.AdjustForTargetValueScore(minValue, maxValue);
                        
            if (Rnd.Next(100) > 20) // 80%
            {
                var penaltyTemplate = dataTemplateService.GetRandomSpellTemplate(EffectType.Penalty);
                var penalty = EffectGenerator.GeneratePenaltyEffect(penaltyTemplate, 0.5 * theSpell.GetFinalPowerRating());
                theSpell.CasterPenaltyCost = penalty;
            }

            return theSpell;
        }

        private static EffectType GenerateEffectType()
        {
            var roll = Rnd.Next(100);
            if (roll > 85)
                return EffectType.Utility; // 15%
            else if (roll > 60)
                return EffectType.Buff;// 25%
            else if (roll > 30)
                return EffectType.Debuff;// 30%
            else
                return EffectType.Damage;// 30%    
        }

        private static SchoolOfMagic GetRandomSchool()
        {
            var minRange = 1;//exclude 0 index because that is for 'Any'
            var maxRange = Enum.GetValues(typeof(SchoolOfMagic)).Cast<SchoolOfMagic>().Max(e => (int)e);
            return (SchoolOfMagic)Rnd.Next(minRange, maxRange);
        }

        private static CastTime GenerateCastTime(EffectType effectType)
        {
            int roll = Rnd.Next(100);
            if (roll > 95 && effectType != EffectType.Damage)
                return CastTime.OneHour; // 5%
            else if (roll > 90 && effectType != EffectType.Utility)
                return CastTime.Reaction; // 5%
            else if (roll > 80)
                return CastTime.BonusAction;// 10%
            else if (roll > 70 && effectType != EffectType.Damage)
                return CastTime.OneMinute;// 10%
            else
                return CastTime.Action;// 70%            
        }

        private static Components GenerateComponents(IDataTemplateService dataTemplateService, SchoolOfMagic school)
        {
            var needsMaterials = Rnd.Next(100) > 40;
            var requiredMaterials = needsMaterials ? dataTemplateService.GetRandomRequiredMaterialsTemplate(school).Material : string.Empty;

            return new Components
            {
                Verbal = Rnd.Next(100) > 40,
                Somatic = Rnd.Next(100) > 30,
                Material = needsMaterials,
                RequiredMaterials = requiredMaterials
            };
        }

        private static bool DetermineConcentration(Duration duration)
        {
            if (duration == Duration.Instant || duration == Duration.OneRound)
                return false;

            if (Rnd.Next(100) > 80)
                return false; // 20%
            else
                return true;
        }

        private static bool DetermineRitual(EffectType effectType)
        {
            if (effectType != EffectType.Utility)
                return false;

            if (Rnd.Next(100) > 70)
                return true; // 30%
            else
                return false;
        }
    }
}
