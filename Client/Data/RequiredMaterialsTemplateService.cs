﻿using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    /// <summary>
    /// Service to provide templates for required spell component materials
    /// </summary>
    public class RequiredMaterialsTemplateService : BaseMaterialsTemplateService
    {
        protected override void CreateTemplates()
        {
            _templates = new List<MaterialsTemplate>
            {
                new MaterialsTemplate("powdered dragon bone"),
                new MaterialsTemplate("powdered dragon claw"),
                new MaterialsTemplate("powdered dragon scale"),
                new MaterialsTemplate("a fragment of a dragon scale"),
                new MaterialsTemplate("crushed lichen"),
                new MaterialsTemplate("dehydrated moss"),
                new MaterialsTemplate("a handful of shelf mushrooms"),
                new MaterialsTemplate("a full clam shell"),
                new MaterialsTemplate("powdered fish scales"),
                new MaterialsTemplate("powdered fish bones"),
                new MaterialsTemplate("several rodent teeth"),
                new MaterialsTemplate("three small feathers"),
                new MaterialsTemplate("a tiny ruby worth at least 10 gold pieces"),
                new MaterialsTemplate("a tiny sapphire worth at least 5 gold pieces"),
                new MaterialsTemplate("a tiny emerald worth at least 5 gold pieces"),
                new MaterialsTemplate("a piece of scrap iron"),
                new MaterialsTemplate("a bit of copper ore"),
                new MaterialsTemplate("a bit of iron ore"),
                new MaterialsTemplate("a small piece of granite"),
                new MaterialsTemplate("a small sandstone rock"),
                new MaterialsTemplate("a fragment of limestone"),
                new MaterialsTemplate("bark from an oak tree"),
                new MaterialsTemplate("dried willow leaves"),
                new MaterialsTemplate("an acorn"),
                new MaterialsTemplate("a smooth piece of aspen wood"),
                new MaterialsTemplate("a wooden coin"),
                new MaterialsTemplate("a small piece of ivory"),
                new MaterialsTemplate("a fragment of pottery"),
                new MaterialsTemplate("bone powder", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new MaterialsTemplate("a fragment from a gravestone", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("a tiny bird or rodent skull", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("a tiny vial of tears", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("dried worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new MaterialsTemplate("a pinch of ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("a handful of rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new MaterialsTemplate("a pinch of graveyard soil", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new MaterialsTemplate("a clump of dried algae"),
                new MaterialsTemplate("crushed sea shells"),
                new MaterialsTemplate("a handful of salt"),
                new MaterialsTemplate("a vial of springwater"),
                new MaterialsTemplate("a vial of pondwater"),
                new MaterialsTemplate("a handful of mud"),
                new MaterialsTemplate("crushed flower stems"),
                new MaterialsTemplate("a tuft of dark fur"),
                new MaterialsTemplate("a square of pale fabric"),
                new MaterialsTemplate("a piece of velvet"),
                new MaterialsTemplate("a fragment of petrified wood"),
                new MaterialsTemplate("a handful of crumbled plaster"),
                new MaterialsTemplate("five grape seeds"),
                new MaterialsTemplate("a vial of oil with a claw in it"),
                new MaterialsTemplate("four pressed three-leaf clovers"),
                new MaterialsTemplate("a fractured cobblestone"),
                new MaterialsTemplate("hard leather in the shape of a leaf"),
                new MaterialsTemplate("an obsidian arrowhead"),
                new MaterialsTemplate("an obsidian marble", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new MaterialsTemplate("a small granite marble"),
                new MaterialsTemplate( "seven wooden marbles"),
                new MaterialsTemplate( "a finger-size piece of quartz"),
                new MaterialsTemplate("a chunk of maple tree root"),
                new MaterialsTemplate( "red brick dust"),
                new MaterialsTemplate( "a smooth piece of sea glass"),
                new MaterialsTemplate( "powdered goat horn"),
                new MaterialsTemplate("a tiny mirror", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new MaterialsTemplate( "powdered finch feathers"),
                new MaterialsTemplate("eight rose thorns"),
                new MaterialsTemplate("a fragment of pumice"),
                new MaterialsTemplate("a handful of volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("a clump of clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new MaterialsTemplate("a vial of vinegar"),
                new MaterialsTemplate("two cactus needles"),
                new MaterialsTemplate("crushed apple seeds"),
                new MaterialsTemplate( "an apple seed"),
                new MaterialsTemplate( "tomato seeds"),
                new MaterialsTemplate( "an alligator tooth"),
                new MaterialsTemplate( "a lizard claw"),
                new MaterialsTemplate( "crushed egg shells"),
                new MaterialsTemplate( "a small wax candle"),
                new MaterialsTemplate("a piece of charred leather"),
                new MaterialsTemplate("a bit of charcoal"),
                new MaterialsTemplate( "ashes from a burned book"),
                new MaterialsTemplate("a pinch of sawdust"),
                new MaterialsTemplate("a small cork"),
                new MaterialsTemplate("two polished, wooden buttons"),
                new MaterialsTemplate("a few strands of horse hair"),
                new MaterialsTemplate( "a small comb made from a sea shell"),
                new MaterialsTemplate("a piece of turtle shell"),
                new MaterialsTemplate( "pressed flowers, gathered in direct sunlight"),
                new MaterialsTemplate("ivy flowers"),
                new MaterialsTemplate("pine needles"),
                new MaterialsTemplate( "pine sap"),
                new MaterialsTemplate( "a pinecone"),
                new MaterialsTemplate( "sand from an anthill"),
                new MaterialsTemplate("braided blades of grass"),
                new MaterialsTemplate("a small leather braid"),
                new MaterialsTemplate("a spool of dark thread"),
                new MaterialsTemplate("a bit of cobweb"),
                new MaterialsTemplate("a piece of lace"),
                new MaterialsTemplate("soap carved into the shape of an acorn"),
                new MaterialsTemplate("soap carved into the shape of a leaf"),
                new MaterialsTemplate("soap carved into the shape of a bird"),
                new MaterialsTemplate("a thimble"),
                new MaterialsTemplate("powdered paint flakes"),
                new MaterialsTemplate("a little vial of paint"),
                new MaterialsTemplate("a scap of blank parchment"),
                new MaterialsTemplate("a single link of chain"),
                new MaterialsTemplate("bread crumbs"),
                new MaterialsTemplate("potato peel"),
                new MaterialsTemplate("a wooden knife"),
                new MaterialsTemplate("dice made from bones"),
                new MaterialsTemplate("powdered feathers"),
                new MaterialsTemplate("driftwood"),
                new MaterialsTemplate("seaweed"),
                new MaterialsTemplate("a little piece of sea glass"),
                new MaterialsTemplate("petals from flowers gathered at midnight"),
                new MaterialsTemplate("stems from flowers gathered during a new moon"),
                new MaterialsTemplate("6 grains of wheat"),
                new MaterialsTemplate("dehydrated fruit"),
                new MaterialsTemplate("ground cinnamon"),
                new MaterialsTemplate("crushed thyme"),
                new MaterialsTemplate("4 holly berries"),
                new MaterialsTemplate("root of apple tree"),
                new MaterialsTemplate("ivy root"),
                new MaterialsTemplate("maple root"),
                new MaterialsTemplate("two owl feathers"),
                new MaterialsTemplate("one hawk tail feather"),
                new MaterialsTemplate("three dove feathers"),
                new MaterialsTemplate("a piece of a brick"),
                new MaterialsTemplate("powdered mortar"),
                new MaterialsTemplate("a rusted file"),
                new MaterialsTemplate("copper dust"),
                new MaterialsTemplate("a mixture of salt and sand"),
                new MaterialsTemplate("a vial of mud sealed on a full moon"),
                new MaterialsTemplate("pond scum"),
                new MaterialsTemplate("nail clippings"),
                new MaterialsTemplate("a bit of yarn"),
                new MaterialsTemplate("a cracked animal tooth"),
                new MaterialsTemplate("lizard skin"),
                new MaterialsTemplate("snake shedding"),
                new MaterialsTemplate("sun bleached fabric"),
                new MaterialsTemplate("a bit of burlap"),
                new MaterialsTemplate("a wooden candlestick"),
                new MaterialsTemplate("an ink-soaked acorn"),
                new MaterialsTemplate("barley root"),
                new MaterialsTemplate("oat root"),
                new MaterialsTemplate("wheat root"),
                new MaterialsTemplate("barley stems"),
                new MaterialsTemplate("oat leaves and stems"),
                new MaterialsTemplate("wheat chaff"),
                new MaterialsTemplate("a fragment of a shepherd's crook"),
                new MaterialsTemplate("an empty bottle"),
                new MaterialsTemplate("a small vial of ale"),
                new MaterialsTemplate("a crushed walnut shell"),
                new MaterialsTemplate("a whole walnut"),
                new MaterialsTemplate("walnut root"),
                new MaterialsTemplate("ink-soaked tree bark"),
                new MaterialsTemplate("walnut oil"),
                new MaterialsTemplate("olive oil"),
                new MaterialsTemplate("olive leaves"),
                new MaterialsTemplate("birch leaves"),
                new MaterialsTemplate("elm root"),
                new MaterialsTemplate("aspen bark"),
                new MaterialsTemplate("clover root"),
                new MaterialsTemplate("clover stems"),
                new MaterialsTemplate("two cherry pits"),
                new MaterialsTemplate("a knotted piece of rope"),
                new MaterialsTemplate("a piece of a fence post"),
                new MaterialsTemplate("brine soaked tree bark"),
                new MaterialsTemplate("brine soaked ivy root"),
                new MaterialsTemplate("a rat pelt"),
                new MaterialsTemplate("salted rat meat"),
                new MaterialsTemplate("powdered owl pellet"),
                new MaterialsTemplate("dehydrated owl pellet"),
                new MaterialsTemplate("a piece of mole pelt"),
                new MaterialsTemplate("a mole claw"),
                new MaterialsTemplate("two badger claws"),
                new MaterialsTemplate("elderberry leaves"),
                new MaterialsTemplate("azalea root"),
                new MaterialsTemplate("honeysuckle root"),
                new MaterialsTemplate("snowberry leaves"),
                new MaterialsTemplate("a juniper sprig"),
                new MaterialsTemplate("cedar bark"),
                new MaterialsTemplate("a willow switch"),
                new MaterialsTemplate("boxwood leaves"),
                new MaterialsTemplate("a saltbush twig"),
                new MaterialsTemplate("a currant twig"),
                new MaterialsTemplate("currant leaves")
            };
        }
    }
}
