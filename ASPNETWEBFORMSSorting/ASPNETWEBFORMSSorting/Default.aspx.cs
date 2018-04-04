using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace ASPNETWEBFORMSSorting
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void arrayButton_Click(object sender, EventArgs e)
        {
            double[] numbers = new double[5];
            numbers[0] = double.Parse(TextBox1.Text);
            numbers[1] = double.Parse(TextBox2.Text);
            numbers[2] = double.Parse(TextBox3.Text);
            numbers[3] = double.Parse(TextBox4.Text);
            numbers[4] = double.Parse(TextBox5.Text);

            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
        }

        protected void bubbleButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(TextBox1.Text);
            numbers[1] = int.Parse(TextBox2.Text);
            numbers[2] = int.Parse(TextBox3.Text);
            numbers[3] = int.Parse(TextBox4.Text);
            numbers[4] = int.Parse(TextBox5.Text);
            Stopwatch ticktock1 = new Stopwatch();
            ticktock1.Start();
            IntArrayBubbleSort(numbers);
            TimeSpan timePassed1 = ticktock1.Elapsed;
            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
            timerLabel.Text = string.Format("{0}", timePassed1);
            //Look to just list miliseconds
        }

        protected void selectionButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(TextBox1.Text);
            numbers[1] = int.Parse(TextBox2.Text);
            numbers[2] = int.Parse(TextBox3.Text);
            numbers[3] = int.Parse(TextBox4.Text);
            numbers[4] = int.Parse(TextBox5.Text);
            Stopwatch ticktock2 = new Stopwatch();
            ticktock2.Start();
            IntArraySelectionSort(numbers);
            TimeSpan timePassed2 = ticktock2.Elapsed;
            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
            timerLabel.Text = string.Format("{0}", timePassed2);
        }

        protected void InsertionButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(TextBox1.Text);
            numbers[1] = int.Parse(TextBox2.Text);
            numbers[2] = int.Parse(TextBox3.Text);
            numbers[3] = int.Parse(TextBox4.Text);
            numbers[4] = int.Parse(TextBox5.Text);
            Stopwatch ticktock3 = new Stopwatch();
            ticktock3.Start();

            IntArrayInsertionSort(numbers);
            TimeSpan timePassed3 = ticktock3.Elapsed;
            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
            timerLabel.Text = string.Format("{0}", timePassed3);
        }

        protected void shellButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(TextBox1.Text);
            numbers[1] = int.Parse(TextBox2.Text);
            numbers[2] = int.Parse(TextBox3.Text);
            numbers[3] = int.Parse(TextBox4.Text);
            numbers[4] = int.Parse(TextBox5.Text);
            Stopwatch ticktock4 = new Stopwatch();
            ticktock4.Start();

            IntArrayShellSortNaive(numbers);
            TimeSpan timePassed4 = ticktock4.Elapsed;
            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
            timerLabel.Text = string.Format("{0}", timePassed4);

        }

        protected void quickButton_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(TextBox1.Text);
            numbers[1] = int.Parse(TextBox2.Text);
            numbers[2] = int.Parse(TextBox3.Text);
            numbers[3] = int.Parse(TextBox4.Text);
            numbers[4] = int.Parse(TextBox5.Text);
            Stopwatch ticktock5 = new Stopwatch();
            ticktock5.Start();

            IntArrayQuickSort(numbers);
            TimeSpan timePassed5 = ticktock5.Elapsed;
            resultLabel.Text = string.Format($"<p>{numbers[0]}<br> {numbers[1]}<br> {numbers[2]}<br> {numbers[3]}<br> {numbers[4]}</p>");
            timerLabel.Text = string.Format("{0}", timePassed5);

        }

        public static void exchange(int[] data, int m, int n)
        {
            //treates as 0 based and only exchanges parts mentioned. 
            int temporary;
            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }
        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }
        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
            }
        }
        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
        }
        public static void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            exchange(data, i, i - interval);
                        }
                    }
                }
            }
        }
        public static void IntArrayShellSortNaive(int[] data)
        {
            int[] intervals = { 1, 2, 4, 8 };
            IntArrayShellSort(data, intervals);

            //      static int[] GenerateIntervals (int n)
            //{
            //          if (n < 2)
            //          {  // no sorting will be needed
            //              return new int[0];
            //          }
            //          int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            //          int[] intervals = new int[t];
            //          intervals[0] = 1;
            //          for (int i = 1; i < t; i++)
            //              intervals[i] = 3 * intervals[i - 1] + 1;
            //          return intervals;
            //      }

            //public static void IntArrayShellSortBetter(int[] data)
            //  {
            //      int[] intervals = GenerateIntervals(data.Length);
            //      IntArrayShellSort(data, intervals);
            //  }


        }
        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }
        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }



    }
}