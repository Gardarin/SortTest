using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Sort
{
    class BubbleSort:ISort
    {
        public void Sort(int[] resultArray)
        {
            int n=resultArray.Length;
            int value = 0;
            for(int i=0;i<n;++i)
            {
                for (int j = 0; j < n-1-i; ++j)
                {
                    if (resultArray[j] > resultArray[j+1])
                    {
                        value = resultArray[j];
                        resultArray[j] = resultArray[j+1];
                        resultArray[j+1] = value;
                    }
                }
            }
        }
    }
}
