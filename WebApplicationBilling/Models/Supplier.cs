using System.ComponentModel.DataAnnotations;

namespace WebApplicationBilling.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(50)]
        public string ContactName { get; set; }

        [MaxLength(40)]
        public string ContactTitle { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(40)]
        public string Country { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage = "El valor introducido no es una dirección de correo electrónico válida.")]
        public string? Email { get; set; }

        public virtual ICollection<Product>? Products { get; set; }

    }
}
