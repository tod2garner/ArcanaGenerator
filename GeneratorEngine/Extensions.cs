using System;
using System.Globalization;

namespace GeneratorEngine
{
    internal static class Extensions
    {
        /// <summary>
        /// Rounds the given value to the given tolerance.
        /// </summary>
        /// <example>
        /// 23.RoundToNearest(5) = 25
        /// 23.RoundToNearest(10) = 20
        /// </example>
        public static double RoundToNearest(this double valueToRound, double tolerance) => Math.Round(valueToRound / tolerance) * tolerance;

        /// <summary>
        /// Capitalizes the first letter of each word in the string (except 'of')
        /// </summary>
        public static string ToTitleCase(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Replace("Of", "of");
        }

        public static string ToUpperFirstCharOnly(this string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}
