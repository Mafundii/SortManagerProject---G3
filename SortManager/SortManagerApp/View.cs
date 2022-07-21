namespace SortManagerApp
{
    public class View
    {
        static void Main(string[] args)
        {
            Controller.Control();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Please select sorting algorithms:");
            Console.WriteLine("[1] Bubble Sort");
            Console.WriteLine("[2] Merge Sort");
            Console.WriteLine("[3] Exit");
            Console.WriteLine();
        }

        public static void InvalidInput()
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }

        public static void InputNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the size of the array from 2 to 1,000");
        }

        public static void UnsortedArray()
        {
            Console.WriteLine();
            Console.WriteLine("Array generated: 1, 2, 3");
            Console.WriteLine("Press <enter> to sort array");
        }

        public static void SortedArray()
        {
            Console.WriteLine();
            Console.WriteLine("Array sorted: 1, 2, 3");
            Console.WriteLine("Time taken: 1 second");
            Console.WriteLine("[1] Back to main menu");
            Console.WriteLine("[2] Exit");
        }
    }
}