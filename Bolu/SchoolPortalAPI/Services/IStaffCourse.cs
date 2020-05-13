using System;
using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface IStaffCourse
    {
        public List<StaffCourseMan> GetStaffCourse();

        public StaffCourseMan AddStaffCourse(StaffCourseMan staffCourse);

        public StaffCourseMan UpdateStaffCourse(int id, StaffCourseMan staffCourse);

        public StaffCourseMan DeleteStaffCourse(int id);

        public StaffCourseMan GetStaffCourseById(int id);
    }
}
