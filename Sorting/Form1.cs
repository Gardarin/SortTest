using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorting.Model;
using Sorting.Sort;
using System.Threading;

namespace Sorting
{
    public partial class Form1 : Form
    {
        int[] Mas;
        int[] ControlArray;
        List<SortObject> SortObjects;
        private ManualResetEvent waitHandle;
        List<Thread> SortThreads;
        int ThreadWork;
        int MaxThreadWork;

        public Form1()
        {
            InitializeComponent();
            SortObjects = new List<SortObject>();
            BubbleSort BubbleSorting = new BubbleSort();
            SortObjects.Add(new SortObject(BubbleSorting, 1));

            ThreadWork = 0;
            MaxThreadWork = 1;

            Sort.СountSort CountSorting = new Sort.СountSort();
            SortObjects.Add(new SortObject(CountSorting, 1));
            waitHandle = new ManualResetEvent(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mas = new int[1000];
            ControlArray = new int[1000];
            Random r = new Random();
            for (int i = 0; i < Mas.Length; ++i)
            {
                Mas[i] = r.Next(100);
            }
            Mas.CopyTo(ControlArray, 0);
            Array.Sort(ControlArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Mas != null)
            {
                SortThreads = new List<Thread>();
                foreach (SortObject sortObject in SortObjects)
                {
                    sortObject.SetArrays(Mas, ControlArray);
                    SortThreads.Add(new Thread(sortObject.StartSort));
                }
               
                

                timer1.Start();
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            List<SortView> ls=new List<SortView>();
            int k = 0;
            foreach (SortObject sortObject in SortObjects)
            {
                if (sortObject.IsComplete)
                {
                    k++;
                    ls.Add(new SortView());
                    ls[ls.Count - 1].Top=5 + 80 * (k - 1);
                    ls[ls.Count-1].Controls.Find("SortName", false)[0].Text = "ghfg";
                    ls[ls.Count - 1].Controls.Find("PerformansPoints", false)[0].Text = "" + sortObject.PerformancePoints;
                    ls[ls.Count - 1].Controls.Find("IsValid", false)[0].Text = "" + sortObject.SortIsValid;
                }
            }
            label1.Text = "" + k;
            label2.Text = "" + ThreadWork;
            listBox1.Controls.AddRange(ls.ToArray());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CountThreadWork();
            foreach (Thread sortThread in SortThreads)
            {
                
                if (sortThread.ThreadState == ThreadState.Unstarted)
                {
                    if (ThreadWork < MaxThreadWork)
                    {
                        sortThread.Start();
                        ++ThreadWork;
                    }
                }
            }
        }

        private void CountThreadWork()
        {
            ThreadWork = 0;
            foreach (Thread sortThread in SortThreads)
            {
                if (sortThread.ThreadState == ThreadState.Running)
                {
                    ++ThreadWork;
                }
            }
        }
    }
}
