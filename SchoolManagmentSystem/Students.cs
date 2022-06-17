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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            homeToolTip_student.SetToolTip(homepageBtn_studeents, "Home");
            refreshToolTip_student.SetToolTip(refreshBtn_students, "Refresh");
            addToolTip_student.SetToolTip(addStudentBtn, "Add Student");
            editToolTip_student.SetToolTip(editStudentBtn, "Edit Student");
            removeToolTip_student.SetToolTip(removeStudentBtn, "Remove Student");
        }

        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string Gender_add = "";
        string Gender_edit = "";
        private void Students_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select * from students", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                studentsGridView.DataSource = dt;
                sqlCon.Close();

            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Students_Load(sender, e);
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            homeForm form = new homeForm();
            form.Show();
            Hide();
        }

        private void addSubmitBtn_Click(object sender, EventArgs e)
        {
            StudentManager student = new StudentManager();
            student.firstName = studentFirstNameTextBox_add.Text;
            student.lastName = studentLastNameTextBox_add.Text;
            student.birthDate = studentBirthDateTimePicker_add.Text;
            student.gender = Gender_add;
            student.enrollmentDate = studentEnrollmentDateTimePicker_add.Text;
            student.major = studentMajorComboBox_add.Text;
            student.status = studentStatusComboBox_add.Text;
            student.gpa = Convert.ToDouble(studentGpaTextBox_add.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (student.firstName == "")
                {
                    MessageBox.Show("First Name is Required");
                    studentFirstNameTextBox_add.Focus();
                }
                else if (student.lastName == "")
                {
                    MessageBox.Show("Last Name is Required");
                    studentLastNameTextBox_add.Focus();
                }
                else if (student.gender == "")
                {
                    MessageBox.Show("Gender is Required");
                    fmaleRadio_addStudent.Focus();
                }
                else if (student.major == "")
                {
                    MessageBox.Show("Majo is Required");
                    studentMajorComboBox_add.Focus();
                }
                else if (student.status == "")
                {
                    MessageBox.Show("Status is Required");
                    studentStatusComboBox_add.Focus();
                }
                else if(studentGpaTextBox_add.Text == "")
                {
                    MessageBox.Show("GPA is Required");
                    studentGpaTextBox_add.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_student", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_firstName", student.firstName);
                    cmd.Parameters.AddWithValue("@student_lastName", student.lastName);
                    cmd.Parameters.AddWithValue("@student_birthDate", student.birthDate);
                    cmd.Parameters.AddWithValue("@student_gender", student.gender);
                    cmd.Parameters.AddWithValue("@student_enrollment_date", student.enrollmentDate);
                    cmd.Parameters.AddWithValue("@student_major", student.major);
                    cmd.Parameters.AddWithValue("@student_status", student.status);
                    cmd.Parameters.AddWithValue("@student_gpa", student.gpa);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Added Successfully");
                        studentFirstNameTextBox_add.Text = "";
                        studentLastNameTextBox_add.Text = "";
                        studentBirthDateTimePicker_add.Text = "";
                        Gender_add = "";
                        studentEnrollmentDateTimePicker_add.Text = "";
                        studentMajorComboBox_add.Text = "";
                        studentStatusComboBox_add.Text = "";
                        studentGpaTextBox_add.Text = "";
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

        private void fmaleRadio_add_CheckedChanged(object sender, EventArgs e)
        {
            Gender_add = "Fmale";
        }

        private void maleRadio_add_CheckedChanged(object sender, EventArgs e)
        {
            Gender_add = "Male";
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

        private void editSubmitBtn_Click(object sender, EventArgs e)
        {
            StudentManager student = new StudentManager();
            student.id = Convert.ToInt32(studentIdNumberTextBox_edit.Text);
            student.firstName = studentFirstNameTextBox_edit.Text;
            student.lastName = studentLastNameTextBox_edit.Text;
            student.birthDate = studentBirthDateTimePicker_edit.Text;
            student.gender = Gender_edit;
            student.enrollmentDate = studentEnrollmentDateTimePicker_edit.Text;
            student.major = studentMajorComboBox_edit.Text;
            student.status = StudentStatusComboBox_edit.Text;
            student.gpa = Convert.ToDouble(gpaTextBox_editStudent.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if(studentIdNumberTextBox_edit.Text == "")
                {
                    MessageBox.Show("ID Number is Required");
                    studentIdNumberTextBox_edit.Focus();
                }
                else if (student.firstName == "")
                {
                    MessageBox.Show("First Name is Required");
                    studentFirstNameTextBox_edit.Focus();
                }
                else if (student.lastName == "")
                {
                    MessageBox.Show("Last Name is Required");
                    studentLastNameTextBox_edit.Focus();
                }
                else if (student.gender == "")
                {
                    MessageBox.Show("Gender is Required");
                    fmaleRadio_editStudent.Focus();
                }
                else if (studentMajorComboBox_edit.Text == "")
                {
                    MessageBox.Show("Majo is Required");
                    studentMajorComboBox_edit.Focus();
                }
                else if (StudentStatusComboBox_edit.Text == "")
                {
                    MessageBox.Show("Status is Required");
                    StudentStatusComboBox_edit.Focus();
                }
                else if (gpaTextBox_editStudent.Text == "")
                {
                    MessageBox.Show("GPA is Required");
                    gpaTextBox_editStudent.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("edit_student", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_id", student.id);
                    cmd.Parameters.AddWithValue("@student_firstName", student.firstName);
                    cmd.Parameters.AddWithValue("@student_lastName", student.lastName);
                    cmd.Parameters.AddWithValue("@student_birthDate", student.birthDate);
                    cmd.Parameters.AddWithValue("@student_gender", student.gender);
                    cmd.Parameters.AddWithValue("@student_enrollment_date", student.enrollmentDate);
                    cmd.Parameters.AddWithValue("@student_major", student.major);
                    cmd.Parameters.AddWithValue("@student_status", student.status);
                    cmd.Parameters.AddWithValue("@student_gpa", student.gpa);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        studentIdNumberTextBox_edit.Text = "";
                        studentFirstNameTextBox_edit.Text = "";
                        studentLastNameTextBox_edit.Text = "";
                        studentBirthDateTimePicker_edit.Text = "";
                        Gender_edit = "";
                        studentEnrollmentDateTimePicker_edit.Text = "";
                        studentMajorComboBox_edit.Text = "";
                        StudentStatusComboBox_edit.Text = "";
                        gpaTextBox_editStudent.Text = "";
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

        private void fmaleRadio_edit_CheckedChanged(object sender, EventArgs e)
        {
            Gender_edit = "Fmale";
        }

        private void maleRadio_edit_CheckedChanged(object sender, EventArgs e)
        {
            Gender_edit = "Male";
        }

        private void removeSubmitBtn_Click(object sender, EventArgs e)
        {
            StudentManager student = new StudentManager();
            student.id = Convert.ToInt32(studentIdNumberTextBox_remove.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (studentIdNumberTextBox_remove.Text == "")
                {
                    MessageBox.Show("ID Number is Required");
                    studentIdNumberTextBox_remove.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("remove_student", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_id", student.id);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Removed Successfully");
                        studentIdNumberTextBox_remove.Text = "";
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = false;
            editGroupBox.Visible = false;
            removeGroupBox.Visible = true;
        }

        private void coursesEnrollmentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            coursesEnrollment_Students form = new coursesEnrollment_Students();
            form.Show();
            Hide();
        }
    }
}
