using System;

namespace MisalignedSpace
{
    public class ColorMap
    {
        const string colorPrintFormat = "{0} | {1} | {2}";

        public static int calculatePairNumber(int majorColorIndex, int minorColorIndex)
        {
            return majorColorIndex * 5 + minorColorIndex;
        }

        public static string formatColorMap(int pairNumber, string majorColor, string minorColor)
        {
            return string.Format(colorPrintFormat, pairNumber, majorColor, minorColor);
        }

        public static void print(string value)
        {
            printOnConsole(value);
        }

        public static void printOnConsole(string value)
        {
            Console.WriteLine(value);
        }

        public static int printColorMap()
        {
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    int pairNumber = calculatePairNumber(i, j);
                    string majorColor = ColorMapData.getMajorColor(i);
                    string minorColor = ColorMapData.getMinorColor(i);
                    print(formatColorMap(pairNumber, majorColor, minorColor));
                }
            }
            return i * j;
        }
    }
}