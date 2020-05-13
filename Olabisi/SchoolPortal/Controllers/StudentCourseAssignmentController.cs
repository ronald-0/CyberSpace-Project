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
    [Route("api/studCourseAssignment")]
    public class StudentCourseAssignmentController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var courseAssignment = StudentCourseAssignmentRepo.GetAll();
            return Ok(courseAssignment);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var students = StudentCourseAssignmentRepo.GetById(id);
            return Ok(students);
        }

        [HttpPost("add")]
        public IActionResult AddCourse([FromBody] StudentCourseAssignmentModel course)
        {
            if (StudentCourseAssignmentRepo.Add(course))
            {
                return Ok("Course has been successfully added.");
            }
            return BadRequest("The course has already been added.");
        }

        [HttpPut("update")]
        public IActionResult UpdateCourse([FromBody] StudentCourseAssignmentModel course)
        {
            if (StudentCourseAssignmentRepo.Update(course))
            {
                return Ok("Course has been successfully updated.");
            }
            return NotFound("The course was not found.");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCourse([FromBody] StudentCourseAssignmentModel course)
        {
            if (StudentCourseAssignmentRepo.Delete(course))
            {
                return Ok("Course has been successfully deleted.");
            }
            return NotFound("The course was not found.");
        }
    }
}
