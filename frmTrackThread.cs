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
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStart.Text = "Start";


            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delThread1 = new ThreadStart(MyThreadClass.Thread2);

            Thread th1 = new Thread(delThread);
            Thread th2 = new Thread(delThread1);

            Thread th3 = new Thread(delThread);
            Thread th4 = new Thread(delThread1);


            th1.Name = "Thread A Process: ";
            th2.Name = "Thread B Process: ";
            th3.Name = "Thread C Process: ";
            th4.Name = "Thread D Process: ";

            th1.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Normal;
            th3.Priority = ThreadPriority.AboveNormal;
            th4.Priority = ThreadPriority.BelowNormal;

            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();

            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();

            Console.WriteLine("End of Thread");
            lblStart.Text = "-- End of Thread --";
        }
    }
}
