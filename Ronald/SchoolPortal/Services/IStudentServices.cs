using StudentManagement.Model;
using System;
using System.Collections.Generic;

namespace StudentManagement.Services
{
    public interface IStudentServices
    {
        public List<Student> GetStudent();

        public Student AddStudent(Student student);

        public Student UpdateStudent(string id, Student student);

        public string DeleteStudent(string id);
    }
}
