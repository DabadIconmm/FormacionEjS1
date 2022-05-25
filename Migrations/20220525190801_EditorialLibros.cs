using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejercicio_Sesión_1.Migrations
{
    /// <inheritdoc />
    public partial class EditorialLibros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditorialId",
                table: "Libros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialId",
                table: "Libros",
                column: "EditorialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Editorials_EditorialId",
                table: "Libros",
                column: "EditorialId",
                principalTable: "Editorials",
                principalColumn: "EditorialId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Editorials_EditorialId",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_EditorialId",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "EditorialId",
                table: "Libros");
        }
    }
}
