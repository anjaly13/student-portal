namespace student_portal.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string? HouseName { get; set; }

        public string? City { get; set; }

        public string? Pincode { get; set; }
         
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
