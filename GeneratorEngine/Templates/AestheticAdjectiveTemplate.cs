using System.Collections.Generic;

namespace GeneratorEngine.Templates
{
    public class AestheticAdjectiveTemplate
    {
        public string Adjective;
        public List<DamageType> DamageTypes;
        public List<SchoolOfMagic> Schools;

        public AestheticAdjectiveTemplate(string adj)
        {
            Adjective = adj;
            DamageTypes = new List<DamageType>();
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any };
        }

        public AestheticAdjectiveTemplate(string adj, List<DamageType> damageTypes)
        {
            Adjective = adj;
            DamageTypes = damageTypes;
            Schools = new List<SchoolOfMagic> { SchoolOfMagic.Any };
        }

        public AestheticAdjectiveTemplate(string adj, List<DamageType> damageTypes, List<SchoolOfMagic> schools)
        {
            Adjective = adj;
            DamageTypes = damageTypes;
            Schools = schools;
        }
    }
}
