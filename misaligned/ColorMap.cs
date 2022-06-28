using System;

namespace MisalignedSpace
{
    public class ColorMap
    {
        public static int calculatePairNumber(int majorColorIndex, int minorColorIndex)
        {
            return majorColorIndex * ColorMapData.getColorsCount() + minorColorIndex + 1;
        }

        static void printColorMap(string value)
        {
            Console.WriteLine(value);
        }

        public static string getPrintableString()
        {
            string outputString = "";
            int i = 0, j = 0;
            for (i = 0; i < ColorMapData.getColorsCount(); i++)
            {
                for (j = 0; j < ColorMapData.getColorsCount(); j++)
                {
                    int pairNumber = calculatePairNumber(i, j);
                    string majorColor = ColorMapData.getMajorColor(i);
                    string minorColor = ColorMapData.getMinorColor(j);
                    outputString += ColorMapToStringConverter.formatColorMap(pairNumber, majorColor, minorColor) + "\n";
                }
            }
            printColorMap(outputString);
            return outputString;
        }
    }
}