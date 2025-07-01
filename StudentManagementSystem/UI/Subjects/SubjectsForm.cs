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

namespace StudentManagementSystem.UI.Subjects
{
    public partial class SubjectsForm : Form
    {
        private int editingSubjectId = -1;

        public SubjectsForm()
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



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            int selectedId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SubjectsDal dal = new SubjectsDal();
                bool success = dal.DeleteSubject(selectedId);

                if (success)
                {
                    MessageBox.Show("Subject deleted successfully.");
                    LoadSubjects();
                }
                else
                {
                    MessageBox.Show("Failed to delete subject.");
                }
            }
        }


        private void btnAddsubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectname.Text.Trim();
            string subjectIndex = txtSubjectindex.Text.Trim();
            string subjectColor = txtSubjectcolor.Text.Trim();
            int subjectOrder = 0;

            if (!int.TryParse(txtSubjectorder.Text.Trim(), out subjectOrder))
            {
                MessageBox.Show("Please enter a valid subject order.");
                return;
            }

            if (string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(subjectIndex))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            var subject = new Subject
            {
                SubjectName = subjectName,
                SubjectIndex = subjectIndex,
                SubjectOrder = subjectOrder,
                SubjectColor = subjectColor,
                CreatedAt = DateTime.Now,
                CreatedBy = "1"
            };

            SubjectsDal dal = new SubjectsDal();
            int newId = dal.AddSubject(subject);

            if (newId > 0)
            {
                MessageBox.Show("Subject added successfully.");
                LoadSubjects();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Failed to add subject.");
            }
        }

        private void LoadSubjects()
        {
            SubjectsDal dal = new SubjectsDal();
            dgvSubjects.DataSource = dal.GetAllSubjects();
            dgvSubjects.Columns["id"].HeaderText = "ID";
            dgvSubjects.Columns["subject_name"].HeaderText = "Subject Name";
            dgvSubjects.Columns["subject_index"].HeaderText = "Subject Index";
            dgvSubjects.Columns["subject_color"].HeaderText = "Color";
            dgvSubjects.Columns["subject_order"].HeaderText = "Order";
            dgvSubjects.Columns["created_at"].Visible = false;
            dgvSubjects.Columns["created_by"].Visible = false;
            dgvSubjects.Columns["updated_at"].Visible = false;
            dgvSubjects.Columns["updated_by"].Visible = false;
            dgvSubjects.Columns["deleted_at"].Visible = false;
            dgvSubjects.Columns["deleted_by"].Visible = false;
            dgvSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearFormFields()
        {
            txtSubjectname.Clear();
            txtSubjectindex.Clear();
            txtSubjectorder.Clear();
            txtSubjectcolor.Clear();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            btnSave.Enabled = false;
            lblcount.Text = $"Total Subjects: {dgvSubjects.Rows.Count}";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

            if (dgvSubjects.SelectedRows.Count > 0)
            {
                editingSubjectId = Convert.ToInt32(dgvSubjects.SelectedRows[0].Cells["Id"].Value);
                SubjectsDal dal = new SubjectsDal();
                Subject subject = dal.GetSubjectById(editingSubjectId);

                if (subject != null)
                {
                    txtSubjectname.Text = subject.SubjectName;
                    txtSubjectindex.Text = subject.SubjectIndex;
                    txtSubjectorder.Text = subject.SubjectOrder.ToString();
                    txtSubjectcolor.Text = subject.SubjectColor;

                    btnAddsubject.Enabled = false;
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (editingSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to edit.");
                return;
            }
            string subjectName = txtSubjectname.Text.Trim();
            string subjectIndex = txtSubjectindex.Text.Trim();
            string subjectColor = txtSubjectcolor.Text.Trim();
            int subjectOrder;
            if (!int.TryParse(txtSubjectorder.Text.Trim(), out subjectOrder))
            {
                MessageBox.Show("Please enter a valid subject order.");
                return;
            }
            if (string.IsNullOrWhiteSpace(subjectName) || string.IsNullOrWhiteSpace(subjectIndex))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }
            var updatedSubject = new Subject
            {
                Id = editingSubjectId,
                SubjectName = subjectName,
                SubjectIndex = subjectIndex,
                SubjectOrder = subjectOrder,
                SubjectColor = subjectColor,
                UpdatedAt = DateTime.Now,
                UpdatedBy = "1"
            };
            SubjectsDal dal = new SubjectsDal();
            bool success = dal.UpdateSubject(updatedSubject);
            if (success)
            {
                MessageBox.Show("Subject updated successfully.");
                LoadSubjects();
                ClearFormFields();
                btnSave.Enabled = false;
                btnAddsubject.Enabled = true;
                editingSubjectId = -1;
            }
            else
            {
                MessageBox.Show("Failed to update subject.");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtsearch.Text.Trim();
            (dgvSubjects.DataSource as DataTable).DefaultView.RowFilter =
                $"subject_name LIKE '%{filter}%'";
            lblcount.Text = $"Total Subjects: {dgvSubjects.Rows.Count}";
        }
    }
}
