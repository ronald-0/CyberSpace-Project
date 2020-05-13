using System;
using System.Collections.Generic;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public interface IStudentService
    {
        public List<Student> GetStudents();

        public Student AddStudent(Student studentItem);

        public Student UpdateStudent(int StudentID, Student studentItem);

        public Student DeleteStudent(int StudentID);

        public Student GetByStudentId(int StudentID);
    }
}
