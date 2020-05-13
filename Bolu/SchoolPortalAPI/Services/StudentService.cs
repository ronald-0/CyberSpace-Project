using System;
using System.Collections.Generic;
using System.Linq;
using SchoolPortalAPI.Models;

namespace SchoolPortalAPI.Services
{
    public class StudentService : IStudentService
    {
        private Dictionary<int, Student> _student;

        private int StudentID = 1;


        public StudentService()
        {
            _student = new Dictionary<int, Student>();
        }

        public List<Student> GetStudents()
        {
            return _student.Values.ToList();
        }


        public Student GetByStudentId(int StudentID)
        {
            if (_student.ContainsKey(StudentID))
                return _student[StudentID];
            return null;
        }

        public Student AddStudent(Student studentItem)
        {
            if (!_student.ContainsKey(studentItem.StudentID))
            {
                studentItem.StudentID = StudentID++;
                _student.Add(studentItem.StudentID, studentItem);
            }

            return studentItem;

        }

        public Student UpdateStudent(int StudentID, Student studentItem)
        {
            for (var index = _student.Count - 1; index >= 0; index--)
            {
                if (_student.ContainsKey(StudentID))
                {
                    _student[StudentID] = studentItem;
                }
                else
                {
                    _student.Add(studentItem.StudentID, studentItem);
                }

            }
            return studentItem;
        }




        public Student DeleteStudent(int StudentID)
        {
            var removed = _student[StudentID];
            for (var index = _student.Count - 1; index >= 0; index--)
            {
                if (_student.ContainsKey(StudentID))
                {
                    _student.Remove(StudentID);
                }

            }
            return removed;
        }


    }

}
