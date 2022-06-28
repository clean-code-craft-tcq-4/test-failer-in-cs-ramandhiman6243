using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace MisalignedSpace
{
    public class Tests
    {
        public static void PerformTests()
        {
            TestColorPair();
            TestAlignment();
        }

        static void TestColorPair()
        {
            ColorMap.calculatePairNumber(0, 0);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int pairNumber = ColorMap.calculatePairNumber(i, j);
                    Debug.Assert(pairNumber == i * 5 + j + 1);
                }
            }

            Console.WriteLine("All is well (maybe!)");
        }

        static void TestAlignment()
        {
            ColorMap.calculatePairNumber(0, 0);

            List<int> separatorIndices = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int pairNumber = ColorMap.calculatePairNumber(i, j);
                    string formattedString = ColorMap.formatColorMap(pairNumber, ColorMapData.getMajorColor(i), ColorMapData.getMinorColor(j));

                    if (i == 0 && j == 0)
                    {
                        separatorIndices = Utils.GetCharIndicesInString(formattedString, '|');
                    }
                    else
                    {
                        Debug.Assert(Utils.CompareLists(Utils.GetCharIndicesInString(formattedString, '|'), separatorIndices));
                    }
                }
            }

            Console.WriteLine("All is well (maybe!)");
        }
    }
}