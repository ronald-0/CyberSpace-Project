using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public class StaffCourseManService : IStaffCourse
    {
        private Dictionary<int, StaffCourseMan> _staffCourses;
      
        private int ID = 1;

        

        public StaffCourseManService()
        {
            _staffCourses = new Dictionary<int, StaffCourseMan>();
        }
        
        public List<StaffCourseMan> GetStaffCourse()  //display
        {
            return _staffCourses.Values.ToList();
        }
        public StaffCourseMan GetStaffCourseById(int ID)
        {
            if (_staffCourses.ContainsKey(ID))
                return _staffCourses[ID];
            return null;
        }


        public StaffCourseMan AddStaffCourse(StaffCourseMan staffCourse)   // add
        {
            //_staffCourses.Add(staffCourse);
            //return staffCourse;
            if (!_staffCourses.ContainsKey(staffCourse.ID))
            {
                staffCourse.ID = ID++;
                _staffCourses.Add(staffCourse.ID, staffCourse);
            }

            return staffCourse;
        }


        



        
        public StaffCourseMan UpdateStaffCourse(int ID, StaffCourseMan staffCourse)
        {
            for (var index = _staffCourses.Count - 1; index >= 0; index--)
            {
                if (_staffCourses.ContainsKey(ID))
                {
                    _staffCourses[ID] = staffCourse;
                }
                //else
                //{
                //    _staffCourses.Add(staffCourse.ID, staffCourse);
                //}

            }
            
            return staffCourse;
        }


        





        public StaffCourseMan DeleteStaffCourse(int ID)
        {
            var removed = _staffCourses[ID];
            for (var index = _staffCourses.Count - 1; index >= 0; index--)
            {
                if (_staffCourses.ContainsKey(ID))
                {
                    _staffCourses.Remove(ID);
                }
            }

            return removed;
        }

        

        
    }

}

