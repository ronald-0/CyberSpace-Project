using StudentCourseAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseAssignment.Services
{
    public interface IStudentCourseServices
    {
        public List<StudentCourse> GetStudentCourse();

        public StudentCourse AddStudentCourse(StudentCourse studentcourse);

        public StudentCourse UpdateStudentCourse(string code, StudentCourse studentcourse);

        public string DeleteStudentCourse(string code);
    }
}
