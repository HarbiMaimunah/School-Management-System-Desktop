
namespace SchoolManagmentSystem
{
    partial class Courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.editSubmitBtn = new System.Windows.Forms.Button();
            this.courseIdTextBox_edit = new System.Windows.Forms.TextBox();
            this.courseNameTextBox_edit = new System.Windows.Forms.TextBox();
            this.courseNameLable = new System.Windows.Forms.Label();
            this.courseIdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coursesEnrollmentStudentsLink = new System.Windows.Forms.LinkLabel();
            this.coursesEnrollmentTeachersLink = new System.Windows.Forms.LinkLabel();
            this.homepageBtn_courses = new System.Windows.Forms.Button();
            this.refreshBtn_courses = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.removeCourseBtn = new System.Windows.Forms.Button();
            this.coursesGridView = new System.Windows.Forms.DataGridView();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.courseNameTextBox_add = new System.Windows.Forms.TextBox();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.submitAddBtn = new System.Windows.Forms.Button();
            this.removeGroupBox = new System.Windows.Forms.GroupBox();
            this.submitRemoveBtn = new System.Windows.Forms.Button();
            this.courseIdTextBox_remove = new System.Windows.Forms.TextBox();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.homeBtnToolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.refreshBtnToolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.addBtnToolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.editBtnToolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.removeBtnToolTip_course = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.editGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.removeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.editGroupBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.coursesGridView);
            this.panel1.Controls.Add(this.addGroupBox);
            this.panel1.Controls.Add(this.removeGroupBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1922, 1050);
            this.panel1.TabIndex = 0;
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.editSubmitBtn);
            this.editGroupBox.Controls.Add(this.courseIdTextBox_edit);
            this.editGroupBox.Controls.Add(this.courseNameTextBox_edit);
            this.editGroupBox.Controls.Add(this.courseNameLable);
            this.editGroupBox.Controls.Add(this.courseIdLbl);
            this.editGroupBox.Location = new System.Drawing.Point(1380, 70);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(445, 345);
            this.editGroupBox.TabIndex = 9;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit Course";
            this.editGroupBox.Visible = false;
            // 
            // editSubmitBtn
            // 
            this.editSubmitBtn.Location = new System.Drawing.Point(164, 251);
            this.editSubmitBtn.Name = "editSubmitBtn";
            this.editSubmitBtn.Size = new System.Drawing.Size(108, 34);
            this.editSubmitBtn.TabIndex = 5;
            this.editSubmitBtn.Text = "Submit";
            this.editSubmitBtn.UseVisualStyleBackColor = true;
            this.editSubmitBtn.Click += new System.EventHandler(this.editSubmitBtn_Click);
            // 
            // courseIdTextBox_edit
            // 
            this.courseIdTextBox_edit.Location = new System.Drawing.Point(183, 98);
            this.courseIdTextBox_edit.Name = "courseIdTextBox_edit";
            this.courseIdTextBox_edit.Size = new System.Drawing.Size(184, 26);
            this.courseIdTextBox_edit.TabIndex = 4;
            // 
            // courseNameTextBox_edit
            // 
            this.courseNameTextBox_edit.Location = new System.Drawing.Point(183, 171);
            this.courseNameTextBox_edit.Name = "courseNameTextBox_edit";
            this.courseNameTextBox_edit.Size = new System.Drawing.Size(184, 26);
            this.courseNameTextBox_edit.TabIndex = 3;
            // 
            // courseNameLable
            // 
            this.courseNameLable.AutoSize = true;
            this.courseNameLable.Location = new System.Drawing.Point(45, 174);
            this.courseNameLable.Name = "courseNameLable";
            this.courseNameLable.Size = new System.Drawing.Size(110, 20);
            this.courseNameLable.TabIndex = 1;
            this.courseNameLable.Text = "Course Name:";
            // 
            // courseIdLbl
            // 
            this.courseIdLbl.AutoSize = true;
            this.courseIdLbl.Location = new System.Drawing.Point(45, 101);
            this.courseIdLbl.Name = "courseIdLbl";
            this.courseIdLbl.Size = new System.Drawing.Size(85, 20);
            this.courseIdLbl.TabIndex = 0;
            this.courseIdLbl.Text = "Course ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.coursesEnrollmentStudentsLink);
            this.panel2.Controls.Add(this.coursesEnrollmentTeachersLink);
            this.panel2.Controls.Add(this.homepageBtn_courses);
            this.panel2.Controls.Add(this.refreshBtn_courses);
            this.panel2.Controls.Add(this.addCourseBtn);
            this.panel2.Controls.Add(this.editCourseBtn);
            this.panel2.Controls.Add(this.removeCourseBtn);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1916, 40);
            this.panel2.TabIndex = 12;
            // 
            // coursesEnrollmentStudentsLink
            // 
            this.coursesEnrollmentStudentsLink.AutoSize = true;
            this.coursesEnrollmentStudentsLink.Location = new System.Drawing.Point(1638, 10);
            this.coursesEnrollmentStudentsLink.Name = "coursesEnrollmentStudentsLink";
            this.coursesEnrollmentStudentsLink.Size = new System.Drawing.Size(240, 20);
            this.coursesEnrollmentStudentsLink.TabIndex = 9;
            this.coursesEnrollmentStudentsLink.TabStop = true;
            this.coursesEnrollmentStudentsLink.Text = "Courses Enrollment for Students";
            this.coursesEnrollmentStudentsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.coursesEnrollmentStudentsLink_LinkClicked);
            // 
            // coursesEnrollmentTeachersLink
            // 
            this.coursesEnrollmentTeachersLink.AutoSize = true;
            this.coursesEnrollmentTeachersLink.Location = new System.Drawing.Point(1317, 10);
            this.coursesEnrollmentTeachersLink.Name = "coursesEnrollmentTeachersLink";
            this.coursesEnrollmentTeachersLink.Size = new System.Drawing.Size(241, 20);
            this.coursesEnrollmentTeachersLink.TabIndex = 6;
            this.coursesEnrollmentTeachersLink.TabStop = true;
            this.coursesEnrollmentTeachersLink.Text = "Courses Enrollment for Teachers";
            this.coursesEnrollmentTeachersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.coursesEnrollmentTeachersLink_LinkClicked);
            // 
            // homepageBtn_courses
            // 
            this.homepageBtn_courses.Image = ((System.Drawing.Image)(resources.GetObject("homepageBtn_courses.Image")));
            this.homepageBtn_courses.Location = new System.Drawing.Point(0, 0);
            this.homepageBtn_courses.Name = "homepageBtn_courses";
            this.homepageBtn_courses.Size = new System.Drawing.Size(46, 40);
            this.homepageBtn_courses.TabIndex = 4;
            this.homepageBtn_courses.UseVisualStyleBackColor = true;
            this.homepageBtn_courses.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // refreshBtn_courses
            // 
            this.refreshBtn_courses.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn_courses.Image")));
            this.refreshBtn_courses.Location = new System.Drawing.Point(45, 0);
            this.refreshBtn_courses.Name = "refreshBtn_courses";
            this.refreshBtn_courses.Size = new System.Drawing.Size(46, 40);
            this.refreshBtn_courses.TabIndex = 5;
            this.refreshBtn_courses.UseVisualStyleBackColor = true;
            this.refreshBtn_courses.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCourseBtn.Image")));
            this.addCourseBtn.Location = new System.Drawing.Point(90, 0);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(46, 40);
            this.addCourseBtn.TabIndex = 8;
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Image = ((System.Drawing.Image)(resources.GetObject("editCourseBtn.Image")));
            this.editCourseBtn.Location = new System.Drawing.Point(135, 0);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(46, 40);
            this.editCourseBtn.TabIndex = 7;
            this.editCourseBtn.UseVisualStyleBackColor = true;
            this.editCourseBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeCourseBtn
            // 
            this.removeCourseBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeCourseBtn.Image")));
            this.removeCourseBtn.Location = new System.Drawing.Point(180, 0);
            this.removeCourseBtn.Name = "removeCourseBtn";
            this.removeCourseBtn.Size = new System.Drawing.Size(46, 40);
            this.removeCourseBtn.TabIndex = 6;
            this.removeCourseBtn.UseVisualStyleBackColor = true;
            this.removeCourseBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // coursesGridView
            // 
            this.coursesGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.coursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesGridView.Location = new System.Drawing.Point(12, 58);
            this.coursesGridView.Name = "coursesGridView";
            this.coursesGridView.RowHeadersWidth = 62;
            this.coursesGridView.RowTemplate.Height = 28;
            this.coursesGridView.Size = new System.Drawing.Size(1237, 966);
            this.coursesGridView.TabIndex = 11;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.courseNameTextBox_add);
            this.addGroupBox.Controls.Add(this.courseNameLbl);
            this.addGroupBox.Controls.Add(this.submitAddBtn);
            this.addGroupBox.Location = new System.Drawing.Point(1380, 159);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(445, 210);
            this.addGroupBox.TabIndex = 9;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Course";
            this.addGroupBox.Visible = false;
            // 
            // courseNameTextBox_add
            // 
            this.courseNameTextBox_add.Location = new System.Drawing.Point(215, 67);
            this.courseNameTextBox_add.Name = "courseNameTextBox_add";
            this.courseNameTextBox_add.Size = new System.Drawing.Size(184, 26);
            this.courseNameTextBox_add.TabIndex = 2;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Location = new System.Drawing.Point(54, 70);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(110, 20);
            this.courseNameLbl.TabIndex = 1;
            this.courseNameLbl.Text = "Course Name:";
            // 
            // submitAddBtn
            // 
            this.submitAddBtn.Location = new System.Drawing.Point(165, 136);
            this.submitAddBtn.Name = "submitAddBtn";
            this.submitAddBtn.Size = new System.Drawing.Size(108, 34);
            this.submitAddBtn.TabIndex = 0;
            this.submitAddBtn.Text = "Submit";
            this.submitAddBtn.UseVisualStyleBackColor = true;
            this.submitAddBtn.Click += new System.EventHandler(this.submitAddBtn_Click);
            // 
            // removeGroupBox
            // 
            this.removeGroupBox.Controls.Add(this.submitRemoveBtn);
            this.removeGroupBox.Controls.Add(this.courseIdTextBox_remove);
            this.removeGroupBox.Controls.Add(this.courseIdLabel);
            this.removeGroupBox.Location = new System.Drawing.Point(1380, 95);
            this.removeGroupBox.Name = "removeGroupBox";
            this.removeGroupBox.Size = new System.Drawing.Size(445, 298);
            this.removeGroupBox.TabIndex = 9;
            this.removeGroupBox.TabStop = false;
            this.removeGroupBox.Text = "Remove Course";
            this.removeGroupBox.Visible = false;
            // 
            // submitRemoveBtn
            // 
            this.submitRemoveBtn.Location = new System.Drawing.Point(170, 194);
            this.submitRemoveBtn.Name = "submitRemoveBtn";
            this.submitRemoveBtn.Size = new System.Drawing.Size(108, 34);
            this.submitRemoveBtn.TabIndex = 6;
            this.submitRemoveBtn.Text = "Submit";
            this.submitRemoveBtn.UseVisualStyleBackColor = true;
            this.submitRemoveBtn.Click += new System.EventHandler(this.submitRemoveBtn_Click);
            // 
            // courseIdTextBox_remove
            // 
            this.courseIdTextBox_remove.Location = new System.Drawing.Point(207, 112);
            this.courseIdTextBox_remove.Name = "courseIdTextBox_remove";
            this.courseIdTextBox_remove.Size = new System.Drawing.Size(184, 26);
            this.courseIdTextBox_remove.TabIndex = 5;
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Location = new System.Drawing.Point(59, 115);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(85, 20);
            this.courseIdLabel.TabIndex = 0;
            this.courseIdLabel.Text = "Course ID:";
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.panel1.ResumeLayout(false);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.removeGroupBox.ResumeLayout(false);
            this.removeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshBtn_courses;
        private System.Windows.Forms.Button homepageBtn_courses;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.Button removeCourseBtn;
        private System.Windows.Forms.TextBox courseNameTextBox_add;
        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.Button submitAddBtn;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label courseNameLable;
        private System.Windows.Forms.Label courseIdLbl;
        private System.Windows.Forms.Button editSubmitBtn;
        private System.Windows.Forms.TextBox courseIdTextBox_edit;
        private System.Windows.Forms.TextBox courseNameTextBox_edit;
        private System.Windows.Forms.GroupBox removeGroupBox;
        private System.Windows.Forms.Button submitRemoveBtn;
        private System.Windows.Forms.TextBox courseIdTextBox_remove;
        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.DataGridView coursesGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel coursesEnrollmentStudentsLink;
        private System.Windows.Forms.LinkLabel coursesEnrollmentTeachersLink;
        private System.Windows.Forms.ToolTip homeBtnToolTip_course;
        private System.Windows.Forms.ToolTip refreshBtnToolTip_course;
        private System.Windows.Forms.ToolTip addBtnToolTip_course;
        private System.Windows.Forms.ToolTip editBtnToolTip_course;
        private System.Windows.Forms.ToolTip removeBtnToolTip_course;
    }
}