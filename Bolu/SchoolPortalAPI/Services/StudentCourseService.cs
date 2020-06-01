using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private Dictionary<int, StudentCourse> _studentcourse;

        private int StudentCourseID = 1;

        
        public StudentCourseService()
        {
            _studentcourse = new Dictionary<int, StudentCourse>();
        }

        public List<StudentCourse> GetStudentCourses() //Display
        {
            return _studentcourse.Values.ToList();
        }


        public StudentCourse GetByStudentCourseId(int StudentCourseID) //GetByID
        {
            if (_studentcourse.ContainsKey(StudentCourseID))
                return _studentcourse[StudentCourseID];
            return null;
        }

        public StudentCourse AddStudentCourse(StudentCourse studentcourseItem) //Add
        {
            if (!_studentcourse.ContainsKey(studentcourseItem.StudentCourseID))
            {
                studentcourseItem.StudentCourseID = StudentCourseID++;
                _studentcourse.Add(studentcourseItem.StudentCourseID, studentcourseItem);
            }

            return studentcourseItem;

        }


            public StudentCourse UpdateStudentCourse(int StudentCourseID, StudentCourse studentcourseItem) //Update
        {
            
            if (_studentcourse.ContainsKey(StudentCourseID))
            {
                _studentcourse[StudentCourseID] = studentcourseItem;
            }
            else
            {
                _studentcourse.Add(studentcourseItem.StudentCourseID, studentcourseItem);
            }
            return studentcourseItem;
        }




        public StudentCourse DeleteStudentCourse(int StudentCourseID) //Delete
        {
            var removed = _studentcourse[StudentCourseID];
            
            if (_studentcourse.ContainsKey(StudentCourseID))
            {
                _studentcourse.Remove(StudentCourseID);
            }

            
            return removed;
        }


    }

}
