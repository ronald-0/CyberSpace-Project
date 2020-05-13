﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Repositories;
using SchoolPortal.StudentModel;

namespace SchoolPortal.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("getAllStudent")]
        public IActionResult Get()
        {
            var students = StudentRepo.GetAll();
            return Ok(students);
        }

        [HttpGet("getStudent")]
        public IActionResult Get(int id)
        {
            var students = StudentRepo.GetById(id);
            return Ok(students);
        }

        [HttpPost("addStudent")]
        public IActionResult AddStudent([FromBody] StudentModel.StudentModel student)
        {
            if (StudentRepo.Add(student))
            {
                return Ok("Student has been successfully added.");
            }
            return BadRequest("The student has already been added.");
        }

        [HttpPut("updateStudent")]
        public IActionResult UpdateStudent([FromBody] StudentModel.StudentModel student)
        {
            if (StudentRepo.Update(student))
            {
                return Ok("Student has been successfully updated.");
            }
            return NotFound("The student was not found.");
        }

        [HttpDelete("deleteStudent")]
        public IActionResult DeleteStudent([FromBody] StudentModel.StudentModel student)
        {
            if (StudentRepo.Delete(student))
            {
                return Ok("Student has been successfully deleted.");
            }
            return NotFound("The student was not found.");
        }
    }
}
