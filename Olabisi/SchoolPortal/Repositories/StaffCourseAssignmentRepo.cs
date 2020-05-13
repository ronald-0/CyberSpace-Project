using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class StaffCourseAssignmentRepo
    {
        static int id;

        private static Dictionary<int, StaffCourseAssignmentModel> Store = new Dictionary<int, StaffCourseAssignmentModel>();

        public static bool Add(StaffCourseAssignmentModel course)
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


        public static StaffCourseAssignmentModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }

        public static List<StaffCourseAssignmentModel> GetAll()
        {
            return Store.Values.ToList();
        }

        public static bool Update(StaffCourseAssignmentModel course)
        {
            if (Store.ContainsKey(course.courseID))
            {
                Store[course.courseID] = course;
                return true;
            }
            return false;
        }
        public static bool Delete(StaffCourseAssignmentModel course)
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
