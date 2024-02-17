namespace student_portal.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string? StudentName { get; set; }

        public int Age { get; set;}

        public List<Address>? Address { get; set; }
    }
}
