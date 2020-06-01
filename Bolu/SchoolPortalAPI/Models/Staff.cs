using System;
namespace SchoolPortalAPI.Models
{
    public class Staff
    {
        public Staff()
        {
        }

        public int StaffID { get; set; }
        public string Name { get; set; }
        public string DateEmployed { get; set; }
        public int Courseid { get; set; }
        public string PhoneNo { get; set; }
        public int Facultyid { get; set; }
    }
}
