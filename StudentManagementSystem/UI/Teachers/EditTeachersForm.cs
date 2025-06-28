using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Teachers
{
    public partial class EditTeachersForm : Form
    {
        private int id;
        private TeachersDal teachersDal = new TeachersDal();

        public EditTeachersForm(int teacherId)
        {
            InitializeComponent();
            this.id = teacherId;
        }

        private void EditTeachersForm_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string telephone = txtTelephone.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            DateTime dob = dtpDOB.Value;
            DateTime dateOfAppoint = dtpAppoint.Value;
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var teacher = new Teacher
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Telephone = telephone,
                Nic = nic,
                Email = email,
                Address = address,
                DateOfBirth = dob,
                DateOfAppoint = dateOfAppoint,
                Gender = gender,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };

            try
            {
                teachersDal.UpdateTeacher(teacher);
                MessageBox.Show("Teacher details updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating teacher: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
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
    }
}
