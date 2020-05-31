using StaffManagement.Model;
using System;
using System.Collections.Generic;

namespace StaffManagement.Services
{
    public interface IStaffServices
    {
        public List<Staff> GetStaff();

        public Staff AddStaff(Staff staff);

        public Staff UpdateStaff(string id, Staff staff);

        public string DeleteStaff(string id);
    }
}
