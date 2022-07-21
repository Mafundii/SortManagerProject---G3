using SortAlgorithms;

namespace SortManagerApp
{
    public class Controller
    {
        //Main menu:  select sorting algorithm or quit
        //if invalid input:  "invalid input" -> Main menu
        //if valid input:  select number of items in array
        //if invalid number:  "invalid input" -> select number of items in array
        //if valid number:  generate array, stopwatch and run sorting algorithm, return array -> Main

        
        public static int ParseSortMethod(string? input)
        {
            if (input == null) return 0;
            if (Int32.TryParse(input, out int num))
            {
                if (num < 1 || num > 4)
                    return 0;
            }
            return num;
        }

        public static int ParseLen(string? input)
        {
            if (input == null) return -1;
            if (Int32.TryParse(input, out int num))
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

        public static int[] SortArray(int[] input, int sortMethod)
        {
            switch (sortMethod)
            {
                case 1:
                    return SortAlgorithms.BubbleSort.BubbleSorting(input);
                case 2:
                    return SortAlgorithms.MergeSort.MergeSorting(input);
                case 3:
                    return SortAlgorithms.NetSort.NetSorting(input);
                default:
                    return input;
            }
        }

        public static string ArrayString(int[] array)
        {
            string result = "";
            foreach (int i in array)
                result += i + " ";
            return result;
        }
    }
}
