using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProductCategory.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Phai nhap ten san pham")]
        [StringLength(100)]
        public string? ProductName { get; set; }
        [Range(0.01, 100000, ErrorMessage = "Gia phai lon hon 0 va nho hon 100000")]
        public decimal ProductPrice { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}