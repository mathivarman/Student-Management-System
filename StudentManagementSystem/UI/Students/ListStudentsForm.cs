using MySqlX.XDevAPI.Common;
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
    public partial class ListStudentsForm : Form
    {
        DAL.StudentsDal studentsDal = new DAL.StudentsDal();
        public ListStudentsForm()
        {
            InitializeComponent();
        }

        private void ListStudentsForm_Load(object sender, EventArgs e)
        {
           
            DataTable studentsTable = studentsDal.GetAllStudents();
            dgvStudents.DataSource = studentsTable;
            dgvStudents.Columns["id"].HeaderText = "ID";
            dgvStudents.Columns["admission_no"].HeaderText = "Admission No";
            dgvStudents.Columns["first_name"].HeaderText = "First Name";
            dgvStudents.Columns["last_name"].HeaderText = "Last Name";
            dgvStudents.Columns["gender"].HeaderText = "Gender";
            dgvStudents.Columns["telephone_no"].HeaderText = "Telephone No";
            dgvStudents.Columns["email_id"].HeaderText = "Email ID";
            dgvStudents.Columns["address"].HeaderText = "Address";
            dgvStudents.Columns["date_of_birth"].HeaderText = "Date of Birth";
            dgvStudents.Columns["date_of_admission"].HeaderText = "Date of Admission";
            dgvStudents.Columns["grade_id"].HeaderText = "Grade ID";
            dgvStudents.Columns["created_at"].Visible = false;
            dgvStudents.Columns["created_by"].Visible = false;
            dgvStudents.Columns["updated_at"].Visible = false;
            dgvStudents.Columns["updated_by"].Visible = false;
            dgvStudents.Columns["deleted_at"].Visible = false;
            dgvStudents.Columns["deleted_by"].Visible = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lblcount.Text = $"Total Students: {dgvStudents.Rows.Count}";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("please select a row");
                return;
            }


            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
                studentsDal.DeleteStudent(studentId);
                ListStudentsForm_Load(sender, e);

                MessageBox.Show("Student deleted successfully.");

            }


        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            CreateStudentsForm createStudentsForm = new CreateStudentsForm();
            this.Hide();
            createStudentsForm.ShowDialog();
            this.Show();
            ListStudentsForm_Load(sender, e);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                int studentId = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
                EditStudentsForm editStudentForm = new EditStudentsForm(studentId);
                this.Hide();
                editStudentForm.ShowDialog();
            this.Show();
                ListStudentsForm_Load(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListStudentsForm_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to Show.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
            
            ShowStudentsForm showStudentsForm = new ShowStudentsForm(id);
            this.Hide();
            showStudentsForm.ShowDialog();

            this.Show();

        }

        private void lblcount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchId = txtsearch.Text.Trim().Length > 0 ? Convert.ToInt32(txtsearch.Text) : 0;
            Model.Student student = studentsDal.GetStudentById(searchId);

            if (student != null)
            {
                DataTable searchResults = new DataTable();
                searchResults.Columns.Add("id", typeof(int));
                searchResults.Columns.Add("admission_no", typeof(string));
                searchResults.Columns.Add("first_name", typeof(string));
                searchResults.Columns.Add("last_name", typeof(string));
                searchResults.Columns.Add("gender", typeof(string));
                searchResults.Columns.Add("telephone_no", typeof(string));
                searchResults.Columns.Add("email_id", typeof(string));
                searchResults.Columns.Add("address", typeof(string));
                searchResults.Columns.Add("date_of_birth", typeof(DateTime));
                searchResults.Columns.Add("date_of_admission", typeof(DateTime));
                searchResults.Columns.Add("grade_id", typeof(int));

                searchResults.Rows.Add(
                    student.Id,
                    student.AdmissionNo,
                    student.FirstName,
                    student.LastName,
                    student.Gender,
                    student.Telephone,
                    student.Email,
                    student.Address,
                    student.DateOfBirth,
                    student.DateOfAdmission,
                    student.GradeId
                );

                dgvStudents.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("No student found with the given ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["id"].Value);
            UI.StudentSubject.StudentSubjectForm studentSubjectsForm = new UI.StudentSubject.StudentSubjectForm(id);
            studentSubjectsForm.ShowDialog();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtsearch.Text.Trim();
            (dgvStudents.DataSource as DataTable).DefaultView.RowFilter =
                $"first_name LIKE '%{filter}%' OR last_name LIKE '%{filter}%' OR admission_no LIKE '%{filter}%'";
            lblcount.Text = $"Total Students: {dgvStudents.Rows.Count}";

        }
    }
 }
            
       
    

