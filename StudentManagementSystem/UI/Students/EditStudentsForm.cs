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
         int id;
        private DAL.StudentsDal studentsDal = new DAL.StudentsDal();
        public EditStudentsForm(int studentID)
        {
            InitializeComponent();
            this.id = studentID;
        }

        private void EditStudentsForm_Load(object sender, EventArgs e)
        {
            

            var student = studentsDal.GetStudentById(id);
            
            txtAdmissionNo.Text = student.AdmissionNo;
            txtFirstname.Text = student.FirstName;
            txtLastname.Text = student.LastName;
            txtTelephoneNo.Text = student.Telephone;
            txtEmail.Text = student.Email;
            txtAddress.Text = student.Address;
            dtpDOB.Text = student.DateOfBirth.ToString("yyyy-MM-dd");
            dtpAdmission.Text = student.DateOfAdmission.ToString("yyyy-MM-dd");
            rdoMale.Checked = student.Gender == "Male";
            rdoFemale.Checked = student.Gender == "Female";
            cmbgrade.SelectedValue = student.GradeId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string ids = Convert.ToString(id);
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
            if (grade != null && int.TryParse(new string(grade.Where(char.IsDigit).ToArray()), out int gradeids))
            {
                gradeid = gradeids;
            }
            else
            {
                gradeid = 0;
            }
            string gender = rdoMale.Checked ? "Male" : "Female";


            var student = new Model.Student
            {
                Id = ids,
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


           

            studentsDal.UpdateStudent(student);
            MessageBox.Show("Student details updated successfully.");
            this.Close();
        }
    }
}
