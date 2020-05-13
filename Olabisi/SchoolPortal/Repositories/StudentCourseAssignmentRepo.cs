using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class StudentCourseAssignmentRepo
    {
        static int id;
        private static Dictionary<int, StudentCourseAssignmentModel> Store = new Dictionary<int, StudentCourseAssignmentModel>();

        public static bool Add(StudentCourseAssignmentModel course)
        {
            if (!Store.ContainsKey(course.courseID))
            {
                id++;
                course.courseID = id;
                Store.Add(course.courseID, course);
                return true;
            }
            else return false;
        }

        public static StudentCourseAssignmentModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }

        public static List<StudentCourseAssignmentModel> GetAll()
        {
            return Store.Values.ToList();
        }

        public static bool Update(StudentCourseAssignmentModel course)
        {
            if (Store.ContainsKey(course.courseID))
            {
                Store[course.courseID] = course;
                return true;
            }
            return false;
        }
        public static bool Delete(StudentCourseAssignmentModel course)
        {
            if (Store.ContainsKey(id))
            {
                id--;
                Store.Remove(course.courseID);
                return true;
            }
            else return false;
        }
    }
}
