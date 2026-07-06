using EmployeeManagementSystemAI.Models.Domain;

namespace EmployeeManagementSystemAI.Repositories.Interface
{
    public interface IEmployeeRepository
    {
       
         Task <List<Employee>> GetAllAsync();
         Task<Employee> AddAsync(Employee employee);
         Task<Employee?> GetByIdAsync(int id);
         Task<Employee?> UpdateAsync(Employee employee);
         Task<bool> DeleteAsync(int id);
        
    }
}
