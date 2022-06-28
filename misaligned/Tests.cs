using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    public class Tests
    {
        const int colorsCount = 5;
        public static void PerformTests()
        {
            TestPrintColorMap();
            TestColorPair();
        }

        static void TestPrintColorMap()
        {
            string expectedString = "";
            for (int i = 0; i < colorsCount; i++)
            {
                for (int j = 0; j < colorsCount; j++)
                {
                    int pairNumber = ColorMap.calculatePairNumber(i, j);
                    string formattedString = ColorMapToStringConverter.formatColorMap(pairNumber, ColorMapData.getMajorColor(i), ColorMapData.getMinorColor(j));
                    expectedString += formattedString + "\n";
                }
            }
            string outputString = ColorMap.getPrintableString();
            Debug.Assert(expectedString.Equals(outputString));
        }

        static void TestColorPair()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int pairNumber = ColorMap.calculatePairNumber(i, j);
                    Debug.Assert(pairNumber == i * colorsCount + j + 1);
                }
            }
        }
    }
}