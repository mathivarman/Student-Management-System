using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;

namespace StudentManagementSystem.UI.Grades
{
    public partial class GradesForm : Form
    {
        private GradesDal gradesDal = new GradesDal();
        private int selectedGradeId = -1;

        public GradesForm()
        {
            InitializeComponent();
            LoadGrades();
        }

        private void LoadGrades()
        {
            DataTable dt = gradesDal.GetAllGrades();
            dgvGrades.DataSource = dt;
            dgvGrades.Columns["id"].HeaderText = "ID";
            dgvGrades.Columns["grade_name"].HeaderText = "Name";
            dgvGrades.Columns["grade_order"].HeaderText = "Order";
            dgvGrades.Columns["grade_color"].HeaderText = "Color";
            dgvGrades.Columns["grade_group"].HeaderText = "Group";
            dgvGrades.Columns["created_at"].Visible = false;
            dgvGrades.Columns["created_by"].Visible = false;
            dgvGrades.Columns["updated_at"].Visible = false;
            dgvGrades.Columns["updated_by"].Visible = false;
            dgvGrades.Columns["deleted_at"].Visible = false;
            dgvGrades.Columns["deleted_by"].Visible = false;
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnSave.Visible = false;
        }

        private void ClearForm()
        {
            txtGradename.Text = "";
            txtGradeorder.Text = "";
            txtGradecolor.Text = "";
            txtGradegroup.Text = "";
            selectedGradeId = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAddgrade_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGradename.Text) ||
                string.IsNullOrWhiteSpace(txtGradeorder.Text) ||
                string.IsNullOrWhiteSpace(txtGradecolor.Text) ||
                string.IsNullOrWhiteSpace(txtGradegroup.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Grade grade = new Grade
            {
                GradeName = txtGradename.Text.Trim(),
                GradeOrder = int.Parse(txtGradeorder.Text.Trim()),
                GradeColor = txtGradecolor.Text.Trim(),
                GradeGroup = txtGradegroup.Text.Trim(),
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            if (selectedGradeId == -1)
            {
                gradesDal.AddGrade(grade);
                MessageBox.Show("Grade added successfully.");
            }
            else
            {
                grade.Id = selectedGradeId;
                grade.UpdatedAt = DateTime.Now;
                grade.UpdatedBy = "1";
                gradesDal.UpdateGrade(grade);
                MessageBox.Show("Grade updated successfully.");
            }
            btnAddgrade.Enabled = true;
            btnSave.Visible = false;
            LoadGrades();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            DataGridViewRow row = dgvGrades.SelectedRows[0];
            selectedGradeId = Convert.ToInt32(row.Cells["id"].Value);
            txtGradename.Text = row.Cells["grade_name"].Value.ToString();
            txtGradeorder.Text = row.Cells["grade_order"].Value.ToString();
            txtGradecolor.Text = row.Cells["grade_color"].Value.ToString();
            txtGradegroup.Text = row.Cells["grade_group"].Value.ToString();
            btnAddgrade.Visible = false; 
            btnSave.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int gradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                gradesDal.DeleteGrade(gradeId);
                MessageBox.Show("Grade deleted successfully.");
                LoadGrades();
                ClearForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrades();
            ClearForm();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            lblcount.Text = $"Total Grades: {dgvGrades.Rows.Count}";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtsearch.Text.Trim();
            (dgvGrades.DataSource as DataTable).DefaultView.RowFilter =
                $"grade_name LIKE '%{filter}%'";
            lblcount.Text = $"Total Grades: {dgvGrades.Rows.Count}";

        }
    }
}
