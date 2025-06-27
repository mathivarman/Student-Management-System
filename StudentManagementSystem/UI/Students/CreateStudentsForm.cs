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
    public partial class CreateStudentsForm : Form
    {
        DAL.StudentsDal studentsDal = new DAL.StudentsDal();
        public CreateStudentsForm()
        {
            InitializeComponent();
            
        }

        private void CreateStudentsForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string admissionNo = txtAdmissionNo.Text;
            string telephoneNo = txtTelephoneNo.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            DateTime dob = dtpDOB.Value;
            DateTime admissionDate = dtpAdmission.Value;
            string grade = cmbgrade.SelectedIndex != -1 ? cmbgrade.SelectedItem.ToString() : null;
            int gradeid = 0;

            if (cmbgrade.SelectedValue != null && int.TryParse(cmbgrade.SelectedValue.ToString(), out int parsedGradeId))
            {
                gradeid = parsedGradeId;
            }
            else
            {
                MessageBox.Show("Please select a valid grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string gender = rdoMale.Checked ? "Male" : "Female";


            var student = new Model.Student
            {
                FirstName = firstName,
                LastName = lastName,
                AdmissionNo = admissionNo,
                Telephone = telephoneNo,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                DateOfAdmission = admissionDate,
                GradeId = gradeid,
                Gender = gender,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = "1"
            };


            studentsDal.AddStudent(student);

            clear();

            MessageBox.Show("Student created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clear()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtAdmissionNo.Clear();
            txtTelephoneNo.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbgrade.SelectedIndex = -1;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
