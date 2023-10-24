using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLanas.BD.Migrations
{
    /// <inheritdoc />
    public partial class Actualizado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ventas_ventaid",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ventaid",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ventaid",
                table: "Productos");

            migrationBuilder.CreateTable(
                name: "ProductoVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoVentas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductoVentas_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoVentas_ProductoId",
                table: "ProductoVentas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoVentas_VentaId",
                table: "ProductoVentas",
                column: "VentaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoVentas");

            migrationBuilder.AddColumn<int>(
                name: "ventaid",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ventaid",
                table: "Productos",
                column: "ventaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ventas_ventaid",
                table: "Productos",
                column: "ventaid",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
