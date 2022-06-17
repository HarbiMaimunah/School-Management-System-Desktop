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
    public partial class coursesEnrollment_Teachers : Form
    {
        public coursesEnrollment_Teachers()
        {
            InitializeComponent();
            homeToolTip.SetToolTip(homepageBtn, "Home");
            refreshToolTip.SetToolTip(refreshBtn, "Refresh");
        }

        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private void coursesEnrollment_Teachers_Load(object sender, EventArgs e)
        {
            
        }
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            homeForm form = new homeForm();
            form.Show();
            Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            TeacherManager teacher = new TeacherManager();
            teacher.id = Convert.ToInt32(teacherIdTextBox.Text);
            CourseManager course = new CourseManager();
            course.id = Convert.ToInt32(courseIdTextBox.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (teacherIdTextBox.Text == "")
                {
                    MessageBox.Show("Teacher ID is Required");
                    teacherIdTextBox.Focus();
                }
                else if (courseIdTextBox.Text == "")
                {
                    MessageBox.Show("Course ID is Required");
                    courseIdTextBox.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("connect_teacher_course", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher_id", teacher.id);
                    cmd.Parameters.AddWithValue("@course_id", course.id);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Course Enrolled Successfully");
                        teacherIdTextBox.Text = "";
                        courseIdTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Course Not Enrolled");
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            coursesEnrollment_Teachers_Load_1(sender, e);
        }

        private void coursesEnrollment_Teachers_Load_1(object sender, EventArgs e)
        {
            string joinQuery = "select teachers_courses.course_id, course_name, teachers_courses.teacher_id, teacher_firstName, teacher_lastName, teacher_department from teachers_courses " +
                "inner join teachers on teachers_courses.teacher_id = teachers.teacher_id " +
                "inner join courses on teachers_courses.course_id = courses.course_id";
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(joinQuery, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                coursesTeachersGridView.DataSource = dt;
                sqlCon.Close();

            }
        }
    }
}
