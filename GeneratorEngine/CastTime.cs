using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorEngine
{
    public class CastTime
    {
        public CastTimeLength Length;

        public string Description()
        {
            if (Length == CastTimeLength.Reaction)
            {
                //TODO - create subtype for CastTime so that reaction can be more detailed
                return Length.ToString();
            }

            return Length.ToString();
        }
    }
}
