using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticAdjectiveTemplateService
    {
        protected List<AestheticAdjectiveTemplate>? _templates;
        public AestheticAdjectiveTemplate GetRandomTemplate(SchoolOfMagic school, DamageType? damageType = null)
        {
            var templatesForGivenSchool = GetTemplates(school, damageType);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count - 1);
            return templatesForGivenSchool.ElementAt(roll);
        }

        private List<AestheticAdjectiveTemplate> GetTemplates(SchoolOfMagic school, DamageType? damageType = null)
        {
            if (_templates == null)
                CreateTemplates();

            IEnumerable<AestheticAdjectiveTemplate> matches;
            if(_templates == null)
            {
                throw new NullReferenceException();
            }
            else if(damageType != null)
            {
                matches = _templates.Where(t => t.DamageTypes.Any(d => d == damageType) || !t.DamageTypes.Any());
            }
            else
            {
                matches = (school == SchoolOfMagic.Any) ? _templates : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school));
            }

            return matches.ToList();
        }

        private void CreateTemplates()
        {
            _templates = new List<AestheticAdjectiveTemplate>
            {
                new AestheticAdjectiveTemplate("burning", new List<DamageType>{ DamageType.Fire }),
                new AestheticAdjectiveTemplate("frozen", new List<DamageType>{ DamageType.Cold }),
                new AestheticAdjectiveTemplate("metallic"),
                new AestheticAdjectiveTemplate("foul smelling"),
                new AestheticAdjectiveTemplate("acrid"),
                new AestheticAdjectiveTemplate("spectral"),
                new AestheticAdjectiveTemplate("glowing"),
                new AestheticAdjectiveTemplate("writhing"),
                new AestheticAdjectiveTemplate("swirling"),
                new AestheticAdjectiveTemplate("floating"),
                new AestheticAdjectiveTemplate("smooth"),
                new AestheticAdjectiveTemplate("rough"),
                new AestheticAdjectiveTemplate("jagged"),
                new AestheticAdjectiveTemplate("translucent"),
                new AestheticAdjectiveTemplate("corrupted", new List<DamageType>{ DamageType.Necrotic }, new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
            };
        }

    }
}
