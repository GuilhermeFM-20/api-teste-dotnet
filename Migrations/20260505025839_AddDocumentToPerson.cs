using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_teste.Migrations
{
    /// <inheritdoc />
    public partial class AddDocumentToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "People",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "People");
        }
    }
}
