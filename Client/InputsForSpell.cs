using GeneratorEngine;

namespace SpellGenerator.Client
{
    public class InputsForSpell
    {
        public string EffectType;
        public SchoolOfMagic SchoolOfMagic;
        public PowerLevel PowerLevel;
        public bool IncludeSideEffects;//TODO - turn penalty effects on/off
    }
}
