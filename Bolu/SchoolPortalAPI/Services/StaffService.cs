using System;
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

        public List<Staff> GetStaff()
        {
            return _staff.Values.ToList();
        }

        public Staff GetByStaffId(int StaffID)
        {
            if (_staff.ContainsKey(StaffID))
                return _staff[StaffID];
            return null;
        }

        public Staff AddStaff(Staff staff)
        {
            if (!_staff.ContainsKey(staff.StaffID))
            {
                staff.StaffID = StaffID++;
                _staff.Add(staff.StaffID, staff);
            }

            return staff;

        }

        public Staff UpdateStaff(int StaffID, Staff staff)
        {
            for (var index = _staff.Count - 1; index >= 0; index--)
            {
                if (_staff.ContainsKey(StaffID))
                {
                    _staff[StaffID] = staff;
                }
                else
                {
                    _staff.Add(staff.StaffID, staff);
                }

            }
            return staff;
        }




        public Staff DeleteStaff(int StaffID)
        {
            var removed = _staff[StaffID];
            for (var index = _staff.Count - 1; index >= 0; index--)
            {
                
                if (_staff.ContainsKey(StaffID))
                {
                    _staff.Remove(StaffID);
                }

            }
           
            return removed;
        }




    }
}



//public Staff UpdateStaff(int ID, Staff Staff)
//{
//    if (!_faculties.ContainsKey(ID))
//    {
//        _faculties[ID] = AddStaff(Staff);

//    }
//    else
//    {
//        _faculties[ID] = Staff;


//    }

//    return Staff;

//}

//public Staff DeleteStaff(int ID)
//{
//    if (!_faculties.ContainsKey(ID))
//    {
//        return null;
//    }
//    else
//    {
//        var removed = _faculties[ID];

//        _faculties.Remove(ID);

//        return removed;
//    }


//}
//    }


