using System;
using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface IStudentCourseService
    {
        public List<StudentCourse> GetStudentCourses();

        public StudentCourse AddStudentCourse(StudentCourse studentcourseItem);

        public StudentCourse UpdateStudentCourse(int StudentCourseID, StudentCourse studentcourseItem);

        public StudentCourse DeleteStudentCourse(int StudentCourseID);

        public StudentCourse GetByStudentCourseId(int StudentCourseID);
    }
}
