using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiDisney.Migrations
{
    /// <inheritdoc />
    public partial class cambiosEnGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Generos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Generos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
