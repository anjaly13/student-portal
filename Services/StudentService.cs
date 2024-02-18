using AutoMapper;
using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Data.DTO;
using student_portal.Data.Entities;

namespace student_portal.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentPortalDbContext _studentPortalDbContext;
        private readonly IMapper _mapper;
        public StudentService(StudentPortalDbContext studentPortalDbContext, IMapper mapper)
        {
            this._studentPortalDbContext = studentPortalDbContext;
            this._mapper = mapper;
        }

        public async Task<Student> addStudent(StudentDTO studentDTO)
        {
            Student student = _mapper.Map<Student>(studentDTO); //MapStudentObject(studentDTO);
            _studentPortalDbContext.Student.Add(student);
            await _studentPortalDbContext.SaveChangesAsync();
            return student;
        }

        public async Task<Student> getAllStudentByIdAsync(int id)
        {
            var student = await _studentPortalDbContext.Student.Include(_ => _.Address).Where(_ => _.Id == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<List<Student>> getAllStudentsAsync()
        {

            var student = await _studentPortalDbContext.Student.Select(x=>new Student { 
            StudentName = x.StudentName
            }).ToListAsync();

            var students = await _studentPortalDbContext.Student.FromSql($"SELECT st.studentName FROM student st").ToListAsync();
            return students;
        }

        /*private Student MapStudentObject(StudentDTO studentDTO) {
            Student student = new Student();
            student.StudentName = studentDTO.StudentName;
            student.Age = studentDTO.Age;
            student.Address = new List<Address>();
            studentDTO.Address.ForEach(_ =>
            {
                Address address = new Address();
                address.HouseName = _.HouseName;
                address.City = _.City;
                address.Pincode = _.Pincode;
                student.Address.Add(address);
            });
            return student;
        }*/
    }
}
