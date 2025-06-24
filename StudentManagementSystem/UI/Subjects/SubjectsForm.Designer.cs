namespace StudentManagementSystem.UI.Subjects
{
    partial class SubjectsForm
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjectname = new System.Windows.Forms.TextBox();
            this.txtSubjectcode = new System.Windows.Forms.TextBox();
            this.btnAddsubject = new System.Windows.Forms.Button();
            this.btnaddgrade = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-5, 588);
            this.groupBoxline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Size = new System.Drawing.Size(1200, 7);
            this.groupBoxline.TabIndex = 92;
            this.groupBoxline.TabStop = false;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(23, 133);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(525, 431);
            this.dgvStudents.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter ID";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsearch.Location = new System.Drawing.Point(84, 15);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(143, 26);
            this.txtsearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblcount);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Location = new System.Drawing.Point(11, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 57);
            this.panel1.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::StudentManagementSystem.Properties.Resources.icons8_search_15;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(217, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 49;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcount.Location = new System.Drawing.Point(365, 21);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(151, 20);
            this.lblcount.TabIndex = 48;
            this.lblcount.Text = "No of Subjects 100";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSearch.Location = new System.Drawing.Point(232, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 27);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.lbltop.Size = new System.Drawing.Size(1045, 46);
            this.lbltop.TabIndex = 88;
            this.lbltop.Text = "Subjects Details";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubject.Location = new System.Drawing.Point(585, 142);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(165, 29);
            this.lblsubject.TabIndex = 102;
            this.lblsubject.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(585, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 102;
            this.label2.Text = "Subject Code";
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectname.Location = new System.Drawing.Point(769, 142);
            this.txtSubjectname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Size = new System.Drawing.Size(249, 34);
            this.txtSubjectname.TabIndex = 103;
            // 
            // txtSubjectcode
            // 
            this.txtSubjectcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectcode.Location = new System.Drawing.Point(769, 204);
            this.txtSubjectcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectcode.Name = "txtSubjectcode";
            this.txtSubjectcode.Size = new System.Drawing.Size(249, 34);
            this.txtSubjectcode.TabIndex = 103;
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddsubject.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddsubject.Location = new System.Drawing.Point(923, 278);
            this.btnAddsubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(96, 46);
            this.btnAddsubject.TabIndex = 131;
            this.btnAddsubject.Text = "Add";
            this.btnAddsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddsubject.UseVisualStyleBackColor = true;
            // 
            // btnaddgrade
            // 
            this.btnaddgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnaddgrade.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnaddgrade.Location = new System.Drawing.Point(281, 608);
            this.btnaddgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddgrade.Name = "btnaddgrade";
            this.btnaddgrade.Size = new System.Drawing.Size(135, 48);
            this.btnaddgrade.TabIndex = 137;
            this.btnaddgrade.Text = "Add Grade";
            this.btnaddgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddgrade.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Image = global::StudentManagementSystem.Properties.Resources.reset;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(561, 609);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 46);
            this.btnRefresh.TabIndex = 156;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Image = global::StudentManagementSystem.Properties.Resources.icons8_export_30;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(809, 609);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 46);
            this.btnExport.TabIndex = 155;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = global::StudentManagementSystem.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(699, 609);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 46);
            this.btnPrint.TabIndex = 154;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(932, 609);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 46);
            this.btnClose.TabIndex = 153;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = global::StudentManagementSystem.Properties.Resources.icons8_delete_24;
            this.btnDelete.Location = new System.Drawing.Point(441, 609);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 46);
            this.btnDelete.TabIndex = 152;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 670);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnaddgrade);
            this.Controls.Add(this.btnAddsubject);
            this.Controls.Add(this.txtSubjectcode);
            this.Controls.Add(this.txtSubjectname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectname;
        private System.Windows.Forms.TextBox txtSubjectcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button btnaddgrade;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}