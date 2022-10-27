using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashierBenosa
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            if (CashierList != null)
            {
                foreach (object obj in CashierList)
                {
                    listCashierQueue.Items.Add(obj.ToString());
                }
            }
        }
        public void timer1_tick (Object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue); 
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!CustomerView.isCustomerViewOpened)
            {
            new CustomerView().Show();
            }

            if(CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count != 0)
            {
                CashierClass.CashierQueue.Dequeue();
            }
   

        }
        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
