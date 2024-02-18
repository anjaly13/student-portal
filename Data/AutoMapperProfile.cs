using AutoMapper;
using student_portal.Data.DTO;
using student_portal.Data.Entities;

namespace student_portal.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<StudentDTO, Student>();
            CreateMap<AddressDTO, Address>();
        }
    }
}
