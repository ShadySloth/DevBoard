using Microsoft.EntityFrameworkCore;
using User.Domain.Entities;

namespace User.Infrastructure.Contexts;

public class ReadUserContext : DbContext
{
    public ReadUserContext(DbContextOptions<ReadUserContext> options) : base(options) { }
    
    public DbSet<Domain.Entities.User> Users { get; set; }
    public DbSet<UserCredential> UserPasswords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}