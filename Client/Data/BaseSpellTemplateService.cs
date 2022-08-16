using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public abstract class BaseSpellTemplateService
    {
        private List<SpellTemplate>? _templates;

        public SpellTemplate GetRandomTemplate(SchoolOfMagic school)
        {
            var templatesForSchool = GetTemplatesPerSchool(school);
            var rng = new Random();
            var roll = rng.Next(templatesForSchool.Count);
            return templatesForSchool.ElementAt(roll);
        }

        public int CountTemplates(SchoolOfMagic school)
        {
            return GetTemplatesPerSchool(school).Count;
        }

        public List<SpellTemplate> GetTemplatesPerSchool(SchoolOfMagic school)
        {
            if (_templates == null)
                _templates = CreateTemplates();

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _templates.ToList() : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        protected abstract List<SpellTemplate> CreateTemplates();
    }
}
