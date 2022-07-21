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
                    parsedSort = Controller.ParseSortMethod(input);
                }
                if (parsedSort == 4) return;

                InputNumber();
                var input2 = Console.ReadLine();
                var parsedLen = Controller.ParseLen(input2);
                while (parsedLen == -1)
                {
                    InvalidInput();
                    InputNumber();
                    input2 = Console.ReadLine();
                    parsedLen = Controller.ParseLen(input2);
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
                "[4] Exit");
        }

        public static void InvalidInput()
        {
            Console.WriteLine($"\nInvalid input{Seperator}\n");
        }

        public static void InputNumber()
        {
            Console.WriteLine($"{Seperator}\nPlease enter the size of the array from 0 to 20: ");
        }

        public static void DisplaySorted(int sort, int len)
        {
            Console.WriteLine($"{Seperator}");
            var array = Controller.GenerateArray(len);
            Console.WriteLine($"Array generated: {Controller.ArrayString(array)}");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var sortedArray = Controller.SortArray(array, sort);

            stopwatch.Stop();

            Console.WriteLine($"Sorted array: {Controller.ArrayString(sortedArray)}");

            Console.WriteLine($"Time taken: {stopwatch.Elapsed}\n{Seperator}\n");
        }
    }
}

