using System.ComponentModel.DataAnnotations;

namespace ProjectService.Models
{
    public class VehicleMake
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        public string Country { get; set; }

    }
}
