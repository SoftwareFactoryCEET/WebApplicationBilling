using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationBilling.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [MaxLength(128)]
        public Guid OrderNumber { get; set; } = Guid.NewGuid(); // Establece un nuevo GUID por defecto

        [Required]
        public int CustomerId { get; set; }

        public decimal TotalAmount { get; set; } = 0;

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
