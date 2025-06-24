namespace StudentManagementSystem.UI.SubjectTeacher
{
    partial class TeacherSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxline = new System.Windows.Forms.GroupBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.lvsubjects = new System.Windows.Forms.ListView();
            this.txtSubjectname = new System.Windows.Forms.TextBox();
            this.lblsubject = new System.Windows.Forms.Label();
            this.btnAddsubject = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-45, 318);
            this.groupBoxline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Size = new System.Drawing.Size(1200, 7);
            this.groupBoxline.TabIndex = 138;
            this.groupBoxline.TabStop = false;
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(997, 46);
            this.lbltop.TabIndex = 137;
            this.lbltop.Text = "Teacher\'s Subjects";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvsubjects
            // 
            this.lvsubjects.HideSelection = false;
            this.lvsubjects.Location = new System.Drawing.Point(27, 65);
            this.lvsubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvsubjects.Name = "lvsubjects";
            this.lvsubjects.Size = new System.Drawing.Size(460, 219);
            this.lvsubjects.TabIndex = 136;
            this.lvsubjects.UseCompatibleStateImageBehavior = false;
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectname.Location = new System.Drawing.Point(728, 80);
            this.txtSubjectname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Size = new System.Drawing.Size(249, 34);
            this.txtSubjectname.TabIndex = 148;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubject.Location = new System.Drawing.Point(513, 84);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(165, 29);
            this.lblsubject.TabIndex = 147;
            this.lblsubject.Text = "Subject Name";
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddsubject.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddsubject.Location = new System.Drawing.Point(880, 135);
            this.btnAddsubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(96, 46);
            this.btnAddsubject.TabIndex = 155;
            this.btnAddsubject.Text = "Add";
            this.btnAddsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddsubject.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Image = global::StudentManagementSystem.Properties.Resources.reset;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(521, 331);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 46);
            this.btnRefresh.TabIndex = 160;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Image = global::StudentManagementSystem.Properties.Resources.icons8_export_30;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(771, 331);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 46);
            this.btnExport.TabIndex = 159;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = global::StudentManagementSystem.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(660, 331);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 46);
            this.btnPrint.TabIndex = 158;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(895, 331);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 46);
            this.btnClose.TabIndex = 157;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = global::StudentManagementSystem.Properties.Resources.icons8_delete_24;
            this.btnDelete.Location = new System.Drawing.Point(400, 331);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 46);
            this.btnDelete.TabIndex = 156;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // TeacherSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 384);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddsubject);
            this.Controls.Add(this.txtSubjectname);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lvsubjects);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherSubjectForm";
            this.Text = "TeacherSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.ListView lvsubjects;
        private System.Windows.Forms.TextBox txtSubjectname;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}