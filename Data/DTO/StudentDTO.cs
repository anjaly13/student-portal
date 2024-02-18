using student_portal.Data.Entities;

namespace student_portal.Data.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string? StudentName { get; set; }

        public int Age { get; set; }

        public List<AddressDTO>? Address { get; set; }
    }
}
