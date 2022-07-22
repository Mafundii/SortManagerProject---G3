using SortAlgorithms;

namespace SortManagerApp
{
    public class Controller
    {
        public static string SortMethod { get; set; }
        public static int[] ArrayGenerated { get; set; }

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

        public static int ParseOption2(string? option)
        {
            if (option == null) return 0;
            if (Int32.TryParse(option, out int num))
            {
                if (num < 1 || num > 5)
                    return 0;
            }
            return num;
        }
        public static int[] GenerateArray(int len)
        {
            ArrayGenerated = new int[len];

            var random = new Random();
            for (int i = 0; i < len; i++)
                ArrayGenerated[i] = random.Next(0, 1000);
            return ArrayGenerated;
        }
        public static int[] SortArray(int[] array, int option)
        {
            var newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = array[i];
            switch (option)
            {
                case 1:
                    SortMethod = SortAlgorithms.BubbleSort.Name;
                    return SortAlgorithms.BubbleSort.BubbleSorting(newArray);
                case 2:
                    SortMethod = SortAlgorithms.MergeSort.Name;
                    return SortAlgorithms.MergeSort.MergeSorting(newArray);
                case 3:
                    SortMethod = SortAlgorithms.NetSort.Name;
                    return SortAlgorithms.NetSort.NetSorting(newArray);
                default:
                    return newArray;
            }
        }  
        public static string ArrayString(int[] sortedArray)
        {
            return String.Join(", ", sortedArray);
        }
    }
}
