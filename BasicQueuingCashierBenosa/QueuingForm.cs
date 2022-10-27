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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberinQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberinQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            new CashierWindowQueueForm().Show();
        }
    }
}
