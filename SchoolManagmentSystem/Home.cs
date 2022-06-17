using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void coursesBtn_Click(object sender, EventArgs e)
        {
            Courses form = new Courses();
            form.Show();
            Hide();
        }

        private void teachersBtn_Click(object sender, EventArgs e)
        {
            Teachers form = new Teachers();
            form.Show();
            Hide();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            Students form = new Students();
            form.Show();
            Hide();
        }
    }
}
