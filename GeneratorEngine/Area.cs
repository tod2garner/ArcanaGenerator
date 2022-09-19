using System;

namespace GeneratorEngine
{
    public class Area
    {
        public AreaOfEffectShape Shape;
        public double Size;

        private double CalculateSquareFeet()
        {
            switch (Shape)
            {
                case AreaOfEffectShape.Line:
                    return 5 * Size;
                case AreaOfEffectShape.Square:
                case AreaOfEffectShape.Cube:
                    return Size * Size;
                case AreaOfEffectShape.Sphere:
                case AreaOfEffectShape.Cylinder:
                    return Math.PI * Size * Size;
                case AreaOfEffectShape.Cone:
                    return Math.Sqrt(3) / 4 * Size * Size;
            }

            return 1;
        }

        public double GetLikelyNumberOfTargets()
        {
            var numberOfSquares = CalculateSquareFeet() / 25.0;
            return Math.Max(1,numberOfSquares / 7);//using 7 as an arbitrary estimate             
        }
    }
}
