﻿// <auto-generated />
using AppLanas.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppLanas.BD.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231010144936_inicio2")]
    partial class inicio2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppLanas.BD.Data.Entity.Caja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Cajas");
                });

            modelBuilder.Entity("AppLanas.BD.Data.Entity.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal>("porcentajeGanancia")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<decimal>("precioProducto")
                        .HasMaxLength(40)
                        .HasColumnType("Decimal(10,2)");

                    b.Property<decimal>("precioProveedor")
                        .HasColumnType("Decimal(10,2)");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("AppLanas.BD.Data.Entity.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("idCaja")
                        .HasColumnType("int");

                    b.Property<decimal>("totalGanancia")
                        .HasColumnType("Decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
