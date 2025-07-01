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

namespace StudentManagementSystem.UI.Teachers
{
    public partial class CreateTeachersForm : Form
    {
        DAL.TeachersDal teachersDal = new DAL.TeachersDal();
        public CreateTeachersForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";
            string telephone = txtTelephone.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value;
            DateTime dateOfAppoint = dtpAppoint.Value;

           

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telephone) || !telephone.All(char.IsDigit) || telephone.Length != 10)
            {
                MessageBox.Show("Telephone number is required and must be 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nic) || (nic.Length != 10 && nic.Length != 12))
            {
                MessageBox.Show("NIC is required and must be 10 or 12 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (dateOfAppoint < dob)
            {
                MessageBox.Show("Date of Appointment cannot be earlier than Date of Birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            var teacher = new Teacher
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Telephone = telephone,
                Nic = nic,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                DateOfAppoint = dateOfAppoint,
                CreatedAt = DateTime.Now,
                CreatedBy = "1",
                UpdatedAt = DateTime.Now
            };

            try
            {
                teachersDal.AddTeacher(teacher);
                MessageBox.Show("Teacher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding teacher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        


        private void clear()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtTelephone.Clear();
            txtNIC.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpAppoint.Value = DateTime.Today;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CreateTeachersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
