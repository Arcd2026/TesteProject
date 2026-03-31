namespace Teste.EmployeeDomain
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; }

        public string? Email { get; set; }

        public int? DepartmentId { get; set; }

        public int? SpecialtyId { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public int? WorkHours { get; set; }

        public string? CNS { get; set; }

        public string? CBO { get; set; }
    }
}
