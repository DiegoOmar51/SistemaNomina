using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class DBinicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FondosReserva",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Porcentaje = table.Column<float>(type: "real", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosReserva", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    empleadoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sueldo = table.Column<float>(type: "real", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CuartosId = table.Column<int>(type: "int", nullable: false),
                    FondoReservaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.empleadoid);
                    table.ForeignKey(
                        name: "FK_Empleados_FondosReserva_FondoReservaid",
                        column: x => x.FondoReservaid,
                        principalTable: "FondosReserva",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DecimoCuartos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    Meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecimoCuartos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecimoCuartos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecimoTerceros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoid = table.Column<int>(type: "int", nullable: true),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecimoTerceros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecimoTerceros_Empleados_empleadoid",
                        column: x => x.empleadoid,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HorasExts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoid = table.Column<int>(type: "int", nullable: true),
                    h25 = table.Column<double>(type: "float", nullable: false),
                    h50 = table.Column<double>(type: "float", nullable: false),
                    h100 = table.Column<double>(type: "float", nullable: false),
                    vh25 = table.Column<double>(type: "float", nullable: false),
                    vh50 = table.Column<double>(type: "float", nullable: false),
                    vh100 = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasExts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorasExts_Empleados_empleadoid",
                        column: x => x.empleadoid,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrabajoEmpleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicioTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrabajoEmpleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrabajoEmpleado_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoid = table.Column<int>(type: "int", nullable: true),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sueldo = table.Column<double>(type: "float", nullable: false),
                    Comisiones = table.Column<double>(type: "float", nullable: false),
                    HorasExtras = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacaciones_Empleados_empleadoid",
                        column: x => x.empleadoid,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sueldos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SueldoBasico = table.Column<float>(type: "real", nullable: false),
                    DecimoTercerSueldo = table.Column<float>(type: "real", nullable: false),
                    DecimoCuartoSueldo = table.Column<float>(type: "real", nullable: false),
                    Utilidades = table.Column<float>(type: "real", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    IdTiempo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sueldos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sueldos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "empleadoid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sueldos_TrabajoEmpleado_IdTiempo",
                        column: x => x.IdTiempo,
                        principalTable: "TrabajoEmpleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DecimoCuartos_EmpleadoId",
                table: "DecimoCuartos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_DecimoTerceros_empleadoid",
                table: "DecimoTerceros",
                column: "empleadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_FondoReservaid",
                table: "Empleados",
                column: "FondoReservaid");

            migrationBuilder.CreateIndex(
                name: "IX_HorasExts_empleadoid",
                table: "HorasExts",
                column: "empleadoid");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmpleadoId",
                table: "Roles",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_EmpleadoId",
                table: "Sueldos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sueldos_IdTiempo",
                table: "Sueldos",
                column: "IdTiempo");

            migrationBuilder.CreateIndex(
                name: "IX_TrabajoEmpleado_EmpleadoId",
                table: "TrabajoEmpleado",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacaciones_empleadoid",
                table: "Vacaciones",
                column: "empleadoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DecimoCuartos");

            migrationBuilder.DropTable(
                name: "DecimoTerceros");

            migrationBuilder.DropTable(
                name: "HorasExts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Sueldos");

            migrationBuilder.DropTable(
                name: "Vacaciones");

            migrationBuilder.DropTable(
                name: "TrabajoEmpleado");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "FondosReserva");
        }
    }
}
