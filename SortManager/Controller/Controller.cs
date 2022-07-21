using SortAlgorithms;

namespace SortManagerApp
{
    public class Controller
    {
        public static string SortMethod { get; set; }
        public static int ParseOption(string? option)
        {
            if (option == null) return 0;
            if (Int32.TryParse(option, out int num))
            {
                if (num < 1 || num > 4)
                    return 0;
            }
            return num;
        }
        public static int ParseLen(string? len)
        {
            if (len == null) return -1;
            if (Int32.TryParse(len, out int num))
            {
                if (num < 0 || num > 20)
                    return -1;
            }
            return num;
        }
        public static int[] GenerateArray(int len)
        {
            var _unsortedArray = new int[len];

            var random = new Random();
            for (int i = 0; i < len; i++)
                _unsortedArray[i] = random.Next(0, 1000);
            return _unsortedArray;
        }
        public static int[] SortArray(int[] array, int option)
        {
            switch (option)
            {
                case 1:
                    SortMethod = SortAlgorithms.BubbleSort.Name;
                    return SortAlgorithms.BubbleSort.BubbleSorting(array);
                case 2:
                    SortMethod = SortAlgorithms.MergeSort.Name;
                    return SortAlgorithms.MergeSort.MergeSorting(array);
                case 3:
                    SortMethod = SortAlgorithms.NetSort.Name;
                    return SortAlgorithms.NetSort.NetSorting(array);
                default:
                    return array;
            }
        }
        public static string ArrayString(int[] sortedArray)
        {
            return String.Join(", ", sortedArray);
        }
    }
}
