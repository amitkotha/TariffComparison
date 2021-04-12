using System;

namespace TariffComparison
{
    public static class InputValidator
    {
        public static bool IsNumeric(this string text)
        {
            double retNum;

            bool isNum = Double.TryParse(text, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
}
