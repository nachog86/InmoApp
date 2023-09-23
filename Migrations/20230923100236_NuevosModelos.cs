using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InmobiliariaBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class NuevosModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inmuebles_Usuarios_UsuarioId",
                table: "Inmuebles");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Rol");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Inmuebles",
                newName: "PropietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Inmuebles_UsuarioId",
                table: "Inmuebles",
                newName: "IX_Inmuebles_PropietarioId");

            migrationBuilder.AddColumn<string>(
                name: "Auth0UserId",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Amenidades",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "AreaTerreno",
                table: "Inmuebles",
                type: "numeric",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoInmueble",
                table: "Inmuebles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mensaje = table.Column<string>(type: "text", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consultas_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Imagenes",
                columns: table => new
                {
                    ImagenId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagenes", x => x.ImagenId);
                    table.ForeignKey(
                        name: "FK_Imagenes_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transacciones",
                columns: table => new
                {
                    TransaccionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaHora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Monto = table.Column<decimal>(type: "numeric", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacciones", x => x.TransaccionId);
                    table.ForeignKey(
                        name: "FK_Transacciones_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacciones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioInmuebles",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioInmuebles", x => new { x.UsuarioId, x.InmuebleId });
                    table.ForeignKey(
                        name: "FK_UsuarioInmuebles_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioInmuebles_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosFavoritos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosFavoritos", x => new { x.UsuarioId, x.InmuebleId });
                    table.ForeignKey(
                        name: "FK_UsuariosFavoritos_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosFavoritos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    VideoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                    table.ForeignKey(
                        name: "FK_Videos_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_InmuebleId",
                table: "Consultas",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_UsuarioId",
                table: "Consultas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagenes_InmuebleId",
                table: "Imagenes",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_InmuebleId",
                table: "Transacciones",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_UsuarioId",
                table: "Transacciones",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioInmuebles_InmuebleId",
                table: "UsuarioInmuebles",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosFavoritos_InmuebleId",
                table: "UsuariosFavoritos",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_InmuebleId",
                table: "Videos",
                column: "InmuebleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inmuebles_Usuarios_PropietarioId",
                table: "Inmuebles",
                column: "PropietarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inmuebles_Usuarios_PropietarioId",
                table: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Imagenes");

            migrationBuilder.DropTable(
                name: "Transacciones");

            migrationBuilder.DropTable(
                name: "UsuarioInmuebles");

            migrationBuilder.DropTable(
                name: "UsuariosFavoritos");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropColumn(
                name: "Auth0UserId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Amenidades",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "AreaTerreno",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Inmuebles");

            migrationBuilder.DropColumn(
                name: "TipoInmueble",
                table: "Inmuebles");

            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "PropietarioId",
                table: "Inmuebles",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Inmuebles_PropietarioId",
                table: "Inmuebles",
                newName: "IX_Inmuebles_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inmuebles_Usuarios_UsuarioId",
                table: "Inmuebles",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
