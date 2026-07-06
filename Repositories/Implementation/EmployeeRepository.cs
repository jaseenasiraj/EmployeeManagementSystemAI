using EmployeeManagementSystemAI.Data;
using EmployeeManagementSystemAI.Models.Domain;
using EmployeeManagementSystemAI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeeManagementSystemAI.Repositories.Implementation
{
    public class EmployeeRepository:IEmployeeRepository
    {
       private readonly ApplicationDbContext _dbContext;
       public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task <List<Employee>> GetAllAsync() 
        { 
              return await _dbContext.Employees.ToListAsync();
        }
        public async Task<Employee> AddAsync(Employee employee)
        {
           
            await _dbContext.Employees.AddAsync(employee);
            await  _dbContext.SaveChangesAsync();
            return employee;

        }
        public async Task<Employee?> GetByIdAsync(int id)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }
        public async Task<Employee?>UpdateAsync(Employee employee)
        {
            var existing=await _dbContext.Employees.FirstOrDefaultAsync(x=>x.Id == employee.Id);
            if(existing==null)
                return null;
            await _dbContext.SaveChangesAsync();
            return existing;

        }
        public async Task<bool>DeleteAsync(int id)
        {
            var employee=await _dbContext.Employees.FirstOrDefaultAsync(x=>x.Id==id);
            if(employee==null)
                return false;
            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();
            return true;

        }

        
        

    }
}
