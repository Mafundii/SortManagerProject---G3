using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithms;

namespace Controller
{
    public abstract class SortFactory
    {
        public abstract ISortable GetSortable(int sortMethod);
    }
}
