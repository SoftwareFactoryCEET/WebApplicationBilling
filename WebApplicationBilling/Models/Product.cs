using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationBilling.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        public int SupplierId { get; set; }

        public decimal UnitPrice { get; set; } = 0;

        [MaxLength(30)]
        public string Package { get; set; }

        [Required]
        public bool IsDiscontinued { get; set; } = false;

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
