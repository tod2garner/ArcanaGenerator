using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    public class RequiredMaterialsTemplateService
    {
        private List<RequiredMaterialsTemplate>? _templates;
        public RequiredMaterialsTemplate GetRandomTemplate(SchoolOfMagic school)
        {
            var templatesForGivenSchool = GetTemplates(school);

            var rng = new Random();
            var roll = rng.Next(templatesForGivenSchool.Count - 1);
            return templatesForGivenSchool.ElementAt(roll);
        }

        public List<RequiredMaterialsTemplate> GetTemplates(SchoolOfMagic school)
        {
            if (_templates == null)
                CreateTemplates();

            var templatesToReturn = (school == SchoolOfMagic.Any) ? _templates.ToList() : _templates.Where(t => t.Schools.Any(s => s == SchoolOfMagic.Any || s == school)).ToList();
            return templatesToReturn;
        }

        private void CreateTemplates()
        {
            _templates = new List<RequiredMaterialsTemplate>
            {
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered dragon bone"
                },new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered dragon claw"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered dragon scale"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a fragment of a dragon scale"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "crushed lichen"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "dehydrated moss"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a handful of shelf mushrooms"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a full clam shell"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered fish scales"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered fish bones"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "several rodent teeth"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "three small feathers"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a tiny ruby worth at least 10 gold pieces"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a tiny sapphire worth at least 5 gold pieces"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a tiny emerald worth at least 5 gold pieces"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation },
                    Material = "a piece of scrap iron"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation },
                    Material = "a bit of copper ore"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Material = "a bit of iron ore"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation },
                    Material = "a small piece of granite"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation },
                    Material = "a small sandstone rock"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Illusion },
                    Material = "a fragment of limestone"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration },
                    Material = "bark from an oak tree"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion },
                    Material = "dried willow leaves"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Material = "an acorn"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion },
                    Material = "a smooth piece of aspen wood"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a wooden coin"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small piece of ivory"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a fragment of pottery"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination },
                    Material = "bone powder"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy },
                    Material = "a fragment from a gravestone"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy },
                    Material = "a tiny bird or rodent skull"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy },
                    Material = "a tiny vial of tears"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy },
                    Material = "dried worms"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration },
                    Material = "a pinch of ashes"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation },
                    Material = "a handful of rust"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination },
                    Material = "a pinch of graveyard soil"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a clump of dried algae"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "crushed sea shells"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a handful of salt"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Enchantment },
                    Material = "a vial of springwater"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a vial of pondwater"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a handful of mud"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "crushed flower stems"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a tuft of dark fur"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a square of pale fabric"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a piece of velvet"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Material = "a fragment of petrified wood"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a handful of crumbled plaster"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Divination, SchoolOfMagic.Enchantment },
                    Material = "five grape seeds"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a vial of oil with a claw in it"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration },
                    Material = "four pressed three-leaf clovers"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a fractured cobblestone"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "hard leather in the shape of a leaf"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "an obsidian arrowhead"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation },
                    Material = "an obsidian marble"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small granite marble"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "seven wooden marbles"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a finger-size piece of quartz"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a chunk of maple tree root"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration },
                    Material = "red brick dust"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a smooth piece of sea glass"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Transmutation },
                    Material = "powdered goat horn"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment },
                    Material = "a tiny mirror"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered finch feathers"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "eight rose thorns"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a fragment of pumice"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration },
                    Material = "a handful of volcanic ash"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration },
                    Material = "a clump of clay"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a vial of vinegar"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "two cactus needles"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "crushed apple seeds"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "an apple seed"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "tomato seeds"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "an alligator tooth"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a lizard claw"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "crushed egg shells"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small wax candle"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a piece of charred leather"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a bit of charcoal"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "ashes from a burned book"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a pinch of sawdust"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small cork"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "two polished, wooden buttons"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a few strands of horse hair"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small comb made from a sea shell"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a piece of turtle shell"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "pressed flowers, gathered in direct sunlight"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "ivy flowers"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "pine needles"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "pine sap"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a pinecone"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "sand from an anthill"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "braided blades of grass"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a small leather braid"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a spool of dark thread"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a bit of cobweb"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a piece of lace"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "soap carved into the shape of an acorn"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "soap carved into the shape of a leaf"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination },
                    Material = "soap carved into the shape of a bird"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a thimble"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "powdered paint flakes"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a little vial of paint"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a scap of blank parchment"
                },
                new RequiredMaterialsTemplate
                {
                    Schools = new List<SchoolOfMagic>{ SchoolOfMagic.Any },
                    Material = "a single link of chain"
                },
            };
        }
    }
}
