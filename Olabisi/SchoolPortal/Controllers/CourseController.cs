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
    [Route("api/course")]
    public class CourseController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var course = CourseRepo.GetAll();
            return Ok(course);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var faculty = CourseRepo.GetById(id);
            return Ok(faculty);
        }

        [HttpPost("add")]
        public IActionResult AddCourse([FromBody] CourseModel course)
        {
            if (CourseRepo.Add(course))
            {
                return Ok("Course successfully added.");
            }
            else return BadRequest("This course already exists.");
        }

        [HttpPut("update")]
        public IActionResult UpdateCourse([FromBody] CourseModel course)
        {
            if (CourseRepo.Update(course))
            {
                return Ok("Course has been successfully updated.");
            }
            return NotFound("The course was not found.");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCourse([FromBody] CourseModel course)
        {
            if (CourseRepo.Delete(course))
            {
                return Ok("Course has been successfully deleted.");
            }
            return NotFound("The course was not found.");
        }
    }
}
