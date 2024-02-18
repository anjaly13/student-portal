using AutoMapper;
using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Data.DTO;
using student_portal.Data.Entities;

namespace student_portal.Services.GraphQLServices
{
    public class StudentServiceGQL : IStudentGQL
    {
        private readonly IMapper _IMapper;
        public StudentServiceGQL(IMapper mapper) { 
            _IMapper = mapper;
        }
        public Task<List<Student>> AllStudentsAsync(StudentPortalDbContext context)
        {
            return context.Student.Include(x => x.Address).ToListAsync();
        }

        public async Task<Student> SaveStudentAsync(StudentPortalDbContext context,StudentDTO studentDTO)
        {
            var student = _IMapper.Map<Student>(studentDTO);
            context.Student.Add(student);
            await context.SaveChangesAsync();
            return student;
        }
    }
}
