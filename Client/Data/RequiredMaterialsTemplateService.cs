﻿using GeneratorEngine;
using GeneratorEngine.Templates;

namespace SpellGenerator.Client.Data
{
    /// <summary>
    /// Service to provide templates for required spell component materials
    /// </summary>
    public class RequiredMaterialsTemplateService : BaseMaterialsTemplateService
    {
        protected override void CreateMaterialTemplates()
        {
            _materialTemplates = new List<TemplatePerSchool>
            {
                new TemplatePerSchool("powdered dragon bone"),
                new TemplatePerSchool("powdered dragon claw"),
                new TemplatePerSchool("powdered dragon scale"),
                new TemplatePerSchool("a fragment of a dragon scale"),
                new TemplatePerSchool("crushed lichen"),
                new TemplatePerSchool("dehydrated moss"),
                new TemplatePerSchool("a handful of shelf mushrooms"),
                new TemplatePerSchool("a full clam shell"),
                new TemplatePerSchool("powdered fish scales"),
                new TemplatePerSchool("powdered fish bones"),
                new TemplatePerSchool("several rodent teeth"),
                new TemplatePerSchool("three small feathers", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),
                new TemplatePerSchool("a tiny ruby worth at least 10 gold pieces"),
                new TemplatePerSchool("a tiny sapphire worth at least 5 gold pieces"),
                new TemplatePerSchool("a tiny emerald worth at least 5 gold pieces"),
                new TemplatePerSchool("a piece of scrap iron"),
                new TemplatePerSchool("a bit of copper ore"),
                new TemplatePerSchool("a bit of iron ore"),
                new TemplatePerSchool("a small piece of granite", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("a small sandstone rock"),
                new TemplatePerSchool("a fragment of limestone", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("bark from an oak tree"),
                new TemplatePerSchool("dried willow leaves"),
                new TemplatePerSchool("an acorn"),
                new TemplatePerSchool("a smooth piece of aspen wood"),
                new TemplatePerSchool("a wooden coin"),
                new TemplatePerSchool("a small piece of ivory"),
                new TemplatePerSchool("a fragment of pottery"),
                new TemplatePerSchool("bone powder", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new TemplatePerSchool("a fragment from a gravestone", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("a tiny bird or rodent skull", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("a tiny vial of tears", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("dried worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("a pinch of ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("a handful of rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("a pinch of graveyard soil", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new TemplatePerSchool("a clump of dried algae"),
                new TemplatePerSchool("crushed sea shells"),
                new TemplatePerSchool("a handful of salt"),
                new TemplatePerSchool("a vial of springwater"),
                new TemplatePerSchool("a vial of pondwater"),
                new TemplatePerSchool("a handful of mud"),
                new TemplatePerSchool("crushed flower stems"),
                new TemplatePerSchool("a tuft of dark fur"),
                new TemplatePerSchool("a square of pale fabric"),
                new TemplatePerSchool("a piece of velvet"),
                new TemplatePerSchool("a fragment of petrified wood"),
                new TemplatePerSchool("a handful of crumbled plaster"),
                new TemplatePerSchool("five grape seeds"),
                new TemplatePerSchool("a vial of oil with a claw in it", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("four pressed three-leaf clovers", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("a fractured cobblestone"),
                new TemplatePerSchool("hard leather in the shape of a leaf"),
                new TemplatePerSchool("an obsidian arrowhead"),
                new TemplatePerSchool("an obsidian marble", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("a small granite marble"),
                new TemplatePerSchool("seven wooden marbles"),
                new TemplatePerSchool("a finger-size piece of quartz"),
                new TemplatePerSchool("a chunk of maple tree root"),
                new TemplatePerSchool("red brick dust"),
                new TemplatePerSchool("a smooth piece of sea glass"),
                new TemplatePerSchool("powdered goat horn"),
                new TemplatePerSchool("a tiny mirror", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("powdered finch feathers"),
                new TemplatePerSchool("eight rose thorns"),
                new TemplatePerSchool("a fragment of pumice"),
                new TemplatePerSchool("a handful of volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("a clump of clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("a vial of vinegar"),
                new TemplatePerSchool("two cactus needles"),
                new TemplatePerSchool("crushed apple seeds"),
                new TemplatePerSchool("an apple seed", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("tomato seeds", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("an alligator tooth"),
                new TemplatePerSchool("a lizard claw"),
                new TemplatePerSchool("crushed egg shells"),
                new TemplatePerSchool("a small wax candle"),
                new TemplatePerSchool("a piece of charred leather"),
                new TemplatePerSchool("a bit of charcoal"),
                new TemplatePerSchool("ashes from a burned book"),
                new TemplatePerSchool("a pinch of sawdust"),
                new TemplatePerSchool("a small cork"),
                new TemplatePerSchool("two polished, wooden buttons"),
                new TemplatePerSchool("a few strands of horse hair"),
                new TemplatePerSchool("a small comb made from a sea shell", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("a piece of turtle shell"),
                new TemplatePerSchool("pressed flowers, gathered in direct sunlight", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("ivy flowers"),
                new TemplatePerSchool("pine needles"),
                new TemplatePerSchool("pine sap"),
                new TemplatePerSchool("a pinecone"),
                new TemplatePerSchool("sand from an anthill"),
                new TemplatePerSchool("braided blades of grass"),
                new TemplatePerSchool("a small leather braid"),
                new TemplatePerSchool("a spool of dark thread"),
                new TemplatePerSchool("a bit of cobweb"),
                new TemplatePerSchool("a piece of lace"),
                new TemplatePerSchool("soap carved into the shape of an acorn", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("soap carved into the shape of a leaf", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("soap carved into the shape of a bird", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("a thimble"),
                new TemplatePerSchool("powdered paint flakes"),
                new TemplatePerSchool("a little vial of paint"),
                new TemplatePerSchool("a scap of blank parchment"),
                new TemplatePerSchool("a single link of chain"),
                new TemplatePerSchool("bread crumbs"),
                new TemplatePerSchool("potato peel"),
                new TemplatePerSchool("a wooden knife"),
                new TemplatePerSchool("dice made from bones", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("powdered feathers"),
                new TemplatePerSchool("driftwood"),
                new TemplatePerSchool("seaweed"),
                new TemplatePerSchool("a little piece of sea glass"),
                new TemplatePerSchool("petals from flowers gathered at midnight", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("stems from flowers gathered during a new moon", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("6 grains of wheat"),
                new TemplatePerSchool("dehydrated fruit"),
                new TemplatePerSchool("ground cinnamon"),
                new TemplatePerSchool("crushed thyme"),
                new TemplatePerSchool("4 holly berries"),
                new TemplatePerSchool("root of apple tree"),
                new TemplatePerSchool("ivy root"),
                new TemplatePerSchool("maple root"),
                new TemplatePerSchool("two owl feathers"),
                new TemplatePerSchool("one hawk tail feather"),
                new TemplatePerSchool("three dove feathers", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("a piece of a brick"),
                new TemplatePerSchool("powdered mortar"),
                new TemplatePerSchool("a rusted file", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("copper dust"),
                new TemplatePerSchool("a mixture of salt and sand"),
                new TemplatePerSchool("a vial of mud sealed on a full moon", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("pond scum"),
                new TemplatePerSchool("nail clippings"),
                new TemplatePerSchool("a bit of yarn"),
                new TemplatePerSchool("a cracked animal tooth", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("lizard skin"),
                new TemplatePerSchool("snake shedding", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("sun bleached fabric"),
                new TemplatePerSchool("a bit of burlap"),
                new TemplatePerSchool("a wooden candlestick"),
                new TemplatePerSchool("an ink-soaked acorn"),
                new TemplatePerSchool("barley root"),
                new TemplatePerSchool("oat root"),
                new TemplatePerSchool("wheat root"),
                new TemplatePerSchool("barley stems"),
                new TemplatePerSchool("oat leaves and stems"),
                new TemplatePerSchool("wheat chaff"),
                new TemplatePerSchool("a fragment of a shepherd's crook"),
                new TemplatePerSchool("an empty bottle"),
                new TemplatePerSchool("a small vial of ale"),
                new TemplatePerSchool("a crushed walnut shell"),
                new TemplatePerSchool("a whole walnut"),
                new TemplatePerSchool("walnut root"),
                new TemplatePerSchool("ink-soaked tree bark"),
                new TemplatePerSchool("walnut oil"),
                new TemplatePerSchool("olive oil"),
                new TemplatePerSchool("olive leaves"),
                new TemplatePerSchool("birch leaves"),
                new TemplatePerSchool("elm root"),
                new TemplatePerSchool("aspen bark"),
                new TemplatePerSchool("clover root"),
                new TemplatePerSchool("clover stems"),
                new TemplatePerSchool("two cherry pits"),
                new TemplatePerSchool("a knotted piece of rope"),
                new TemplatePerSchool("a piece of a fence post"),
                new TemplatePerSchool("brine soaked tree bark"),
                new TemplatePerSchool("brine soaked ivy root"),
                new TemplatePerSchool("a rat pelt"),
                new TemplatePerSchool("salted rat meat"),
                new TemplatePerSchool("powdered owl pellet"),
                new TemplatePerSchool("dehydrated owl pellet"),
                new TemplatePerSchool("a piece of mole pelt"),
                new TemplatePerSchool("a mole claw"),
                new TemplatePerSchool("two badger claws"),
                new TemplatePerSchool("elderberry leaves"),
                new TemplatePerSchool("azalea root"),
                new TemplatePerSchool("honeysuckle root"),
                new TemplatePerSchool("snowberry leaves"),
                new TemplatePerSchool("a juniper sprig"),
                new TemplatePerSchool("cedar bark"),
                new TemplatePerSchool("a willow switch"),
                new TemplatePerSchool("boxwood leaves"),
                new TemplatePerSchool("a saltbush twig"),
                new TemplatePerSchool("a currant twig"),
                new TemplatePerSchool("currant leaves")
            };
        }
    }
}
