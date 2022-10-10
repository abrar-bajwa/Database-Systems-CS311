using System.ComponentModel.DataAnnotations;

namespace SaleSystem.Models
{
    public class ProductCategory
    {
        [Key]
        public int PCatId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
