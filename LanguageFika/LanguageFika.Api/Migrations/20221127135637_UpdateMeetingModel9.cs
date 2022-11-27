using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateMeetingModel9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("02cd496a-61bd-4843-a532-d031b7effd8a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("060081ed-b89f-4dda-beaf-6cbb9d9b2d77"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("16dd130d-2f86-46db-a1c6-5ed8fe1dcd9a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5afadb4a-1682-4f52-85b4-d98b8772b5dd"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ad1ff2af-146b-4171-8bf4-26c001d7299c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c1ee3bfb-6810-46ef-8330-f95158107aee"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d8ae1f5f-64d6-41c1-bde2-c7953bff87fe"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ed77bc6f-cfa7-42e8-aed2-375109c6f745"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ede39cd2-af40-4084-a5a1-8ccfe51742eb"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f3a8ea29-cf9a-4867-bc7e-b7b72ce54ee7"));

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("1ea5c739-19e4-480b-9b42-f2574a58f3ba"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("33ff43cf-9895-49ed-90bc-eed6c227731d"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("8828f76a-209b-4f04-bcd7-032cddd6b7c6"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("8a0c924c-e315-42cb-8e6a-0853d3d70991"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("935b023b-0b83-4250-8315-1f1407bf4dcc"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("93cf9028-c585-4d70-bce4-1346ddc18d3a"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("bfad9c59-4084-4805-a982-df1291a0a527"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("c89f7485-45b3-4e6c-b972-03fb29503493"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("d8bdfb7f-e5a4-4765-a361-213bed57bc03"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("fd798d8b-a5d9-4c5c-a5ff-8adbef654dda"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("1ea5c739-19e4-480b-9b42-f2574a58f3ba"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("33ff43cf-9895-49ed-90bc-eed6c227731d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8828f76a-209b-4f04-bcd7-032cddd6b7c6"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8a0c924c-e315-42cb-8e6a-0853d3d70991"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("935b023b-0b83-4250-8315-1f1407bf4dcc"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("93cf9028-c585-4d70-bce4-1346ddc18d3a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("bfad9c59-4084-4805-a982-df1291a0a527"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c89f7485-45b3-4e6c-b972-03fb29503493"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("d8bdfb7f-e5a4-4765-a361-213bed57bc03"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("fd798d8b-a5d9-4c5c-a5ff-8adbef654dda"));

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("02cd496a-61bd-4843-a532-d031b7effd8a"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("060081ed-b89f-4dda-beaf-6cbb9d9b2d77"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("16dd130d-2f86-46db-a1c6-5ed8fe1dcd9a"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("5afadb4a-1682-4f52-85b4-d98b8772b5dd"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("ad1ff2af-146b-4171-8bf4-26c001d7299c"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("c1ee3bfb-6810-46ef-8330-f95158107aee"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("d8ae1f5f-64d6-41c1-bde2-c7953bff87fe"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("ed77bc6f-cfa7-42e8-aed2-375109c6f745"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("ede39cd2-af40-4084-a5a1-8ccfe51742eb"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("f3a8ea29-cf9a-4867-bc7e-b7b72ce54ee7"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" }
                });
        }
    }
}
