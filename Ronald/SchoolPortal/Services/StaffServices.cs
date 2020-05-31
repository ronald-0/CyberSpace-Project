using StaffManagement.Model;
using System;
using System.Collections.Generic;

namespace StaffManagement.Services
{
    public class StaffServices: IStaffServices
    {
        private List<Staff> _staff;

        public StaffServices()
        {
            _staff = new List<Staff>();
        }

        public List<Staff> GetStaff()
        {
            return _staff;
        }

        public Staff AddStaff(Staff staff)
        {
            _staff.Add(staff);
            return staff;
        }

        public Staff UpdateStaff(string id, Staff staff)
        {
            for (var index = _staff.Count - 1; index >= 0; index--)
            {
                if (_staff[index].ID == id)
                {
                    _staff[index] = staff;
                }
            }
            return staff;
        }

        public string DeleteStaff(string id)
        {
            for (var index = _staff.Count - 1; index >= 0; index--)
            {
                if (_staff[index].ID == id)
                {
                    _staff.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
