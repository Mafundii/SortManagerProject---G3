using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class NetSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
