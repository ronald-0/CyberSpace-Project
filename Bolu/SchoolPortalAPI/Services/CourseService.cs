using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public class CourseService : ICourseService
    {
        private Dictionary<int, Course> _courses;

        private int CourseID = 1;


        public CourseService()
        {
            _courses = new Dictionary<int, Course>();
        }

        public List<Course> GetCourses()
        {
            return _courses.Values.ToList();
        }

        
        public Course GetById(int CourseID)
        {
            if (_courses.ContainsKey(CourseID))
                return _courses[CourseID];
            return null;
        }

        public Course AddCourse(Course courseItem)
        {
            if (!_courses.ContainsKey(courseItem.CourseID))
            {
                courseItem.CourseID = CourseID++;
                _courses.Add(courseItem.CourseID, courseItem);
            }

            return courseItem;

        }

        public Course UpdateCourse(int CourseID, Course courseItem)
        {
            for (var index = _courses.Count - 1; index >= 0; index--)
            {
                if (_courses.ContainsKey(CourseID))
                {
                    _courses[CourseID] = courseItem;
                }
                else
                {
                    _courses.Add(courseItem.CourseID, courseItem);
                }

            }
            return courseItem;
        }




        public Course DeleteCourse(int CourseID)
        {
            var removed = _courses[CourseID];
            for (var index = _courses.Count - 1; index >= 0; index--)
            {
                if (_courses.ContainsKey(CourseID))
                {
                    _courses.Remove(CourseID);
                }

            }
            return removed;
        }

        
    }

}

