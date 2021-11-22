using FinalProjGroup1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjGroup1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentInfoController : ControllerBase
    {

        private readonly ILogger<StudentInfoController> _logger;
        private readonly StudentInfoDatabase _db;

        public StudentInfoController(ILogger<StudentInfoController> logger, StudentInfoDatabase db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.GetAllStudents());
        }

        [HttpGet("id")]
        public IActionResult GetStudentById(int? id)
        {
            var student = _db.GetStudentById(id);
            if (student.ToList().Count() == 0)
            {
                return NotFound();
            }
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound();
        }

    }
}
