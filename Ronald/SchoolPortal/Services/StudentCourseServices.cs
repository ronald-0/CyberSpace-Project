using StudentCourseAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseAssignment.Services
{
    public class StudentCourseServices: IStudentCourseServices
    {
        private List<StudentCourse> _studentcourses;

        public StudentCourseServices()
        {
            _studentcourses = new List<StudentCourse>();
        }

        public List<StudentCourse> GetStudentCourse()
        {
            return _studentcourses;
        }

        public StudentCourse AddStudentCourse(StudentCourse studentcourse)
        {
            _studentcourses.Add(studentcourse);
            return studentcourse;
        }

        public StudentCourse UpdateStudentCourse(string code, StudentCourse studentcourse)
        {
            for (var index = _studentcourses.Count - 1; index >= 0; index--)
            {
                if (_studentcourses[index].CourseCode == code)
                {
                    _studentcourses[index] = studentcourse;
                }
            }
            return studentcourse;
        }

        public string DeleteStudentCourse(string code)
        {
            for (var index = _studentcourses.Count - 1; index >= 0; index--)
            {
                if (_studentcourses[index].CourseCode == code)
                {
                    _studentcourses.RemoveAt(index);
                }
            }

            return code;
        }
    }
}
