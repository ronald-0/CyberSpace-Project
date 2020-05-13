using SchoolPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Repositories
{
    public class StaffRepo
    {
        static int id;
        public static Dictionary<int, StaffModel> Store = new Dictionary<int, StaffModel>();

        public static bool Add(StaffModel staffModel)
        {
            if (!Store.ContainsKey(staffModel.id))
            {
                id++;
                staffModel.id = id;
                Store.Add(staffModel.id, staffModel);
                return true;
            }
            else return false;
        }

        public static StaffModel GetById(int id)
        {
            if (Store.ContainsKey(id))
            {
                return Store[id];
            }
            return null;
        }

        public static List<StaffModel> GetAll()
        {
            return Store.Values.ToList();
        }

        public static bool Update(StaffModel staffModel)
        {
            if (Store.ContainsKey(staffModel.id))
            {
                Store[staffModel.id] = staffModel;
                return true;
            }
            return false;
        }

        public static bool Delete(StaffModel staffModel)
        {
            if (Store.ContainsKey(id))
            {
                id--;
                Store.Remove(staffModel.id);
                return true;
            }
            return false;
        }
    }
}
