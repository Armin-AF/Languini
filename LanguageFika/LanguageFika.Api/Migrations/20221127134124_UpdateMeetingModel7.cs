using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateMeetingModel7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("3d74d233-0fdc-465e-b064-d47ee8a953b9"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5531f55f-c551-4bb8-b9ed-9864c8733c14"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5bc7f06d-6625-4123-860f-5803b6ae25b5"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("5cf66ee3-9021-4d96-b718-d56e7640f2c0"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("6fe6ac0f-9b83-4406-9180-36e86ddf0683"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("78741fe8-3dcc-4844-9859-a38cdaa9a6dd"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("91ad89fa-14d7-4e75-afee-a6c9409346e2"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ab3ffd28-19b7-486d-b351-75c28559908e"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("b26df750-3fd1-4d63-acad-16a48e25b151"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c213cb1f-8014-47c8-ab21-4ca1fa9802e7"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3d74d233-0fdc-465e-b064-d47ee8a953b9"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("5531f55f-c551-4bb8-b9ed-9864c8733c14"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("5bc7f06d-6625-4123-860f-5803b6ae25b5"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("5cf66ee3-9021-4d96-b718-d56e7640f2c0"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("6fe6ac0f-9b83-4406-9180-36e86ddf0683"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("78741fe8-3dcc-4844-9859-a38cdaa9a6dd"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("91ad89fa-14d7-4e75-afee-a6c9409346e2"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("ab3ffd28-19b7-486d-b351-75c28559908e"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("b26df750-3fd1-4d63-acad-16a48e25b151"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("c213cb1f-8014-47c8-ab21-4ca1fa9802e7"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" }
                });
        }
    }
}
