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
    public partial class coursesEnrollment_Students : Form
    {
        public coursesEnrollment_Students()
        {
            InitializeComponent();
        }

        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            homeForm form = new homeForm();
            form.Show();
            Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            StudentManager student = new StudentManager();
            student.id = Convert.ToInt32(studentIdTextBox.Text);
            CourseManager course = new CourseManager();
            course.id = Convert.ToInt32(courseIdTextBox.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (studentIdTextBox.Text == "")
                {
                    MessageBox.Show("Student ID is Required");
                    studentIdTextBox.Focus();
                }
                else if (courseIdTextBox.Text == "")
                {
                    MessageBox.Show("Course ID is Required");
                    courseIdTextBox.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("connect_student_course", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_id", student.id);
                    cmd.Parameters.AddWithValue("@course_id", course.id);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Course Enrolled Successfully");
                        studentIdTextBox.Text = "";
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

        private void coursesEnrollment_Students_Load(object sender, EventArgs e)
        {
            string joinQuery = "select students_courses.course_id, course_name, students_courses.student_id, student_firstName, student_lastName, student_major, student_status from students_courses " +
                "inner join students on students_courses.student_id = students.student_id " +
                "inner join courses on students_courses.course_id = courses.course_id";
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(joinQuery, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                coursesStudentsGridView.DataSource = dt;
                sqlCon.Close();

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            coursesEnrollment_Students_Load(sender, e);
        }
    }
}
