using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca_PasosManuel.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "PKRol", "Nombre" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "PKUsuario", "Apellido", "FKRol", "Nombre", "Password", "UserName" },
                values: new object[] { 1, "Pasos", 1, "Manuel", "root", "MPasos" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "PKUsuario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "PKRol",
                keyValue: 1);
        }
    }
}
