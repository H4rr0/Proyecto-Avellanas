using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class CreacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdUsuario = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Secuencias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secuencias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    IdTipoPersona = table.Column<string>(maxLength: 50, nullable: false),
                    Descripción = table.Column<string>(type: "nchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.IdTipoPersona);
                });

            migrationBuilder.CreateTable(
                name: "Ventanas",
                columns: table => new
                {
                    Id_Ventana = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventanas", x => x.Id_Ventana);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentanasXPerfil",
                columns: table => new
                {
                    TipoPersona = table.Column<string>(maxLength: 50, nullable: false),
                    Id_Ventana = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentanasXPerfil", x => x.TipoPersona);
                    table.ForeignKey(
                        name: "FK_VentanasXPerfil_Ventanas",
                        column: x => x.Id_Ventana,
                        principalTable: "Ventanas",
                        principalColumn: "Id_Ventana",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciaEstudiantes",
                columns: table => new
                {
                    ind_asistencia = table.Column<string>(maxLength: 50, nullable: false),
                    comentarios = table.Column<string>(maxLength: 50, nullable: true),
                    estado = table.Column<int>(nullable: false),
                    fechaasistencia = table.Column<DateTime>(type: "date", nullable: false),
                    id_grupo = table.Column<string>(maxLength: 50, nullable: false),
                    id_persona = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaEstudiantes", x => x.ind_asistencia);
                });

            migrationBuilder.CreateTable(
                name: "AsistenciaProfesor",
                columns: table => new
                {
                    id_Asistencia = table.Column<string>(maxLength: 50, nullable: false),
                    comentarios = table.Column<string>(maxLength: 50, nullable: true),
                    estado = table.Column<int>(nullable: false),
                    horaingreso = table.Column<DateTime>(type: "datetime", nullable: false),
                    horasalida = table.Column<DateTime>(type: "datetime", nullable: false),
                    id_grupo = table.Column<string>(maxLength: 50, nullable: true),
                    id_persona = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistenciaProfesor", x => x.id_Asistencia);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    id_carrera = table.Column<string>(maxLength: 50, nullable: false),
                    id_persona = table.Column<string>(maxLength: 50, nullable: true),
                    NombreCarrera = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.id_carrera);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id_Curso = table.Column<string>(maxLength: 50, nullable: false),
                    id_carrera = table.Column<string>(maxLength: 50, nullable: false),
                    creditos = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: true),
                    estado = table.Column<int>(nullable: false),
                    id_materiarequerida = table.Column<string>(maxLength: 50, nullable: true),
                    id_persona = table.Column<string>(maxLength: 50, nullable: true),
                    precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => new { x.Id_Curso, x.id_carrera });
                    table.ForeignKey(
                        name: "FK_Cursos_Carreras",
                        column: x => x.id_carrera,
                        principalTable: "Carreras",
                        principalColumn: "id_carrera",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id_Grupo = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: true),
                    id_carrera = table.Column<string>(maxLength: 50, nullable: true),
                    id_curso = table.Column<string>(maxLength: 50, nullable: true),
                    id_horario = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id_Grupo);
                    table.ForeignKey(
                        name: "FK_Grupos_Cursos",
                        columns: x => new { x.id_carrera, x.id_curso },
                        principalTable: "Cursos",
                        principalColumns: new[] { "Id_Curso", "id_carrera" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    AccessFailedCount = table.Column<int>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    Id = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Id_Persona = table.Column<string>(maxLength: 50, nullable: false),
                    carnet = table.Column<string>(maxLength: 50, nullable: false),
                    Ciudad = table.Column<string>(maxLength: 50, nullable: true),
                    Correo = table.Column<string>(maxLength: 50, nullable: false),
                    genero = table.Column<string>(maxLength: 1, nullable: true),
                    idTipoPersona = table.Column<string>(maxLength: 50, nullable: true),
                    NombreCompleto = table.Column<string>(maxLength: 50, nullable: false),
                    Pais = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    GrupoIdGrupo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id_Persona);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Grupos_GrupoIdGrupo",
                        column: x => x.GrupoIdGrupo,
                        principalTable: "Grupos",
                        principalColumn: "Id_Grupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_TipoPersona",
                        column: x => x.idTipoPersona,
                        principalTable: "TipoPersona",
                        principalColumn: "IdTipoPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rubros",
                columns: table => new
                {
                    IdRubro = table.Column<string>(maxLength: 50, nullable: false),
                    id_Carrera = table.Column<string>(maxLength: 50, nullable: true),
                    id_Curso = table.Column<string>(maxLength: 50, nullable: true),
                    NombreRubro = table.Column<string>(type: "nchar(10)", nullable: true),
                    Porcentaje = table.Column<int>(nullable: false),
                    GrupoIdGrupo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rubros", x => x.IdRubro);
                    table.ForeignKey(
                        name: "FK_Rubros_Grupos_GrupoIdGrupo",
                        column: x => x.GrupoIdGrupo,
                        principalTable: "Grupos",
                        principalColumn: "Id_Grupo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rubros_Cursos",
                        columns: x => new { x.id_Curso, x.id_Carrera },
                        principalTable: "Cursos",
                        principalColumns: new[] { "Id_Curso", "id_carrera" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matricula",
                columns: table => new
                {
                    id_matricula = table.Column<string>(maxLength: 50, nullable: false),
                    creidtomatriculado = table.Column<string>(type: "nchar(10)", nullable: true),
                    fecha = table.Column<DateTime>(type: "date", nullable: false),
                    id_estudiante = table.Column<string>(maxLength: 50, nullable: true),
                    id_matriculante = table.Column<string>(maxLength: 50, nullable: true),
                    monto = table.Column<string>(type: "nchar(10)", nullable: true),
                    nota = table.Column<int>(nullable: false),
                    periodo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matricula", x => x.id_matricula);
                    table.ForeignKey(
                        name: "FK_Matricula_Persona2",
                        column: x => x.id_estudiante,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matricula_Persona3",
                        column: x => x.id_matriculante,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonaXTipo",
                columns: table => new
                {
                    Id_Persona = table.Column<string>(maxLength: 50, nullable: false),
                    Id_TipoPersona = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonaXTipo", x => new { x.Id_Persona, x.Id_TipoPersona });
                    table.ForeignKey(
                        name: "FK_PersonaXTipo_Persona",
                        column: x => x.Id_Persona,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonaXTipo_TipoPersona",
                        column: x => x.Id_TipoPersona,
                        principalTable: "TipoPersona",
                        principalColumn: "IdTipoPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleMatricula",
                columns: table => new
                {
                    idDetalleMatricula = table.Column<string>(maxLength: 50, nullable: false),
                    id_carrera = table.Column<string>(maxLength: 50, nullable: true),
                    id_Curso = table.Column<string>(maxLength: 50, nullable: true),
                    id_Matricula = table.Column<string>(maxLength: 50, nullable: false),
                    nota = table.Column<int>(nullable: false),
                    submonto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleMatricula", x => x.idDetalleMatricula);
                    table.ForeignKey(
                        name: "FK_DetalleMatricula_Matricula",
                        column: x => x.id_Matricula,
                        principalTable: "Matricula",
                        principalColumn: "id_matricula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleMatricula_Cursos",
                        columns: x => new { x.id_Curso, x.id_carrera },
                        principalTable: "Cursos",
                        principalColumns: new[] { "Id_Curso", "id_carrera" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    id_historico = table.Column<string>(maxLength: 50, nullable: false),
                    id_curso = table.Column<string>(maxLength: 50, nullable: true),
                    id_persona = table.Column<string>(maxLength: 50, nullable: true),
                    id_tipopersona = table.Column<string>(maxLength: 50, nullable: true),
                    idcarrera = table.Column<string>(maxLength: 50, nullable: true),
                    ind_estado = table.Column<string>(maxLength: 50, nullable: true),
                    nota = table.Column<int>(nullable: false),
                    periodo = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.id_historico);
                    table.ForeignKey(
                        name: "FK_Notas_Persona",
                        column: x => x.id_persona,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id_Persona",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notas_Cursos",
                        columns: x => new { x.id_curso, x.idcarrera },
                        principalTable: "Cursos",
                        principalColumns: new[] { "Id_Curso", "id_carrera" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Historico_PersonaXTipo",
                        columns: x => new { x.id_tipopersona, x.id_persona },
                        principalTable: "PersonaXTipo",
                        principalColumns: new[] { "Id_Persona", "Id_TipoPersona" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleNotas",
                columns: table => new
                {
                    id_DetalleNota = table.Column<string>(maxLength: 50, nullable: false),
                    id_historico = table.Column<string>(maxLength: 50, nullable: true),
                    id_Rubro = table.Column<string>(maxLength: 50, nullable: true),
                    porcentajeganado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleNotas", x => x.id_DetalleNota);
                    table.ForeignKey(
                        name: "FK_DetalleNotas_Notas",
                        column: x => x.id_historico,
                        principalTable: "Notas",
                        principalColumn: "id_historico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleNotas_Rubros",
                        column: x => x.id_Rubro,
                        principalTable: "Rubros",
                        principalColumn: "IdRubro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaEstudiantes_id_grupo",
                table: "AsistenciaEstudiantes",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaEstudiantes_id_persona",
                table: "AsistenciaEstudiantes",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaProfesor_id_grupo",
                table: "AsistenciaProfesor",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "IX_AsistenciaProfesor_id_persona",
                table: "AsistenciaProfesor",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GrupoIdGrupo",
                table: "AspNetUsers",
                column: "GrupoIdGrupo");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_idTipoPersona",
                table: "AspNetUsers",
                column: "idTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Carreras_id_persona",
                table: "Carreras",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_id_carrera",
                table: "Cursos",
                column: "id_carrera");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMatricula_id_Matricula",
                table: "DetalleMatricula",
                column: "id_Matricula");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleMatricula_id_Curso_id_carrera",
                table: "DetalleMatricula",
                columns: new[] { "id_Curso", "id_carrera" });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleNotas_id_historico",
                table: "DetalleNotas",
                column: "id_historico");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleNotas_id_Rubro",
                table: "DetalleNotas",
                column: "id_Rubro");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_id_carrera_id_curso",
                table: "Grupos",
                columns: new[] { "id_carrera", "id_curso" });

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_id_estudiante",
                table: "Matricula",
                column: "id_estudiante");

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_id_matriculante",
                table: "Matricula",
                column: "id_matriculante");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_id_persona",
                table: "Notas",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_Notas_id_curso_idcarrera",
                table: "Notas",
                columns: new[] { "id_curso", "idcarrera" });

            migrationBuilder.CreateIndex(
                name: "IX_Notas_id_tipopersona_id_persona",
                table: "Notas",
                columns: new[] { "id_tipopersona", "id_persona" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonaXTipo_Id_TipoPersona",
                table: "PersonaXTipo",
                column: "Id_TipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_GrupoIdGrupo",
                table: "Rubros",
                column: "GrupoIdGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_Rubros_id_Curso_id_Carrera",
                table: "Rubros",
                columns: new[] { "id_Curso", "id_Carrera" });

            migrationBuilder.CreateIndex(
                name: "IX_VentanasXPerfil_Id_Ventana",
                table: "VentanasXPerfil",
                column: "Id_Ventana");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleGrupo_Grupos",
                table: "AsistenciaEstudiantes",
                column: "id_grupo",
                principalTable: "Grupos",
                principalColumn: "Id_Grupo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleGrupo_Persona",
                table: "AsistenciaEstudiantes",
                column: "id_persona",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AsistenciaProfesor_Grupos",
                table: "AsistenciaProfesor",
                column: "id_grupo",
                principalTable: "Grupos",
                principalColumn: "Id_Grupo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AsistenciaProfesor_Persona",
                table: "AsistenciaProfesor",
                column: "id_persona",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carreras_Persona",
                table: "Carreras",
                column: "id_persona",
                principalTable: "AspNetUsers",
                principalColumn: "Id_Persona",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Grupos_GrupoIdGrupo",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AsistenciaEstudiantes");

            migrationBuilder.DropTable(
                name: "AsistenciaProfesor");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DetalleMatricula");

            migrationBuilder.DropTable(
                name: "DetalleNotas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Secuencias");

            migrationBuilder.DropTable(
                name: "VentanasXPerfil");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Matricula");

            migrationBuilder.DropTable(
                name: "Notas");

            migrationBuilder.DropTable(
                name: "Rubros");

            migrationBuilder.DropTable(
                name: "Ventanas");

            migrationBuilder.DropTable(
                name: "PersonaXTipo");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TipoPersona");
        }
    }
}
