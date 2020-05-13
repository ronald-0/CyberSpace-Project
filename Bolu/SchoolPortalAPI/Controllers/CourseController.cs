using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CourseController : ControllerBase
    {
        private ILogger _logger;
        private ICourseService _service;


        public CourseController(ILogger<CourseController> logger, ICourseService service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("/schoolapi/courses/{Courseid}")]
        public ActionResult<Course> GetById(int CourseID)
        {
            var courses = _service.GetById(CourseID);
            return courses;

        }
        [HttpGet("/schoolapi/courses")]
        public ActionResult<List<Course>> GetCourses()
        {
            var courses = _service.GetCourses();

            if (courses.Count == 0)
            {
                return Ok();
            }

            return courses;
        }

        [HttpPost("/schoolapi/courses")]
        public ActionResult<Course> AddCourse(Course course)
        {
            var courses = _service.AddCourse(course);
            //if (courses == null)
            //{
            //    return NotFound();
            //}
            return courses;
        }

        [HttpPut("/schoolapi/courses/{Courseid}")]
        public ActionResult<Course> UpdateCourse(int CourseID, Course course)
        {
            var courses = _service.UpdateCourse(CourseID, course);
            return courses;
        }

        [HttpDelete("/schoolapi/courses/{Courseid}")]
        public ActionResult<Course> DeleteCourse(int CourseID)
        {
            var del_course = _service.DeleteCourse(CourseID);
            //_logger.LogInformation("Courses", _Courses);
            return del_course;
        }

    }
}