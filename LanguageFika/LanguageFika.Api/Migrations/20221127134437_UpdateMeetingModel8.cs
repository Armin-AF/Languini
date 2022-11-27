using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateMeetingModel8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("1a863fe2-b6f5-4ede-81b4-d95c04f8f703"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("2b9cd03b-8274-4146-b2ce-1ff5264e9670"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("3234069d-3cb8-45df-b7b7-cb2bcdff575c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("4e32f08a-e4d9-40d5-90b4-313a045085de"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("706fe9eb-8b30-4bfa-9724-cfbe6d437971"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9a72d191-bc30-44fe-802b-eab23f66ee62"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("a213d1c7-a04f-4ec0-9996-b16becb7ec20"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("abee38e6-2492-4941-bac9-71ad7a737c2a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c0065b1a-66cb-4a54-8df8-b2786621c39c"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c158e427-3c32-488c-90e8-cd4d0b8c0864"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1a863fe2-b6f5-4ede-81b4-d95c04f8f703"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("2b9cd03b-8274-4146-b2ce-1ff5264e9670"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("3234069d-3cb8-45df-b7b7-cb2bcdff575c"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("4e32f08a-e4d9-40d5-90b4-313a045085de"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("706fe9eb-8b30-4bfa-9724-cfbe6d437971"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("9a72d191-bc30-44fe-802b-eab23f66ee62"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("a213d1c7-a04f-4ec0-9996-b16becb7ec20"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("abee38e6-2492-4941-bac9-71ad7a737c2a"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("c0065b1a-66cb-4a54-8df8-b2786621c39c"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("c158e427-3c32-488c-90e8-cd4d0b8c0864"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" }
                });
        }
    }
}
