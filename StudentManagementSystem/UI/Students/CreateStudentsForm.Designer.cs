namespace StudentManagementSystem.UI.Students
{
    partial class CreateStudentsForm
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
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbsubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(232, 274);
            this.cmbgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(323, 33);
            this.cmbgrade.TabIndex = 37;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(232, 233);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 35;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-9, 450);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(651, 7);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastname.Location = new System.Drawing.Point(232, 170);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(321, 30);
            this.txtLastname.TabIndex = 32;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstname.Location = new System.Drawing.Point(232, 121);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(321, 30);
            this.txtFirstname.TabIndex = 27;
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdmissionNo.Location = new System.Drawing.Point(232, 74);
            this.txtAdmissionNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.Size = new System.Drawing.Size(321, 30);
            this.txtAdmissionNo.TabIndex = 25;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDOB.Location = new System.Drawing.Point(28, 342);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(118, 25);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGrade.Location = new System.Drawing.Point(28, 283);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(66, 25);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.Text = "Grade";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGender.Location = new System.Drawing.Point(28, 228);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastname.Location = new System.Drawing.Point(28, 174);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 25);
            this.lblLastname.TabIndex = 16;
            this.lblLastname.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(28, 124);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmissionNo.Location = new System.Drawing.Point(28, 78);
            this.lblAdmissionNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(133, 25);
            this.lblAdmissionNo.TabIndex = 26;
            this.lblAdmissionNo.Text = "Admission No";
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
            this.lbltop.Size = new System.Drawing.Size(585, 46);
            this.lbltop.TabIndex = 14;
            this.lbltop.Text = "Mathi\'s Details";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Location = new System.Drawing.Point(232, 342);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(323, 30);
            this.dtpDOB.TabIndex = 40;
            // 
            // cmbsubjects
            // 
            this.cmbsubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubjects.FormattingEnabled = true;
            this.cmbsubjects.Location = new System.Drawing.Point(232, 399);
            this.cmbsubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbsubjects.Name = "cmbsubjects";
            this.cmbsubjects.Size = new System.Drawing.Size(323, 33);
            this.cmbsubjects.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(28, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "Subjects";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(343, 233);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 36;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Image = global::StudentManagementSystem.Properties.Resources.reset;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(335, 482);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 47);
            this.btnReset.TabIndex = 129;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(464, 482);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 47);
            this.btnClose.TabIndex = 128;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Image = global::StudentManagementSystem.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(213, 483);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 46);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CreateStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 555);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbsubjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAdmissionNo);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateStudentsForm";
            this.Text = "CreateStudentsForm";
            this.Load += new System.EventHandler(this.CreateStudentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbsubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}