﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plataforma_de_banca_digital.Infrastructure.Persistence;

#nullable disable

namespace Plataforma_de_banca_digital.Infrastructure.Migrations
{
    [DbContext(typeof(DbContextSQL))]
    partial class DbContextSQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cargo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cliente", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DNI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly?>("FechaDeNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cuenta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CuentaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDeApertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroCuenta")
                        .HasColumnType("int");

                    b.Property<decimal>("SaldoActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("TipoDeCuentaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CuentaId");

                    b.HasIndex("TipoDeCuentaId");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Empleado", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CargoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SucursalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.EstadoPrestamo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EstadoPrestamo");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Notificacion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mensaje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.PagoPrestamo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontoPago")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroRecibo")
                        .HasColumnType("int");

                    b.Property<Guid?>("PrestamoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SaldoRestante")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PrestamoId");

                    b.ToTable("PagoPrestamos");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Prestamo", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EstadoPrestamoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeDesembolso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<float>("InteresAnual")
                        .HasColumnType("real");

                    b.Property<decimal>("MontoPrestamo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PlazoMeses")
                        .HasColumnType("int");

                    b.Property<decimal>("SaldoPendiente")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoPrestamoId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Rol", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreRol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Sucursal", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("HorarioAtencion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NonbreSucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.TipoCuenta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCuenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoCuentas");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.TipoTransaccion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TipoTransacciones");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Transaccion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CuentaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeTransaccion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("NumeroRecibo")
                        .HasColumnType("int");

                    b.Property<Guid>("TipoDeTransaccionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CuentaId");

                    b.HasIndex("TipoDeTransaccionId");

                    b.ToTable("Transacciones");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Usuario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContrasenaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmpleadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDeCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaDeModificacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IntentosFallidos")
                        .HasColumnType("int");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UltimoAcceso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UsuarioModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique()
                        .HasFilter("[ClienteId] IS NOT NULL");

                    b.HasIndex("EmpleadoId")
                        .IsUnique()
                        .HasFilter("[EmpleadoId] IS NOT NULL");

                    b.HasIndex("RolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cuenta", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cliente", "Cliente")
                        .WithMany("Cuentas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Plataforma_de_banca_digital.Application.Cuenta", null)
                        .WithMany("Cuentas")
                        .HasForeignKey("CuentaId");

                    b.HasOne("Plataforma_de_banca_digital.Application.TipoCuenta", "TipoCuenta")
                        .WithMany("Cuentas")
                        .HasForeignKey("TipoDeCuentaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cliente");

                    b.Navigation("TipoCuenta");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Empleado", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Plataforma_de_banca_digital.Application.Sucursal", "Sucursal")
                        .WithMany("Empleados")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cargo");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Notificacion", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cliente", "Cliente")
                        .WithMany("Notificaciones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.PagoPrestamo", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Prestamo", "Prestamo")
                        .WithMany("PagoPrestamos")
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Prestamo", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cliente", "Cliente")
                        .WithMany("Prestamos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Plataforma_de_banca_digital.Application.EstadoPrestamo", "EstadoPrestamo")
                        .WithMany()
                        .HasForeignKey("EstadoPrestamoId");

                    b.Navigation("Cliente");

                    b.Navigation("EstadoPrestamo");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Transaccion", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cuenta", "Cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Plataforma_de_banca_digital.Application.TipoTransaccion", "TipoTransaccion")
                        .WithMany("Transacciones")
                        .HasForeignKey("TipoDeTransaccionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cuenta");

                    b.Navigation("TipoTransaccion");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Usuario", b =>
                {
                    b.HasOne("Plataforma_de_banca_digital.Application.Cliente", "Cliente")
                        .WithOne("Usuario")
                        .HasForeignKey("Plataforma_de_banca_digital.Application.Usuario", "ClienteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Plataforma_de_banca_digital.Application.Empleado", "Empleado")
                        .WithOne("Usuario")
                        .HasForeignKey("Plataforma_de_banca_digital.Application.Usuario", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Plataforma_de_banca_digital.Application.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cliente", b =>
                {
                    b.Navigation("Cuentas");

                    b.Navigation("Notificaciones");

                    b.Navigation("Prestamos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Cuenta", b =>
                {
                    b.Navigation("Cuentas");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Empleado", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Prestamo", b =>
                {
                    b.Navigation("PagoPrestamos");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.Sucursal", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.TipoCuenta", b =>
                {
                    b.Navigation("Cuentas");
                });

            modelBuilder.Entity("Plataforma_de_banca_digital.Application.TipoTransaccion", b =>
                {
                    b.Navigation("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}
