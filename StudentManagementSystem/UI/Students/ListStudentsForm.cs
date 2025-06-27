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
            createStudentsForm.ShowDialog();
         
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
                editStudentForm.ShowDialog();
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
    }
    }
            
       
    

