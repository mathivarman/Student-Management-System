namespace StudentManagementSystem.UI.Teachers
{
    partial class EditTeachersForm
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
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.lbltop = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(177, 271);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(181, 26);
            this.dtpDOB.TabIndex = 76;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(260, 183);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 75;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(177, 183);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 74;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-6, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 6);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelephone.Location = new System.Drawing.Point(177, 223);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(180, 26);
            this.txtTelephone.TabIndex = 71;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLastname.Location = new System.Drawing.Point(177, 132);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(180, 26);
            this.txtLastname.TabIndex = 70;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstname.Location = new System.Drawing.Point(177, 92);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(180, 26);
            this.txtFirstname.TabIndex = 69;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTeacherID.Location = new System.Drawing.Point(177, 54);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(180, 26);
            this.txtTeacherID.TabIndex = 67;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDOB.Location = new System.Drawing.Point(24, 271);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(99, 20);
            this.lblDOB.TabIndex = 66;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelephone.Location = new System.Drawing.Point(24, 223);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(108, 20);
            this.lblTelephone.TabIndex = 65;
            this.lblTelephone.Text = "Telephone No";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGender.Location = new System.Drawing.Point(24, 179);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 64;
            this.lblGender.Text = "Gender";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastname.Location = new System.Drawing.Point(24, 134);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(86, 20);
            this.lblLastname.TabIndex = 63;
            this.lblLastname.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(24, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 62;
            this.lblFirstName.Text = "First Name";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTeacherID.Location = new System.Drawing.Point(24, 56);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(88, 20);
            this.lblTeacherID.TabIndex = 68;
            this.lblTeacherID.Text = "Teacher ID";
            // 
            // lbltop
            // 
            this.lbltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbltop.ForeColor = System.Drawing.Color.White;
            this.lbltop.Location = new System.Drawing.Point(0, 0);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(377, 37);
            this.lbltop.TabIndex = 61;
            this.lbltop.Text = "Vaathi\'s Edit";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Image = global::StudentManagementSystem.Properties.Resources.icons8_refresh_30;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(177, 337);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 38);
            this.btnReset.TabIndex = 132;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(271, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 38);
            this.btnClose.TabIndex = 131;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Image = global::StudentManagementSystem.Properties.Resources.icons8_save_30;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(85, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 38);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // EditTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 386);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTeacherID);
            this.Controls.Add(this.lbltop);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditTeachersForm";
            this.Text = "EditTeachersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}