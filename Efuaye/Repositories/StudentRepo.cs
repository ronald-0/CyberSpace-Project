using SchoolPortal.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class StudentRepo
    {
        static int id;
        private static Dictionary<int, StudentModel.StudentModel> Store = new Dictionary<int, StudentModel.StudentModel>();

        public static bool Add(StudentModel.StudentModel student)
        {
            if (!Store.ContainsKey(student.id))
            {
                id++;
                student.id = id;
                Store.Add(student.id, student);
                return true;
            }
            else return false;
        }

        public static StudentModel.StudentModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }
        public static List<StudentModel.StudentModel> GetAll()
        {
            return Store.Values.ToList();
        }
        public static bool Update(StudentModel.StudentModel student)
        {
            if (Store.ContainsKey(student.id))
            {
                Store[student.id] = student;
                return true;
            }
            return false;
        }
        public static bool Delete(StudentModel.StudentModel Student)
        {
            if (Store.ContainsKey(id))
            {
                id--;
                Store.Remove(Student.id);
                return true;
            }
            else return false;
        }

    }
}
