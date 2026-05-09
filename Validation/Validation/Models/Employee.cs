using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Validation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }


        [Range(typeof(decimal), "1", "1000000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }


    }
}
