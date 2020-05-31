using System;
using System.Collections.Generic;


namespace CourseManagement.Services
{
    public interface ICourseServices
    {
        public List<Course> GetCourse();

        public Course AddCourse(Course course);

        public Course UpdateCourse(string id, Course course);

        public string DeleteCourse(string id);
    }
}
