using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class moveListOfAuthorsFromAuthorsTableToBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Authors_Author_id1",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Author_id1",
                table: "Authors",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_Author_id1",
                table: "Authors",
                newName: "IX_Authors_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Authors",
                newName: "Author_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                newName: "IX_Authors_Author_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Authors_Author_id1",
                table: "Authors",
                column: "Author_id1",
                principalTable: "Authors",
                principalColumn: "Author_id");
        }
    }
}
