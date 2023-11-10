
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class RMS_Dbcontext : DbContext
    {
        public RMS_Dbcontext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
