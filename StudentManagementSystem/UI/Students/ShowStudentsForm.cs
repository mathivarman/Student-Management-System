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

namespace StudentManagementSystem.UI.Students
{
    public partial class ShowStudentsForm : Form
    {
        int id;

        DAL.StudentsDal studentsDal = new DAL.StudentsDal();
        public ShowStudentsForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ShowStudentsForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
            var student = studentsDal.GetStudentById(id);
            if (student != null)
            {
                txtAdmissionNo.Text = student.AdmissionNo;
                txtFirstname.Text = student.FirstName;
                txtLastname.Text = student.LastName;
                txtTelephoneNo.Text = student.Telephone;
                txtEmail.Text = student.Email;
                txtAddress.Text = student.Address;
                dtpDOB.Value = student.DateOfBirth;
                dtpAdmission.Value = student.DateOfAdmission;
                rdoMale.Checked = student.Gender == "Male";
                rdoFemale.Checked = student.Gender == "Female";
                cmbgrade.SelectedValue = student.GradeId;
                lbltop.Text = $"{student.FirstName}'s Details";
            }
            else
            {
                MessageBox.Show("Student not found.");
                this.Close();
            }
        }
        private void LoadGrades()
        {
            var gradesDal = new DAL.GradesDal();
            DataTable gradeTable = gradesDal.GetAllGrades();

            cmbgrade.DataSource = gradeTable;
            cmbgrade.DisplayMember = "grade_name";
            cmbgrade.ValueMember = "id";
            cmbgrade.SelectedIndex = -1;
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
