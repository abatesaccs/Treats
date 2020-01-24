using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SweetTreat.Models
{
    public class SweetTreatContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavor> Flavors {get; set;}
        public virtual DbSet<Treat> Treats {get; set;}
        public virtual DbSet<TreatFlavor> TreatFlavor {get; set;}

        public SweetTreatContext(DbContextOptions options) : base(options) { }
    }
}