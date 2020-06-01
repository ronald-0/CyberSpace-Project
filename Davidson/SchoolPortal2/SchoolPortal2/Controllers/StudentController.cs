using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal2.Model;
using SchoolPortal2.Repository;

namespace SchoolPortal2.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET api/student/all

        [HttpGet("all")]
        public ActionResult Get()
        {
            var student = StudentRepo.GetAll();
            return Ok(student);
        }

        // GET api/student/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var student = StudentRepo.Retrieve(id);
            return Ok(student);
        }

        // POST api/student/add
        [HttpPost("add")]
        public ActionResult AddStudent([FromBody] Student s)
        {
            if (StudentRepo.Add(s))
                return Ok("Student has been successfully added");
            return BadRequest("The student has already been added");
        }

        // PUT api/student/update
        [HttpPut("update")]
        public ActionResult UpdateStudent([FromBody] Student s)
        {
            if (StudentRepo.Update(s))
                return Ok("Student has been successfull updated");
            return NotFound("The studnt record is not found");
        }

        // DELETE api/student/delete
        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Student s)
        {
            if (StudentRepo.Del(s))
                return Ok("Student has been successfull deleted");
            return NotFound("The student record is not found");
        }
    }
}
