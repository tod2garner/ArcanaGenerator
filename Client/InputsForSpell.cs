using GeneratorEngine;

namespace SpellGenerator.Client
{
    public class InputsForSpell
    {
        public EffectType? EffectType;
        public SchoolOfMagic SchoolOfMagic;
        public PowerLevel PowerLevel;
        public bool IncludeSideEffects;

        public InputsForSpell()
        {
            EffectType = null;
            SchoolOfMagic = SchoolOfMagic.Any;
            PowerLevel = PowerLevel.Random;
            IncludeSideEffects = true;
        }
    }
}
