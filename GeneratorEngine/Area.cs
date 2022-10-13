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

        private double GetLikelyNumberOfTargets()
        {
            var numberOfSquares = CalculateSquareFeet() / 25.0;
            return Math.Max(1, numberOfSquares / 5);//using 5 as an arbitrary estimate             
        }

        public double GetPowerRatingFactor()
        {
            var targets = GetLikelyNumberOfTargets();
            //Cap power rating for large numbers of targets because in combat if there are >2 enemies most will be minions that are less important
            var factor = 1.5 * Math.Log(targets) + 1;//Diminishing returns after 2 targets
            return Math.Min(factor, 5);
        }
    }
}
