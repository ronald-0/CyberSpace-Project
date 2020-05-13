using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Repositories;
using SchoolPortal.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortal.Controllers
{
    [Route("api/studCourseAssignment")]
    public class StudentCourseAssignmentController : Controller
    {
        // a student can retrieve the assignment based on the assignment id
        //For a assignment of the: 
        // College of Science and Technology, use the ID number - 11
        // College of Engineering, use the ID number - 12
        // College of Business and Strategic Studies, use the ID number - 13
        [HttpGet("getAssignment")]
        public IActionResult Get(int id)
        {
            var studassignment = assignmentRepo.GetAssignment(id);
            return Ok(studassignment);
        }
       
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
