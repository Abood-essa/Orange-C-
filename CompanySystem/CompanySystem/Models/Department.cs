using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
