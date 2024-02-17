using student_portal.Data.Entities;

namespace student_portal.Services
{
    public interface IStudentService
    {
        Task<List<Student>> getAllStudentsAsync();
    }
}
