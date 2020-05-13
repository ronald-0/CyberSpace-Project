using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StaffManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StaffManagement.Model;

namespace StaffManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : ControllerBase
    {
        private ILogger _logger;
        private IStaffServices _service;


        public StaffController(ILogger<StaffController> logger, IStaffServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("schoolportal")]
        public ActionResult<List<Staff>> GetStaff()
        {
            return _service.GetStaff();
        }

        [HttpPost("schoolportal")]
        public ActionResult<Staff> AddStaff(Staff staff)
        {
            _service.AddStaff(staff);
            return staff;
        }

        [HttpPut("schoolportal")]
        public ActionResult<Staff> UpdateStaff(string id, Staff staff)
        {
            _service.UpdateStaff(id, staff);
            return staff;
        }

        [HttpDelete("schoolportal")]
        public ActionResult<string> DeleteStaff(string id)
        {
            _service.DeleteStaff(id);
            //_logger.LogInformation("faculties", _faculties);
            return id;
        }
    }
}
