﻿using GeneratorEngine;
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
                new RequiredMaterialsTemplate("powdered dragon bone"),
                new RequiredMaterialsTemplate("powdered dragon claw"),
                new RequiredMaterialsTemplate("powdered dragon scale"),
                new RequiredMaterialsTemplate("a fragment of a dragon scale"),
                new RequiredMaterialsTemplate("crushed lichen"),
                new RequiredMaterialsTemplate("dehydrated moss"),
                new RequiredMaterialsTemplate("a handful of shelf mushrooms"),
                new RequiredMaterialsTemplate("a full clam shell"),
                new RequiredMaterialsTemplate("powdered fish scales"),
                new RequiredMaterialsTemplate("powdered fish bones"),
                new RequiredMaterialsTemplate("several rodent teeth"),
                new RequiredMaterialsTemplate("three small feathers"),
                new RequiredMaterialsTemplate("a tiny ruby worth at least 10 gold pieces"),
                new RequiredMaterialsTemplate("a tiny sapphire worth at least 5 gold pieces"),
                new RequiredMaterialsTemplate("a tiny emerald worth at least 5 gold pieces"),
                new RequiredMaterialsTemplate("a piece of scrap iron"),
                new RequiredMaterialsTemplate("a bit of copper ore"),
                new RequiredMaterialsTemplate("a bit of iron ore"),
                new RequiredMaterialsTemplate("a small piece of granite"),
                new RequiredMaterialsTemplate("a small sandstone rock"),
                new RequiredMaterialsTemplate("a fragment of limestone"),
                new RequiredMaterialsTemplate("bark from an oak tree"),
                new RequiredMaterialsTemplate("dried willow leaves"),
                new RequiredMaterialsTemplate("an acorn"),
                new RequiredMaterialsTemplate("a smooth piece of aspen wood"),
                new RequiredMaterialsTemplate("a wooden coin"),
                new RequiredMaterialsTemplate("a small piece of ivory"),
                new RequiredMaterialsTemplate("a fragment of pottery"),
                new RequiredMaterialsTemplate("bone powder", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new RequiredMaterialsTemplate("a fragment from a gravestone", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new RequiredMaterialsTemplate("a tiny bird or rodent skull", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new RequiredMaterialsTemplate("a tiny vial of tears", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new RequiredMaterialsTemplate("dried worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new RequiredMaterialsTemplate("a pinch of ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new RequiredMaterialsTemplate("a handful of rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new RequiredMaterialsTemplate("a pinch of graveyard soil", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new RequiredMaterialsTemplate("a clump of dried algae"),
                new RequiredMaterialsTemplate("crushed sea shells"),
                new RequiredMaterialsTemplate("a handful of salt"),
                new RequiredMaterialsTemplate("a vial of springwater"),
                new RequiredMaterialsTemplate("a vial of pondwater"),
                new RequiredMaterialsTemplate("a handful of mud"),
                new RequiredMaterialsTemplate("crushed flower stems"),
                new RequiredMaterialsTemplate("a tuft of dark fur"),
                new RequiredMaterialsTemplate("a square of pale fabric"),
                new RequiredMaterialsTemplate("a piece of velvet"),
                new RequiredMaterialsTemplate("a fragment of petrified wood"),
                new RequiredMaterialsTemplate("a handful of crumbled plaster"),
                new RequiredMaterialsTemplate("five grape seeds"),
                new RequiredMaterialsTemplate("a vial of oil with a claw in it"),
                new RequiredMaterialsTemplate("four pressed three-leaf clovers"),
                new RequiredMaterialsTemplate("a fractured cobblestone"),
                new RequiredMaterialsTemplate("hard leather in the shape of a leaf"),
                new RequiredMaterialsTemplate("an obsidian arrowhead"),
                new RequiredMaterialsTemplate("an obsidian marble", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new RequiredMaterialsTemplate("a small granite marble"),
                new RequiredMaterialsTemplate( "seven wooden marbles"),
                new RequiredMaterialsTemplate( "a finger-size piece of quartz"),
                new RequiredMaterialsTemplate("a chunk of maple tree root"),
                new RequiredMaterialsTemplate( "red brick dust"),
                new RequiredMaterialsTemplate( "a smooth piece of sea glass"),
                new RequiredMaterialsTemplate( "powdered goat horn"),
                new RequiredMaterialsTemplate("a tiny mirror", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new RequiredMaterialsTemplate( "powdered finch feathers"),
                new RequiredMaterialsTemplate("eight rose thorns"),
                new RequiredMaterialsTemplate("a fragment of pumice"),
                new RequiredMaterialsTemplate("a handful of volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new RequiredMaterialsTemplate("a clump of clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new RequiredMaterialsTemplate("a vial of vinegar"),
                new RequiredMaterialsTemplate("two cactus needles"),
                new RequiredMaterialsTemplate("crushed apple seeds"),
                new RequiredMaterialsTemplate( "an apple seed"),
                new RequiredMaterialsTemplate( "tomato seeds"),
                new RequiredMaterialsTemplate( "an alligator tooth"),
                new RequiredMaterialsTemplate( "a lizard claw"),
                new RequiredMaterialsTemplate( "crushed egg shells"),
                new RequiredMaterialsTemplate( "a small wax candle"),
                new RequiredMaterialsTemplate("a piece of charred leather"),
                new RequiredMaterialsTemplate("a bit of charcoal"),
                new RequiredMaterialsTemplate( "ashes from a burned book"),
                new RequiredMaterialsTemplate("a pinch of sawdust"),
                new RequiredMaterialsTemplate("a small cork"),
                new RequiredMaterialsTemplate("two polished, wooden buttons"),
                new RequiredMaterialsTemplate("a few strands of horse hair"),
                new RequiredMaterialsTemplate( "a small comb made from a sea shell"),
                new RequiredMaterialsTemplate("a piece of turtle shell"),
                new RequiredMaterialsTemplate( "pressed flowers, gathered in direct sunlight"),
                new RequiredMaterialsTemplate("ivy flowers"),
                new RequiredMaterialsTemplate("pine needles"),
                new RequiredMaterialsTemplate( "pine sap"),
                new RequiredMaterialsTemplate( "a pinecone"),
                new RequiredMaterialsTemplate( "sand from an anthill"),
                new RequiredMaterialsTemplate("braided blades of grass"),
                new RequiredMaterialsTemplate("a small leather braid"),
                new RequiredMaterialsTemplate("a spool of dark thread"),
                new RequiredMaterialsTemplate("a bit of cobweb"),
                new RequiredMaterialsTemplate("a piece of lace"),
                new RequiredMaterialsTemplate("soap carved into the shape of an acorn"),
                new RequiredMaterialsTemplate("soap carved into the shape of a leaf"),
                new RequiredMaterialsTemplate("soap carved into the shape of a bird"),
                new RequiredMaterialsTemplate("a thimble"),
                new RequiredMaterialsTemplate("powdered paint flakes"),
                new RequiredMaterialsTemplate("a little vial of paint"),
                new RequiredMaterialsTemplate("a scap of blank parchment"),
                new RequiredMaterialsTemplate("a single link of chain"),
                new RequiredMaterialsTemplate("bread crumbs"),
                new RequiredMaterialsTemplate("potato peel"),
                new RequiredMaterialsTemplate("a wooden knife"),
                new RequiredMaterialsTemplate("dice made from bones"),
                new RequiredMaterialsTemplate("powdered feathers"),
                new RequiredMaterialsTemplate("driftwood"),
                new RequiredMaterialsTemplate("seaweed"),
                new RequiredMaterialsTemplate("a little piece of sea glass"),
                new RequiredMaterialsTemplate("petals from flowers gathered at midnight"),
                new RequiredMaterialsTemplate("stems from flowers gathered during a new moon"),
                new RequiredMaterialsTemplate("6 grains of wheat"),
                new RequiredMaterialsTemplate("dehydrated fruit"),
                new RequiredMaterialsTemplate("ground cinnamon"),
                new RequiredMaterialsTemplate("crushed thyme"),
                new RequiredMaterialsTemplate("4 holly berries"),
                new RequiredMaterialsTemplate("root of apple tree"),
                new RequiredMaterialsTemplate("ivy root"),
                new RequiredMaterialsTemplate("maple root"),
                new RequiredMaterialsTemplate("two owl feathers"),
                new RequiredMaterialsTemplate("one hawk tail feather"),
                new RequiredMaterialsTemplate("three dove feathers"),
                new RequiredMaterialsTemplate("a piece of a brick"),
                new RequiredMaterialsTemplate("powdered mortar"),
                new RequiredMaterialsTemplate("a rusted file"),
                new RequiredMaterialsTemplate("copper dust"),
                new RequiredMaterialsTemplate("a mixture of salt and sand"),
                new RequiredMaterialsTemplate("a vial of mud sealed on a full moon"),
                new RequiredMaterialsTemplate("pond scum"),
                new RequiredMaterialsTemplate("nail clippings"),
                new RequiredMaterialsTemplate("a bit of yarn"),
                new RequiredMaterialsTemplate("a cracked animal tooth"),
                new RequiredMaterialsTemplate("lizard skin"),
                new RequiredMaterialsTemplate("snake shedding"),
                new RequiredMaterialsTemplate("sun bleached fabric"),
                new RequiredMaterialsTemplate("a bit of burlap"),
                new RequiredMaterialsTemplate("a wooden candlestick"),
                new RequiredMaterialsTemplate("an ink-soaked acorn"),
                new RequiredMaterialsTemplate("barley root"),
                new RequiredMaterialsTemplate("oat root"),
                new RequiredMaterialsTemplate("wheat root"),
                new RequiredMaterialsTemplate("barley stems"),
                new RequiredMaterialsTemplate("oat leaves and stems"),
                new RequiredMaterialsTemplate("wheat chaff"),
                new RequiredMaterialsTemplate("a fragment of a shepherd's crook"),
                new RequiredMaterialsTemplate("an empty bottle"),
                new RequiredMaterialsTemplate("a small vial of ale"),
                new RequiredMaterialsTemplate("a crushed walnut shell"),
                new RequiredMaterialsTemplate("a whole walnut"),
                new RequiredMaterialsTemplate("walnut root"),
                new RequiredMaterialsTemplate("ink-soaked tree bark"),
                new RequiredMaterialsTemplate("walnut oil"),
                new RequiredMaterialsTemplate("olive oil"),
                new RequiredMaterialsTemplate("olive leaves"),
                new RequiredMaterialsTemplate("birch leaves"),
                new RequiredMaterialsTemplate("elm root"),
                new RequiredMaterialsTemplate("aspen bark"),
                new RequiredMaterialsTemplate("clover root"),
                new RequiredMaterialsTemplate("clover stems"),
                new RequiredMaterialsTemplate("two cherry pits"),
                new RequiredMaterialsTemplate("a knotted piece of rope"),
                new RequiredMaterialsTemplate("a piece of a fence post"),
                new RequiredMaterialsTemplate("brine soaked tree bark"),
                new RequiredMaterialsTemplate("brine soaked ivy root"),
                new RequiredMaterialsTemplate("a rat pelt"),
                new RequiredMaterialsTemplate("salted rat meat"),
                new RequiredMaterialsTemplate("powdered owl pellet"),
                new RequiredMaterialsTemplate("dehydrated owl pellet"),
                new RequiredMaterialsTemplate("a piece of mole pelt"),
                new RequiredMaterialsTemplate("a mole claw"),
                new RequiredMaterialsTemplate("two badger claws"),
                new RequiredMaterialsTemplate("elderberry leaves"),
                new RequiredMaterialsTemplate("azalea root"),
                new RequiredMaterialsTemplate("honeysuckle root"),
                new RequiredMaterialsTemplate("snowberry leaves"),
                new RequiredMaterialsTemplate("a juniper sprig"),
                new RequiredMaterialsTemplate("cedar bark"),
                new RequiredMaterialsTemplate("a willow switch"),
                new RequiredMaterialsTemplate("boxwood leaves"),
                new RequiredMaterialsTemplate("a saltbush twig"),
                new RequiredMaterialsTemplate("a currant twig"),
                new RequiredMaterialsTemplate("currant leaves")
            };
        }
    }
}
