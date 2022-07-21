using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class View
    {
        public static string Seperator = "--------------------------------------------";

        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
                var input = Console.ReadLine();
                var parsedSort = Controller.ParseSortMethod(input);
                while (parsedSort == 0)
                {
                    InvalidInput();
                    MainMenu();
                    input = Console.ReadLine();
                }

                InputNumber();
                var input2 = Console.ReadLine();
                var parsedLen = Controller.ParseLen(input2);
                while (parsedLen == -1)
                {
                    InvalidInput();
                    InputNumber();
                    input2 = Console.ReadLine();
                }

                DisplaySorted(parsedSort, parsedLen);



            }
        }

        public static void MainMenu()
        {
            Console.WriteLine("Please select sorting algorithms:\n" +
                "[1] Bubble Sort\n" +
                "[2] Merge Sort\n" +
                "[3] .Net Sort\n" +
                "[4] Exit\n");
        }

        public static void InvalidInput()
        {
            Console.WriteLine();
            Console.WriteLine("\nInvalid input\n" +
                Seperator);
        }

        public static void InputNumber()
        {
            Console.WriteLine("\n" + Seperator +
                "\nPlease enter the size of the array from 0 to 20\n");
        }

        public static void DisplaySorted(int sort, int len)
        {
            Console.WriteLine($"\n {Seperator}");
            var array = Controller.GenerateArray(len);
            Console.WriteLine(Controller.ArrayString(array));

            Console.WriteLine($"\n {Seperator}");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var sortedArray = Controller.SortArray(array, sort);

            stopwatch.Stop();

            Console.WriteLine(Controller.ArrayString(sortedArray));

            Console.WriteLine($"Time taken: {stopwatch.Elapsed}");
        }
    }
}

