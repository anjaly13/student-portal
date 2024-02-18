using student_portal.Data;
using student_portal.Data.DTO;
using student_portal.Data.Entities;

namespace student_portal.Services.GraphQLServices
{
    public interface IStudentGQL
    {
        Task<List<Student>> AllStudentsAsync(StudentPortalDbContext context);

        Task<Student> SaveStudentAsync(StudentPortalDbContext context,StudentDTO studentDTO);
    }
}
