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
    [Route("staff")]
    public class StaffController : Controller
    {
        [HttpGet("getAllStaff")]
        public IActionResult Get()
        {
            var staff = StaffRepo.GetAll();
            return Ok(staff);
        }

        [HttpGet("getStaff")]
        public IActionResult Get(int id)
        {
            var staff = StaffRepo.GetById(id);
            return Ok(staff);
        }

        [HttpPost("addStaff")]
        public IActionResult AddStaff ([FromBody] StaffModel staff)
        {
            if (StaffRepo.Add(staff))
            {
                return Ok($"Successfully added {staff.name} to staff.");
            }
            else return BadRequest("This member of staff already exists.");
        }

        [HttpPut("updateStaff")]
        public IActionResult UpdateStaff([FromBody] StaffModel staff)
        {
            if (StaffRepo.Update(staff))
            {
                return Ok($"Successfully updated {staff.name}'s details.");
            }
            else return NotFound($"Staff member was not found.");
        }

        [HttpDelete("deleteStaff")]
        public IActionResult DeleteStaff([FromBody] StaffModel staff)
        {
            if (StaffRepo.Delete(staff))
            {
                return Ok($"Successfully deleted {staff.name}'s details.");
            }
            else return NotFound($"Staff member was not found.");
        }
        [HttpPost("addAssignment")]
        public IActionResult AddAssignment([FromBody] assignment assign)
        {
            if (assignmentRepo.AddAssignment(assign))
            {
                return Ok($"Successfully added to assignment.");
            }
            else return BadRequest("This assignment already exists.");
        }
      
    }

}
