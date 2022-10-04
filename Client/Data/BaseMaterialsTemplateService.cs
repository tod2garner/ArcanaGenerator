using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public abstract class BaseMaterialsTemplateService
    {
        protected List<TemplatePerSchool>? _materialTemplates;
        public TemplatePerSchool GetRandomMaterialTemplate(SchoolOfMagic school)
        {
            var templatesForGivenSchool = GetTemplates(school);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count);
            return templatesForGivenSchool.ElementAt(roll);
        }

        protected List<TemplatePerSchool> GetTemplates(SchoolOfMagic school)
        {
            if (_materialTemplates == null)
                CreateMaterialTemplates();

            if (_materialTemplates == null)
                throw new NullReferenceException("Material Templates were not created");

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _materialTemplates.ToList() : _materialTemplates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        protected abstract void CreateMaterialTemplates();

    }
}
