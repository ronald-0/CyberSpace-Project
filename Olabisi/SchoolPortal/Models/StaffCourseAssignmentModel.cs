using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class StaffCourseAssignmentModel
    {
        public int courseID { get; set; }
        public int staffID { get; set; }
        public string courseName { get; set; }
        public string staffName { get; set; }
    }
}
