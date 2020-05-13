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
    [Route("api/faculty")]
    public class FacultyController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var faculty = FacultyRepo.GetAll();
            return Ok(faculty);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var faculty = FacultyRepo.GetById(id);
            return Ok(faculty);
        }

        [HttpPost("add")]
        public IActionResult AddFaculty([FromBody] FacultyModel faculty)
        {
            if (FacultyRepo.Add(faculty))
            {
                return Ok($"{faculty.name} has been successfully added to faculty.");
            }
            return BadRequest("This member of faculty already exists.");
        }

        [HttpPut("update")]
        public IActionResult UpdateFaculty([FromBody] FacultyModel faculty)
        {
            if (FacultyRepo.Update(faculty))
            {
                return Ok("Faculty has been successfully updated.");
            }
            return NotFound("The faculty member was not found.");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteFaculty([FromBody] FacultyModel faculty)
        {
            if (FacultyRepo.Delete(faculty))
            {
                return Ok("Faculty has been successfully deleted.");
            }
            return NotFound("The faculty member was not found.");
        }
    }
}
