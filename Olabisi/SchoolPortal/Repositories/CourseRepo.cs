using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class CourseRepo
    {
        static int id;
        private static Dictionary<int, CourseModel> Store = new Dictionary<int, CourseModel>();

        public static bool Add(CourseModel course)
        {
            if (!Store.ContainsKey(course.courseID))
            {
                Store.Add(course.courseID, course);
                return true;
            }
            else return false;
        }

        public static CourseModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }

        public static List<CourseModel> GetAll()
        {
            return Store.Values.ToList();
        }

        public static bool Update(CourseModel course)
        {
            if (Store.ContainsKey(course.courseID))
            {
                Store[course.courseID] = course;
                return true;
            }
            return false;
        }
        public static bool Delete(CourseModel course)
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
