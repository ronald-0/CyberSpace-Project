using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal2.Model;
using SchoolPortal2.Repository;


namespace SchoolPortal2.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        // GET api/course/all

        [HttpGet("all")]
        public ActionResult Get()
        {
            var course = CourseRepo.GetAll();
            return Ok(course);
        }

        // GET api/course/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var course = CourseRepo.Retrieve(id);
            return Ok(course);
        }

        // POST api/course/add
        [HttpPost("add")]
        public ActionResult AddCourse([FromBody] Course c)
        {
            if (CourseRepo.Add(c))
                return Ok("The Course has been successfully added");
            return BadRequest("The Course has already been added");
        }

        // PUT api/course/update
        [HttpPut("update")]
        public ActionResult UpdateCourse([FromBody] Course c)
        {
            if (CourseRepo.Update(c))
                return Ok("Course has been successfull updated");
            return NotFound("The Course record is not found");
        }

        // DELETE api/course/delete
        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Course c)
        {
            if (CourseRepo.Del(c))
                return Ok("Course has been successfull deleted");
            return NotFound("The Course record is not found");
        }
    }
}