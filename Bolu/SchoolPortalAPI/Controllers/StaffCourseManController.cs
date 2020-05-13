using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffCourseManController : Controller
    {
        
        private ILogger _logger;
        private IStaffCourse _service;


        public StaffCourseManController(ILogger<StaffCourseManController> logger, IStaffCourse service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("/schoolapi/staffcourse/{id}")]
        public ActionResult<StaffCourseMan> GetStaffCoursesById(int ID)
        {
           
            var staffcourses = _service.GetStaffCourseById(ID);
            return Ok(staffcourses);

        }
        
        [HttpGet("/schoolapi/staffcourse")]
        public ActionResult<List<StaffCourseMan>> GetStaffCourses()
        {
            //return _service.GetStaffCourses();
            var staffcourses = _service.GetStaffCourse();

            if (staffcourses.Count == 0)
            {
                return Ok();
            }

            return staffcourses;
        }

        

        [HttpPost("/schoolapi/staffcourse")]
        public ActionResult<StaffCourseMan> AddStaffCourse(StaffCourseMan staffCourse)
        {
            var staffcourses = _service.AddStaffCourse(staffCourse);
            if (staffcourses == null)
            {
                return NotFound();
            }
            return staffcourses;
         
        }

        

       

        [HttpPut("/schoolapi/staffcourse/{id}")]
        public ActionResult<StaffCourseMan> UpdateStaffCourse(int ID, StaffCourseMan staffCourse)
        {
            var staffcourses = _service.UpdateStaffCourse(ID, staffCourse);
            return staffcourses;
        }

        [HttpDelete("/schoolapi/staffcourse/{id}")]
       
        public ActionResult<StaffCourseMan> DeleteStaffCourse(int ID)
        {
           var del_course =  _service.DeleteStaffCourse(ID);
            //_logger.LogInformation("products", _products);
            return del_course;
        }
    }
}




