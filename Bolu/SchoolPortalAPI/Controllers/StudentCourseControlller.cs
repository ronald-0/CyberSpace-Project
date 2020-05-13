using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]



    public class StudentCourseController : ControllerBase
    {
        private ILogger _logger;
        private IStudentCourseService _service;


        public StudentCourseController(ILogger<StudentCourseController> logger, IStudentCourseService service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("/schoolapi/studentcourse/{StudentCourseid}")]
        public ActionResult<StudentCourse> GetByStudentCourseId(int StudentCourseID)
        {
            var studentcourses = _service.GetByStudentCourseId(StudentCourseID);
            return studentcourses;

        }
        [HttpGet("/schoolapi/studentcourse")]
        public ActionResult<List<StudentCourse>> GetStudentCourses()
        {
            var studentcourses = _service.GetStudentCourses();

            if (studentcourses.Count == 0)
            {
                return Ok();
            }

            return studentcourses;
        }

        [HttpPost("/schoolapi/studentcourse")]
        public ActionResult<StudentCourse> AddStudentCourse(StudentCourse studentcourse)
        {
            var studentcourses = _service.AddStudentCourse(studentcourse);
            if (studentcourses == null)
            {
                return NotFound();
            }
            return studentcourses;
        }

        [HttpPut("/schoolapi/studentcourse/{StudentCourseid}")]
        public ActionResult<StudentCourse> UpdateStudentCourse(int StudentCourseID, StudentCourse student)
        {
            var studentcourses = _service.UpdateStudentCourse(StudentCourseID, student);
            return studentcourses;
        }

        [HttpDelete("/schoolapi/studentcourse/{StudentCourseid}")]
        public ActionResult<StudentCourse> DeleteStudentCourse(int StudentCourseID)
        {
            var del_studentcourse = _service.DeleteStudentCourse(StudentCourseID);
            return del_studentcourse;
        }
    }
}
