using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalProject.Model;
using PortalProject.Repository;

namespace PortalProject.Controllers
{
    [Route("api/staff")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        // GET api/staff/all

        [HttpGet("all")]
        public ActionResult Get()
        {
            var staff = StaffRepo.GetAll();
            return Ok(staff);
        }

        // GET api/staff/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var staff = StaffRepo.Retrieve(id);
            return Ok(staff);
        }

        // POST api/staff/add
        [HttpPost("add")]
        public ActionResult AddStaff([FromBody] Staff s)
        {
            if (StaffRepo.Add(s))
                return Ok("Staff has been successfully added");
            return BadRequest("The Staff has already been added");
        }

        // PUT api/staff/update
        [HttpPut("update")]
        public ActionResult UpdateStaff([FromBody] Staff s)
        {
            if (StaffRepo.Update(s))
                return Ok("Staff has been successfull updated");
            return NotFound("The Staff record is not found");
        }

        // DELETE api/staff/delete
        [HttpDelete("delete")]
        public ActionResult Delete([FromBody] Staff s)
        {
            if (StaffRepo.Del(s))
                return Ok("Staff has been successfull deleted");
            return NotFound("The Staff record is not found");
        }
    }
}