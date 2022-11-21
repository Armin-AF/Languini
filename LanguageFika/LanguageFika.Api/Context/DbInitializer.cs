using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Context;

public class DbInitializer
{
    readonly ModelBuilder _builder;
    
    public DbInitializer(ModelBuilder builder)
    {
        _builder = builder;
    }

    public void Seed(){
        _builder.Entity<Meeting>().HasData(
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 10,  18, 0, 0),
                Description = "This is a test meeting 1",
                Location = "Test location 1",
                Language = Language.Finnish
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 11,  18, 0, 0),
                Description = "This is a test meeting 2",
                Location = "Test location 2",
                Language = Language.Chinese
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 12,  18, 0, 0),
                Description = "This is a test meeting 3",
                Location = "Test location 3",
                Language = Language.Japanese
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 13,  18, 0, 0),
                Description = "This is a test meeting 4",
                Location = "Test location 4",
                Language = Language.Portuguese
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 14,  18, 0, 0),
                Description = "This is a test meeting 5",
                Location = "Test location 5",
                Language = Language.Swedish
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 15,  18, 0, 0),
                Description = "This is a test meeting 6",
                Location = "Test location 6",
                Language = Language.English,
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 16,  18, 0, 0),
                Description = "This is a test meeting 7",
                Location = "Test location 7",
                Language = Language.French
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 17,  18, 0, 0),
                Description = "This is a test meeting 8",
                Location = "Test location 8",
                Language = Language.German
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 18,  18, 0, 0),
                Description = "This is a test meeting 9",
                Location = "Test location 9",
                Language = Language.Swedish
            },
            new Meeting
            {
                Id = Guid.NewGuid(),
                Date = new DateTime(2022, 12, 19,  18, 0, 0),
                Description = "This is a test meeting 10",
                Location = "Test location 10",
                Language = Language.Greek
            }
        );
    }
}