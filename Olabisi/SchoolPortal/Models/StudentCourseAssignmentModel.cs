using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class StudentCourseAssignmentModel
    {
        public int courseID { get; set; }
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string courseName { get; set; }
    }
}
