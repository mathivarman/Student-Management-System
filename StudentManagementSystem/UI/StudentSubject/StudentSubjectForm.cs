using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.StudentSubject
{
    public partial class StudentSubjectForm : Form
    {
        public StudentSubjectForm()
        {
            InitializeComponent();
        }

        private void StudentSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddsubject_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
