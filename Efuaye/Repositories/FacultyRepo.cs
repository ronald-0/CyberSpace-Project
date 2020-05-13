using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class FacultyRepo
    {
        static int id;
        private static Dictionary<int, FacultyModel> Store = new Dictionary<int, FacultyModel>();

        public static bool Add(FacultyModel facultyRepo)
        {
            if (!Store.ContainsKey(facultyRepo.id))
            {
                id++;
                facultyRepo.id = id;
                Store.Add(facultyRepo.id, facultyRepo);
                return true;
            }
            else return false;
        }
        public static FacultyModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }
        public static List<FacultyModel> GetAll()
        {
            return Store.Values.ToList();
        }
        public static bool Update(FacultyModel facultyModel)
        {
            if (Store.ContainsKey(facultyModel.id))
            {
                Store[facultyModel.id] = facultyModel;
                return true;
            }
            return false;
        }
        public static bool Delete(FacultyModel facultyModel)
        {
            if (Store.ContainsKey(id))
            {
                id--;
                Store.Remove(facultyModel.id);
                return true;
            }
            else return false;
        }
    }
}
