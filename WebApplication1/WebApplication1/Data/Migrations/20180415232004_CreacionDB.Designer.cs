﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication1.Data;

namespace WebApplication1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180415232004_CreacionDB")]
    partial class CreacionDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview2-30571")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication1.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnName("Id_Persona")
                        .HasMaxLength(50);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Carnet")
                        .IsRequired()
                        .HasColumnName("carnet")
                        .HasMaxLength(50);

                    b.Property<string>("Ciudad")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Genero")
                        .HasColumnName("genero")
                        .HasMaxLength(1);

                    b.Property<string>("GrupoIdGrupo")
                        .HasMaxLength(50);

                    b.Property<string>("Id");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("TipoPersonaId")
                        .HasColumnName("idTipoPersona")
                        .HasMaxLength(50);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Cedula");

                    b.HasIndex("GrupoIdGrupo");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("TipoPersonaId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("WebApplication1.Models.AsistenciaEstudiantes", b =>
                {
                    b.Property<string>("IndAsistencia")
                        .HasColumnName("ind_asistencia")
                        .HasMaxLength(50);

                    b.Property<string>("Comentarios")
                        .HasColumnName("comentarios")
                        .HasMaxLength(50);

                    b.Property<int>("Estado")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Fechaasistencia")
                        .HasColumnName("fechaasistencia")
                        .HasColumnType("date");

                    b.Property<string>("IdGrupo")
                        .IsRequired()
                        .HasColumnName("id_grupo")
                        .HasMaxLength(50);

                    b.Property<string>("IdPersona")
                        .HasColumnName("id_persona")
                        .HasMaxLength(50);

                    b.HasKey("IndAsistencia");

                    b.HasIndex("IdGrupo");

                    b.HasIndex("IdPersona");

                    b.ToTable("AsistenciaEstudiantes");
                });

            modelBuilder.Entity("WebApplication1.Models.AsistenciaProfesor", b =>
                {
                    b.Property<string>("IdAsistencia")
                        .HasColumnName("id_Asistencia")
                        .HasMaxLength(50);

                    b.Property<string>("Comentarios")
                        .HasColumnName("comentarios")
                        .HasMaxLength(50);

                    b.Property<int>("Estado")
                        .HasColumnName("estado");

                    b.Property<DateTime>("Horaingreso")
                        .HasColumnName("horaingreso")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Horasalida")
                        .HasColumnName("horasalida")
                        .HasColumnType("datetime");

                    b.Property<string>("IdGrupo")
                        .HasColumnName("id_grupo")
                        .HasMaxLength(50);

                    b.Property<string>("IdPersona")
                        .HasColumnName("id_persona")
                        .HasMaxLength(50);

                    b.HasKey("IdAsistencia");

                    b.HasIndex("IdGrupo");

                    b.HasIndex("IdPersona");

                    b.ToTable("AsistenciaProfesor");
                });

            modelBuilder.Entity("WebApplication1.Models.Carreras", b =>
                {
                    b.Property<string>("IdCarrera")
                        .HasColumnName("id_carrera")
                        .HasMaxLength(50);

                    b.Property<string>("IdPersona")
                        .HasColumnName("id_persona")
                        .HasMaxLength(50);

                    b.Property<string>("NombreCarrera")
                        .HasMaxLength(50);

                    b.HasKey("IdCarrera");

                    b.HasIndex("IdPersona");

                    b.ToTable("Carreras");
                });

            modelBuilder.Entity("WebApplication1.Models.Cursos", b =>
                {
                    b.Property<string>("IdCurso")
                        .HasColumnName("Id_Curso")
                        .HasMaxLength(50);

                    b.Property<string>("IdCarrera")
                        .HasColumnName("id_carrera")
                        .HasMaxLength(50);

                    b.Property<int>("Creditos")
                        .HasColumnName("creditos");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50);

                    b.Property<int>("Estado")
                        .HasColumnName("estado");

                    b.Property<string>("IdMateriarequerida")
                        .HasColumnName("id_materiarequerida")
                        .HasMaxLength(50);

                    b.Property<string>("IdPersona")
                        .HasColumnName("id_persona")
                        .HasMaxLength(50);

                    b.Property<int>("Precio")
                        .HasColumnName("precio");

                    b.HasKey("IdCurso", "IdCarrera");

                    b.HasIndex("IdCarrera");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("WebApplication1.Models.DetalleMatricula", b =>
                {
                    b.Property<string>("IdDetalleMatricula")
                        .HasColumnName("idDetalleMatricula")
                        .HasMaxLength(50);

                    b.Property<string>("IdCarrera")
                        .HasColumnName("id_carrera")
                        .HasMaxLength(50);

                    b.Property<string>("IdCurso")
                        .HasColumnName("id_Curso")
                        .HasMaxLength(50);

                    b.Property<string>("IdMatricula")
                        .IsRequired()
                        .HasColumnName("id_Matricula")
                        .HasMaxLength(50);

                    b.Property<int>("Nota")
                        .HasColumnName("nota");

                    b.Property<int>("Submonto")
                        .HasColumnName("submonto");

                    b.HasKey("IdDetalleMatricula");

                    b.HasIndex("IdMatricula");

                    b.HasIndex("IdCurso", "IdCarrera");

                    b.ToTable("DetalleMatricula");
                });

            modelBuilder.Entity("WebApplication1.Models.DetalleNotas", b =>
                {
                    b.Property<string>("IdDetalleNota")
                        .HasColumnName("id_DetalleNota")
                        .HasMaxLength(50);

                    b.Property<string>("IdHistorico")
                        .HasColumnName("id_historico")
                        .HasMaxLength(50);

                    b.Property<string>("IdRubro")
                        .HasColumnName("id_Rubro")
                        .HasMaxLength(50);

                    b.Property<int>("Porcentajeganado")
                        .HasColumnName("porcentajeganado");

                    b.HasKey("IdDetalleNota");

                    b.HasIndex("IdHistorico");

                    b.HasIndex("IdRubro");

                    b.ToTable("DetalleNotas");
                });

            modelBuilder.Entity("WebApplication1.Models.Grupos", b =>
                {
                    b.Property<string>("IdGrupo")
                        .HasColumnName("Id_Grupo")
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50);

                    b.Property<string>("IdCarrera")
                        .HasColumnName("id_carrera")
                        .HasMaxLength(50);

                    b.Property<string>("IdCurso")
                        .HasColumnName("id_curso")
                        .HasMaxLength(50);

                    b.Property<string>("IdHorario")
                        .HasColumnName("id_horario")
                        .HasMaxLength(50);

                    b.HasKey("IdGrupo");

                    b.HasIndex("IdCarrera", "IdCurso");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("WebApplication1.Models.Matricula", b =>
                {
                    b.Property<string>("IdMatricula")
                        .HasColumnName("id_matricula")
                        .HasMaxLength(50);

                    b.Property<string>("Creidtomatriculado")
                        .HasColumnName("creidtomatriculado")
                        .HasColumnType("nchar(10)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("date");

                    b.Property<string>("IdEstudiante")
                        .HasColumnName("id_estudiante")
                        .HasMaxLength(50);

                    b.Property<string>("IdMatriculante")
                        .HasColumnName("id_matriculante")
                        .HasMaxLength(50);

                    b.Property<string>("Monto")
                        .HasColumnName("monto")
                        .HasColumnType("nchar(10)");

                    b.Property<int>("Nota")
                        .HasColumnName("nota");

                    b.Property<string>("Periodo")
                        .HasColumnName("periodo")
                        .HasMaxLength(50);

                    b.HasKey("IdMatricula");

                    b.HasIndex("IdEstudiante");

                    b.HasIndex("IdMatriculante");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("WebApplication1.Models.Notas", b =>
                {
                    b.Property<string>("IdHistorico")
                        .HasColumnName("id_historico")
                        .HasMaxLength(50);

                    b.Property<string>("IdCurso")
                        .HasColumnName("id_curso")
                        .HasMaxLength(50);

                    b.Property<string>("IdPersona")
                        .HasColumnName("id_persona")
                        .HasMaxLength(50);

                    b.Property<string>("IdTipopersona")
                        .HasColumnName("id_tipopersona")
                        .HasMaxLength(50);

                    b.Property<string>("Idcarrera")
                        .HasColumnName("idcarrera")
                        .HasMaxLength(50);

                    b.Property<string>("IndEstado")
                        .HasColumnName("ind_estado")
                        .HasMaxLength(50);

                    b.Property<int>("Nota")
                        .HasColumnName("nota");

                    b.Property<string>("Periodo")
                        .HasColumnName("periodo")
                        .HasMaxLength(50);

                    b.HasKey("IdHistorico");

                    b.HasIndex("IdPersona");

                    b.HasIndex("IdCurso", "Idcarrera");

                    b.HasIndex("IdTipopersona", "IdPersona");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("WebApplication1.Models.PersonaXtipo", b =>
                {
                    b.Property<string>("IdPersona")
                        .HasColumnName("Id_Persona")
                        .HasMaxLength(50);

                    b.Property<string>("IdTipoPersona")
                        .HasColumnName("Id_TipoPersona")
                        .HasMaxLength(50);

                    b.HasKey("IdPersona", "IdTipoPersona");

                    b.HasIndex("IdTipoPersona");

                    b.ToTable("PersonaXTipo");
                });

            modelBuilder.Entity("WebApplication1.Models.Roles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("IdUsuario");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication1.Models.Rubros", b =>
                {
                    b.Property<string>("IdRubro")
                        .HasMaxLength(50);

                    b.Property<string>("GrupoIdGrupo")
                        .HasMaxLength(50);

                    b.Property<string>("IdCarrera")
                        .HasColumnName("id_Carrera")
                        .HasMaxLength(50);

                    b.Property<string>("IdCurso")
                        .HasColumnName("id_Curso")
                        .HasMaxLength(50);

                    b.Property<string>("NombreRubro")
                        .HasColumnType("nchar(10)");

                    b.Property<int>("Porcentaje");

                    b.HasKey("IdRubro");

                    b.HasIndex("GrupoIdGrupo");

                    b.HasIndex("IdCurso", "IdCarrera");

                    b.ToTable("Rubros");
                });

            modelBuilder.Entity("WebApplication1.Models.Secuencias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.ToTable("Secuencias");
                });

            modelBuilder.Entity("WebApplication1.Models.TipoPersona", b =>
                {
                    b.Property<string>("IdTipoPersona")
                        .HasMaxLength(50);

                    b.Property<string>("Descripción")
                        .HasColumnType("nchar(10)");

                    b.HasKey("IdTipoPersona");

                    b.ToTable("TipoPersona");
                });

            modelBuilder.Entity("WebApplication1.Models.Ventanas", b =>
                {
                    b.Property<string>("IdVentana")
                        .HasColumnName("Id_Ventana")
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50);

                    b.HasKey("IdVentana");

                    b.ToTable("Ventanas");
                });

            modelBuilder.Entity("WebApplication1.Models.VentanasXperfil", b =>
                {
                    b.Property<string>("TipoPersona")
                        .HasMaxLength(50);

                    b.Property<string>("IdVentana")
                        .IsRequired()
                        .HasColumnName("Id_Ventana")
                        .HasMaxLength(50);

                    b.HasKey("TipoPersona");

                    b.HasIndex("IdVentana");

                    b.ToTable("VentanasXPerfil");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.ApplicationUser", b =>
                {
                    b.HasOne("WebApplication1.Models.Grupos", "GrupoIdGrupoNavigation")
                        .WithMany("Persona")
                        .HasForeignKey("GrupoIdGrupo");

                    b.HasOne("WebApplication1.Models.TipoPersona", "IdTipoPersonaNavigation")
                        .WithMany("Persona")
                        .HasForeignKey("TipoPersonaId")
                        .HasConstraintName("FK_Persona_TipoPersona");
                });

            modelBuilder.Entity("WebApplication1.Models.AsistenciaEstudiantes", b =>
                {
                    b.HasOne("WebApplication1.Models.Grupos", "IdGrupoNavigation")
                        .WithMany("AsistenciaEstudiantes")
                        .HasForeignKey("IdGrupo")
                        .HasConstraintName("FK_DetalleGrupo_Grupos");

                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdPersonaNavigation")
                        .WithMany("AsistenciaEstudiantes")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("FK_DetalleGrupo_Persona");
                });

            modelBuilder.Entity("WebApplication1.Models.AsistenciaProfesor", b =>
                {
                    b.HasOne("WebApplication1.Models.Grupos", "IdGrupoNavigation")
                        .WithMany("AsistenciaProfesor")
                        .HasForeignKey("IdGrupo")
                        .HasConstraintName("FK_AsistenciaProfesor_Grupos");

                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdPersonaNavigation")
                        .WithMany("AsistenciaProfesor")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("FK_AsistenciaProfesor_Persona");
                });

            modelBuilder.Entity("WebApplication1.Models.Carreras", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdPersonaNavigation")
                        .WithMany("Carreras")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("FK_Carreras_Persona");
                });

            modelBuilder.Entity("WebApplication1.Models.Cursos", b =>
                {
                    b.HasOne("WebApplication1.Models.Carreras", "IdCarreraNavigation")
                        .WithMany("Cursos")
                        .HasForeignKey("IdCarrera")
                        .HasConstraintName("FK_Cursos_Carreras");
                });

            modelBuilder.Entity("WebApplication1.Models.DetalleMatricula", b =>
                {
                    b.HasOne("WebApplication1.Models.Matricula", "IdMatriculaNavigation")
                        .WithMany("DetalleMatricula")
                        .HasForeignKey("IdMatricula")
                        .HasConstraintName("FK_DetalleMatricula_Matricula");

                    b.HasOne("WebApplication1.Models.Cursos", "IdC")
                        .WithMany("DetalleMatricula")
                        .HasForeignKey("IdCurso", "IdCarrera")
                        .HasConstraintName("FK_DetalleMatricula_Cursos");
                });

            modelBuilder.Entity("WebApplication1.Models.DetalleNotas", b =>
                {
                    b.HasOne("WebApplication1.Models.Notas", "IdHistoricoNavigation")
                        .WithMany("DetalleNotas")
                        .HasForeignKey("IdHistorico")
                        .HasConstraintName("FK_DetalleNotas_Notas");

                    b.HasOne("WebApplication1.Models.Rubros", "IdRubroNavigation")
                        .WithMany("DetalleNotas")
                        .HasForeignKey("IdRubro")
                        .HasConstraintName("FK_DetalleNotas_Rubros");
                });

            modelBuilder.Entity("WebApplication1.Models.Grupos", b =>
                {
                    b.HasOne("WebApplication1.Models.Cursos", "IdC")
                        .WithMany("Grupos")
                        .HasForeignKey("IdCarrera", "IdCurso")
                        .HasConstraintName("FK_Grupos_Cursos");
                });

            modelBuilder.Entity("WebApplication1.Models.Matricula", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdEstudianteNavigation")
                        .WithMany("MatriculaIdEstudianteNavigation")
                        .HasForeignKey("IdEstudiante")
                        .HasConstraintName("FK_Matricula_Persona2");

                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdMatriculanteNavigation")
                        .WithMany("MatriculaIdMatriculanteNavigation")
                        .HasForeignKey("IdMatriculante")
                        .HasConstraintName("FK_Matricula_Persona3");
                });

            modelBuilder.Entity("WebApplication1.Models.Notas", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdPersonaNavigation")
                        .WithMany("Notas")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("FK_Notas_Persona");

                    b.HasOne("WebApplication1.Models.Cursos", "Id")
                        .WithMany("Notas")
                        .HasForeignKey("IdCurso", "Idcarrera")
                        .HasConstraintName("FK_Notas_Cursos");

                    b.HasOne("WebApplication1.Models.PersonaXtipo", "IdNavigation")
                        .WithMany("Notas")
                        .HasForeignKey("IdTipopersona", "IdPersona")
                        .HasConstraintName("FK_Historico_PersonaXTipo");
                });

            modelBuilder.Entity("WebApplication1.Models.PersonaXtipo", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", "IdPersonaNavigation")
                        .WithMany("PersonaXtipo")
                        .HasForeignKey("IdPersona")
                        .HasConstraintName("FK_PersonaXTipo_Persona");

                    b.HasOne("WebApplication1.Models.TipoPersona", "IdTipoPersonaNavigation")
                        .WithMany("PersonaXtipo")
                        .HasForeignKey("IdTipoPersona")
                        .HasConstraintName("FK_PersonaXTipo_TipoPersona");
                });

            modelBuilder.Entity("WebApplication1.Models.Rubros", b =>
                {
                    b.HasOne("WebApplication1.Models.Grupos", "GrupoIdGrupoNavigation")
                        .WithMany("Rubros")
                        .HasForeignKey("GrupoIdGrupo");

                    b.HasOne("WebApplication1.Models.Cursos", "IdC")
                        .WithMany("Rubros")
                        .HasForeignKey("IdCurso", "IdCarrera")
                        .HasConstraintName("FK_Rubros_Cursos");
                });

            modelBuilder.Entity("WebApplication1.Models.VentanasXperfil", b =>
                {
                    b.HasOne("WebApplication1.Models.Ventanas", "IdVentanaNavigation")
                        .WithMany("VentanasXperfil")
                        .HasForeignKey("IdVentana")
                        .HasConstraintName("FK_VentanasXPerfil_Ventanas");
                });
#pragma warning restore 612, 618
        }
    }
}
