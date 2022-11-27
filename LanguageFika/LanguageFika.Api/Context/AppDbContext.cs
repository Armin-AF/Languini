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
    
    public virtual DbSet<User>? Users { get; set; } = null!;
    public virtual DbSet<Meeting>? Meetings { get; set; } = null!;
    public virtual DbSet<Participant>? ParticipantsModel { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        new DbInitializer(modelBuilder).Seed();
    }

}