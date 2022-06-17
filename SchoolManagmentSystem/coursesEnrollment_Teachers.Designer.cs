
namespace SchoolManagmentSystem
{
    partial class coursesEnrollment_Teachers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coursesEnrollment_Teachers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursesEnrollmentGroupBox = new System.Windows.Forms.GroupBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.teacherIdTextBox = new System.Windows.Forms.TextBox();
            this.courseIdLbl = new System.Windows.Forms.Label();
            this.teacherIdLbl = new System.Windows.Forms.Label();
            this.coursesTeachersGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.homeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.refreshToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.coursesEnrollmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTeachersGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.coursesEnrollmentGroupBox);
            this.panel1.Controls.Add(this.coursesTeachersGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 1047);
            this.panel1.TabIndex = 0;
            // 
            // coursesEnrollmentGroupBox
            // 
            this.coursesEnrollmentGroupBox.Controls.Add(this.submitBtn);
            this.coursesEnrollmentGroupBox.Controls.Add(this.courseIdTextBox);
            this.coursesEnrollmentGroupBox.Controls.Add(this.teacherIdTextBox);
            this.coursesEnrollmentGroupBox.Controls.Add(this.courseIdLbl);
            this.coursesEnrollmentGroupBox.Controls.Add(this.teacherIdLbl);
            this.coursesEnrollmentGroupBox.Location = new System.Drawing.Point(1397, 65);
            this.coursesEnrollmentGroupBox.Name = "coursesEnrollmentGroupBox";
            this.coursesEnrollmentGroupBox.Size = new System.Drawing.Size(404, 482);
            this.coursesEnrollmentGroupBox.TabIndex = 15;
            this.coursesEnrollmentGroupBox.TabStop = false;
            this.coursesEnrollmentGroupBox.Text = "Enroll Course for Teacher";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(157, 336);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(108, 34);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(172, 241);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.Size = new System.Drawing.Size(184, 26);
            this.courseIdTextBox.TabIndex = 6;
            // 
            // teacherIdTextBox
            // 
            this.teacherIdTextBox.Location = new System.Drawing.Point(172, 159);
            this.teacherIdTextBox.Name = "teacherIdTextBox";
            this.teacherIdTextBox.Size = new System.Drawing.Size(184, 26);
            this.teacherIdTextBox.TabIndex = 5;
            // 
            // courseIdLbl
            // 
            this.courseIdLbl.AutoSize = true;
            this.courseIdLbl.Location = new System.Drawing.Point(46, 247);
            this.courseIdLbl.Name = "courseIdLbl";
            this.courseIdLbl.Size = new System.Drawing.Size(85, 20);
            this.courseIdLbl.TabIndex = 1;
            this.courseIdLbl.Text = "Course ID:";
            // 
            // teacherIdLbl
            // 
            this.teacherIdLbl.AutoSize = true;
            this.teacherIdLbl.Location = new System.Drawing.Point(46, 162);
            this.teacherIdLbl.Name = "teacherIdLbl";
            this.teacherIdLbl.Size = new System.Drawing.Size(92, 20);
            this.teacherIdLbl.TabIndex = 0;
            this.teacherIdLbl.Text = "Teacher ID:";
            // 
            // coursesTeachersGridView
            // 
            this.coursesTeachersGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.coursesTeachersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesTeachersGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.coursesTeachersGridView.Location = new System.Drawing.Point(28, 65);
            this.coursesTeachersGridView.Name = "coursesTeachersGridView";
            this.coursesTeachersGridView.RowHeadersWidth = 62;
            this.coursesTeachersGridView.RowTemplate.Height = 28;
            this.coursesTeachersGridView.Size = new System.Drawing.Size(1237, 966);
            this.coursesTeachersGridView.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.homepageBtn);
            this.panel2.Controls.Add(this.refreshBtn);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1916, 40);
            this.panel2.TabIndex = 13;
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
            // coursesEnrollment_Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "coursesEnrollment_Teachers";
            this.Text = "Courses Enrollment for Teachers";
            this.Load += new System.EventHandler(this.coursesEnrollment_Teachers_Load_1);
            this.panel1.ResumeLayout(false);
            this.coursesEnrollmentGroupBox.ResumeLayout(false);
            this.coursesEnrollmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTeachersGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button homepageBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView coursesTeachersGridView;
        private System.Windows.Forms.GroupBox coursesEnrollmentGroupBox;
        private System.Windows.Forms.Label courseIdLbl;
        private System.Windows.Forms.Label teacherIdLbl;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox teacherIdTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ToolTip homeToolTip;
        private System.Windows.Forms.ToolTip refreshToolTip;
    }
}