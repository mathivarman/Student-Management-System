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
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string admissionNo = txtAdmissionNo.Text.Trim();
            string telephoneNo = txtTelephoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;
            DateTime admissionDate = dtpAdmission.Value.Date;
            string grade = cmbgrade.SelectedIndex != -1 ? cmbgrade.SelectedItem.ToString() : null;
            int gradeid = 0;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(admissionNo))
            {
                MessageBox.Show("Admission number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telephoneNo))
            {
                MessageBox.Show("Telephone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob >= DateTime.Today)
            {
                MessageBox.Show("Date of birth must be a past date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (admissionDate < dob)
            {
                MessageBox.Show("Admission date cannot be before date of birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbgrade.SelectedValue == null || !int.TryParse(cmbgrade.SelectedValue.ToString(), out gradeid))
            {
                MessageBox.Show("Please select a valid grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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

        private void lbltop_Click(object sender, EventArgs e)
        {

        }

        private void txtAdmissionNo_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
