using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticMaterialsTemplateService : BaseMaterialsTemplateService
    {
        protected override void CreateTemplates()
        {
            _templates = new List<MaterialsTemplate>
            {
                new MaterialsTemplate("bones", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new MaterialsTemplate("animal claws"),
                new MaterialsTemplate("reptile scales"),
                new MaterialsTemplate("lichen"),
                new MaterialsTemplate("moss"),
                new MaterialsTemplate("fungus"),
                new MaterialsTemplate("sea shells"),
                new MaterialsTemplate("animal teeth"),
                new MaterialsTemplate("feathers"),
                new MaterialsTemplate("hair"),
                new MaterialsTemplate("seaweed"),
                new MaterialsTemplate("petals"),
                new MaterialsTemplate("cobweb"),
                new MaterialsTemplate("egg shells"),
                new MaterialsTemplate("charcoal"),
                new MaterialsTemplate("worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("insects", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("spiders", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new MaterialsTemplate("algae"),
                new MaterialsTemplate("flowers"),
                new MaterialsTemplate("fur"),

                new MaterialsTemplate("water"),
                new MaterialsTemplate("energy"),
                new MaterialsTemplate("flames"),
                new MaterialsTemplate("sparks"),
                new MaterialsTemplate("mist"),
                new MaterialsTemplate("vapor"),
                new MaterialsTemplate("venom"),
                new MaterialsTemplate("acid"),
                new MaterialsTemplate("lava"),
                new MaterialsTemplate("coal"),

                new MaterialsTemplate("ruby"),
                new MaterialsTemplate("sapphire"),
                new MaterialsTemplate("gold"),
                new MaterialsTemplate("silver"),
                new MaterialsTemplate("emerald"),
                new MaterialsTemplate("ivory"),

                new MaterialsTemplate("iron"),
                new MaterialsTemplate("steel"),
                new MaterialsTemplate("copper"),
                new MaterialsTemplate("tin"),
                new MaterialsTemplate("chain"),
                new MaterialsTemplate("knives"),

                new MaterialsTemplate("soil"),
                new MaterialsTemplate("dirt"),
                new MaterialsTemplate("sand"),
                new MaterialsTemplate("stone"),
                new MaterialsTemplate("granite"),
                new MaterialsTemplate("sandstone"),
                new MaterialsTemplate("limestone"),
                new MaterialsTemplate("gravel"),
                new MaterialsTemplate("pebbles"),
                new MaterialsTemplate("obsidian"),
                new MaterialsTemplate("quartz"),
                new MaterialsTemplate("pumice"),
                new MaterialsTemplate("glass"),
                new MaterialsTemplate("clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("salt"),
                new MaterialsTemplate("mud"),

                new MaterialsTemplate("tree bark"),
                new MaterialsTemplate("leaves and vines"),
                new MaterialsTemplate("branches"),
                new MaterialsTemplate("wood"),
                new MaterialsTemplate("thorns"),
                new MaterialsTemplate("cactus needles"),
                new MaterialsTemplate("ivy"),
                new MaterialsTemplate("pine needles"),
                new MaterialsTemplate("sap"),
                new MaterialsTemplate("grass"),
                new MaterialsTemplate("roots"),

                new MaterialsTemplate("fabric"),
                new MaterialsTemplate("plaster"),
                new MaterialsTemplate("oil"),
                new MaterialsTemplate("coins"),
                new MaterialsTemplate("pottery"),
                new MaterialsTemplate("leather"),
                new MaterialsTemplate("brick"),
                new MaterialsTemplate("mirrors", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new MaterialsTemplate("vinegar"),
                new MaterialsTemplate("wax"),
                new MaterialsTemplate("books"),
                new MaterialsTemplate("cork"),
                new MaterialsTemplate("buttons"),
                new MaterialsTemplate("thread"),
                new MaterialsTemplate("sawdust"),
                new MaterialsTemplate("lace"),
                new MaterialsTemplate("soap"),
                new MaterialsTemplate("paint"),
                new MaterialsTemplate("parchment"),
                new MaterialsTemplate("food"),
                new MaterialsTemplate("liquor"),
                new MaterialsTemplate("rope"),

            };
        }
    }

}
