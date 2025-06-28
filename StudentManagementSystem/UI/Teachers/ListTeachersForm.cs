using StudentManagementSystem.DAL;
using StudentManagementSystem.UI.Students;
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
    public partial class ListTeachersForm : Form
    {
        DAL.TeachersDal teachersDal = new DAL.TeachersDal();
        public ListTeachersForm()
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

        private void ListTeachersForm_Load(object sender, EventArgs e)
        {
            DataTable teachersTable = teachersDal.GetAllTeachers();
            dgvTeachers.DataSource = teachersTable;
            dgvTeachers.Columns["id"].HeaderText = "ID";
            dgvTeachers.Columns["first_name"].HeaderText = "First Name";
            dgvTeachers.Columns["last_name"].HeaderText = "Last Name";
            dgvTeachers.Columns["gender"].HeaderText = "Gender";
            dgvTeachers.Columns["telephone_no"].HeaderText = "Telephone No";
            dgvTeachers.Columns["email_id"].HeaderText = "Email";
            dgvTeachers.Columns["nic_no"].HeaderText = "Nic";
            dgvTeachers.Columns["date_of_birth"].HeaderText = "DOB";
            dgvTeachers.Columns["date_of_appoint"].HeaderText = "DOA";
            dgvTeachers.Columns["address"].HeaderText = "Address";
            dgvTeachers.Columns["created_at"].Visible = false;
            dgvTeachers.Columns["created_by"].Visible = false;
            dgvTeachers.Columns["updated_at"].Visible = false;
            dgvTeachers.Columns["updated_by"].Visible = false;
            dgvTeachers.Columns["deleted_at"].Visible = false;
            dgvTeachers.Columns["deleted_by"].Visible = false;
            dgvTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblcount.Text = $"Total Teachers: {dgvTeachers.Rows.Count}";


        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            CreateTeachersForm createTeachersForm = new CreateTeachersForm();
            createTeachersForm.ShowDialog();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListTeachersForm_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
            EditTeachersForm editTeachersForm = new EditTeachersForm(teacherId);
            editTeachersForm.ShowDialog();
            ListTeachersForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int teacherId = Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value);
                teachersDal.DeleteTeacher(teacherId);
                ListTeachersForm_Load(sender, e);

                MessageBox.Show("Teacher deleted successfully.");

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowTeachersForm showTeachersForm = new ShowTeachersForm(Convert.ToInt32(dgvTeachers.SelectedRows[0].Cells["id"].Value));
            showTeachersForm.ShowDialog();
        }
    }
}
