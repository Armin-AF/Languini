using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class AddsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("00cd26f6-b36f-486b-adb1-76352e2ff967"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "French", "Test location 1" },
                    { new Guid("07d37f90-e9e3-4ec8-904c-4c90eabde863"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "French", "Test location 5" },
                    { new Guid("18be087a-9f14-47ca-9867-cdae7f9c0e5c"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Swedish", "Test location 10" },
                    { new Guid("306cd4b1-b394-43e1-b095-dc3307a980da"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "French", "Test location 9" },
                    { new Guid("78e030a7-d803-4b33-a189-3c0b34111c58"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "Spanish", "Test location 7" },
                    { new Guid("8caafdcc-5e45-42fe-a75b-2876c9e2c466"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("8efced14-3279-497b-92cd-4110eb0dae02"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Spanish", "Test location 3" },
                    { new Guid("a6e3f566-a8f1-4181-9f1a-bde23bd781c9"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "Swedish", "Test location 6" },
                    { new Guid("e14a578d-025d-41e2-ad08-7b87c1125b97"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "German", "Test location 4" },
                    { new Guid("f6f7ffec-ccbf-4b31-8628-5d80ef35d146"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "English", "Test location 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("00cd26f6-b36f-486b-adb1-76352e2ff967"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("07d37f90-e9e3-4ec8-904c-4c90eabde863"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("18be087a-9f14-47ca-9867-cdae7f9c0e5c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("306cd4b1-b394-43e1-b095-dc3307a980da"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("78e030a7-d803-4b33-a189-3c0b34111c58"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8caafdcc-5e45-42fe-a75b-2876c9e2c466"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8efced14-3279-497b-92cd-4110eb0dae02"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("a6e3f566-a8f1-4181-9f1a-bde23bd781c9"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("e14a578d-025d-41e2-ad08-7b87c1125b97"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f6f7ffec-ccbf-4b31-8628-5d80ef35d146"));
        }
    }
}
