using student_portal.Data;
using student_portal.Data.DTO;
using student_portal.Data.Entities;
using student_portal.Services.GraphQLServices;

namespace student_portal.Resolvers
{
    public class MutationType
    {
        private readonly IStudentGQL _studentService;
        public MutationType(IStudentGQL studentService) { 
            _studentService = studentService;
        }
        public async Task<Student> SaveStudents([Service] StudentPortalDbContext context, StudentDTO studentDTO) {
            return await _studentService.SaveStudentAsync(context, studentDTO);
        }
    }
}
