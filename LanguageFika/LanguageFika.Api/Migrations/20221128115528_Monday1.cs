using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class Monday1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("08b8dc6a-a8c3-4e30-a4e5-9f9dee06ed2f"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("1d0d2d33-5254-4027-89d7-7e41a90218d7"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("4a89bf78-9fa1-4303-8dd7-ee050267121b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("516a7735-c37d-423b-9189-49819ae39a69"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("60e709ea-beb9-42be-8d93-a10b4542fd54"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("610a6c90-3324-4adf-a144-8e07796db668"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("70ddf00a-67ad-4237-a49d-509b9c12a8f4"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8e7e5b23-e974-44c3-bc09-d655105f3ccb"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9fa16857-0d49-4634-a8de-5383a5bd143d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("a1796405-d322-4551-b229-06fd5ec896a9"));

            migrationBuilder.AddColumn<string>(
                name: "CreatorEmail",
                table: "Meetings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "CreatorEmail", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("33419d9f-d1f5-453b-9f23-3fe0cb15a9c4"), null, new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("4b663b26-5789-43c1-8300-609ec04b151d"), null, new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("70fc311c-fcf7-40fb-b540-9c8ef4734e20"), null, new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("7c03a67b-1246-47a9-ad6c-1f93e2aa882c"), null, new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("85780020-c803-4c84-bf64-1d1ea3f69b0e"), null, new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("9abb3545-19bd-4b6d-8bb9-0456e2b9b022"), null, new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("9cb46a33-6845-4d59-8092-f8979be17e3c"), null, new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("bf6ed48f-a5aa-4a19-960e-3529b907f85f"), null, new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("d24d14cc-767d-47fb-a7f4-436ce53ef06b"), null, new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("d6ccff1e-79cb-40e0-bc10-aa8c794f2761"), null, new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("33419d9f-d1f5-453b-9f23-3fe0cb15a9c4"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("4b663b26-5789-43c1-8300-609ec04b151d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("70fc311c-fcf7-40fb-b540-9c8ef4734e20"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("7c03a67b-1246-47a9-ad6c-1f93e2aa882c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("85780020-c803-4c84-bf64-1d1ea3f69b0e"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9abb3545-19bd-4b6d-8bb9-0456e2b9b022"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9cb46a33-6845-4d59-8092-f8979be17e3c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("bf6ed48f-a5aa-4a19-960e-3529b907f85f"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d24d14cc-767d-47fb-a7f4-436ce53ef06b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d6ccff1e-79cb-40e0-bc10-aa8c794f2761"));

            migrationBuilder.DropColumn(
                name: "CreatorEmail",
                table: "Meetings");

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("08b8dc6a-a8c3-4e30-a4e5-9f9dee06ed2f"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("1d0d2d33-5254-4027-89d7-7e41a90218d7"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("4a89bf78-9fa1-4303-8dd7-ee050267121b"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("516a7735-c37d-423b-9189-49819ae39a69"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("60e709ea-beb9-42be-8d93-a10b4542fd54"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("610a6c90-3324-4adf-a144-8e07796db668"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("70ddf00a-67ad-4237-a49d-509b9c12a8f4"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("8e7e5b23-e974-44c3-bc09-d655105f3ccb"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("9fa16857-0d49-4634-a8de-5383a5bd143d"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("a1796405-d322-4551-b229-06fd5ec896a9"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" }
                });
        }
    }
}
