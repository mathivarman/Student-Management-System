namespace StudentManagementSystem.UI.GradeSubject
{
    partial class SubjectGradeForm
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
            this.lvgrades = new System.Windows.Forms.ListView();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnAddgrade = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBoxline
            // 
            this.groupBoxline.Location = new System.Drawing.Point(-32, 321);
            this.groupBoxline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Name = "groupBoxline";
            this.groupBoxline.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxline.Size = new System.Drawing.Size(1200, 7);
            this.groupBoxline.TabIndex = 127;
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
            this.lbltop.Size = new System.Drawing.Size(1048, 46);
            this.lbltop.TabIndex = 126;
            this.lbltop.Text = "Subject\'s Grade";
            this.lbltop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvgrades
            // 
            this.lvgrades.HideSelection = false;
            this.lvgrades.Location = new System.Drawing.Point(40, 69);
            this.lvgrades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvgrades.Name = "lvgrades";
            this.lvgrades.Size = new System.Drawing.Size(460, 219);
            this.lvgrades.TabIndex = 125;
            this.lvgrades.UseCompatibleStateImageBehavior = false;
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGrade.Location = new System.Drawing.Point(741, 80);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(249, 34);
            this.txtGrade.TabIndex = 134;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGrade.Location = new System.Drawing.Point(557, 80);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(80, 29);
            this.lblGrade.TabIndex = 133;
            this.lblGrade.Text = "Grade";
            // 
            // btnAddgrade
            // 
            this.btnAddgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddgrade.Image = global::StudentManagementSystem.Properties.Resources.icons8_add_30;
            this.btnAddgrade.Location = new System.Drawing.Point(894, 134);
            this.btnAddgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddgrade.Name = "btnAddgrade";
            this.btnAddgrade.Size = new System.Drawing.Size(96, 46);
            this.btnAddgrade.TabIndex = 141;
            this.btnAddgrade.Text = "Add";
            this.btnAddgrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddgrade.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Image = global::StudentManagementSystem.Properties.Resources.icons8_delete_24;
            this.button6.Location = new System.Drawing.Point(408, 344);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 46);
            this.button6.TabIndex = 140;
            this.button6.Text = "Delete";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Image = global::StudentManagementSystem.Properties.Resources.reset;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(759, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 46);
            this.button2.TabIndex = 139;
            this.button2.Text = "Refresh";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Image = global::StudentManagementSystem.Properties.Resources.close;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(892, 342);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 46);
            this.button3.TabIndex = 138;
            this.button3.Text = "Close";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Image = global::StudentManagementSystem.Properties.Resources.icons8_export_30;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(638, 342);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 46);
            this.button4.TabIndex = 137;
            this.button4.Text = "Export";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Image = global::StudentManagementSystem.Properties.Resources.icons8_print_30;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(527, 342);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 46);
            this.button5.TabIndex = 136;
            this.button5.Text = "Print";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // SubjectGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 407);
            this.Controls.Add(this.btnAddgrade);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.groupBoxline);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.lvgrades);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubjectGradeForm";
            this.Text = "SubjectGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxline;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.ListView lvgrades;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddgrade;
    }
}