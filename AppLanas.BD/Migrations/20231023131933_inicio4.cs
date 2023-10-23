using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLanas.BD.Migrations
{
    /// <inheritdoc />
    public partial class inicio4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Cajas_cajaId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "cajaId",
                table: "Ventas",
                newName: "CajaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_cajaId",
                table: "Ventas",
                newName: "IX_Ventas_CajaId");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Cajas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Cajas_CajaId",
                table: "Ventas",
                column: "CajaId",
                principalTable: "Cajas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Cajas_CajaId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Cajas");

            migrationBuilder.RenameColumn(
                name: "CajaId",
                table: "Ventas",
                newName: "cajaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_CajaId",
                table: "Ventas",
                newName: "IX_Ventas_cajaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Cajas_cajaId",
                table: "Ventas",
                column: "cajaId",
                principalTable: "Cajas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
