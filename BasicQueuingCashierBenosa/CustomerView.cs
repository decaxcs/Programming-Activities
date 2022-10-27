using System;
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
    public partial class CustomerView : Form
    {
        public static bool isCustomerViewOpened;
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();

            isCustomerViewOpened = true;
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count != 0)
            {
                lblCustomerView.Text = CashierClass.CashierQueue.Peek();
            }
        }

        private void CustomerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCustomerViewOpened = false;
        }
    }
}


















