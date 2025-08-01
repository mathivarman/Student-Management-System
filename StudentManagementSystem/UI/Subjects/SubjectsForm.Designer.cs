﻿namespace StudentManagementSystem.UI.Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsForm));
            this.groupBoxline = new System.Windows.Forms.GroupBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcount = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblsubindex = new System.Windows.Forms.Label();
            this.txtSubjectname = new System.Windows.Forms.TextBox();
            this.txtSubjectindex = new System.Windows.Forms.TextBox();
            this.lblsuborder = new System.Windows.Forms.Label();
            this.txtSubjectorder = new System.Windows.Forms.TextBox();
            this.lblsubcolor = new System.Windows.Forms.Label();
            this.txtSubjectcolor = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnaddgrade = new System.Windows.Forms.Button();
            this.btnAddsubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-4, 478);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Size = new System.Drawing.Size(900, 6);
            this.groupBoxline.TabIndex = 92;
            this.groupBoxline.TabStop = false;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(16, 108);
            this.dgvSubjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(395, 350);
            this.dgvSubjects.TabIndex = 90;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearch.Location = new System.Drawing.Point(5, 15);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 46;
            this.lblSearch.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsearch.Location = new System.Drawing.Point(63, 12);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(108, 23);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblcount);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Location = new System.Drawing.Point(8, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 46);
            this.panel1.TabIndex = 89;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcount.Location = new System.Drawing.Point(274, 17);
            this.lblcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(128, 17);
            this.lblcount.TabIndex = 48;
            this.lblcount.Text = "No of Subjects 100";
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(784, 37);
            this.lbltop.TabIndex = 88;
            this.lbltop.Text = "Subjects Details";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubject.Location = new System.Drawing.Point(439, 115);
            this.lblsubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(129, 24);
            this.lblsubject.TabIndex = 102;
            this.lblsubject.Text = "Subject Name";
            // 
            // lblsubindex
            // 
            this.lblsubindex.AutoSize = true;
            this.lblsubindex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubindex.Location = new System.Drawing.Point(439, 168);
            this.lblsubindex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubindex.Name = "lblsubindex";
            this.lblsubindex.Size = new System.Drawing.Size(125, 24);
            this.lblsubindex.TabIndex = 102;
            this.lblsubindex.Text = "Subject Index";
            // 
            // txtSubjectname
            // 
            this.txtSubjectname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectname.Location = new System.Drawing.Point(577, 115);
            this.txtSubjectname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectname.Name = "txtSubjectname";
            this.txtSubjectname.Size = new System.Drawing.Size(188, 29);
            this.txtSubjectname.TabIndex = 103;
            // 
            // txtSubjectindex
            // 
            this.txtSubjectindex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectindex.Location = new System.Drawing.Point(577, 166);
            this.txtSubjectindex.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectindex.Name = "txtSubjectindex";
            this.txtSubjectindex.Size = new System.Drawing.Size(188, 29);
            this.txtSubjectindex.TabIndex = 103;
            // 
            // lblsuborder
            // 
            this.lblsuborder.AutoSize = true;
            this.lblsuborder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsuborder.Location = new System.Drawing.Point(439, 225);
            this.lblsuborder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsuborder.Name = "lblsuborder";
            this.lblsuborder.Size = new System.Drawing.Size(127, 24);
            this.lblsuborder.TabIndex = 102;
            this.lblsuborder.Text = "Subject Order";
            // 
            // txtSubjectorder
            // 
            this.txtSubjectorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectorder.Location = new System.Drawing.Point(577, 223);
            this.txtSubjectorder.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectorder.Name = "txtSubjectorder";
            this.txtSubjectorder.Size = new System.Drawing.Size(188, 29);
            this.txtSubjectorder.TabIndex = 103;
            // 
            // lblsubcolor
            // 
            this.lblsubcolor.AutoSize = true;
            this.lblsubcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubcolor.Location = new System.Drawing.Point(439, 284);
            this.lblsubcolor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubcolor.Name = "lblsubcolor";
            this.lblsubcolor.Size = new System.Drawing.Size(123, 24);
            this.lblsubcolor.TabIndex = 102;
            this.lblsubcolor.Text = "Subject Color";
            // 
            // txtSubjectcolor
            // 
            this.txtSubjectcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSubjectcolor.Location = new System.Drawing.Point(577, 282);
            this.txtSubjectcolor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubjectcolor.Name = "txtSubjectcolor";
            this.txtSubjectcolor.Size = new System.Drawing.Size(188, 29);
            this.txtSubjectcolor.TabIndex = 103;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(71, 496);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 38);
            this.btnEdit.TabIndex = 162;
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
            this.btnSave.Location = new System.Drawing.Point(680, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 38);
            this.btnSave.TabIndex = 161;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(387, 497);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 37);
            this.btnRefresh.TabIndex = 160;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(577, 496);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(99, 37);
            this.btnExport.TabIndex = 155;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(496, 496);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 37);
            this.btnPrint.TabIndex = 154;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(680, 496);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 37);
            this.btnClose.TabIndex = 153;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(293, 496);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 37);
            this.btnDelete.TabIndex = 152;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnaddgrade
            // 
            this.btnaddgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnaddgrade.Image = ((System.Drawing.Image)(resources.GetObject("btnaddgrade.Image")));
            this.btnaddgrade.Location = new System.Drawing.Point(163, 496);
            this.btnaddgrade.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddgrade.Name = "btnaddgrade";
            this.btnaddgrade.Size = new System.Drawing.Size(126, 39);
            this.btnaddgrade.TabIndex = 137;
            this.btnaddgrade.Text = "Add Grade";
            this.btnaddgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddgrade.UseVisualStyleBackColor = true;
            // 
            // btnAddsubject
            // 
            this.btnAddsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddsubject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddsubject.Image")));
            this.btnAddsubject.Location = new System.Drawing.Point(680, 358);
            this.btnAddsubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddsubject.Name = "btnAddsubject";
            this.btnAddsubject.Size = new System.Drawing.Size(85, 37);
            this.btnAddsubject.TabIndex = 131;
            this.btnAddsubject.Text = "Add";
            this.btnAddsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddsubject.UseVisualStyleBackColor = true;
            this.btnAddsubject.Click += new System.EventHandler(this.btnAddsubject_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 544);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnaddgrade);
            this.Controls.Add(this.btnAddsubject);
            this.Controls.Add(this.txtSubjectcolor);
            this.Controls.Add(this.txtSubjectorder);
            this.Controls.Add(this.lblsubcolor);
            this.Controls.Add(this.txtSubjectindex);
            this.Controls.Add(this.lblsuborder);
            this.Controls.Add(this.txtSubjectname);
            this.Controls.Add(this.lblsubindex);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblsubindex;
        private System.Windows.Forms.TextBox txtSubjectname;
        private System.Windows.Forms.TextBox txtSubjectindex;
        private System.Windows.Forms.Button btnAddsubject;
        private System.Windows.Forms.Button btnaddgrade;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblsuborder;
        private System.Windows.Forms.TextBox txtSubjectorder;
        private System.Windows.Forms.Label lblsubcolor;
        private System.Windows.Forms.TextBox txtSubjectcolor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
    }
}