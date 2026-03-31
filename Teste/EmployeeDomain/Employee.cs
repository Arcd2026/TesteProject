using Teste.UserDomain;

namespace Teste.EmployeeDomain
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Email { get; set; }

        public int? DepartmentId { get; set; }

        public int? SpecialtyId { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? TerminationDate { get; set; }

        public int? StatusId { get; set; }

        public int? WorkHours { get; set; }

        public string? CNS { get; set; }

        public string? CBO { get; set; }

        public int? CreatedById { get; set; }

        public int? UpdatedById { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }
    }
}