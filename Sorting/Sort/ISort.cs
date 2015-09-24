using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting.Model;

namespace Sorting.Sort
{
    public interface ISort
    {
        string Name { get; set; }

        void Sort(int[] resultArray);
    }
}
