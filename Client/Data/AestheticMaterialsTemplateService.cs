﻿using GeneratorEngine.Templates;
using GeneratorEngine;

namespace SpellGenerator.Client.Data
{
    public class AestheticMaterialsTemplateService : BaseMaterialsTemplateService
    {
        protected override void CreateTemplates()
        {
            _templates = new List<TemplatePerSchool>
            {
                new TemplatePerSchool("bones", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Divination }),
                new TemplatePerSchool("animal claws", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("reptile scales", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("sea shells", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("animal teeth", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Divination }),
                new TemplatePerSchool("feathers", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation, SchoolOfMagic.Divination, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("fur", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("cobwebs", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("egg shells", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("worms", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("insects", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("spiders", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("scorpions", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("snakes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy }),

                new TemplatePerSchool("water", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("liquid"),
                new TemplatePerSchool("foam", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("viscous liquid", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("energy", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),                
                new TemplatePerSchool("lightning", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("flames"),//--remove and move to adjectives?
                new TemplatePerSchool("embers"),
                new TemplatePerSchool("sparks", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("ice", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("snow", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("mist", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("smoke", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("shadows", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("lava", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),

                new TemplatePerSchool("ruby", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("sapphire", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("gold", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("silver", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Enchantment, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("emerald", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("ivory", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),

                new TemplatePerSchool("metal"),
                new TemplatePerSchool("iron", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("steel", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("copper", new List<SchoolOfMagic> { SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("chains", new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("lead", new List<SchoolOfMagic> { SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),

                new TemplatePerSchool("stone", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("soil", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("dirt", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("dust", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("sand", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("granite", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("sandstone", new List<SchoolOfMagic>{ SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("limestone", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("gravel", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("pebbles", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("obsidian", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Illusion, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("quartz", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("pumice", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("glass", new List<SchoolOfMagic>{ SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment, SchoolOfMagic.Divination }),
                new TemplatePerSchool("clay", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("salt", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("coal", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("charcoal", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("ashes", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("volcanic ash", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Necromancy, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("rust", new List<SchoolOfMagic>{ SchoolOfMagic.Necromancy, SchoolOfMagic.Transmutation }),

                new TemplatePerSchool("wood", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("tree bark", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("leaves and vines", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("branches", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Evocation, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("thorns", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("cactus needles", new List < SchoolOfMagic > { SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("ivy", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Evocation, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("pine needles", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("sap", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("grass", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("roots", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("seaweed", new List<SchoolOfMagic>{ SchoolOfMagic.Evocation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("petals", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("algae", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("flowers", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("lichen", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("moss", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("fungus", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),

                new TemplatePerSchool("fabric", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("plaster", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("oil"),
                new TemplatePerSchool("grease", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation }),
                new TemplatePerSchool("coins", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination }),
                new TemplatePerSchool("pottery", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("leather", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("brick", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("mirrors", new List<SchoolOfMagic>{ SchoolOfMagic.Divination, SchoolOfMagic.Illusion, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("vinegar", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("wax", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("books", new List < SchoolOfMagic > { SchoolOfMagic.Divination, SchoolOfMagic.Conjuration, SchoolOfMagic.Abjuration }),
                new TemplatePerSchool("buttons", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("thread", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("sawdust", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("lace", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("soap", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("paint", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("parchment", new List < SchoolOfMagic > { SchoolOfMagic.Divination, SchoolOfMagic.Conjuration }),
                new TemplatePerSchool("liquor", new List<SchoolOfMagic>{ SchoolOfMagic.Transmutation, SchoolOfMagic.Divination, SchoolOfMagic.Evocation }),
                new TemplatePerSchool("rope", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Enchantment }),
                new TemplatePerSchool("bubbles", new List<SchoolOfMagic>{ SchoolOfMagic.Enchantment, SchoolOfMagic.Abjuration, SchoolOfMagic.Illusion }),
                new TemplatePerSchool("ink", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Divination, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("tar", new List<SchoolOfMagic>{ SchoolOfMagic.Conjuration, SchoolOfMagic.Transmutation, SchoolOfMagic.Necromancy }),
                new TemplatePerSchool("letters", new List<SchoolOfMagic>{ SchoolOfMagic.Divination }),
                new TemplatePerSchool("runes"),
            };
        }
    }

}
