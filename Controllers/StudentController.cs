using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Services;

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
    }
}
 