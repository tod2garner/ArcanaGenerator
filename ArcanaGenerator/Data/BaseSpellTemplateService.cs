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

        public SpellTemplate GetRandomTemplate()
        {
            if (_templates == null)
                _templates = CreateTemplates();

            var rng = new Random();
            var roll = rng.Next(_templates.Count - 1);
            return _templates.ElementAt(roll);
        }

        public List<SpellTemplate> GetTemplate(SchoolOfMagic school)
        {
            if (_templates == null)
                _templates = CreateTemplates();

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _templates.ToList() : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        protected abstract List<SpellTemplate> CreateTemplates();
    }
}
