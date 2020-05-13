using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentCourseAssignment.Model;
using StudentCourseAssignment.Services;

namespace StudentCourseAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCourseController : ControllerBase
    {
            private ILogger _logger;
            private IStudentCourseServices _service;


            public StudentCourseController(ILogger<StudentCourseController> logger, IStudentCourseServices service)
            {
                _logger = logger;
                _service = service;

            }

            [HttpGet("schoolportal")]
            public ActionResult<List<StudentCourse>> GetStudentCourse()
            {
                return _service.GetStudentCourse();
            }

            [HttpPost("schoolportal")]
            public ActionResult<StudentCourse> AddStudentCourse(StudentCourse studentcourse)
            {
                _service.AddStudentCourse(studentcourse);
                return studentcourse;
            }

            [HttpPut("schoolportal")]
            public ActionResult<StudentCourse> UpdateStudentCourse(string code, StudentCourse studentcourse)
            {
                _service.UpdateStudentCourse(code, studentcourse);
                return studentcourse;
            }

            [HttpDelete("schoolportal")]
            public ActionResult<string> DeleteStudentCourse(string code)
            {
                _service.DeleteStudentCourse(code);
                //_logger.LogInformation("faculties", _faculties);
                return code;
            }
    }
}
