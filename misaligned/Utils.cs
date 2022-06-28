using System.Collections.Generic;

namespace MisalignedSpace
{
    public class Utils
    {
        public static List<int> GetCharIndicesInString(string inputString, char charToFind)
        {
            List<int> indices = new List<int>();
            char[] charArray = inputString.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].Equals(charToFind))
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public static bool CompareLists(List<int> list1, List<int> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}