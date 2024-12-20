using Microsoft.EntityFrameworkCore;
using OpenewsBackend.Models;

namespace OpenewsBackend.Data
{
    public class OpenewsDbContext : DbContext
    {
        public OpenewsDbContext(DbContextOptions<OpenewsDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
