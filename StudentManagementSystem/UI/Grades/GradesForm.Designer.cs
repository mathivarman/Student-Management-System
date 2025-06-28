namespace StudentManagementSystem.UI.Grades
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            this.txtGradename = new System.Windows.Forms.TextBox();
            this.lblGradensme = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBoxline = new System.Windows.Forms.GroupBox();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblGradeorder = new System.Windows.Forms.Label();
            this.txtGradeorder = new System.Windows.Forms.TextBox();
            this.lblgradecolor = new System.Windows.Forms.Label();
            this.txtGradecolor = new System.Windows.Forms.TextBox();
            this.lblGradegroup = new System.Windows.Forms.Label();
            this.txtGradegroup = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAddgrade = new System.Windows.Forms.Button();
            this.btnAddsubject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGradename
            // 
            this.txtGradename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGradename.Location = new System.Drawing.Point(579, 114);
            this.txtGradename.Margin = new System.Windows.Forms.Padding(2);
            this.txtGradename.Name = "txtGradename";
            this.txtGradename.Size = new System.Drawing.Size(188, 29);
            this.txtGradename.TabIndex = 116;
            // 
            // lblGradensme
            // 
            this.lblGradensme.AutoSize = true;
            this.lblGradensme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGradensme.Location = new System.Drawing.Point(441, 119);
            this.lblGradensme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradensme.Name = "lblGradensme";
            this.lblGradensme.Size = new System.Drawing.Size(62, 24);
            this.lblGradensme.TabIndex = 115;
            this.lblGradensme.Text = "Grade";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcount.Location = new System.Drawing.Point(274, 17);
            this.lblcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(121, 17);
            this.lblcount.TabIndex = 48;
            this.lblcount.Text = "No of Grades 100";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblcount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 46);
            this.panel1.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Enter ID";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsearch.Location = new System.Drawing.Point(63, 12);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(108, 23);
            this.txtsearch.TabIndex = 0;
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-2, 482);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Size = new System.Drawing.Size(900, 6);
            this.groupBoxline.TabIndex = 108;
            this.groupBoxline.TabStop = false;
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(20, 112);
            this.dgvGrades.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 24;
            this.dgvGrades.Size = new System.Drawing.Size(394, 350);
            this.dgvGrades.TabIndex = 107;
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(789, 37);
            this.lbltop.TabIndex = 105;
            this.lbltop.Text = "Grades Details";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGradeorder
            // 
            this.lblGradeorder.AutoSize = true;
            this.lblGradeorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGradeorder.Location = new System.Drawing.Point(441, 172);
            this.lblGradeorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradeorder.Name = "lblGradeorder";
            this.lblGradeorder.Size = new System.Drawing.Size(116, 24);
            this.lblGradeorder.TabIndex = 115;
            this.lblGradeorder.Text = "Grade Order";
            // 
            // txtGradeorder
            // 
            this.txtGradeorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGradeorder.Location = new System.Drawing.Point(579, 167);
            this.txtGradeorder.Margin = new System.Windows.Forms.Padding(2);
            this.txtGradeorder.Name = "txtGradeorder";
            this.txtGradeorder.Size = new System.Drawing.Size(188, 29);
            this.txtGradeorder.TabIndex = 116;
            // 
            // lblgradecolor
            // 
            this.lblgradecolor.AutoSize = true;
            this.lblgradecolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblgradecolor.Location = new System.Drawing.Point(441, 221);
            this.lblgradecolor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgradecolor.Name = "lblgradecolor";
            this.lblgradecolor.Size = new System.Drawing.Size(112, 24);
            this.lblgradecolor.TabIndex = 115;
            this.lblgradecolor.Text = "Grade Color";
            // 
            // txtGradecolor
            // 
            this.txtGradecolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGradecolor.Location = new System.Drawing.Point(579, 216);
            this.txtGradecolor.Margin = new System.Windows.Forms.Padding(2);
            this.txtGradecolor.Name = "txtGradecolor";
            this.txtGradecolor.Size = new System.Drawing.Size(188, 29);
            this.txtGradecolor.TabIndex = 116;
            // 
            // lblGradegroup
            // 
            this.lblGradegroup.AutoSize = true;
            this.lblGradegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGradegroup.Location = new System.Drawing.Point(441, 274);
            this.lblGradegroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradegroup.Name = "lblGradegroup";
            this.lblGradegroup.Size = new System.Drawing.Size(62, 24);
            this.lblGradegroup.TabIndex = 115;
            this.lblGradegroup.Text = "Grade";
            // 
            // txtGradegroup
            // 
            this.txtGradegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGradegroup.Location = new System.Drawing.Point(579, 269);
            this.txtGradegroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGradegroup.Name = "txtGradegroup";
            this.txtGradegroup.Size = new System.Drawing.Size(188, 29);
            this.txtGradegroup.TabIndex = 116;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(77, 492);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 41);
            this.btnEdit.TabIndex = 163;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(679, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 38);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Image = global::StudentManagementSystem.Properties.Resources.icons8_refresh_30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(571, 495);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnRefresh.TabIndex = 160;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = global::StudentManagementSystem.Properties.Resources.icons8_delete_24;
            this.btnDelete.Location = new System.Drawing.Point(293, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 39);
            this.btnDelete.TabIndex = 147;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(675, 495);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 37);
            this.btnClose.TabIndex = 145;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Image = global::StudentManagementSystem.Properties.Resources.icons8_export_30;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(474, 494);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 37);
            this.btnExport.TabIndex = 144;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = global::StudentManagementSystem.Properties.Resources.icons8_print_30;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(387, 494);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 37);
            this.btnPrint.TabIndex = 143;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAddgrade
            // 
            this.btnAddgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddgrade.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddgrade.Location = new System.Drawing.Point(679, 329);
            this.btnAddgrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddgrade.Name = "btnAddgrade";
            this.btnAddgrade.Size = new System.Drawing.Size(88, 37);
            this.btnAddgrade.TabIndex = 126;
            this.btnAddgrade.Text = "Add";
            this.btnAddgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddgrade.UseVisualStyleBackColor = true;
            this.btnAddgrade.Click += new System.EventHandler(this.btnAddgrade_Click);
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddsubject.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddsubject.Location = new System.Drawing.Point(167, 492);
            this.btnAddsubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(122, 41);
            this.btnAddsubject.TabIndex = 125;
            this.btnAddsubject.Text = "Add Subject";
            this.btnAddsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddsubject.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Image = global::StudentManagementSystem.Properties.Resources.icons8_search_15;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(175, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 540);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAddgrade);
            this.Controls.Add(this.btnAddsubject);
            this.Controls.Add(this.txtGradegroup);
            this.Controls.Add(this.lblGradegroup);
            this.Controls.Add(this.txtGradeorder);
            this.Controls.Add(this.txtGradecolor);
            this.Controls.Add(this.lblGradeorder);
            this.Controls.Add(this.lblgradecolor);
            this.Controls.Add(this.txtGradename);
            this.Controls.Add(this.lblGradensme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradesForm";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGradename;
        private System.Windows.Forms.Label lblGradensme;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button btnAddgrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblGradeorder;
        private System.Windows.Forms.TextBox txtGradeorder;
        private System.Windows.Forms.Label lblgradecolor;
        private System.Windows.Forms.TextBox txtGradecolor;
        private System.Windows.Forms.Label lblGradegroup;
        private System.Windows.Forms.TextBox txtGradegroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
    }
}