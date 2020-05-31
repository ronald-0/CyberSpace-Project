using StaffCourseAssignment.Model;
using System;
using System.Collections.Generic;

namespace StaffCourseAssignment.Services
{
    public interface IStaffCourseServices
    {
        public List<StaffCourse> GetStaffCourse();

        public StaffCourse AddStaffCourse(StaffCourse staffcourse);

        public StaffCourse UpdateStaffCourse(string id, StaffCourse staffcourse);

        public string DeleteStaffCourse(string id);
    }
}
