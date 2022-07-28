using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class DebuffEffect : EffectBase
    {
        public AttackOrSavingThrow AttackOrSaveWhenCast;
        SavingThrowType? SavingThrowType;
        bool CannotEndEffectEarly;//When true, increase impact of duration modifier
        
    }
}
