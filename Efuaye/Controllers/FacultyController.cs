using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Models;
using SchoolPortal.Repositories;


namespace SchoolPortal.Controllers
{
    [Route("faculty")]
    public class FacultyController : Controller
    {
        //This is for adding to the faculty
        [HttpPost("addfaculty")]
        public IActionResult AddFaculty([FromBody] FacultyModel faculty)
        {
            if (FacultyRepo.Add(faculty))
            {
                return Ok($"{faculty.name} has been successfully added to faculty.");
            }
            return BadRequest("This member of faculty already exists.");
        }

        //This is for retrieving a faculty

      [HttpGet("getfaculty")]
        public IActionResult Get(int id)
        {
            var faculty = FacultyRepo.GetById(id);
            return Ok(faculty);
        }

        [HttpPut("updatefaculty")]
        public IActionResult UpdateFaculty([FromBody] FacultyModel faculty)
        {
            if (FacultyRepo.Update(faculty))
            {
                return Ok("Faculty has been successfully updated.");
            }
            return NotFound("The faculty member was not found.");
        }

        [HttpDelete("deletefaculty")]
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
