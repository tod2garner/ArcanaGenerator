using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public abstract class BaseMaterialsTemplateService
    {
        protected List<MaterialsTemplate>? _templates;
        public MaterialsTemplate GetRandomTemplate(SchoolOfMagic school)
        {
            var templatesForGivenSchool = GetTemplates(school);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count - 1);
            return templatesForGivenSchool.ElementAt(roll);
        }

        public List<MaterialsTemplate> GetTemplates(SchoolOfMagic school)
        {
            if (_templates == null)
                CreateTemplates();

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _templates.ToList() : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        protected abstract void CreateTemplates();

    }
}
