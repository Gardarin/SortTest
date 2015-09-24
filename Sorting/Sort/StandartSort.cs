using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sort
{
    class StandartSort:ISort
    {
        public string Name
        {
            get
            {
                return "12312";
            }
            set
            {
                
            }
        }

        public void Sort(int[] resultArray)
        {
            Array.Sort(resultArray);
        }
    }
}
