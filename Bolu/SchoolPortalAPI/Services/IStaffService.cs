using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface IStaffService
    {
        public List<Staff> GetStaff();

        public Staff AddStaff(Staff staff);

        public Staff UpdateStaff(int id, Staff staff);

        public Staff DeleteStaff(int id);

        public Staff GetByStaffId(int id);
    }
}