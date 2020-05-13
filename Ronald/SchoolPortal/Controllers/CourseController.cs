using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CourseManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController: ControllerBase
    {
        private ILogger _logger;
        private ICourseServices _service;


        public CourseController(ILogger<CourseController> logger, ICourseServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("schoolportal")]
        public ActionResult<List<Course>> GetCourse()
        {
            return _service.GetCourse();
        }

        [HttpPost("schoolportal")]
        public ActionResult<Course> AddCourse(Course course)
        {
            _service.AddCourse(course);
            return course;
        }

        [HttpPut("schoolportal")]
        public ActionResult<Course> UpdateCourse(string code, Course course)
        {
            _service.UpdateCourse(code, course);
            return course;
        }

        [HttpDelete("schoolportal")]
        public ActionResult<string> DeleteCourse(string code)
        {
            _service.DeleteCourse(code);
            //_logger.LogInformation("faculties", _faculties);
            return code;
        }
    }
}
