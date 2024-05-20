using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiDisney.Migrations
{
    /// <inheritdoc />
    public partial class cambioPersonaje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Personajes");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Personajes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Personajes");

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Personajes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
