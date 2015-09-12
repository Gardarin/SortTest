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
        Thread SortThread;
        public Form1()
        {
            InitializeComponent();
            SortObjects = new List<SortObject>();
            BubbleSort BubbleSorting = new BubbleSort();
            SortObjects.Add(new SortObject(BubbleSorting, 2));
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
                SortObjects[0].SetArrays(Mas, ControlArray);

                timer1.Start();
                SortThread = new Thread(SortObjects[0].StartSort);
                SortThread.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (SortThread.ThreadState == ThreadState.Stopped)
            {
                progressBar1.Value = progressBar1.Maximum;
                sortView1.Controls.Find("SortName", false)[0].Text = "ghfg";
                sortView1.Controls.Find("PerformansPoints", false)[0].Text = "" + SortObjects[0].PerformancePoints;
                sortView1.Controls.Find("IsValid", false)[0].Text = "" + SortObjects[0].SortIsValid;
            }
        }
    }
}
