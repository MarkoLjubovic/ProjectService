using System.ComponentModel.DataAnnotations;

namespace ProjectService.Models
{
    public class VehicleModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Price { get; set; }
        public int VehicleMakeId { get; set; }

        public VehicleMake VehicleMake { get; set; }
    }
}
