using Org.BouncyCastle.Utilities;
using student_portal.Data.DTO;
using student_portal.Data.Entities;

namespace student_portal.Services
{
    public interface IStudentService
    {
        Task<List<Student>> getAllStudentsAsync();

        Task<Student> addStudent(StudentDTO studentDTO);

        Task<Student> getAllStudentByIdAsync(int id);
    }
}
