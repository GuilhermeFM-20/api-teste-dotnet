using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_teste.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditFields2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "People");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "People",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
