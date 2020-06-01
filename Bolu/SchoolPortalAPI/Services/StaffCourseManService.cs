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
        
        public List<StaffCourseMan> GetStaffCourse()  //Display
        {
            return _staffCourses.Values.ToList();
        }

        public StaffCourseMan GetStaffCourseById(int ID) //GetByID
        {
            if (_staffCourses.ContainsKey(ID))
                return _staffCourses[ID];
            return null;
        }


        public StaffCourseMan AddStaffCourse(StaffCourseMan staffCourse)   // Add
        {
           
            if (!_staffCourses.ContainsKey(staffCourse.ID))
            {
                staffCourse.ID = ID++;
                _staffCourses.Add(staffCourse.ID, staffCourse);
            }

            return staffCourse;
        }


        
        public StaffCourseMan UpdateStaffCourse(int ID, StaffCourseMan staffCourse) //Update
        {
            
            if (_staffCourses.ContainsKey(ID))
            {
                _staffCourses[ID] = staffCourse;
            }
            else
            {
                _staffCourses.Add(staffCourse.ID, staffCourse);
            }


            return staffCourse;
        }



        public StaffCourseMan DeleteStaffCourse(int ID) //Delete
        {
            var removed = _staffCourses[ID];
           
            
                if (_staffCourses.ContainsKey(ID))
                {
                    _staffCourses.Remove(ID);
                }
            

            return removed;
        }

        

        
    }

}

