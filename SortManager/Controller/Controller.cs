
using Controller;
using SortAlgorithms;



namespace SortManagerApp
{
    public enum sortMethods
    {
        BUBBLESORT, MERGESORT, NETSORT
    }
    public class Controller : SortFactory
    {
        public override ISortable GetSortable(int sortMethod)
        {
            sortMethod--;
            switch (sortMethod)
            {
                case (int)sortMethods.BUBBLESORT:
                    return new BubbleSort();
                case (int)sortMethods.MERGESORT:
                    return new MergeSort();
                case (int)sortMethods.NETSORT:
                    return new NetSort();
                default:
                    return new BubbleSort();
            }
        }

        public static int Parse(string? input, int minNum, int maxNum)
        {
            if (input == null) return minNum - 1;
            if (Int32.TryParse(input, out int num))
            {
                if (num < minNum || num > maxNum)
                    return minNum - 1;
            }
            return num;
        }

        public int[] GenerateArray(int len)
        {
            var _unsortedArray = new int[len];

            var random = new Random();
            for (int i = 0; i < len; i++)
                _unsortedArray[i] = random.Next(0, 1000);
            return _unsortedArray;
        }

        public int[] SortArray(int[] input, int sortMethod)
        {
            return GetSortable(sortMethod).Sort(input);
        }

        public string ArrayString(int[] array)
        {
            string result = "";
            foreach (int i in array)
                result += i + " ";
            return result;
        }
    }
}
