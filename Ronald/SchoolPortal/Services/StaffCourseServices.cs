using StaffCourseAssignment.Model;
using System;
using System.Collections.Generic;

namespace StaffCourseAssignment.Services
{
    public class StaffCourseServices: IStaffCourseServices
    {
        private List<StaffCourse> _staffcourses;

        public StaffCourseServices()
        {
            _staffcourses = new List<StaffCourse>();
        }

        public List<StaffCourse> GetStaffCourse()
        {
            return _staffcourses;
        }

        public StaffCourse AddStaffCourse(StaffCourse staffcourse)
        {
            _staffcourses.Add(staffcourse);
            return staffcourse;
        }

        public StaffCourse UpdateStaffCourse(string id, StaffCourse staffcourse)
        {
            for (var index = _staffcourses.Count - 1; index >= 0; index--)
            {
                if (_staffcourses[index].ID == id)
                {
                    _staffcourses[index] = staffcourse;
                }
            }
            return staffcourse;
        }

        public string DeleteStaffCourse(string id)
        {
            for (var index = _staffcourses.Count - 1; index >= 0; index--)
            {
                if (_staffcourses[index].ID == id)
                {
                    _staffcourses.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
