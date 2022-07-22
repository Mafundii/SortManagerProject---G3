using Controller;
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
        public static string Seperator = "-------------------------------------------------";

        static void Main(string[] args)
        {
            while(true)
            {
                var sortMethod = MainMenu();
                if (sortMethod == 4) return;
                var arrayLength = InputNumber();
                DisplaySorted(sortMethod, arrayLength);
            }
        }

        public static int MainMenu()
        {
            Console.WriteLine("Please select sorting algorithms:\n" +
                "[1] Bubble Sort\n" +
                "[2] Merge Sort\n" +
                "[3] .Net Sort\n" +
                "[4] Exit");

            var input = Console.ReadLine();
            var parsedSort = Controller.Parse(input, 1, 4);
            while (parsedSort == 0)
            {
                InvalidInput();
                MainMenu();
                input = Console.ReadLine();
                parsedSort = Controller.Parse(input, 1, 4);
            }
            return parsedSort;
        }

        public static void InvalidInput()
        {
            Console.WriteLine($"\nInvalid input{Seperator}\n");
        }

        public static int InputNumber()
        {
            Console.WriteLine($"{Seperator}\nPlease enter the size of the array from 0 to 20: ");
            var input = Console.ReadLine();
            var parsedLen = Controller.Parse(input, 0, 20);
            while (parsedLen == -1)
            {
                InvalidInput();
                InputNumber();
                input = Console.ReadLine();
                parsedLen = Controller.Parse(input, 0, 20);
            }
            return parsedLen;
        }

        public static void DisplaySorted(int sort, int len)
        {
            Controller sorter = new Controller();
            Console.WriteLine($"{Seperator}");
            var array = sorter.GenerateArray(len);
            Console.WriteLine($"Array generated: {sorter.ArrayString(array)}");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var sortedArray = sorter.SortArray(array, sort);

            stopwatch.Stop();

            Console.WriteLine($"Sorted array: {sorter.ArrayString(sortedArray)}");

            Console.WriteLine($"Time taken: {stopwatch.Elapsed}\n{Seperator}\n");
        }
    }
}

