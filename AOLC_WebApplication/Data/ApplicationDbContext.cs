using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AOLC_WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<AolcUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AolcUser> AolcUsers { get; set; }
    }
}
