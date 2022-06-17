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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            homeBtnToolTip_teacher.SetToolTip(homepageBtn_teachers, "Home");
            refreshBtnToolTip_teacher.SetToolTip(refreshBtn_teachers, "Refresh");
            addBtnToolTip_teacher.SetToolTip(addTeacherBtn, "Add Teacher");
            editBtnToolTip_teacher.SetToolTip(editTeacherBtn, "Edit Teacher");
            removeBtnToolTip_teacher.SetToolTip(removeTeacherBtn, "Remove Teacher");
        }

        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string Gender_add = "";
        string Gender_edit = "";
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            homeForm form = new homeForm();
            form.Show();
            Hide();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(con))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("select * from teachers", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                teachersGridView.DataSource = dt;
                sqlCon.Close();

            }

        }

        private void fmaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            Gender_add = "Fmale";
        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            Gender_add = "Male";
        }

        private void addSubmitBtn_Click(object sender, EventArgs e)
        {
            TeacherManager teacher = new TeacherManager();
            teacher.firstName = fNameTextBox_add.Text;
            teacher.lastName = lNameTextBox_add.Text;
            teacher.birthDate = dateTimePicker_add.Text;
            teacher.gender = Gender_add;
            teacher.department = comboBox_add.Text;
            teacher.salary = Convert.ToInt32(salaryTextBox_Add.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (teacher.firstName == "")
                {
                    MessageBox.Show("First Name is Required");
                    fNameTextBox_add.Focus();
                }
                else if (teacher.lastName == "")
                {
                    MessageBox.Show("Last Name is Required");
                    lNameTextBox_add.Focus();
                }
                else if (teacher.gender == "")
                {
                    MessageBox.Show("Gender is Required");
                    fmaleRadio_add.Focus();
                }
                else if(teacher.department == "")
                {
                    MessageBox.Show("Department Name is Required");
                    comboBox_add.Focus();
                }
                else if (salaryTextBox_Add.Text == "")
                {
                    MessageBox.Show("Salary is Required");
                    salaryTextBox_Add.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_teacher", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher_firstName", teacher.firstName);
                    cmd.Parameters.AddWithValue("@teacher_lastName", teacher.lastName);
                    cmd.Parameters.AddWithValue("@teacher_birthDate", teacher.birthDate);
                    cmd.Parameters.AddWithValue("@teacher_gender", teacher.gender);
                    cmd.Parameters.AddWithValue("@teacher_department", teacher.department);
                    cmd.Parameters.AddWithValue("@teacher_salary", teacher.salary);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Added Successfully");
                        fNameTextBox_add.Text = "";
                        lNameTextBox_add.Text = "";
                        dateTimePicker_add.Text = "";
                        Gender_add = "";
                        comboBox_add.Text = "";
                        salaryTextBox_Add.Text = "";
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            
                editGroupBox.Visible = false;
            
                removeGroupBox.Visible = false;
            
                addGroupBox.Visible = true;
           
        }

        private void submitBtn_edit_Click(object sender, EventArgs e)
        {
            TeacherManager teacher = new TeacherManager();
            teacher.id = Convert.ToInt32(teacherIdTextBox_edit.Text);
            teacher.firstName = fNameTextBox_edit.Text;
            teacher.lastName = lNameTextBox_edit.Text;
            teacher.birthDate = dateTimePicker_edit.Text;
            teacher.gender = Gender_edit;
            teacher.department = comboBox_edit.Text;
            teacher.salary = Convert.ToInt32(salaryTextBox_edit.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (teacherIdTextBox_edit.Text == "")
                {
                    MessageBox.Show("ID Number is Required");
                    teacherIdTextBox_edit.Focus();
                }
                else if (teacher.firstName == "")
                {
                    MessageBox.Show("First Name is Required");
                    fNameTextBox_edit.Focus();
                }
                else if (teacher.lastName == "")
                {
                    MessageBox.Show("Last Name is Required");
                    lNameTextBox_edit.Focus();
                }
                else if (teacher.gender == "")
                {
                    MessageBox.Show("Gender is Required");
                    fmaleRadio_edit.Focus();
                }
                else if (teacher.department == "")
                {
                    MessageBox.Show("Department Name is Required");
                    comboBox_edit.Focus();
                }
                else if (salaryTextBox_edit.Text == "")
                {
                    MessageBox.Show("Salary is Required");
                    salaryTextBox_edit.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("edit_teacher", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher_id", teacher.id);
                    cmd.Parameters.AddWithValue("@teacher_firstName", teacher.firstName);
                    cmd.Parameters.AddWithValue("@teacher_lastName", teacher.lastName);
                    cmd.Parameters.AddWithValue("@teacher_birthDate", teacher.birthDate);
                    cmd.Parameters.AddWithValue("@teacher_gender", teacher.gender);
                    cmd.Parameters.AddWithValue("@teacher_department", teacher.department);
                    cmd.Parameters.AddWithValue("@teacher_salary", teacher.salary);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Updated Successfully");
                        teacherIdTextBox_edit.Text = "";
                        fNameTextBox_edit.Text = "";
                        lNameTextBox_edit.Text = "";
                        dateTimePicker_edit.Text = "";
                        Gender_edit = "";
                        comboBox_edit.Text = "";
                        salaryTextBox_edit.Text = "";
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            
                addGroupBox.Visible = false;
            
                removeGroupBox.Visible = false;
            
                editGroupBox.Visible = true;
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Teachers_Load(sender, e);
        }

        private void fmaleRadio_edit_CheckedChanged(object sender, EventArgs e)
        {
            Gender_edit = "Fmale";
        }

        private void maleRadio_edit_CheckedChanged(object sender, EventArgs e)
        {
            Gender_edit = "Male";
        }

        private void submitBtn_remove_Click(object sender, EventArgs e)
        {
            TeacherManager teacher = new TeacherManager();
            teacher.id = Convert.ToInt32(teacherIdTextBox_remove.Text);

            SqlConnection sqlCon = new SqlConnection(con);
            try
            {
                if (teacherIdTextBox_remove.Text == "")
                {
                    MessageBox.Show("ID Number is Required");
                    teacherIdTextBox_remove.Focus();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("remove_teacher", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@teacher_id", teacher.id);
                    sqlCon.Open();
                    int i = cmd.ExecuteNonQuery(); //used for insert and delete queries and return >0 if it executed successfully, and 0 otherwise
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Record Removed Successfully");
                        teacherIdTextBox_remove.Text = "";
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
            coursesEnrollment_Teachers form = new coursesEnrollment_Teachers();
            form.Show();
            Hide();
        }
    }
}
