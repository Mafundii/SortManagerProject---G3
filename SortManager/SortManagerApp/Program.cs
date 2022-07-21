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
        public static string Seperator = "------------------------------------------------------------------------------------------";

        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
                var option = Console.ReadLine();
                var parsedOption = Controller.ParseOption(option);
                while (parsedOption == 0)
                {
                    InvalidInput();
                    MainMenu();
                    option = Console.ReadLine();
                    parsedOption = Controller.ParseOption(option);
                }
                if (parsedOption == 4) return;

                RequestLen();
                var len = Console.ReadLine();
                var parsedLen = Controller.ParseLen(len);
                while (parsedLen == -1)
                {
                    InvalidInput();
                    RequestLen();
                    len = Console.ReadLine();
                    parsedLen = Controller.ParseLen(len);
                }
                
                DisplaySorted(parsedOption, parsedLen);
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("Please select sorting algorithms:\n" +
                "[1] Bubble Sort\n" +
                "[2] Merge Sort\n" +
                "[3] .NET Sort\n" +
                "[4] Exit\n");
        }
        public static void InvalidInput()
        {
            Console.WriteLine($"\nInvalid input\n\n{Seperator}\n");
        }
        public static void RequestLen()
        {
            Console.WriteLine($"\n{Seperator}\n\nPlease enter the size of the array from 0 to 20:\n");
        }
        public static void DisplaySorted(int option, int len)
        {
            var array = Controller.GenerateArray(len);

            Console.WriteLine($"\n{Seperator}\n");
            Console.WriteLine($"Array generated: {Controller.ArrayString(array)}");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var sortedArray = Controller.SortArray(array, option);

            stopwatch.Stop();

            Console.WriteLine($"Sorted array: {Controller.ArrayString(sortedArray)}");
            Console.WriteLine($"Sort method: {Controller.SortMethod}");
            Console.WriteLine($"Time taken: {Math.Round(stopwatch.Elapsed.TotalMilliseconds,1)} ms\n\n{Seperator}\n");
        }
    }
}

