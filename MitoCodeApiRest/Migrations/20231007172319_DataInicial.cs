using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitoCodeApiRest.Migrations
{
    /// <inheritdoc />
    public partial class DataInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Erick" },
                    { 2, "Adam" },
                    { 3, "Roxana" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
