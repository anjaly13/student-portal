using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities;
using student_portal.Data;
using student_portal.Data.DTO;
using student_portal.Services;
using System.ComponentModel;

namespace student_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) {
           this._studentService = studentService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> getStudents() {
            var student = await _studentService.getAllStudentsAsync();
            return Ok(student);

        }

        [HttpPost("save")]
        public async Task<IActionResult> addStudent(StudentDTO studentDTO) {
            var student = await _studentService.addStudent(studentDTO);
            return Ok(student);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getStudent(int id)
        {
            var student = await _studentService.getAllStudentByIdAsync(id);
            return Ok(student);

        }
    }
}
 