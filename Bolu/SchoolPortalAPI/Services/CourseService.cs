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

        public List<Course> GetCourses() //Display
        {
            return _courses.Values.ToList();
        }

        
        public Course GetById(int CourseID) //GetByID
        {
            if (_courses.ContainsKey(CourseID))
                return _courses[CourseID];
            return null;
        }

        public Course AddCourse(Course courseItem) //Add
        {
            if (!_courses.ContainsKey(courseItem.CourseID))
            {
                courseItem.CourseID = CourseID++;
                _courses.Add(courseItem.CourseID, courseItem);
            }

            return courseItem;

        }

        // DONE: this code can be improved on to reduce the time complexity 
        // DONE: remove the loop
        public Course UpdateCourse(int CourseID, Course courseItem) //Update
        {
            
                if (_courses.ContainsKey(CourseID))
                {
                    _courses[CourseID] = courseItem;
                }
                else
                {
                    _courses.Add(courseItem.CourseID, courseItem);
                }

            
            return courseItem;
        }

        


        public Course DeleteCourse(int CourseID) //Delete
        {
            var removed = _courses[CourseID];
            
                if (_courses.ContainsKey(CourseID))
                {
                    _courses.Remove(CourseID);
                }

            
            return removed;
        }

        
    }

}

