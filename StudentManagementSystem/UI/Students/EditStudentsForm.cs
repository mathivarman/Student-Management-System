using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
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
    public partial class EditStudentsForm : Form
    {
        private int id;
        private DAL.StudentsDal studentsDal = new DAL.StudentsDal();

        public EditStudentsForm(int studentID)
        {
            InitializeComponent();
            this.id = studentID;
        }

        private void EditStudentsForm_Load(object sender, EventArgs e)
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string admissionNo = txtAdmissionNo.Text.Trim();
            string telephoneNo = txtTelephoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value;
            DateTime admissionDate = dtpAdmission.Value;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

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


            var student = new Student
            {
                Id = id.ToString(),
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
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };


            try
            {
                studentsDal.UpdateStudent(student);
                MessageBox.Show("Student details updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
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
