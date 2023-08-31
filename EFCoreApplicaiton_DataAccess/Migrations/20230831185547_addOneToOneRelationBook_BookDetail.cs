using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addOneToOneRelationBook_BookDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book_id",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_Book_id",
                table: "BookDetails",
                column: "Book_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_Book_id",
                table: "BookDetails",
                column: "Book_id",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_Book_id",
                table: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_Book_id",
                table: "BookDetails");

            migrationBuilder.DropColumn(
                name: "Book_id",
                table: "BookDetails");
        }
    }
}
