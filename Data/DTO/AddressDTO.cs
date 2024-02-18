namespace student_portal.Data.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }

        public string? HouseName { get; set; }

        public string? City { get; set; }

        public string? Pincode { get; set; }

        public int StudentId { get; set; }
    }
}
