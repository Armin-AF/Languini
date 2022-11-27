using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateMeetingModel6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Meetings_MeetingId",
                table: "Participants");

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("00373933-d97b-4f8d-b2c1-2b81133bfe34"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("0db9f314-4d8a-41d2-959e-3c65ba708317"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("29463ac6-8b84-41ba-a2fd-48f8ea29b89b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("63956d05-ffb8-4f01-95e0-288ffda024fb"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8905383a-86c0-487d-b6b2-292cd3dcba25"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("92a086ba-1518-4b02-9c3c-9fae47f77199"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("cf818dcd-082c-4ac9-8a5f-be7a3ffe16a8"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ea67bf50-58dd-4df0-9095-0579e47e646d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("ee4b5c20-39b0-49e2-b76f-3a0a5d9ed52d"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("f4d78e58-b43e-401a-b1ca-4f90568c5f84"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Participants",
                newName: "ParticipantId");

            migrationBuilder.AlterColumn<Guid>(
                name: "MeetingId",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Meetings_MeetingId",
                table: "Participants",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Meetings_MeetingId",
                table: "Participants");

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

            migrationBuilder.RenameColumn(
                name: "ParticipantId",
                table: "Participants",
                newName: "Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "MeetingId",
                table: "Participants",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("00373933-d97b-4f8d-b2c1-2b81133bfe34"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("0db9f314-4d8a-41d2-959e-3c65ba708317"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("29463ac6-8b84-41ba-a2fd-48f8ea29b89b"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("63956d05-ffb8-4f01-95e0-288ffda024fb"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("8905383a-86c0-487d-b6b2-292cd3dcba25"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("92a086ba-1518-4b02-9c3c-9fae47f77199"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("cf818dcd-082c-4ac9-8a5f-be7a3ffe16a8"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("ea67bf50-58dd-4df0-9095-0579e47e646d"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("ee4b5c20-39b0-49e2-b76f-3a0a5d9ed52d"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("f4d78e58-b43e-401a-b1ca-4f90568c5f84"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Meetings_MeetingId",
                table: "Participants",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id");
        }
    }
}
