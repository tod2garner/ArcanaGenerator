using GeneratorEngine;

namespace SpellGenerator.Client
{
    public class InputsForSpell
    {
        public string EffectType;
        public SchoolOfMagic SchoolOfMagic;
        public PowerLevel PowerLevel;
        public bool IncludeSideEffects;

        public InputsForSpell()
        {
            EffectType = "Any";
            SchoolOfMagic = SchoolOfMagic.Any;
            PowerLevel = PowerLevel.Random;
            IncludeSideEffects = true;
        }
    }
}
