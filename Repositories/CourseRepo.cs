using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class CourseRepo
    {
        private static Dictionary<string, CourseModel> Store = new Dictionary<string, CourseModel>();

        public static bool Add(CourseModel course)
        {
            if (!Store.ContainsKey(course.courseCode))
            {
                Store.Add(course.courseCode, course);
                return true;
            }
            else return false;
        }

        public static List<CourseModel> GetAll()
        {
            return Store.Values.ToList();
        }
    }
}
