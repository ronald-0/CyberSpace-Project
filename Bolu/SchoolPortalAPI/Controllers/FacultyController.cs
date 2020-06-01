using System.Collections.Generic;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class FacultyController : ControllerBase
    {
        private ILogger _logger;
        private IFacultyService _service;

        public FacultyController(ILogger<FacultyController> logger, IFacultyService service)
        {
            _logger = logger;
            _service = service;
        }
        
        [HttpGet("/schoolapi/faculty/{FacultyID}")]
        public ActionResult<Faculty> GetByFacultyId(int FacultyID)
        {
            var fac = _service.GetByFacultyId(FacultyID);
            return fac;

        }
        [HttpGet("/schoolapi/faculty")]
        public ActionResult<List<Faculty>> GetFaculties()
        {
            var fac = _service.GetFaculties();

            if (fac.Count == 0)
            {
                return Ok();
            }

            return fac;
        }

        [HttpPost("/schoolapi/faculty")]
        public ActionResult<Faculty> AddFaculty(Faculty faculty)
        {
            var fac = _service.AddFaculty(faculty);
            
            return fac;
        }

        [HttpPut("/schoolapi/faculty/{FacultyID}")]
        public ActionResult<Faculty> UpdateFaculty(int FacultyID, Faculty faculty)
        {
            var fac = _service.UpdateFaculty(FacultyID, faculty);
            return fac;
        }

        [HttpDelete("/schoolapi/faculty/{FacultyID}")]
        public ActionResult<Faculty> DeleteFaculty(int FacultyID)
        {
            var del_fac = _service.DeleteFaculty(FacultyID);
            return del_fac;
        }
        
    }
}










