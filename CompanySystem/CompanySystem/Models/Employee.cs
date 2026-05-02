using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string NationalId { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string PersonalPhoto { get; set; }

        public DateTime EntryDate { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }



        public int DepartmentId { get; set; }


        public Department Department { get; set; }



        public int RoleId { get; set; }


        public Role Role { get; set; }


        public List<TaskItem> Tasks { get; set; }
    }
}
