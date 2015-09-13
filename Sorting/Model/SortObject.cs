using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting.Sort;

namespace Sorting.Model
{
    public class SortObject
    {
        private ISort Sort;
        private int Interval;
        public bool SortIsValid;
        public bool IsComplete;
        public int[] OriginalArray { get; set; }
        public int[] ControlArray { get; set; }
        public int[] ResultArray { get; private set; }
        public int PerformancePoints { get; private set; }

        public SortObject(ISort sort, int interval)
        {
            Sort = sort;
            Interval = interval;
            OriginalArray = new int[0];
            ControlArray = new int[0];
            ResultArray = new int[0];
            IsComplete = false;
        }

        public void SetArrays(int[] originalArray,int[] controlArray)
        {
            OriginalArray = originalArray;
            ControlArray = controlArray;
        }

        public void StartSort()
        {
            SortIsValid = false;
            PerformancePoints = 0;
            DateTime StartTime = DateTime.Now;
            TimeSpan t = new TimeSpan(0, 0, Interval, 0, 0);
            while (DateTime.Now - StartTime < t)
            {
                ResultArray = new int[OriginalArray.Length];
                OriginalArray.CopyTo(ResultArray, 0);

                Sort.Sort(ResultArray);
                PerformancePoints++;
            }
            SortIsValid = CompareArrays();
            IsComplete = true;
        }

        private bool CompareArrays()
        {
            for (int i = 0; i < ControlArray.Length; ++i)
            {
                if (ResultArray[i] != ControlArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
