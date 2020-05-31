using System;
using System.Collections.Generic;

namespace CourseManagement.Services
{
    public class CourseServices: ICourseServices
    {
        private List<Course> _courses;

        public CourseServices()
        {
            _courses = new List<Course>();
        }

        public List<Course> GetCourse()
        {
            return _courses;
        }

        public Course AddCourse(Course course)
        {
            _courses.Add(course);
            return course;
        }

        public Course UpdateCourse(string code, Course course)
        {
            for (var index = _courses.Count - 1; index >= 0; index--)
            {
                if (_courses[index].CourseCode == code)
                {
                    _courses[index] = course;
                }
            }
            return course;
        }

        public string DeleteCourse(string code)
        {
            for (var index = _courses.Count - 1; index >= 0; index--)
            {
                if (_courses[index].CourseCode == code)
                {
                    _courses.RemoveAt(index);
                }
            }

            return code;
        }
    }
}
