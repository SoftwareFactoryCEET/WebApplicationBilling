using System.ComponentModel.DataAnnotations;

namespace WebApplicationBilling.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(40)]
        public string Country { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
