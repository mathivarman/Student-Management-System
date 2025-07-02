using StudentManagementSystem.DAL;
using StudentManagementSystem.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem.UI.Grades
{
    public partial class GradesForm : Form
    {
        private int editingGradeId = -1;

        public GradesForm()
        {
            InitializeComponent();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
            btnSave.Enabled = false;
            lblcount.Text = $"Total Grades: {dgvGrades.Rows.Count}";
        }

        private void LoadGrades()
        {
            GradesDal dal = new GradesDal();
            dgvGrades.DataSource = dal.GetAllGrades();
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
            lblcount.Text = $"Total Grades: {dgvGrades.Rows.Count}";
        }

        private void ClearFormFields()
        {
            txtGradename.Clear();
            txtGradeorder.Clear();
            txtGradecolor.Clear();
            txtGradegroup.Clear();
            editingGradeId = -1;
        }

        private void btnAddgrade_Click(object sender, EventArgs e)
        {
            string gradeName = txtGradename.Text.Trim();
            string gradeOrderText = txtGradeorder.Text.Trim();
            string gradeColor = txtGradecolor.Text.Trim();
            string gradeGroup = txtGradegroup.Text.Trim();
            int gradeOrder;

            if (!int.TryParse(gradeOrderText, out gradeOrder))
            {
                MessageBox.Show("Please enter a valid grade order.");
                return;
            }

            if (string.IsNullOrWhiteSpace(gradeName) || string.IsNullOrWhiteSpace(gradeGroup))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            var grade = new Grade
            {
                GradeName = gradeName,
                GradeOrder = gradeOrder,
                GradeColor = gradeColor,
                GradeGroup = gradeGroup,
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            GradesDal dal = new GradesDal();
            int newId = dal.AddGrade(grade);

            if (newId > 0)
            {
                MessageBox.Show("Grade added successfully.");
                LoadGrades();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Failed to add grade.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

            if (dgvGrades.SelectedRows.Count > 0)
            {
                editingGradeId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);
                GradesDal dal = new GradesDal();
                Grade grade = dal.GetGradeById(editingGradeId);

                if (grade != null)
                {
                    txtGradename.Text = grade.GradeName;
                    txtGradeorder.Text = grade.GradeOrder.ToString();
                    txtGradecolor.Text = grade.GradeColor;
                    txtGradegroup.Text = grade.GradeGroup;
                    btnAddgrade.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editingGradeId == -1)
            {
                MessageBox.Show("Please select a grade to edit.");
                return;
            }

            string gradeName = txtGradename.Text.Trim();
            string gradeOrderText = txtGradeorder.Text.Trim();
            string gradeColor = txtGradecolor.Text.Trim();
            string gradeGroup = txtGradegroup.Text.Trim();
            int gradeOrder;

            if (!int.TryParse(gradeOrderText, out gradeOrder))
            {
                MessageBox.Show("Please enter a valid grade order.");
                return;
            }

            if (string.IsNullOrWhiteSpace(gradeName) || string.IsNullOrWhiteSpace(gradeGroup))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            var updatedGrade = new Grade
            {
                Id = editingGradeId,
                GradeName = gradeName,
                GradeOrder = gradeOrder,
                GradeColor = gradeColor,
                GradeGroup = gradeGroup,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };

            GradesDal dal = new GradesDal();
            bool success = dal.UpdateGrade(updatedGrade);

            if (success)
            {
                MessageBox.Show("Grade updated successfully.");
                LoadGrades();
                ClearFormFields();
                btnSave.Enabled = false;
                btnAddgrade.Enabled = true;
                editingGradeId = -1;
            }
            else
            {
                MessageBox.Show("Failed to update grade.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            int selectedId = Convert.ToInt32(dgvGrades.SelectedRows[0].Cells["id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                GradesDal dal = new GradesDal();
                bool success = dal.DeleteGrade(selectedId);

                if (success)
                {
                    MessageBox.Show("Grade deleted successfully.");
                    LoadGrades();
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete grade.");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGrades();
            ClearFormFields();
            btnAddgrade.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
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