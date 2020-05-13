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
    [Route("api/staffCourseAssignment")]
    public class StaffCourseAssignmentController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var courseAssignment = StaffCourseAssignmentRepo.GetAll();
            return Ok(courseAssignment);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var students = StaffCourseAssignmentRepo.GetById(id);
            return Ok(students);
        }

        [HttpPost("add")]
        public IActionResult AddCourse([FromBody] StaffCourseAssignmentModel courseAssignment)
        {
            if (StaffCourseAssignmentRepo.Add(courseAssignment))
            {
                return Ok("Course successfully added.");
            }
            else return BadRequest("This course already exists.");
        }

        [HttpPut("update")]
        public IActionResult UpdateCourse([FromBody] StaffCourseAssignmentModel course)
        {
            if (StaffCourseAssignmentRepo.Update(course))
            {
                return Ok("Course has been successfully updated.");
            }
            return NotFound("The course was not found.");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteCourse([FromBody] StaffCourseAssignmentModel course)
        {
            if (StaffCourseAssignmentRepo.Delete(course))
            {
                return Ok("Course has been successfully deleted.");
            }
            return NotFound("The course was not found.");
        }
    }
}
