using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationBilling.Models;

namespace WebApplicationBilling.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Agrego la clase modelo Supplier
        public DbSet<Supplier> Suppliers { get; set; }
    }
}