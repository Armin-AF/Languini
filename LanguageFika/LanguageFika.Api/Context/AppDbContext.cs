using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Context;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    protected AppDbContext(){
        
    }
    
    public DbSet<Language>? Languages { get; set; } = null!;
    public DbSet<User>? Users { get; set; } = null!;
    public DbSet<Meeting>? Meetings { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

}