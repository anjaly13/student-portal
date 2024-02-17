using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Data.Entities;

namespace student_portal.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentPortalDbContext _studentPortalDbContext;
        public StudentService(StudentPortalDbContext studentPortalDbContext)
        {
            this._studentPortalDbContext = studentPortalDbContext;
        }
        public async Task<List<Student>> getAllStudentsAsync()
        {
            var student = await _studentPortalDbContext.Student.Include(_ => _.Address).ToListAsync();
            return student;
        }
    }
}
