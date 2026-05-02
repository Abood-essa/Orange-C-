using System.ComponentModel.DataAnnotations;

namespace CompanySystem.Models
{
    public class ContactFeedback
    {
        public int Id { get; set; }

        [Required]
        public string SenderName { get; set; }

        [Required]
        public string SenderEmail { get; set; }

        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime SentDate { get; set; }
    }
}
