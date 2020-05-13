using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolPortal.Models
{
    public class assignment
    {
        public int assignmentId { get; set; }
        public string homework { get; set; }

        //to give an assignment, you have to add an assignment id so that 
        // a student can retrieve the assignment based on the assignment id
        //For a assignment of the: 
        // College of Science and Technology, use the ID number - 11
        // College of Engineering, use the ID number - 12
        // College of Business and Strategic Studies, use the ID number - 13


    }
}
