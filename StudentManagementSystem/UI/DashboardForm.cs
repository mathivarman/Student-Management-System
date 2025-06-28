using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Students.ListStudentsForm listStudentsForm = new UI.Students.ListStudentsForm();
            listStudentsForm.MdiParent = this;
            listStudentsForm.Show();
        }

        private void listTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UI.Teachers.ListTeachersForm listTeachersForm = new UI.Teachers.ListTeachersForm();
            listTeachersForm.MdiParent = this;
            listTeachersForm.Show();

        }

        private void gradesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            UI.Grades.GradesForm listGradesForm = new UI.Grades.GradesForm();
            listGradesForm.MdiParent = this;
            listGradesForm.Show();
        }

        private void subjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            UI.Subjects.SubjectsForm subjectsForm = new UI.Subjects.SubjectsForm();
            subjectsForm.MdiParent = this;
            subjectsForm.Show();
        }
    }
}
