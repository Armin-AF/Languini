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
                Id = new Guid("c0a80121-7001-eb11-8146-002248001c4d"),
                Date = new DateTime(2022, 12, 10,  18, 0, 0),
                Description = "This is a test meeting 1",
                Location = "Test location 1",
                Language = "French",
            },
            new Meeting
            {
                Id = new Guid("c1a80121-7001-eb11-8146-002548001c4q"),
                Date = new DateTime(2022, 12, 11,  18, 0, 0),
                Description = "This is a test meeting 2",
                Location = "Test location 2",
                Language = "English",
            },
            new Meeting
            {
                Id = new Guid("c2a80121-7001-ds11-8146-002548001c4q"),
                Date = new DateTime(2022, 12, 12,  18, 0, 0),
                Description = "This is a test meeting 3",
                Location = "Test location 3",
                Language = "Spanish",
            },
            new Meeting
            {
                Id = new Guid("c3a80121-6501-eb11-8146-00254hg01c4q"),
                Date = new DateTime(2022, 12, 13,  18, 0, 0),
                Description = "This is a test meeting 4",
                Location = "Test location 4",
                Language = "German",
            },
            new Meeting
            {
                Id = new Guid("c4a43121-7001-eb11-8146-00fr48001c4q"),
                Date = new DateTime(2022, 12, 14,  18, 0, 0),
                Description = "This is a test meeting 5",
                Location = "Test location 5",
                Language = "French",
            },
            new Meeting
            {
                Id = new Guid("c5a80121-7551-eb11-8146-00254800cf4q"),
                Date = new DateTime(2022, 12, 15,  18, 0, 0),
                Description = "This is a test meeting 6",
                Location = "Test location 6",
                Language = "Swedish",
            },
            new Meeting
            {
                Id = new Guid("c6ada121-7001-eb11-8146-019548001c4q"),
                Date = new DateTime(2022, 12, 16,  18, 0, 0),
                Description = "This is a test meeting 7",
                Location = "Test location 7",
                Language = "Spanish",
            },
            new Meeting
            {
                Id = new Guid("c7v00121-7001-eb11-8146-002500001c4q"),
                Date = new DateTime(2022, 12, 17,  18, 0, 0),
                Description = "This is a test meeting 8",
                Location = "Test location 8",
                Language = "German",
            },
            new Meeting
            {
                Id = new Guid("c8a8rt21-7001-eb11-7146-002548089c4q"),
                Date = new DateTime(2022, 12, 18,  18, 0, 0),
                Description = "This is a test meeting 9",
                Location = "Test location 9",
                Language = "French",
            },
            new Meeting
            {
                Id = new Guid("c9gh0121-7jk1-7811-8146-002fd8001c4q"),
                Date = new DateTime(2022, 12, 19,  18, 0, 0),
                Description = "This is a test meeting 10",
                Location = "Test location 10",
                Language = "Swedish",
            }
        );
    }
}