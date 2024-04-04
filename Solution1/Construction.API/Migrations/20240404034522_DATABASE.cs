using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Construction.API.Migrations
{
    /// <inheritdoc />
    public partial class DATABASE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipoConstrucciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especialidades = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ListaMiembros = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipoConstrucciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Provedor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaEntregaAprox = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Presupuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostoManoObra = table.Column<double>(type: "float", nullable: false),
                    CostoMateriales = table.Column<double>(type: "float", nullable: false),
                    CostoMaquinas = table.Column<double>(type: "float", nullable: false),
                    CostoProyecto = table.Column<double>(type: "float", nullable: false),
                    CostoTarea = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAproxFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsignacionMateriales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialesId = table.Column<int>(type: "int", nullable: true),
                    TareasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionMateriales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionMateriales_Materiales_MaterialesId",
                        column: x => x.MaterialesId,
                        principalTable: "Materiales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AsignacionMateriales_Tareas_TareasId",
                        column: x => x.TareasId,
                        principalTable: "Tareas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Maquinarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Disponibilidad = table.Column<bool>(type: "bit", nullable: false),
                    TareasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquinarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maquinarias_Tareas_TareasId",
                        column: x => x.TareasId,
                        principalTable: "Tareas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProyectoConstrucciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAproxFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PresupuestosId = table.Column<int>(type: "int", nullable: true),
                    MaterialesId = table.Column<int>(type: "int", nullable: true),
                    TareasId = table.Column<int>(type: "int", nullable: true),
                    MaquinariasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoConstrucciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProyectoConstrucciones_Maquinarias_MaquinariasId",
                        column: x => x.MaquinariasId,
                        principalTable: "Maquinarias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProyectoConstrucciones_Materiales_MaterialesId",
                        column: x => x.MaterialesId,
                        principalTable: "Materiales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProyectoConstrucciones_Presupuestos_PresupuestosId",
                        column: x => x.PresupuestosId,
                        principalTable: "Presupuestos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProyectoConstrucciones_Tareas_TareasId",
                        column: x => x.TareasId,
                        principalTable: "Tareas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AsignacionEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipoContruccionesId = table.Column<int>(type: "int", nullable: true),
                    ProyectoConstruccionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignacionEquipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsignacionEquipos_EquipoConstrucciones_EquipoContruccionesId",
                        column: x => x.EquipoContruccionesId,
                        principalTable: "EquipoConstrucciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AsignacionEquipos_ProyectoConstrucciones_ProyectoConstruccionesId",
                        column: x => x.ProyectoConstruccionesId,
                        principalTable: "ProyectoConstrucciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionEquipos_EquipoContruccionesId",
                table: "AsignacionEquipos",
                column: "EquipoContruccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionEquipos_ProyectoConstruccionesId",
                table: "AsignacionEquipos",
                column: "ProyectoConstruccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMateriales_MaterialesId",
                table: "AsignacionMateriales",
                column: "MaterialesId");

            migrationBuilder.CreateIndex(
                name: "IX_AsignacionMateriales_TareasId",
                table: "AsignacionMateriales",
                column: "TareasId");

            migrationBuilder.CreateIndex(
                name: "IX_Maquinarias_TareasId",
                table: "Maquinarias",
                column: "TareasId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoConstrucciones_MaquinariasId",
                table: "ProyectoConstrucciones",
                column: "MaquinariasId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoConstrucciones_MaterialesId",
                table: "ProyectoConstrucciones",
                column: "MaterialesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoConstrucciones_PresupuestosId",
                table: "ProyectoConstrucciones",
                column: "PresupuestosId");

            migrationBuilder.CreateIndex(
                name: "IX_ProyectoConstrucciones_TareasId",
                table: "ProyectoConstrucciones",
                column: "TareasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignacionEquipos");

            migrationBuilder.DropTable(
                name: "AsignacionMateriales");

            migrationBuilder.DropTable(
                name: "EquipoConstrucciones");

            migrationBuilder.DropTable(
                name: "ProyectoConstrucciones");

            migrationBuilder.DropTable(
                name: "Maquinarias");

            migrationBuilder.DropTable(
                name: "Materiales");

            migrationBuilder.DropTable(
                name: "Presupuestos");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
