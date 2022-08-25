using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GeneratorEngine.Generators
{
    public static class NameGenerator
    {
        private const string CORE = "{-Core-}";
        private const string ADJECTIVE = "{-Adjective-}";
        private const string POSSESIVE = "{-Possesive-}";
        private const string EMOTION = "{-Emotion-}";
        private const string MATERIAL = "{-Material-}";
        private static List<string> _formats;

        public static string GenerateName(IDataTemplateService dataTemplateService, SchoolOfMagic school, EffectType effectType, Aesthetic aesthetic)
        {
            var rnd = new Random();

            var name = GetRandomNameFormat(rnd, effectType);

            if(name.Contains(CORE)) 
            {
                var core = (aesthetic != null && rnd.NextDouble() > 0.5) 
                            ? aesthetic.ShapeCore 
                            : dataTemplateService.GetRandomNameCore(school, effectType);
                name = name.Replace(CORE, core);
            }

            if (name.Contains(ADJECTIVE))
            {
                var adj = (!string.IsNullOrEmpty(aesthetic?.MaterialAdjective) && rnd.NextDouble() > 0.7) 
                            ? aesthetic.MaterialAdjective 
                            : dataTemplateService.GetRandomNameAdjective(school, effectType);
                name = name.Replace(ADJECTIVE, adj);
            }

            if (name.Contains(MATERIAL))
            {
                var material = (aesthetic != null)
                                ? aesthetic.MaterialDescription
                                : "energy";
                name = name.Replace(MATERIAL, material);
            }

            if (name.Contains(POSSESIVE))
                name = name.Replace(POSSESIVE, dataTemplateService.GetRandomNamePossesive(school));            

            if (name.Contains(EMOTION))
                name = name.Replace(EMOTION, dataTemplateService.GetRandomNameEmotion(school, effectType));            

            return name.ToTitleCase();
        }

        /// <summary>
        /// Capitalizes the first letter of each word in the string (except 'of')
        /// </summary>
        private static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Replace("Of", "of");
        }

        private static string GetRandomNameFormat(Random rnd, EffectType effectType)
        {
            if(_formats is null || _formats.Count == 0)
            {
                _formats = new List<string>()
                {
                    $"{POSSESIVE} {CORE}",
                    $"{POSSESIVE} {EMOTION}",
                    $"{ADJECTIVE} {MATERIAL} of {EMOTION}",
                    $"{CORE} of {ADJECTIVE} {MATERIAL}",
                    $"{CORE} of {ADJECTIVE} {EMOTION}",
                    $"{ADJECTIVE} {CORE} of {EMOTION}",
                    $"{POSSESIVE} {ADJECTIVE} {CORE}",
                    $"{POSSESIVE} {ADJECTIVE} {EMOTION}",
                    $"{POSSESIVE} {ADJECTIVE} {MATERIAL}",
                    $"{POSSESIVE} {CORE} of {EMOTION}",
                    $"{POSSESIVE} {CORE} of {MATERIAL}",
                    $"{POSSESIVE} {MATERIAL} of {EMOTION}",
                    $"{POSSESIVE} {CORE} of {ADJECTIVE} {MATERIAL}"
                };
            }

            var formatsToChooseFrom = (effectType == EffectType.Utility)
                                        ? _formats.Where(f => !f.Contains(MATERIAL)).ToList()
                                        : _formats.ToList();

            return formatsToChooseFrom.ElementAt(rnd.Next(formatsToChooseFrom.Count));
        }
    }
}
