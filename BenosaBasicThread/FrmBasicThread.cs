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

namespace BenosaBasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            lblThread.Text = "-Before Starting Thread-";

            Console.WriteLine("-Before Starting Thread-");
            ThreadStart Thread = new ThreadStart(MyThreadClass.thread1);
            Thread ThreadA = new Thread(Thread);
            ThreadA.Name = "ThreadA";
            Thread ThreadB = new Thread(Thread);
            ThreadB.Name = "ThreadB";
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("-End of Thread-");

            if(!ThreadA.IsAlive && !ThreadB.IsAlive)
            {
                lblThread.Text = "-End of Thread-";
            }
        }
    }
}
