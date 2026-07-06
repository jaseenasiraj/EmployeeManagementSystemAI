using AutoMapper;
using EmployeeManagementSystemAI.Models.Domain;
using EmployeeManagementSystemAI.Models.DTO;
using EmployeeManagementSystemAI.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystemAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _repo;
        public EmployeesController(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _repo.GetAllAsync();
            var response=_mapper.Map<List<EmployeeResponseDto>>(employees);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id) 
        {
            var employees=await _repo.GetByIdAsync(id);
            if (employees == null)
            return NotFound();
            var response = _mapper.Map<EmployeeResponseDto>(employees);
            return Ok(response);
           
          
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployees(CreateEmployeeRequestDto request)
        {
            var employee = _mapper.Map<Employee>(request);
            var result=await _repo.AddAsync(employee);
            var response=_mapper.Map<EmployeeResponseDto>(result);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, UpdateEmployeeRequestDto request)
        {
            var existing = await _repo.GetByIdAsync(id);

            if (existing == null)
                return NotFound();

            _mapper.Map(request, existing);

            var updated = await _repo.UpdateAsync(existing);

            return Ok(updated);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result=  await _repo.DeleteAsync(id);
            if(!result)
                return NotFound();
            return Ok(result);

        }

    }
}
