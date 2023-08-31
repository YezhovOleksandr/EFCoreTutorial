using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addingPossibilityToGainBooksWithTheSamePublisher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Author_id1",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Author_id1",
                table: "Authors",
                column: "Author_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Authors_Author_id1",
                table: "Authors",
                column: "Author_id1",
                principalTable: "Authors",
                principalColumn: "Author_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Authors_Author_id1",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Author_id1",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Author_id1",
                table: "Authors");
        }
    }
}
