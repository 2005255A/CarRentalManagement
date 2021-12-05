using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "b8dd8110-4b51-41cc-a24c-abbfb935cfb5", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5da27357-fe60-40f8-9b49-bfb0714b373b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "9dd1aad8-c0c4-4b25-a854-b05cbd1293b7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEBrio2YcXOakmkVktuhhHCGqXOgUUFRVAeVhbXxQKw6+rzJ7k8Bl6wsMk6IKbNngBw==", null, false, "d94c6a0b-1f97-4011-a591-2401c1e66939", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 19, 19, 25, 492, DateTimeKind.Local).AddTicks(1750), new DateTime(2021, 12, 5, 19, 19, 25, 495, DateTimeKind.Local).AddTicks(926), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 19, 19, 25, 495, DateTimeKind.Local).AddTicks(3766), new DateTime(2021, 12, 5, 19, 19, 25, 495, DateTimeKind.Local).AddTicks(3784), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 19, 19, 25, 501, DateTimeKind.Local).AddTicks(296), new DateTime(2021, 12, 5, 19, 19, 25, 501, DateTimeKind.Local).AddTicks(370), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 19, 19, 25, 501, DateTimeKind.Local).AddTicks(376), new DateTime(2021, 12, 5, 19, 19, 25, 501, DateTimeKind.Local).AddTicks(378), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5438), new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5492), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5503), new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5505), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5508), new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5510), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5513), new DateTime(2021, 12, 5, 19, 19, 25, 502, DateTimeKind.Local).AddTicks(5515), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
