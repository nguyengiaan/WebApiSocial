using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MangxahoiBE.Data
{
    public class MyDbcontext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public MyDbcontext(DbContextOptions options) : base(options) { }
    }
}