using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThread
{
    public partial class thread_01 : Form
    {
        public thread_01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStart.Text = "Start";



            ThreadStart delThread = new ThreadStart(MyThreadClass.thread1);

            Thread th1 = new Thread(delThread);
            Thread th2 = new Thread(delThread);

            th1.Name = "Thread Process A: ";
            th2.Name = "Thread Process B: ";

            th1.Start();
            th2.Start();

            th1.Join();
            th2.Join();

            Console.WriteLine("End of Thread");
            lblStart.Text = "-- End of Thread --";
        }
    }
}
