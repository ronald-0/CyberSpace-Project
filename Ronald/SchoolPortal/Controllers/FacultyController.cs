using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacultyManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FacultyManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacultyController : ControllerBase
    {

        private ILogger _logger;
        private IFacultyServices _service;


        public FacultyController(ILogger<FacultyController> logger, IFacultyServices service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("schoolportal")]
        public ActionResult<List<Faculty>> GetFaculty()
        {
            return _service.GetFaculty();
        }

        [HttpPost("schoolportal")]
        public ActionResult<Faculty> AddFaculty(Faculty faculty)
        {
            _service.AddFaculty(faculty);
            return faculty;
        }

        [HttpPut("schoolportal")]
        public ActionResult<Faculty> UpdateFaculty(string id, Faculty faculty)
        {
            _service.UpdateFaculty(id, faculty);
            return faculty;
        }

        [HttpDelete("schoolportal")]
        public ActionResult<string> DeleteFaculty(string id)
        {
            _service.DeleteFaculty(id);
            //_logger.LogInformation("faculties", _faculties);
            return id;  
        }
    }
}
