using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolPortalAPI.Models;
using SchoolPortalAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolPortalAPI.Controllers
{
[ApiController]
[Route("[controller]")]
public class StaffController : Controller
{

    private ILogger _logger;
    private IStaffService _service;
    //private readonly IStaffService _service;


    public StaffController(ILogger<StaffController> logger, IStaffService service)
    {
        _logger = logger;
        _service = service;

    }
    [HttpGet("/schoolapi/staff/{StaffID}")]

    public ActionResult<Staff> GetByStaffId(int StaffID)
    {
        var staff = _service.GetByStaffId(StaffID);
        return Ok(staff);

    }
    [HttpGet("/schoolapi/staff")]
    public ActionResult<List<Staff>> GetStaff()
    //public ActionResult<Dictionary<int, Staff>> GetStaffs()
    {
        var staff = _service.GetStaff();

        if (staff.Count == 0)
        {
            return Ok();
        }

        return staff;
    }

    [HttpPost("/schoolapi/staff")]
    public ActionResult<Staff> AddStaff(Staff staff)
    {
        var staffs = _service.AddStaff(staff);
        if (staffs == null)
        {
            return NotFound();
        }
        return staffs;
    }

    [HttpPut("/schoolapi/staff/{StaffID}")]
    public ActionResult<Staff> UpdateStaff(int StaffID, Staff staff)
    {
        var staffs = _service.UpdateStaff(StaffID, staff);
        return staffs;
    }

    [HttpDelete("/schoolapi/staff/{StaffID}")]
    public ActionResult<Staff> DeleteStaff(int StaffID)
    {
        var del_staff = _service.DeleteStaff(StaffID);
        //_logger.LogInformation("Staffs", _Staffs);
        return del_staff;
    }
}
}





