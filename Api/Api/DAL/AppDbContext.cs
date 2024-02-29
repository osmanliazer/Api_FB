using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Tag> Tags { get; set; }
    }
}
