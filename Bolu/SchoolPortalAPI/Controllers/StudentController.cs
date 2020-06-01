using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace SchoolPortalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

   

    public class StudentController : ControllerBase
    {
        private ILogger _logger;
        private IStudentService _service;


        public StudentController(ILogger<StudentController> logger, IStudentService service)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("/schoolapi/student/{StudentID}")]
        public ActionResult<Student> GetByStudentId(int StudentID)
        {
            var students = _service.GetByStudentId(StudentID);
            return students;

        }
        [HttpGet("/schoolapi/student")]
        public ActionResult<List<Student>> GetStudents()
        {
            var students = _service.GetStudents();

            if (students.Count == 0)
            {
                return Ok();
            }

            return students;
        }

        [HttpPost("/schoolapi/student")]
        public ActionResult<Student> AddStudent(Student student)
        {
            var students = _service.AddStudent(student);
            if (students == null)
            {
                return NotFound();
            }
            return students;
        }

        [HttpPut("/schoolapi/student/{StudentID}")]
        public ActionResult<Student> UpdateStudent(int StudentID, Student student)
        {
            var students = _service.UpdateStudent(StudentID, student);
            return students;
        }

        [HttpDelete("/schoolapi/student/{StudentID}")]
        public ActionResult<Student> DeleteStudent(int StudentID)
        {
            var del_student = _service.DeleteStudent(StudentID);
            return del_student;
        }
    }
}