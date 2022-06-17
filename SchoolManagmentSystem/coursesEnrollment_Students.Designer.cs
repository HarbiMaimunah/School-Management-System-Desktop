
namespace SchoolManagmentSystem
{
    partial class coursesEnrollment_Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coursesEnrollment_Students));
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursesEnrollmentGroupBox = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.courseIdLbl = new System.Windows.Forms.Label();
            this.studentIdLbl = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.coursesStudentsGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.coursesEnrollmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesStudentsGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.coursesEnrollmentGroupBox);
            this.panel1.Controls.Add(this.coursesStudentsGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1922, 1049);
            this.panel1.TabIndex = 0;
            // 
            // coursesEnrollmentGroupBox
            // 
            this.coursesEnrollmentGroupBox.Controls.Add(this.submitBtn);
            this.coursesEnrollmentGroupBox.Controls.Add(this.courseIdLbl);
            this.coursesEnrollmentGroupBox.Controls.Add(this.studentIdLbl);
            this.coursesEnrollmentGroupBox.Controls.Add(this.courseIdTextBox);
            this.coursesEnrollmentGroupBox.Controls.Add(this.studentIdTextBox);
            this.coursesEnrollmentGroupBox.Location = new System.Drawing.Point(1389, 66);
            this.coursesEnrollmentGroupBox.Name = "coursesEnrollmentGroupBox";
            this.coursesEnrollmentGroupBox.Size = new System.Drawing.Size(428, 482);
            this.coursesEnrollmentGroupBox.TabIndex = 16;
            this.coursesEnrollmentGroupBox.TabStop = false;
            this.coursesEnrollmentGroupBox.Text = "Enroll Course for Student";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(170, 341);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(108, 34);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // courseIdLbl
            // 
            this.courseIdLbl.AutoSize = true;
            this.courseIdLbl.Location = new System.Drawing.Point(52, 237);
            this.courseIdLbl.Name = "courseIdLbl";
            this.courseIdLbl.Size = new System.Drawing.Size(85, 20);
            this.courseIdLbl.TabIndex = 9;
            this.courseIdLbl.Text = "Course ID:";
            // 
            // studentIdLbl
            // 
            this.studentIdLbl.AutoSize = true;
            this.studentIdLbl.Location = new System.Drawing.Point(52, 159);
            this.studentIdLbl.Name = "studentIdLbl";
            this.studentIdLbl.Size = new System.Drawing.Size(91, 20);
            this.studentIdLbl.TabIndex = 8;
            this.studentIdLbl.Text = "Student ID:";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(188, 234);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(184, 26);
            this.courseIdTextBox.TabIndex = 7;
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(188, 156);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(184, 26);
            this.studentIdTextBox.TabIndex = 6;
            // 
            // coursesStudentsGridView
            // 
            this.coursesStudentsGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.coursesStudentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesStudentsGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.coursesStudentsGridView.Location = new System.Drawing.Point(26, 66);
            this.coursesStudentsGridView.Name = "coursesStudentsGridView";
            this.coursesStudentsGridView.RowHeadersWidth = 62;
            this.coursesStudentsGridView.RowTemplate.Height = 28;
            this.coursesStudentsGridView.Size = new System.Drawing.Size(1237, 966);
            this.coursesStudentsGridView.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.homepageBtn);
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1922, 40);
            this.panel2.TabIndex = 14;
            // 
            // homepageBtn
            // 
            this.homepageBtn.Image = ((System.Drawing.Image)(resources.GetObject("homepageBtn.Image")));
            this.homepageBtn.Location = new System.Drawing.Point(0, 0);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(46, 40);
            this.homepageBtn.TabIndex = 4;
            this.homepageBtn.UseVisualStyleBackColor = true;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(45, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(46, 40);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // coursesEnrollment_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "coursesEnrollment_Students";
            this.Text = "Courses Enrollment for Students";
            this.Load += new System.EventHandler(this.coursesEnrollment_Students_Load);
            this.panel1.ResumeLayout(false);
            this.coursesEnrollmentGroupBox.ResumeLayout(false);
            this.coursesEnrollmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesStudentsGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox coursesEnrollmentGroupBox;
        private System.Windows.Forms.DataGridView coursesStudentsGridView;
        private System.Windows.Forms.Label courseIdLbl;
        private System.Windows.Forms.Label studentIdLbl;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Button submitBtn;
    }
}