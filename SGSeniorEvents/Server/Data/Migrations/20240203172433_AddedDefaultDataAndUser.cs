using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SGSeniorEvents.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(7963), "Black", "System" },
                    { 2, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(7966), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(7967), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8274), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8277), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8472), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8474), "X5", "System" },
                    { 3, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8476), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8477), new DateTime(2024, 2, 4, 1, 24, 33, 852, DateTimeKind.Local).AddTicks(8477), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
