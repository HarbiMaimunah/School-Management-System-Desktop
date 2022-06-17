using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem.DB_Manager
{
    class StudentManager
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string gender { get; set; }
        public string enrollmentDate { get; set; }
        public string major { get; set; }
        public string status { get; set; }
        public double gpa { get; set; }
    }
}
