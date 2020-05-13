using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StaffCourseAssignment.Model;
using StaffCourseAssignment.Services;

namespace StaffCourseAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffCourseController
    {
        private ILogger _logger;
        private IStaffCourseServices _service;


        public StaffCourseController(ILogger<StaffCourseController> logger, IStaffCourseServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("schoolportal")]
        public ActionResult<List<StaffCourse>> GetStaffCourse()
        {
            return _service.GetStaffCourse();
        }

        [HttpPost("schoolportal")]
        public ActionResult<StaffCourse> AddStaffCourse(StaffCourse staffcourse)
        {
            _service.AddStaffCourse(staffcourse);
            return staffcourse;
        }

        [HttpPut("schoolportal")]
        public ActionResult<StaffCourse> UpdateStaffCourse(string id, StaffCourse staffcourse)
        {
            _service.UpdateStaffCourse(id, staffcourse);
            return staffcourse;
        }

        [HttpDelete("schoolportal")]
        public ActionResult<string> DeleteStaffCourse(string id)
        {
            _service.DeleteStaffCourse(id);
            //_logger.LogInformation("faculties", _faculties);
            return id;
        }
    }
}
