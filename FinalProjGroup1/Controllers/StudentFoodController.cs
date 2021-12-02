using FinalProjGroup1.Models;
using Microsoft.AspNetCore.Http;
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
    public class StudentFoodController : ControllerBase
    {

        private readonly ILogger<StudentFoodController> _logger;
        private readonly StudentInfoDatabase _db;
        private readonly StudentInfoContext _context;

        public StudentFoodController(ILogger<StudentFoodController> logger, StudentInfoDatabase db, StudentInfoContext context)
        {
            _logger = logger;
            _db = db;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.GetAllStudentFoods());
        }

        [HttpGet("id")]
        public IActionResult GetStudentById(int? id)
        {
            var student = _db.GetStudentFoodById(id);
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

        [HttpGet("name")]
        public IActionResult GetStudentByName(string? name)
        {
            var student = _db.GetStudentFoodByFullName(name);
            if (name == null || student.ToList().Count() == 0)
            {
                return NotFound();
            }
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound();
            
        }

        [HttpPost]
        public IActionResult AddNewPerson(StudentFood person)
        {
            try
            {
                _db.AddNewStudentFood(person);
            }
            catch (Exception e)
            {

                return new StatusCodeResult(500);
            }
            return Created("", person);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StudentFood))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeletePerson(int? id)
        {
            
            try
            {
                var deletedStudent = _db.DeleteStudentFood(id);
                if (deletedStudent == null)
                {
                    return NotFound();
                }
                return Ok(deletedStudent.FullName);
            }
            catch (Exception)
            {

                return new StatusCodeResult(500);
            }
            
        }

        [HttpPut]
        public IActionResult UpdateStudent(int? id, [FromBody]StudentFood student)
        {
            
            var result = _db.UpdateStudentFood(student);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
