using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using SchoolManagmentSystem.DB_Manager;

namespace SchoolManagmentSystem
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            homeBtnToolTip_course.SetToolTip(homepageBtn_courses, "Home");
            refreshBtnToolTip_course.SetToolTip(refreshBtn_courses, "Refresh");
            addBtnToolTip_course.SetToolTip(addCourseBtn, "Add Course");
            editBtnToolTip_course.SetToolTip(editCourseBtn, "Edit Course");
            removeBtnToolTip_course.SetToolTip(removeCourseBtn, "Remove Course");
        }
        
        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        private void Courses_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select * from courses", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                coursesGridView.DataSource = dt;
                sqlCon.Close();

            }
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            homeForm form = new homeForm();
            form.Show();
            Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Courses_Load(sender, e);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
                editGroupBox.Visible = false;
            
                removeGroupBox.Visible = false;
            
                addGroupBox.Visible = true;
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
                addGroupBox.Visible = false;
            
            
                removeGroupBox.Visible = false;
            
            
                editGroupBox.Visible = true;
            
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            
                addGroupBox.Visible = false;
            
                editGroupBox.Visible = false;
            
            
                removeGroupBox.Visible = true;
            
        }

        private void submitAddBtn_Click(object sender, EventArgs e)
        {
            CourseManager course = new CourseManager();
            course.name = courseNameTextBox_add.Text;

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                
                if (course.name == "")
                {
                    MessageBox.Show("Course Name is Required");
                    courseNameTextBox_add.Focus();
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("add_course", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@course_name", course.name);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Added Successfully");
                        courseNameTextBox_add.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Not Added");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void editSubmitBtn_Click(object sender, EventArgs e)
        {
            CourseManager course = new CourseManager();
            course.id = Convert.ToInt32(courseIdTextBox_edit.Text);
            course.name = courseNameTextBox_edit.Text;

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (courseIdTextBox_edit.Text == "")
                {
                    MessageBox.Show("Course ID is Required");
                    courseIdTextBox_edit.Focus();
                }
                else if (course.name == "")
                {
                    MessageBox.Show("Course Name is Required");
                    courseNameTextBox_edit.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("edit_course", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@course_id", course.id);
                    cmd.Parameters.AddWithValue("@course_name", course.name);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        courseIdTextBox_edit.Text = "";
                        courseNameTextBox_edit.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Not Updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void submitRemoveBtn_Click(object sender, EventArgs e)
        {
            CourseManager course = new CourseManager();
            course.id = Convert.ToInt32(courseIdTextBox_remove.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (courseIdTextBox_remove.Text == "")
                {
                    MessageBox.Show("Course ID is Required");
                    courseIdTextBox_remove.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("remove_course", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@course_id", course.id);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Removed Successfully");
                        courseIdTextBox_remove.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Record Not Removed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void coursesEnrollmentTeachersLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            coursesEnrollment_Teachers form = new coursesEnrollment_Teachers();
            form.Show();
            Hide();
        }

        private void coursesEnrollmentStudentsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            coursesEnrollment_Students form = new coursesEnrollment_Students();
            form.Show();
            Hide();
        }
    }
}
