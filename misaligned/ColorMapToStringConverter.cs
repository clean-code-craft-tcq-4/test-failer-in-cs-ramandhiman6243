namespace MisalignedSpace
{
    public class ColorMapToStringConverter
    {
        const int pairNumberLength = 2;
        const int majorColorLength = 6;

        const string separator = " | ";

        public static string formatColorMap(int pairNumber, string majorColor, string minorColor)
        {
            string formattedString = pairNumber.ToString();

            formattedString = AddPairNumber(formattedString);
            formattedString = AddMajorColor(majorColor, formattedString);
            formattedString = AddMinorColor(minorColor, formattedString);

            return formattedString;
        }

        private static string AddPairNumber(string targetString)
        {
            for (int i = 0; i < pairNumberLength - targetString.Length; i++)
            {
                targetString += " ";
            }
            targetString += separator;
            return targetString;
        }

        private static string AddMajorColor(string majorColor, string targetString)
        {
            targetString += majorColor;

            for (int i = 0; i < majorColorLength - majorColor.Length; i++)
            {
                targetString += " ";
            }
            targetString += separator;

            return targetString;
        }

        private static string AddMinorColor(string minorColor, string targetString)
        {
            targetString += minorColor;
            return targetString;
        }
    }
}