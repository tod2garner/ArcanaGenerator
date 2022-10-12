namespace GeneratorEngine
{
    public class CastTime
    {
        public CastTimeLength Length;
        public string Conditions;

        public string Description()
        {
            if (!string.IsNullOrEmpty(Conditions))
            {
                return $"{Length} - {Conditions}";
            }

            return Length.ToString();
        }
    }
}
