using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public string ImportanceLevel { get; set; }



        public int EmployeeId { get; set; }


        public Employee Employee { get; set; }
    }
}
