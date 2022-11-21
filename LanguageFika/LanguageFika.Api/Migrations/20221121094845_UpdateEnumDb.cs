using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateEnumDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Language",
                table: "Meetings",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("04448b09-9262-4704-a781-324378853849"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", 1, "Test location 9" },
                    { new Guid("19889ed0-30ac-4e34-aad1-254ba56239b1"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", 1, "Test location 5" },
                    { new Guid("299e8f29-e1f1-4cfd-8475-1e44493a0c0d"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", 17, "Test location 1" },
                    { new Guid("38e804c6-6785-45cb-8cc2-e518238cf431"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", 3, "Test location 7" },
                    { new Guid("4ba87d23-c957-473f-8670-6f55d23d419a"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", 0, "Test location 6" },
                    { new Guid("566d4a6f-1909-4cd3-81d4-8f6579db94a0"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", 8, "Test location 3" },
                    { new Guid("5937bafd-9973-49c3-9273-686b7a749b1b"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", 4, "Test location 8" },
                    { new Guid("6f34521b-5786-4c2a-a90a-a12ae87e03d7"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", 9, "Test location 2" },
                    { new Guid("be4aa1c3-afb9-44a8-99d5-6686b8233038"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", 6, "Test location 4" },
                    { new Guid("f72ccafa-addb-4619-af98-d822d0a13cfa"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", 20, "Test location 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("04448b09-9262-4704-a781-324378853849"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("19889ed0-30ac-4e34-aad1-254ba56239b1"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("299e8f29-e1f1-4cfd-8475-1e44493a0c0d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("38e804c6-6785-45cb-8cc2-e518238cf431"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("4ba87d23-c957-473f-8670-6f55d23d419a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("566d4a6f-1909-4cd3-81d4-8f6579db94a0"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5937bafd-9973-49c3-9273-686b7a749b1b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("6f34521b-5786-4c2a-a90a-a12ae87e03d7"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("be4aa1c3-afb9-44a8-99d5-6686b8233038"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f72ccafa-addb-4619-af98-d822d0a13cfa"));

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Meetings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
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
    }
}
