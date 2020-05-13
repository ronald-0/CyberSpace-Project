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
    [Route("api/staff")]
    public class StaffController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var staff = StaffRepo.GetAll();
            return Ok(staff);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var staff = StaffRepo.GetById(id);
            return Ok(staff);
        }

        [HttpPost("add")]
        public IActionResult AddStaff ([FromBody] StaffModel staff)
        {
            if (StaffRepo.Add(staff))
            {
                return Ok($"Successfully added {staff.name} to staff.");
            }
            else return BadRequest("This member of staff already exists.");
        }

        [HttpPut("update")]
        public IActionResult UpdateStaff([FromBody] StaffModel staff)
        {
            if (StaffRepo.Update(staff))
            {
                return Ok($"Successfully updated {staff.name}'s details.");
            }
            else return NotFound($"Staff member was not found.");
        }

        [HttpDelete("delete")]
        public IActionResult DeleteStaff([FromBody] StaffModel staff)
        {
            if (StaffRepo.Delete(staff))
            {
                return Ok($"Successfully deleted {staff.name}'s details.");
            }
            else return NotFound($"Staff member was not found.");
        }
    }
}
