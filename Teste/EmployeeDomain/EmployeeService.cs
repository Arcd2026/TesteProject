using Teste.Data;

namespace Teste.EmployeeDomain
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _Context;

        public EmployeeService(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task CreateAsync(CreateEmployeeDTO dto)
        {
            var employee = new Employee
            {
                Name = dto.Name,
                Email = dto.Email,
                DepartmentId = dto.DepartmentId,
                SpecialtyId = dto.SpecialtyId,
                BirthDate = dto.BirthDate,
                HireDate = dto.HireDate,
                WorkHours = dto.WorkHours,
                CNS = dto.CNS,
                CBO = dto.CBO,
            };

            employee.CreatedAt = DateTime.Now;

            _Context.Add(employee);
            await _Context.SaveChangesAsync();
        }
    }
   
}
