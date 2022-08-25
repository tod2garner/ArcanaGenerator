using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;

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

            var name = GetRandomNameFormat(rnd);

            if(name.Contains(CORE)) 
            {
                var core = (rnd.NextDouble() > 0.5) 
                            ? aesthetic.ShapeCore 
                            : dataTemplateService.GetRandomNameCore(school, effectType);
                name = name.Replace(CORE, core);
            }

            if (name.Contains(ADJECTIVE))
            {
                var adj = (!string.IsNullOrEmpty(aesthetic.MaterialAdjective) && rnd.NextDouble() > 0.5) 
                            ? aesthetic.MaterialAdjective 
                            : dataTemplateService.GetRandomNameAdjective(school, effectType);
                name = name.Replace(ADJECTIVE, adj);
            }

            if (name.Contains(POSSESIVE))
                name = name.Replace(POSSESIVE, dataTemplateService.GetRandomNamePossesive(school));            

            if (name.Contains(EMOTION))
                name = name.Replace(EMOTION, dataTemplateService.GetRandomNameEmotion(school));            

            if (name.Contains(MATERIAL))            
                name = name.Replace(MATERIAL, aesthetic.MaterialDescription);            

            return name;
        }

        private static string GetRandomNameFormat(Random rnd)
        {
            if(_formats is null || _formats.Count == 0)
            {
                _formats = new List<string>()
                {
                    $"{ADJECTIVE} {CORE}",
                    $"{POSSESIVE} {CORE}",
                    $"{POSSESIVE} {EMOTION}",
                    $"{CORE} of {ADJECTIVE}",
                    $"{CORE} of {EMOTION}",
                    $"{POSSESIVE} {ADJECTIVE} {CORE}",
                    $"{POSSESIVE} {ADJECTIVE} {EMOTION}",
                    $"{POSSESIVE} {ADJECTIVE} {MATERIAL}",
                    $"{POSSESIVE} {CORE} of {EMOTION}",
                    $"{POSSESIVE} {MATERIAL} of {EMOTION}",
                    $"{CORE} of {ADJECTIVE} {MATERIAL}",
                    $"{CORE} of {ADJECTIVE} {EMOTION}",
                    $"{POSSESIVE} {CORE} of {ADJECTIVE} {MATERIAL}",
                    $"{POSSESIVE} {CORE} of {ADJECTIVE} {EMOTION}"
                };
            }

            return _formats[rnd.Next(_formats.Count)];
        }
    }
}
