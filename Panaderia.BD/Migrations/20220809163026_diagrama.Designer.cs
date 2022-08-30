﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Panaderia.BD.Data;

#nullable disable

namespace Panaderia.BD.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20220809163026_diagrama")]
    partial class diagrama
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("EncargadoId")
                        .HasColumnType("int");

                    b.Property<string>("NombrCargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EmpleadoId", "Id" }, "EmpleadoCargoId_UQ")
                        .IsUnique();

                    b.HasIndex(new[] { "EncargadoId", "Id" }, "EncargadoCargoId_UQ")
                        .IsUnique();

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApellidoEncargado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DNI")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Edad")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaContrato")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PuestoCargo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Telefono")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.HasIndex(new[] { "DNI" }, "EmpleadoDNI_UQ")
                        .IsUnique();

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Encargado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApellidoEncargado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DNI")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Edad")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInicio")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEncargado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<string>("PuestoCargo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Telefono")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorId");

                    b.HasIndex(new[] { "DNI" }, "EncargadoDNI_UQ")
                        .IsUnique();

                    b.ToTable("Encargados");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Codigo")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Precio")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.HasIndex(new[] { "Codigo" }, "ProductoCodigo_UQ")
                        .IsUnique();

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DNI")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EncargadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrega")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EncargadoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex(new[] { "DNI" }, "ProveedorDNI_UQ")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadProduc")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("CodigoProduc")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProduc")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PrecioProduc")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex(new[] { "CodigoProduc" }, "CodigoProducVenta_UQ")
                        .IsUnique();

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Cargo", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Empleado", "Empleado")
                        .WithMany("Cargos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Panaderia.BD.Data.Entidades.Encargado", "Encargado")
                        .WithMany("Cargos")
                        .HasForeignKey("EncargadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("Encargado");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Empleado", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Venta", null)
                        .WithMany("Empleados")
                        .HasForeignKey("VentaId");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Encargado", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Proveedor", null)
                        .WithMany("Encargados")
                        .HasForeignKey("ProveedorId");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Producto", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Venta", null)
                        .WithMany("Productos")
                        .HasForeignKey("VentaId");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Proveedor", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Encargado", "Encargado")
                        .WithMany()
                        .HasForeignKey("EncargadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Panaderia.BD.Data.Entidades.Producto", null)
                        .WithMany("Proveedores")
                        .HasForeignKey("ProductoId");

                    b.Navigation("Encargado");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Venta", b =>
                {
                    b.HasOne("Panaderia.BD.Data.Entidades.Empleado", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Empleado", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Encargado", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Producto", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Proveedor", b =>
                {
                    b.Navigation("Encargados");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Venta", b =>
                {
                    b.Navigation("Empleados");

                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}