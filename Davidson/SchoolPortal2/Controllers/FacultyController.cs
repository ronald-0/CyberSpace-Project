using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal2.Model;
using SchoolPortal2.Repository;


namespace SchoolPortal2.Controllers
{
    [Route("api/faculty")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        // GET api/faculty/all

        [HttpGet("all")]
        public ActionResult Get()
        {
            var faculty = FacultyRepo.GetAll();
            return Ok(faculty);
        }

        // GET api/faculty/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var faculty = FacultyRepo.Retrieve(id);
            return Ok(faculty);
        }

        // POST api/faculty/add
        [HttpPost("add")]
        public ActionResult AddFaculty([FromBody] Faculty f)
        {
            if (FacultyRepo.Add(f))
                return Ok("Faculty has been successfully added");
            return BadRequest("The Faculty has already been added");
        }

        // PUT api/faculty/update
        [HttpPut("update")]
        public ActionResult UpdateStudent([FromBody] Faculty f)
        {
            if (FacultyRepo.Update(f))
                return Ok("Faculty has been successfull updated");
            return NotFound("The Faculty record is not found");
        }

        // DELETE api/faculty/delete
        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Faculty f)
        {
            if (FacultyRepo.Del(f))
                return Ok("Faculty has been successfull deleted");
            return NotFound("The Faculty record is not found");
        }
    }
}