using System.ComponentModel.DataAnnotations;

namespace Online_Solar_Power_System510.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
