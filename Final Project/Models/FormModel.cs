using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models
{
    public class FormModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }

}
