using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = tBLastName.Text;
            StudentInfoClass.FirstName = tBFirstName.Text;
            StudentInfoClass.MiddleName = tBMiddleName.Text;
            StudentInfoClass.Address = tBAddress.Text;
            StudentInfoClass.StudentNo = Convert.ToInt64(tBStudentNo.Text.ToString());
            StudentInfoClass.Age = Convert.ToInt64(tbAge.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(tbContactNo.Text.ToString());

            FrmConfirm fc = new FrmConfirm();
            if (fc.ShowDialog(this) == DialogResult.OK)
            {
                tBStudentNo.Clear();
                tBLastName.Clear();
                tBFirstName.Clear();
                tBMiddleName.Clear();
                tbAge.Clear();
                tBAddress.Clear();
                tbContactNo.Clear();
                cbProgram.SelectedIndex = -1;
            }
        }
    }
}
