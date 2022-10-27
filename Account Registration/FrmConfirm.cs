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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblShowStudNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lblShowAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lblShowContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lblShowProgram.Text = DelProgram(StudentInfoClass.Program);
            lblShowLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblShowFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblShowMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblShowAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
