namespace SortManagerApp
{
    public class Controller
    {
        //Main menu:  select sorting algorithm or quit
        //if invalid input:  "invalid input" -> Main menu
        //if valid input:  select number of items in array
        //if invalid number:  "invalid input" -> select number of items in array
        //if valid number:  generate array, stopwatch and run sorting algorithm, return array -> Main
        
        private static int _sortMethod;
        private static int[] _unsortedArray;

        public static void Control()
        {
            while (true)
            {
                //Main menu
                //Given invalid input
                View.MainMenu();
                var input = Console.ReadLine();
                while (input != "1" && input != "2" && input != "3")
                {
                    View.InvalidInput();
                    View.MainMenu();
                    input = Console.ReadLine();
                }

                //Given valid input
                int sortNum = Int32.Parse(input);
                if (sortNum == 3) Environment.Exit(0);
                else if (sortNum == 1)
                    _sortMethod = 1;
                else if (sortNum == 2)
                    _sortMethod = 2;

                //Generate unsorted array
                //Invalid input
                View.InputNumber();
                input = Console.ReadLine();
                bool isNum = Int32.TryParse(input, out int len);
                while (!isNum || len < 0 || len > 1000)
                {
                    View.InvalidInput();
                    View.InputNumber();
                    input = Console.ReadLine();
                }

                //Valid input
                GenerateArray(len);

                //Sort array
                View.UnsortedArray();
                //press enter
                View.SortedArray();
                input = Console.ReadLine();

                //Invalid input
                while (input != "1" && input != "2")
                {
                    View.InvalidInput();
                    input = Console.ReadLine();
                }
                //Valid input
                if (input == "2") Environment.Exit(0);
            }
        }

        public static int[] GenerateArray(int len)
        {
            _unsortedArray = new int[len];

            var random = new Random();
            for (int i = 0; i < len; i++)
                _unsortedArray[i] = random.Next(2, 1000);
            return _unsortedArray;
        }
        
        public static int[] SortArray()
        {
            return SortAlgorithms.MergeSort.Sort(_unsortedArray);
        }
    }
}