﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(NominaDB))]
    [Migration("20220121112519_DBinicial")]
    partial class DBinicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo1.Entidades.DecimoCuarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Meses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("DecimoCuartos");
                });

            modelBuilder.Entity("Modelo1.Entidades.DecimoTercero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Meses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int?>("empleadoid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("empleadoid");

                    b.ToTable("DecimoTerceros");
                });

            modelBuilder.Entity("Modelo1.Entidades.Empleado", b =>
                {
                    b.Property<int>("empleadoid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuartosId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FondoReservaid")
                        .HasColumnType("int");

                    b.Property<string>("NombreEmp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Sueldo")
                        .HasColumnType("real");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("empleadoid");

                    b.HasIndex("FondoReservaid");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Modelo1.Entidades.FondoReserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Porcentaje")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("FondosReserva");
                });

            modelBuilder.Entity("Modelo1.Entidades.HorasExt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int?>("empleadoid")
                        .HasColumnType("int");

                    b.Property<double>("h100")
                        .HasColumnType("float");

                    b.Property<double>("h25")
                        .HasColumnType("float");

                    b.Property<double>("h50")
                        .HasColumnType("float");

                    b.Property<double>("vh100")
                        .HasColumnType("float");

                    b.Property<double>("vh25")
                        .HasColumnType("float");

                    b.Property<double>("vh50")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("empleadoid");

                    b.ToTable("HorasExts");
                });

            modelBuilder.Entity("Modelo1.Entidades.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Modelo1.Entidades.Sueldos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("DecimoCuartoSueldo")
                        .HasColumnType("real");

                    b.Property<float>("DecimoTercerSueldo")
                        .HasColumnType("real");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTiempo")
                        .HasColumnType("int");

                    b.Property<float>("SueldoBasico")
                        .HasColumnType("real");

                    b.Property<float>("Utilidades")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.HasIndex("IdTiempo");

                    b.ToTable("Sueldos");
                });

            modelBuilder.Entity("Modelo1.Entidades.TrabajoEmpleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFinTrabajo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioTrabajo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("TrabajoEmpleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Vacaciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Comisiones")
                        .HasColumnType("float");

                    b.Property<double>("HorasExtras")
                        .HasColumnType("float");

                    b.Property<string>("Meses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sueldo")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int?>("empleadoid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("empleadoid");

                    b.ToTable("Vacaciones");
                });

            modelBuilder.Entity("Modelo1.Entidades.DecimoCuarto", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany("Cuartos")
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.DecimoTercero", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("empleadoid");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Empleado", b =>
                {
                    b.HasOne("Modelo1.Entidades.FondoReserva", null)
                        .WithMany("Empleados")
                        .HasForeignKey("FondoReservaid");
                });

            modelBuilder.Entity("Modelo1.Entidades.HorasExt", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("empleadoid");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Roles", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Sueldos", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo1.Entidades.TrabajoEmpleado", "TiempoTrabajo")
                        .WithMany("Salarios")
                        .HasForeignKey("IdTiempo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");

                    b.Navigation("TiempoTrabajo");
                });

            modelBuilder.Entity("Modelo1.Entidades.TrabajoEmpleado", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Vacaciones", b =>
                {
                    b.HasOne("Modelo1.Entidades.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("empleadoid");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Modelo1.Entidades.Empleado", b =>
                {
                    b.Navigation("Cuartos");
                });

            modelBuilder.Entity("Modelo1.Entidades.FondoReserva", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Modelo1.Entidades.TrabajoEmpleado", b =>
                {
                    b.Navigation("Salarios");
                });
#pragma warning restore 612, 618
        }
    }
}