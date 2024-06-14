using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Home
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Country {  get; set; }
        [Required]
        public string? Organization { get; set; }

    }
}
