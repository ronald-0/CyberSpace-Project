using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class StudentServices: IStudentServices
    {
        private List<Student> _students;

        public StudentServices()
        {
            _students = new List<Student>();
        }

        public List<Student> GetStudent()
        {
            return _students;
        }

        public Student AddStudent(Student student)
        {
            _students.Add(student);
            return student;
        }

        public Student UpdateStudent(string id, Student student)
        {
            for (var index = _students.Count - 1; index >= 0; index--)
            {
                if (_students[index].ID == id)
                {
                    _students[index] = student;
                }
            }
            return student;
        }

        public string DeleteStudent(string id)
        {
            for (var index = _students.Count - 1; index >= 0; index--)
            {
                if (_students[index].ID == id)
                {
                    _students.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
