using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateEnumLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "LanguageToTeach",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageToLearn",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("31d24f06-3327-4836-884e-143be5a1e41a"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("50d1339c-0a1b-4c26-a2b2-9e3d8a990021"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "German", "Test location 4" },
                    { new Guid("5ece7df9-62c2-4949-8ffe-a55aba1a7332"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Swedish", "Test location 10" },
                    { new Guid("917352e4-7d5f-45af-b93f-8a31bed036c4"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "Swedish", "Test location 6" },
                    { new Guid("9b4744dd-935e-4f82-a541-e9ab86e634ce"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "French", "Test location 9" },
                    { new Guid("a75c1432-f22a-4990-879f-7ef968486254"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "French", "Test location 1" },
                    { new Guid("bb9dc6ef-0a81-4281-9b52-d78e2979ed01"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "Spanish", "Test location 7" },
                    { new Guid("c5881095-0295-4813-a923-905fab0c26cf"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Spanish", "Test location 3" },
                    { new Guid("d3844a3c-c218-4972-ab77-fe8e3a80b567"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "French", "Test location 5" },
                    { new Guid("f7be2ae2-77cd-48d0-9a96-df90d3e26e94"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "English", "Test location 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("31d24f06-3327-4836-884e-143be5a1e41a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("50d1339c-0a1b-4c26-a2b2-9e3d8a990021"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5ece7df9-62c2-4949-8ffe-a55aba1a7332"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("917352e4-7d5f-45af-b93f-8a31bed036c4"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9b4744dd-935e-4f82-a541-e9ab86e634ce"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("a75c1432-f22a-4990-879f-7ef968486254"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("bb9dc6ef-0a81-4281-9b52-d78e2979ed01"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c5881095-0295-4813-a923-905fab0c26cf"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d3844a3c-c218-4972-ab77-fe8e3a80b567"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f7be2ae2-77cd-48d0-9a96-df90d3e26e94"));

            migrationBuilder.AlterColumn<string>(
                name: "LanguageToTeach",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LanguageToLearn",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
