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
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string gender = rdoMale.Checked ? "Male" : "Female";
            string telephone = txtTelephone.Text;
            string nic = txtNIC.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            DateTime dob = dtpDOB.Value;
            DateTime dateOfAppoint = dtpAppoint.Value;

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
    }
}
