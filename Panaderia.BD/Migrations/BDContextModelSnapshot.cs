﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Panaderia.BD.Data;

#nullable disable

namespace Panaderia.BD.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("NombreCargo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EmpleadoId", "Id" }, "EmpleadoCargoId_UQ")
                        .IsUnique();

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApellidoEmpleado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DNIEmpleado")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("DireccionEmpleado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EdadEmpleado")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaContratoEmpleado")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEmpleado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PuestoCargoEmpleado")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TelefonoEmpleado")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DNIEmpleado" }, "EmpleadoDNI_UQ")
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

                    b.Property<int>("DNIEncargado")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("DireccionEncargado")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EdadEncargado")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInicioEncargado")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEncargado")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("PuestoCargoEncargado")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TelefonoEncargado")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DNIEncargado" }, "EncargadoDNI_UQ")
                        .IsUnique();

                    b.ToTable("Encargados");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Producto", b =>
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

                    b.Property<DateTime>("FechaVencimientoProduc")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProduc")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PrecioProduc")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int?>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.HasIndex(new[] { "CodigoProduc" }, "ProductoCodigo_UQ")
                        .IsUnique();

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DNIProved")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("DireccionProved")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EncargadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntregaProved")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProved")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("TelefonoProved")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EncargadoId");

                    b.HasIndex("ProductoId");

                    b.HasIndex(new[] { "DNIProved" }, "ProveedorDNI_UQ")
                        .IsUnique();

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadVenta")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("CodigoVenta")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<int>("PrecioVenta")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex(new[] { "CodigoVenta" }, "CodigoProducVenta_UQ")
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

                    b.Navigation("Empleado");
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
                    b.HasOne("Panaderia.BD.Data.Entidades.Empleado", "Empleados")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Empleado", b =>
                {
                    b.Navigation("Cargos");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Producto", b =>
                {
                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Panaderia.BD.Data.Entidades.Venta", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
