using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Models;
using SchoolPortal.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortal.Controllers
{
    [Route("course")]
    public class CourseController : Controller
    {
        //This is to add a course
        [HttpPost("addcourse")]
        public IActionResult AddCourse([FromBody] CourseModel course)
        {
            if (CourseRepo.Add(course))
            {
                return Ok("Course successfully added.");
            }
            else return BadRequest("This course already exists.");
        }


        //This is to retrieve all the added corses
        [HttpGet("getcourse")]
        public IActionResult Get()
        {
            var course = CourseRepo.GetAll();
            return Ok(course);
        }
        /*
        [HttpDelete("delete")]
        public IActionResult DeleteFaculty([FromBody] CourseModel course)
        {
            if (CourseModel.Delete(course))
            {
                return Ok("Course has been successfully deleted.");
            }
            return NotFound("Course was not added.");
        }*/




    }
}
