using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Languages");

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

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "LanguageToTeach",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("22bfc63b-0c98-42a7-8a2a-82a49761bc65"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Spanish", "Test location 3" },
                    { new Guid("7b571aec-bd4a-40f7-887b-db2d4fea6a5e"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "French", "Test location 9" },
                    { new Guid("8aaae329-09e8-44e0-98bd-e9cb796bebd2"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "German", "Test location 4" },
                    { new Guid("9884b342-9bc3-4ec5-a159-923d12036a51"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "French", "Test location 5" },
                    { new Guid("9f3ad127-79ef-4d9d-a268-497994795f2a"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("ca4aab6e-6738-4cef-b46e-3b15a9fd18cf"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Swedish", "Test location 10" },
                    { new Guid("ce3e4836-e5e2-4534-a8e8-2332c072527b"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "Swedish", "Test location 6" },
                    { new Guid("de3ff426-b836-457c-9fa5-6739f6a45dd4"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "English", "Test location 2" },
                    { new Guid("edf0a9f3-e9fc-43db-a478-f43d95c99915"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "Spanish", "Test location 7" },
                    { new Guid("f0742dbc-2714-42ec-af34-a510f3c8af3a"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "French", "Test location 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("22bfc63b-0c98-42a7-8a2a-82a49761bc65"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("7b571aec-bd4a-40f7-887b-db2d4fea6a5e"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8aaae329-09e8-44e0-98bd-e9cb796bebd2"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9884b342-9bc3-4ec5-a159-923d12036a51"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9f3ad127-79ef-4d9d-a268-497994795f2a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ca4aab6e-6738-4cef-b46e-3b15a9fd18cf"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ce3e4836-e5e2-4534-a8e8-2332c072527b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("de3ff426-b836-457c-9fa5-6739f6a45dd4"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("edf0a9f3-e9fc-43db-a478-f43d95c99915"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f0742dbc-2714-42ec-af34-a510f3c8af3a"));

            migrationBuilder.DropColumn(
                name: "LanguageToTeach",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserId1",
                table: "Languages",
                column: "UserId1");
        }
    }
}
