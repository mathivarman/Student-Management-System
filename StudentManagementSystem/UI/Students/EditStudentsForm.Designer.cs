namespace StudentManagementSystem.UI.Students
{
    partial class EditStudentsForm
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
            this.lbltop = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lbladmission = new System.Windows.Forms.Label();
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblTelephoneno = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(453, 37);
            this.lbltop.TabIndex = 43;
            this.lbltop.Text = "Student\'s Edits";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Image = global::StudentManagementSystem.Properties.Resources.icons8_refresh_30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(243, 504);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 38);
            this.btnReset.TabIndex = 174;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(337, 504);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 38);
            this.btnClose.TabIndex = 173;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Image = global::StudentManagementSystem.Properties.Resources.icons8_save_30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(151, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 38);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtpAdmission
            // 
            this.dtpAdmission.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdmission.Location = new System.Drawing.Point(173, 451);
            this.dtpAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(257, 26);
            this.dtpAdmission.TabIndex = 171;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(173, 261);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(257, 26);
            this.dtpDOB.TabIndex = 170;
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(173, 220);
            this.cmbgrade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(257, 28);
            this.cmbgrade.TabIndex = 169;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(256, 183);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 168;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(173, 183);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 167;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-18, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 6);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(173, 392);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(256, 39);
            this.txtAddress.TabIndex = 164;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(173, 349);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 26);
            this.txtEmail.TabIndex = 162;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastname.Location = new System.Drawing.Point(173, 134);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(256, 26);
            this.txtLastname.TabIndex = 165;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelephoneNo.Location = new System.Drawing.Point(173, 306);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.Size = new System.Drawing.Size(256, 26);
            this.txtTelephoneNo.TabIndex = 158;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstname.Location = new System.Drawing.Point(173, 91);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(257, 26);
            this.txtFirstname.TabIndex = 163;
            // 
            // lbladmission
            // 
            this.lbladmission.AutoSize = true;
            this.lbladmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbladmission.Location = new System.Drawing.Point(20, 456);
            this.lbladmission.Name = "lbladmission";
            this.lbladmission.Size = new System.Drawing.Size(139, 20);
            this.lbladmission.TabIndex = 157;
            this.lbladmission.Text = "Date of Admission";
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdmissionNo.Location = new System.Drawing.Point(173, 48);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.Size = new System.Drawing.Size(256, 26);
            this.txtAdmissionNo.TabIndex = 159;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDOB.Location = new System.Drawing.Point(20, 266);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(99, 20);
            this.lblDOB.TabIndex = 156;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGrade.Location = new System.Drawing.Point(20, 223);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(54, 20);
            this.lblGrade.TabIndex = 155;
            this.lblGrade.Text = "Grade";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.Location = new System.Drawing.Point(20, 395);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 153;
            this.lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGender.Location = new System.Drawing.Point(20, 180);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 154;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(20, 352);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 20);
            this.lblEmail.TabIndex = 150;
            this.lblEmail.Text = "Email ID";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastname.Location = new System.Drawing.Point(20, 137);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(86, 20);
            this.lblLastname.TabIndex = 152;
            this.lblLastname.Text = "Last Name";
            // 
            // lblTelephoneno
            // 
            this.lblTelephoneno.AutoSize = true;
            this.lblTelephoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelephoneno.Location = new System.Drawing.Point(20, 309);
            this.lblTelephoneno.Name = "lblTelephoneno";
            this.lblTelephoneno.Size = new System.Drawing.Size(111, 20);
            this.lblTelephoneno.TabIndex = 160;
            this.lblTelephoneno.Text = "Telephone NO";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(20, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 151;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdmissionNo.Location = new System.Drawing.Point(20, 51);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(106, 20);
            this.lblAdmissionNo.TabIndex = 161;
            this.lblAdmissionNo.Text = "Admission No";
            // 
            // EditStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 551);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpAdmission);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtTelephoneNo);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lbladmission);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblTelephoneno);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAdmissionNo);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditStudentsForm";
            this.Text = "EditStudentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpAdmission;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lbladmission;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblTelephoneno;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblAdmissionNo;
    }
}