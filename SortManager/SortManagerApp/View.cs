namespace SortManagerApp
{
    public class View
    {
        public static string Seperator = "--------------------------------------------";
        
        static void Main(string[] args)
        {
            Controller.Control();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Please select sorting algorithms:");
            Console.WriteLine("[1] Bubble Sort");
            Console.WriteLine("[2] Merge Sort");
            Console.WriteLine("[3] .Net Sort");
            Console.WriteLine("[4] Exit");
            Console.WriteLine();
        }

        public static void InvalidInput()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input");
            Console.WriteLine();
            Console.WriteLine(Seperator);
            Console.WriteLine();
        }

        public static void InputNumber()
        {
            Console.WriteLine();
            Console.WriteLine(Seperator);
            Console.WriteLine("Please enter the size of the array from 0 to 20");
        }

        //public static void UnsortedArray()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine(Seperator);
        //    Console.WriteLine("Array generated: 1, 2, 3");
        //    Console.WriteLine("Press <enter> to sort array");
        //}

        public static void SortedArray(int input)
        {
            Console.WriteLine();
            Console.WriteLine(Seperator);
            var array = Controller.GenerateArray(input);
            Console.WriteLine();
            Console.WriteLine(array);
            Console.WriteLine();
            Console.WriteLine(Controller.SortArray(array));
            Console.WriteLine();
            Console.WriteLine($"Time taken: {Controller.StopWatch()}");
            Console.WriteLine();
            Console.WriteLine("[1] Back to main menu");
            Console.WriteLine("[2] Exit");
        }
    }
}