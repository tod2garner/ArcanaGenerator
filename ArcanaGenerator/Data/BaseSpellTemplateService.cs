using GeneratorEngine;
using GeneratorEngine.Templates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArcanaGenerator.Data
{
    public abstract class BaseSpellTemplateService
    {
        private List<SpellTemplate> _templates;

        public SpellTemplate GetRandomTemplate(SchoolOfMagic school)
        {
            var rng = new Random();
            var templatesForSchool = GetTemplatesPerSchool(school);
            var roll = rng.Next(templatesForSchool.Count);
            return templatesForSchool.ElementAt(roll);
        }

        private List<SpellTemplate> GetTemplatesPerSchool(SchoolOfMagic school)
        {
            if (_templates == null)
                _templates = CreateTemplates();

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _templates.ToList() : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        protected abstract List<SpellTemplate> CreateTemplates();
    }
}
