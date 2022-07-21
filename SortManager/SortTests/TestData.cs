using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTests
{
    public class TestData
    {
        public static object[] ArraysToTest =
        {
            new object[] { new int[] { 30, 29, 24, 4, 18 }, new int[] { 4, 18, 24, 29, 30 } },
            new object[] { new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } },
            new object[] { new int[] { 66, 21 }, new int[] { 21, 66 } }

        };

        public static object[] NegativeArraysToTest =
        {
            new object[] {new int[] { -1, -10, -9, -12, -50 }, new int[] { -50, -12, -10, -9, -1 } },
            new object[] {new int[] { -4, -2, -5 }, new int[] { -5, -4, -2 } },
            new object[] {new int[] { 0, -10, 32, -5 }, new int[] { -10, -5, 0, 32 } }
        };

        public static object[] OneElementArrayToTest =
        {
            new int[] { 1 },
            new int[] { 1000 },
            new int[] { -12 },
        };

        public static object[] EmptyArrayToTest =
        {
            new int[] {  }
        };

        public static object[] SameNumberArrayToTest =
        {
            new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            new int[] { -40, -40, -40 },
            new int[] { 1000, 1000 },
        };
    }
}
