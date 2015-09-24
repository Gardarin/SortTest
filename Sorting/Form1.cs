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

        List<SortView> ls;

        List<Thread> SortThreads;
        int ThreadWork;
        int MaxThreadWork;

        public Form1()
        {
            InitializeComponent();

            ls = new List<SortView>();
            SortObjects = new List<SortObject>();
            BubbleSort BubbleSorting = new BubbleSort();
            SortObjects.Add(new SortObject(BubbleSorting, 1));
            ThreadWork = 0;
            MaxThreadWork = 1;
     
            CountSort CountSorting = new CountSort();
            SortObjects.Add(new SortObject(CountSorting, 1));

            //BubbleSorting = new BubbleSort();
            //SortObjects.Add(new SortObject(BubbleSorting, 1));

            //CountSorting = new CountSort();
            //SortObjects.Add(new SortObject(CountSorting, 1));

            StandartSort standS = new StandartSort();
            SortObjects.Add(new SortObject(standS, 1));

            progressBar1.Maximum = SortObjects.Count();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mas = new int[10000];
            ControlArray = new int[10000];
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

        int ccount = 0;
        int k;  

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = 0;
           
            foreach (SortObject sortObject in SortObjects)
            {
                if (sortObject.IsComplete)
                {
                    k++;
                    if (k > ccount)
                    {
                        ccount++;
                        SortView Sv=new SortView();
                        Sv.Top = 75 * k - 70;
                        Sv.Controls.Find("SortName", false)[0].Text = sortObject.GetName();
                        Sv.Controls.Find("PerformansPoints", false)[0].Text = "" + sortObject.PerformancePoints;
                        Sv.Controls.Find("IsValid", false)[0].Text = "" + sortObject.SortIsValid;
                        listBox1.Controls.Add(Sv);
                        listBox1.Height = 10 + 75 * k;
                    }
                }
            }
            progressBar1.Value = k;
            label1.Text = "" + k;
            label2.Text = "" + ThreadWork;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            CountThreadWork();
            foreach (Thread sortThread in SortThreads)
            {
                if (sortThread.ThreadState == ThreadState.Unstarted)
                {
                    timer2.Start();
                    if (ThreadWork < MaxThreadWork)
                    {
                        sortThread.Start();
                        ++ThreadWork;
                    }
                }
            }

            for(int i=0;i<SortThreads.Count;++i)
            {
                if (SortThreads[i].ThreadState == ThreadState.Stopped)
                {
                    SortThreads.Remove(SortThreads[i]);
                    break;
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
                    timer2.Start();
                    ++ThreadWork;
                }
            }
        }
    }
}
