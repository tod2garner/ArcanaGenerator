using GeneratorEngine.Templates;
using System;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class SpellGenerator
    {
        private static readonly Random Rnd = new Random();

        public static Spell CreateSpell(
                                IDataTemplateService dataTemplateService, 
                                SchoolOfMagic inputSchoolOfMagic, 
                                EffectType? inputEffectType, 
                                PowerLevel inputPowerLevel, 
                                bool includeSideEffect)
        {
            var effectType = inputEffectType ?? GenerateEffectType();
            var spellTemplate = dataTemplateService.GetRandomSpellTemplate(effectType, inputSchoolOfMagic);

            var school = (inputSchoolOfMagic != SchoolOfMagic.Any) ? inputSchoolOfMagic: spellTemplate.Schools.ElementAt(Rnd.Next(spellTemplate.Schools.Count));
            if(school == SchoolOfMagic.Any)
                school = GetRandomSchool();

            var delivery = DeliveryGenerator.GenerateDelivery(spellTemplate);
            var effect = EffectGenerator.GenerateEffect(spellTemplate, school, delivery.Type);
            var aesthetic = GenerateAesthetic(dataTemplateService, school, effect, delivery);
            var name = NameGenerator.GenerateName(dataTemplateService, school, effectType, aesthetic);
            var castTime = GenerateCastTime(effectType, effect.Duration, spellTemplate.IsAlwaysAReaction, spellTemplate.DoesNotTargetCreatures);

            var theSpell = new Spell
            {
                Name = name,
                School = school,
                Effect = effect,
                Delivery = delivery,
                Aesthetic = aesthetic,
                CastTime = castTime,
                Components = GenerateComponents(dataTemplateService, school),
                RequiresConcentration = true,
                Ritual = DetermineRitual(effectType, castTime),
                CasterPenaltyCost = null,
            };

            (var minValue, var maxValue) = LookupPowerScores(inputPowerLevel);
            theSpell.AdjustForTargetValueScore(spellTemplate, minValue, maxValue);
            theSpell.RequiresConcentration = DetermineConcentration(theSpell.Effect.Duration);

            var spellPower = theSpell.GetFinalPowerRating();
            if (includeSideEffect && spellPower > minValue && Rnd.Next(100) > 40) // 60%
            {
                var penaltyTemplate = dataTemplateService.GetRandomSpellTemplate(EffectType.Penalty, SchoolOfMagic.Any);
                var penalty = EffectGenerator.GeneratePenaltyEffect(penaltyTemplate, 0.5 * spellPower);
                penalty.UpdateDescription();

                if (penalty.GetPowerRating() < spellPower - 1)
                    theSpell.CasterPenaltyCost = penalty; ;
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

        private static CastTime GenerateCastTime(EffectType effectType, Duration duration, bool isAlwaysReaction, bool doesNotTargetCreatures)
        {
            if (isAlwaysReaction)
                return CastTime.Reaction;

            int roll = Rnd.Next(100);
            if (roll > 95 && effectType != EffectType.Damage && (int) duration > (int) Duration.OneHour)
                return CastTime.OneHour; // 5%
            else if (roll > 90 && !doesNotTargetCreatures)
                return CastTime.Reaction; // 5%
            else if (roll > 80)
                return CastTime.BonusAction;// 10%
            else if (roll > 70 && effectType != EffectType.Damage && (int) duration > (int) Duration.OneMinute)
                return CastTime.OneMinute;// 10%
            else
                return CastTime.Action;// 70%            
        }

        private static Components GenerateComponents(IDataTemplateService dataTemplateService, SchoolOfMagic school)
        {
            var needsMaterials = Rnd.Next(100) > 40;
            var requiredMaterials = needsMaterials ? dataTemplateService.GetRandomRequiredMaterialComponent(school) : string.Empty;

            if(needsMaterials && Rnd.Next(100) > 80) //20% chance for multiple materials
            {
                var newMaterial = dataTemplateService.GetRandomRequiredMaterialComponent(school);
                var bothOrEither = (Rnd.Next(100) > 50) ? "and" : "or";

                if(newMaterial != requiredMaterials)
                    requiredMaterials += $" {bothOrEither} {newMaterial}";
            }

            return new Components
            {
                Verbal = Rnd.Next(100) > 40,
                Somatic = Rnd.Next(100) > 30,
                Material = needsMaterials,
                RequiredMaterials = requiredMaterials
            };
        }

        private static Aesthetic GenerateAesthetic(IDataTemplateService dataTemplateService, SchoolOfMagic school, EffectBase effect, Delivery delivery)
        {
            if (effect.Type == EffectType.Utility)
                return null;

            DamageType? damageType;
            switch (effect)
            {
                case DamageEffect damageEffect:
                    damageType = damageEffect.DamageType;
                    break;
                default:
                    damageType = null;
                    break;
            }

            AreaOfEffectShape? aoEShape;
            switch (delivery)
            {
                case AreaDelivery areaDelivery:
                    aoEShape = areaDelivery.Area.Shape;
                    break;
                case AreaProjectileDelivery areaProjectileDelivery:
                    aoEShape = areaProjectileDelivery.Area.Shape;
                    break;
                default:
                    aoEShape = null;
                    break;
            }

            return AestheticGenerator.GetRandomAesthetic(dataTemplateService, delivery.Type, school, damageType, aoEShape);
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

        private static bool DetermineRitual(EffectType effectType, CastTime castTime)
        {
            if (effectType != EffectType.Utility || castTime == CastTime.Reaction)
                return false;

            if (Rnd.Next(100) > 70)
                return true; // 30%
            else
                return false;
        }
    
        private static (double minValue, double maxValue) LookupPowerScores(PowerLevel powerLevel)
        {
            switch (powerLevel)
            {
                case PowerLevel.Minor:
                    return (2, 20);
                case PowerLevel.Lesser:
                    return (20, 60);
                case PowerLevel.Greater:
                    return (60, 150);
                case PowerLevel.Major:
                    return (150, 500);
                case PowerLevel.Random:
                default:
                    return (Rnd.Next(250), Rnd.Next(500, int.MaxValue));
            };
        }
    }
}
