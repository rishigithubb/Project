using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
