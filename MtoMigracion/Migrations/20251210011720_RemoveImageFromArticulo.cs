using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtoMigracion.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImageFromArticulo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Articulos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Articulos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
