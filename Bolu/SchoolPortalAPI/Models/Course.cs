using System;
using System.Collections.Generic;

namespace SchoolPortalAPI.Models
{
    public class Course
    {
        public Course()
        {
        }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string  CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public string StaffID { get; set; }
        public int FacultyID { get; set; }

        
    }
}
