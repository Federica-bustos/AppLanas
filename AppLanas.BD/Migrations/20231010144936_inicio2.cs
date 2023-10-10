using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLanas.BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "totalGanancia",
                table: "Ventas",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "precioProveedor",
                table: "Productos",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "precioProducto",
                table: "Productos",
                type: "Decimal(10,2)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<decimal>(
                name: "porcentajeGanancia",
                table: "Productos",
                type: "Decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "totalGanancia",
                table: "Ventas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "precioProveedor",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "precioProducto",
                table: "Productos",
                type: "decimal(18,2)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<decimal>(
                name: "porcentajeGanancia",
                table: "Productos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(10,2)");
        }
    }
}
