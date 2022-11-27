using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageFika.Api.Migrations
{
    public partial class UpdateMeetingModel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("24bac4a4-1719-4f11-a224-2046ad9a607b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("451a93c3-ba64-4be8-8db8-e142b2a45ee0"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("50405fc6-45e9-4938-828a-80979f4f9e57"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("7537fa44-44aa-4e14-8c7f-a25a532710e3"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("75d2a68c-6fe1-41d4-8a66-2cf672399dfa"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("802b2420-f709-4142-b4c4-76a95e283074"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("8751dd2e-cdee-4288-84bc-71fd22289642"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("89e210ba-89ce-4bbe-81a2-97dfe5c3183e"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("9b86bc9e-1ee3-49b1-869c-ee61f02d3604"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("bc53f3ab-0d12-4d57-93dc-92abd9c457c3"));

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("084b16cb-eb67-4eed-afd6-2527679bed4f"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("1caec0ed-34e1-4f34-938b-48c784d838d8"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("34b9ea88-2b24-4700-8638-41477893cf87"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("388b6723-e988-4a59-911e-1e3e41650f1b"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" },
                    { new Guid("3a0aac54-40b4-49ff-a2bc-cfc8a4ab403a"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("4ca9f035-7995-4714-a090-e04f3d489665"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("7346f11d-50cd-43b0-9b0f-fad3095785ba"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("82a376fb-1743-4574-8194-9dc55c0fad79"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("c19fd53a-db7d-4ca3-b532-e1078f764e15"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("fae39c7c-6b96-4635-87e3-69b21008d537"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("084b16cb-eb67-4eed-afd6-2527679bed4f"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("1caec0ed-34e1-4f34-938b-48c784d838d8"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("34b9ea88-2b24-4700-8638-41477893cf87"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("388b6723-e988-4a59-911e-1e3e41650f1b"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("3a0aac54-40b4-49ff-a2bc-cfc8a4ab403a"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("4ca9f035-7995-4714-a090-e04f3d489665"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("7346f11d-50cd-43b0-9b0f-fad3095785ba"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("82a376fb-1743-4574-8194-9dc55c0fad79"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("c19fd53a-db7d-4ca3-b532-e1078f764e15"));

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: new Guid("fae39c7c-6b96-4635-87e3-69b21008d537"));

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Date", "Description", "Language", "Location" },
                values: new object[,]
                {
                    { new Guid("24bac4a4-1719-4f11-a224-2046ad9a607b"), new DateTime(2022, 12, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 5", "Swedish", "Test location 5" },
                    { new Guid("451a93c3-ba64-4be8-8db8-e142b2a45ee0"), new DateTime(2022, 12, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 10", "Greek", "Test location 10" },
                    { new Guid("50405fc6-45e9-4938-828a-80979f4f9e57"), new DateTime(2022, 12, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 6", "English", "Test location 6" },
                    { new Guid("7537fa44-44aa-4e14-8c7f-a25a532710e3"), new DateTime(2022, 12, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 2", "Chinese", "Test location 2" },
                    { new Guid("75d2a68c-6fe1-41d4-8a66-2cf672399dfa"), new DateTime(2022, 12, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 1", "Finnish", "Test location 1" },
                    { new Guid("802b2420-f709-4142-b4c4-76a95e283074"), new DateTime(2022, 12, 17, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 8", "German", "Test location 8" },
                    { new Guid("8751dd2e-cdee-4288-84bc-71fd22289642"), new DateTime(2022, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 4", "Portuguese", "Test location 4" },
                    { new Guid("89e210ba-89ce-4bbe-81a2-97dfe5c3183e"), new DateTime(2022, 12, 16, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 7", "French", "Test location 7" },
                    { new Guid("9b86bc9e-1ee3-49b1-869c-ee61f02d3604"), new DateTime(2022, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 9", "Swedish", "Test location 9" },
                    { new Guid("bc53f3ab-0d12-4d57-93dc-92abd9c457c3"), new DateTime(2022, 12, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), "This is a test meeting 3", "Japanese", "Test location 3" }
                });
        }
    }
}
