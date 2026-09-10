using Microsoft.EntityFrameworkCore;
using User.Domain.Entities;

namespace User.Infrastructure.Contexts;

public class WriteUserContext : DbContext
{
    public WriteUserContext(DbContextOptions<WriteUserContext> options) : base(options) { }
    
    public DbSet<Domain.Entities.User> Users { get; set; }
    public DbSet<UserPassword> UserPasswords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}