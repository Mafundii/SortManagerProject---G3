using System;
namespace SortAlgorithms
{
    public class BubbleSort
    {
        public static int[] BubbleSorting(int[] intArray)
        {
            if (intArray.Length == 0 || intArray == null)
                return intArray;

            for (int j = 0; j < intArray.Length - 1; j++)
            {
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        (intArray[i + 1], intArray[i]) = (intArray[i], intArray[i + 1]); // hold the larger vakue in the temp holder
                    }
                }
            }
            return intArray;
        }
    }
}

