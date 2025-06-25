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
            this.btnAddsubject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-191, 318);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Size = new System.Drawing.Size(900, 6);
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
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(595, 37);
            this.lbltop.TabIndex = 137;
            this.lbltop.Text = "Teacher\'s Subjects";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvsubjects
            // 
            this.lvsubjects.HideSelection = false;
            this.lvsubjects.Location = new System.Drawing.Point(20, 53);
            this.lvsubjects.Name = "lvsubjects";
            this.lvsubjects.Size = new System.Drawing.Size(559, 260);
            this.lvsubjects.TabIndex = 136;
            this.lvsubjects.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddsubject.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddsubject.Location = new System.Drawing.Point(26, 330);
            this.btnAddsubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(72, 37);
            this.btnAddsubject.TabIndex = 155;
            this.btnAddsubject.Text = "Add";
            this.btnAddsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddsubject.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::StudentManagementSystem.Properties.Resources.icons8_refresh_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(389, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 165;
            this.button1.Text = "Refresh";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = global::StudentManagementSystem.Properties.Resources.icons8_delete_24;
            this.btnDelete.Location = new System.Drawing.Point(102, 328);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 39);
            this.btnDelete.TabIndex = 164;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(496, 328);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 37);
            this.btnClose.TabIndex = 163;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Image = global::StudentManagementSystem.Properties.Resources.icons8_export_30;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(287, 328);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 37);
            this.btnExport.TabIndex = 162;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = global::StudentManagementSystem.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(195, 328);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 37);
            this.btnPrint.TabIndex = 161;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // TeacherSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddsubject);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lvsubjects);
            this.Name = "TeacherSubjectForm";
            this.Text = "TeacherSubjectForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.ListView lvsubjects;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
    }
}