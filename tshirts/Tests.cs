using System.Diagnostics;

namespace TshirtSpace
{
    public class Tests
    {
        public static void PerformTests()
        {
            Debug.Assert(SizeChart.GetSize(37) == "S");
            Debug.Assert(SizeChart.GetSize(38) == "S");
            Debug.Assert(SizeChart.GetSize(40) == "M");
            Debug.Assert(SizeChart.GetSize(43) == "L");
        }
    }
}
