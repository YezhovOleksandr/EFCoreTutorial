using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("4b4a035d-20f9-4a84-916d-d5ac1081d2da"));

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Author_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Author_id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Price", "Title" },
                values: new object[] { new Guid("468cb377-6526-40bb-98a5-0e04aeb02bef"), "Antiutopia", 200.0, "1984" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: new Guid("468cb377-6526-40bb-98a5-0e04aeb02bef"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Description", "Price", "Title" },
                values: new object[] { new Guid("4b4a035d-20f9-4a84-916d-d5ac1081d2da"), "Antiutopia", 200.0, "1984" });
        }
    }
}
