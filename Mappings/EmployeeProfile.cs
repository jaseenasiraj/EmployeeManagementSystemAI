using AutoMapper;
using EmployeeManagementSystemAI.Models.Domain;
using EmployeeManagementSystemAI.Models.DTO;

namespace EmployeeManagementSystemAI.Mappings
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeRequestDto, Employee>();
            CreateMap<Employee, EmployeeResponseDto>();
            CreateMap<UpdateEmployeeRequestDto, Employee>();
        }
    }
}
