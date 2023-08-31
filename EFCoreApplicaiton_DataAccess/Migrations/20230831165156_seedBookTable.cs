using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Price", "Title" },
                values: new object[] { new Guid("4b4a035d-20f9-4a84-916d-d5ac1081d2da"), "Antiutopia", 200.0, "1984" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("4b4a035d-20f9-4a84-916d-d5ac1081d2da"));
        }
    }
}
