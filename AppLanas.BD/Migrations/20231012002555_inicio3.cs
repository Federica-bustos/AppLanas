using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLanas.BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cajaId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ventaid",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_cajaId",
                table: "Ventas",
                column: "cajaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Cajas_cajaId",
                table: "Ventas",
                column: "cajaId",
                principalTable: "Cajas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ventas_ventaid",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Cajas_cajaId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_cajaId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ventaid",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "cajaId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "ventaid",
                table: "Productos");
        }
    }
}
