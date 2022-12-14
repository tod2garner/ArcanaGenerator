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

            var school = (inputSchoolOfMagic != SchoolOfMagic.Any) ? inputSchoolOfMagic : spellTemplate.Schools.ElementAt(Rnd.Next(spellTemplate.Schools.Count));
            if (school == SchoolOfMagic.Any)
                school = GetRandomSchool();

            var delivery = DeliveryGenerator.GenerateDelivery(spellTemplate);
            var effect = EffectGenerator.GenerateEffect(spellTemplate, school, delivery.Type);
            var aesthetic = GenerateAesthetic(dataTemplateService, school, effect, delivery);
            var name = NameGenerator.GenerateName(dataTemplateService, school, effectType, aesthetic, spellTemplate.Names);
            var castTime = GenerateCastTime(dataTemplateService, school, effectType, effect.Duration, spellTemplate.IsAlwaysAReaction, spellTemplate.DoesNotTargetCreatures, spellTemplate.MinimumCastTime);

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
                Ritual = DetermineRitual(effectType, castTime.Length),
                CasterPenaltyCost = null,
            };

            (var minValue, var maxValue) = LookupPowerScores(inputPowerLevel);
            theSpell.AdjustForTargetValueScore(spellTemplate, minValue, maxValue);
            theSpell.RequiresConcentration = DetermineConcentration(theSpell.Effect.Duration);

            theSpell.UpdatePowerRatingFactors();
            var spellPower = theSpell.FinalPowerRating;
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

        private static CastTime GenerateCastTime(IDataTemplateService dataTemplateService, SchoolOfMagic school, EffectType effectType, Duration duration, bool isAlwaysReaction, bool doesNotTargetCreatures, CastTimeLength? minimumCastTime)
        {
            var result = new CastTime { Length = GenerateCastTimeLength(effectType, duration, isAlwaysReaction, doesNotTargetCreatures, minimumCastTime) };

            if(result.Length == CastTimeLength.Reaction && !isAlwaysReaction)            
                result.Conditions = dataTemplateService.GetRandomReactionCondition(school);
            
            return result;
        }

        private static CastTimeLength GenerateCastTimeLength(EffectType effectType, Duration duration, bool isAlwaysReaction, bool doesNotTargetCreatures, CastTimeLength? minimumCastTime)
        {
            if (isAlwaysReaction)
                return CastTimeLength.Reaction;

            int roll = Rnd.Next(100);
            CastTimeLength result;
            if (roll > 95 && effectType != EffectType.Damage && (int)duration > (int)Duration.OneHour)
                result = CastTimeLength.OneHour; // 5%
            else if (roll > 90 && !doesNotTargetCreatures)
                result = CastTimeLength.Reaction; // 5%
            else if (roll > 80)
                result = CastTimeLength.BonusAction;// 10%
            else if (roll > 70 && effectType != EffectType.Damage && (int)duration > (int)Duration.OneMinute)
                result = CastTimeLength.OneMinute;// 10%
            else
                result = CastTimeLength.Action;// 70%

            if (minimumCastTime.HasValue && (int)result < (int)minimumCastTime.Value)
            {
                return minimumCastTime.Value;
            }

            return result;
        }

        private static Components GenerateComponents(IDataTemplateService dataTemplateService, SchoolOfMagic school)
        {
            var needsMaterials = Rnd.Next(100) > 40;
            var requiredMaterials = needsMaterials ? dataTemplateService.GetRandomRequiredMaterialComponent(school) : string.Empty;

            if (needsMaterials && Rnd.Next(100) > 80) //20% chance for multiple materials
            {
                var newMaterial = dataTemplateService.GetRandomRequiredMaterialComponent(school);
                var bothOrEither = (Rnd.Next(100) > 50) ? "and" : "or";

                if (newMaterial != requiredMaterials)
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

            ProjectileType? projectileType;
            switch (delivery)
            {
                case ProjectileDelivery projectileDelivery:
                    projectileType = projectileDelivery.ProjectileType;
                    break;
                case AreaProjectileDelivery areaProjectileDelivery:
                    projectileType = areaProjectileDelivery.ProjectileType;
                    break;
                default:
                    projectileType = null;
                    break;
            }

            return AestheticGenerator.GetRandomAesthetic(dataTemplateService, delivery.Type, school, damageType, aoEShape, projectileType);
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

        private static bool DetermineRitual(EffectType effectType, CastTimeLength castTime)
        {
            if (effectType != EffectType.Utility || castTime == CastTimeLength.Reaction)
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
