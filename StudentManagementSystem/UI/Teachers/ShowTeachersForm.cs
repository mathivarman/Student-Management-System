using StudentManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Teachers
{
    public partial class ShowTeachersForm : Form
    {
        int id;

        DAL.TeachersDal teachersDal = new DAL.TeachersDal();
        public ShowTeachersForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ShowTeachersForm_Load(object sender, EventArgs e)
        {
            var teacher = teachersDal.GetTeacherById(id);
            if (teacher != null)
            {
                txtFirstname.Text = teacher.FirstName;
                txtLastname.Text = teacher.LastName;
                txtTelephone.Text = teacher.Telephone;
                txtNIC.Text = teacher.Nic;
                txtEmail.Text = teacher.Email;
                txtAddress.Text = teacher.Address;
                dtpDOB.Value = teacher.DateOfBirth;
                dtpAppoint.Value = teacher.DateOfAppoint;
                rdoMale.Checked = teacher.Gender == "Male";
                rdoFemale.Checked = teacher.Gender == "Female";
                lbltop.Text = $"{teacher.FirstName}'s Details";
            }
            else
            {
                MessageBox.Show("Teacher not found.");
                this.Close();
            }
        }
    }
}
