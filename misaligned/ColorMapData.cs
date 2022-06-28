namespace MisalignedSpace
{
    public class ColorMapData
    {
        static string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
        static string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };

        public static int getColorsCount()
        {
            return majorColors.Length;
        }

        public static string getMajorColor(int index)
        {
            return majorColors[index];
        }

        public static string getMinorColor(int index)
        {
            return minorColors[index];
        }
    }
}