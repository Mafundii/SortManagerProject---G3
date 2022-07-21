using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class NetSort
    {
        public static int[] NetSorting(int[] array)
        {
            List<int> sortList = new List<int>();
            foreach (int i in array)
            {
                sortList.Add(i);
            }
            sortList.Sort();
            return sortList.ToArray();
        }
    }
}
