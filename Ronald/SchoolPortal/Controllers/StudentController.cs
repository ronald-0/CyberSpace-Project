using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentManagement.Model;

namespace StudentManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        private ILogger _logger;
        private IStudentServices _service;


        public StudentController(ILogger<StudentController> logger, IStudentServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("schoolportal")]
        public ActionResult<List<Student>> GetStudent()
        {
            return _service.GetStudent();
        }

        [HttpPost("schoolportal")]
        public ActionResult<Student> AddStudent(Student student)
        {
            _service.AddStudent(student);
            return student;
        }

        [HttpPut("schoolportal")]
        public ActionResult<Student> UpdateStudent(string id, Student student)
        {
            _service.UpdateStudent(id, student);
            return student;
        }

        [HttpDelete("schoolportal")]
        public ActionResult<string> DeleteStudent(string id)
        {
            _service.DeleteStudent(id);
            //_logger.LogInformation("faculties", _faculties);
            return id;
        }
    }
}
