using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("468cb377-6526-40bb-98a5-0e04aeb02bef"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Price", "Title" },
                values: new object[] { new Guid("63606e06-440c-4d0e-b54a-b814945d9fc8"), "Antiutopia", 200.0, "1984" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("63606e06-440c-4d0e-b54a-b814945d9fc8"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Price", "Title" },
                values: new object[] { new Guid("468cb377-6526-40bb-98a5-0e04aeb02bef"), "Antiutopia", 200.0, "1984" });
        }
    }
}
