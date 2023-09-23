using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InmobiliariaBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AñadirNuevosMetodos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MetrosCubiertos",
                table: "Inmuebles",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroBaños",
                table: "Inmuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TieneAscensor",
                table: "Inmuebles",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TieneCochera",
                table: "Inmuebles",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "MetrosCubiertos",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "NumeroBaños",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "TieneAscensor",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "TieneCochera",
                table: "Inmuebles");
        }
    }
}
