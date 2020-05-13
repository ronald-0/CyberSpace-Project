using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolPortal.Models;

namespace SchoolPortal.Repositories
{
    public class assignmentRepo
    {
        
        static int ID;
        public static Dictionary<int, assignment> Store2 = new Dictionary<int, assignment>();

        public static bool AddAssignment(assignment assign)
        {
            if (!Store2.ContainsKey(assign.assignmentId))
            {
                ID++;
                assign.assignmentId = ID;
                Store2.Add(assign.assignmentId, assign);
                return true;
            }
            else return false;
        }

        public static assignment GetAssignment(int id)
        {
            if (Store2.ContainsKey(id))
            {
                return Store2[id];
            }
            return null;
        }


    }
}
