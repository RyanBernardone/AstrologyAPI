using Microsoft.EntityFrameworkCore;
using AstrologyAPI.Models;

namespace AstrologyAPI.Data;

public class AstrologyDbContext : DbContext
{
    public AstrologyDbContext(DbContextOptions<AstrologyDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
