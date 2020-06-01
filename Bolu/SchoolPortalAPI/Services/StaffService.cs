using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services

{
    public class StaffService : IStaffService
    {
        private Dictionary<int, Staff> _staff;
        //private List<Staff> _StaffItems;
        private int StaffID = 1;


        public StaffService()
        {
            _staff = new Dictionary<int, Staff>();
        }

        public List<Staff> GetStaff() //Display
        {
            return _staff.Values.ToList();
        }

        public Staff GetByStaffId(int StaffID) //GetByID
        {
            if (_staff.ContainsKey(StaffID))
                return _staff[StaffID];
            return null;
        }

        public Staff AddStaff(Staff staff) //Add
        {
            if (!_staff.ContainsKey(staff.StaffID))
            {
                staff.StaffID = StaffID++;
                _staff.Add(staff.StaffID, staff);
            }

            return staff;

        }

        public Staff UpdateStaff(int StaffID, Staff staff) //Update
        {

            if (_staff.ContainsKey(StaffID))
            {
                _staff[StaffID] = staff;
            }
            else
            {
                _staff.Add(staff.StaffID, staff);
            }

            
            return staff;
        }




        public Staff DeleteStaff(int StaffID) //Delete
        {
            var removed = _staff[StaffID];
            
                
            if (_staff.ContainsKey(StaffID))
            {
                _staff.Remove(StaffID);
            }

            
           
            return removed;
        }




    }
}



