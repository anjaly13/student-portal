using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Data.Entities;
using student_portal.Services.GraphQLServices;

namespace student_portal.Resolvers
{
    public class QueryType
    {
        private readonly IStudentGQL _studentServiceGQL;
        public QueryType(IStudentGQL studentService) { 
            _studentServiceGQL = studentService;
        }
        public Task<List<Student>> AllStudentsAsync([Service] StudentPortalDbContext context)
        {
            return _studentServiceGQL.AllStudentsAsync(context);
        }
    }
}
