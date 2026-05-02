using System.ComponentModel.DataAnnotations;

namespace CategoriesSystem.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? ImagePath { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
