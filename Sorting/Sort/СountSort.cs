using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sort
{
    public class СountSort:ISort
    {
        public void Sort(int[] resultArray)
        {
            int[] arrayCount = new int[resultArray.Length];
            for(int i=0;i<resultArray.Length;++i)
            {
                ++arrayCount[resultArray[i]];
            }
            int j=0;
            for (int i = 0; i < resultArray.Length; )
            {
                if (arrayCount[j] != 0)
                {
                    resultArray[i] = j;
                    ++i;
                    --arrayCount[j];
                }
                else
                {
                    ++j;
                }
            }
        }
    }
}
