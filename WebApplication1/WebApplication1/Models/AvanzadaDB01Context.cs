using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
//    public partial class AvanzadaDB01Context : DbContext
//    {
//        public virtual DbSet<AsistenciaEstudiantes> AsistenciaEstudiantes { get; set; }
//        public virtual DbSet<AsistenciaProfesor> AsistenciaProfesor { get; set; }
//        public virtual DbSet<Carreras> Carreras { get; set; }
//        public virtual DbSet<Cursos> Cursos { get; set; }
//        public virtual DbSet<DetalleMatricula> DetalleMatricula { get; set; }
//        public virtual DbSet<DetalleNotas> DetalleNotas { get; set; }
//        public virtual DbSet<Grupos> Grupos { get; set; }
//        public virtual DbSet<Matricula> Matricula { get; set; }
//        public virtual DbSet<Notas> Notas { get; set; }
//        public virtual DbSet<ApplicationUser> Persona { get; set; }
//        public virtual DbSet<PersonaXtipo> PersonaXtipo { get; set; }
//        public virtual DbSet<Roles> Roles { get; set; }
//        public virtual DbSet<Rubros> Rubros { get; set; }
//        public virtual DbSet<Secuencias> Secuencias { get; set; }
//        public virtual DbSet<TipoPersona> TipoPersona { get; set; }
//        public virtual DbSet<Ventanas> Ventanas { get; set; }
//        public virtual DbSet<VentanasXperfil> VentanasXperfil { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AvanzadaDB01;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<AsistenciaEstudiantes>(entity =>
//            {
//                entity.HasKey(e => e.IndAsistencia);

//                entity.HasIndex(e => e.IdGrupo);

//                entity.HasIndex(e => e.IdPersona);

//                entity.Property(e => e.IndAsistencia)
//                    .HasColumnName("ind_asistencia")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Comentarios)
//                    .HasColumnName("comentarios")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.Fechaasistencia)
//                    .HasColumnName("fechaasistencia")
//                    .HasColumnType("date");

//                entity.Property(e => e.IdGrupo)
//                    .IsRequired()
//                    .HasColumnName("id_grupo")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("id_persona")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdGrupoNavigation)
//                    .WithMany(p => p.AsistenciaEstudiantes)
//                    .HasForeignKey(d => d.IdGrupo)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_DetalleGrupo_Grupos");

//                entity.HasOne(d => d.IdPersonaNavigation)
//                    .WithMany(p => p.AsistenciaEstudiantes)
//                    .HasForeignKey(d => d.IdPersona)
//                    .HasConstraintName("FK_DetalleGrupo_Persona");
//            });

//            modelBuilder.Entity<AsistenciaProfesor>(entity =>
//            {
//                entity.HasKey(e => e.IdAsistencia);

//                entity.HasIndex(e => e.IdGrupo);

//                entity.HasIndex(e => e.IdPersona);

//                entity.Property(e => e.IdAsistencia)
//                    .HasColumnName("id_Asistencia")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Comentarios)
//                    .HasColumnName("comentarios")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.Horaingreso)
//                    .HasColumnName("horaingreso")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Horasalida)
//                    .HasColumnName("horasalida")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.IdGrupo)
//                    .HasColumnName("id_grupo")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("id_persona")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdGrupoNavigation)
//                    .WithMany(p => p.AsistenciaProfesor)
//                    .HasForeignKey(d => d.IdGrupo)
//                    .HasConstraintName("FK_AsistenciaProfesor_Grupos");

//                entity.HasOne(d => d.IdPersonaNavigation)
//                    .WithMany(p => p.AsistenciaProfesor)
//                    .HasForeignKey(d => d.IdPersona)
//                    .HasConstraintName("FK_AsistenciaProfesor_Persona");
//            });

//            modelBuilder.Entity<Carreras>(entity =>
//            {
//                entity.HasKey(e => e.IdCarrera);

//                entity.HasIndex(e => e.IdPersona);

//                entity.Property(e => e.IdCarrera)
//                    .HasColumnName("id_carrera")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("id_persona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NombreCarrera).HasMaxLength(50);

//                entity.HasOne(d => d.IdPersonaNavigation)
//                    .WithMany(p => p.Carreras)
//                    .HasForeignKey(d => d.IdPersona)
//                    .HasConstraintName("FK_Carreras_Persona");
//            });

//            modelBuilder.Entity<Cursos>(entity =>
//            {
//                entity.HasKey(e => new { e.IdCurso, e.IdCarrera });

//                entity.HasIndex(e => e.IdCarrera);

//                entity.Property(e => e.IdCurso)
//                    .HasColumnName("Id_Curso")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdCarrera)
//                    .HasColumnName("id_carrera")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Creditos).HasColumnName("creditos");

//                entity.Property(e => e.Descripcion).HasMaxLength(50);

//                entity.Property(e => e.Estado).HasColumnName("estado");

//                entity.Property(e => e.IdMateriarequerida)
//                    .HasColumnName("id_materiarequerida")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("id_persona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Precio).HasColumnName("precio");

//                entity.HasOne(d => d.IdCarreraNavigation)
//                    .WithMany(p => p.Cursos)
//                    .HasForeignKey(d => d.IdCarrera)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_Cursos_Carreras");
//            });

//            modelBuilder.Entity<DetalleMatricula>(entity =>
//            {
//                entity.HasKey(e => e.IdDetalleMatricula);

//                entity.HasIndex(e => e.IdMatricula);

//                entity.HasIndex(e => new { e.IdCurso, e.IdCarrera });

//                entity.Property(e => e.IdDetalleMatricula)
//                    .HasColumnName("idDetalleMatricula")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.IdCarrera)
//                    .HasColumnName("id_carrera")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdCurso)
//                    .HasColumnName("id_Curso")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdMatricula)
//                    .IsRequired()
//                    .HasColumnName("id_Matricula")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nota).HasColumnName("nota");

//                entity.Property(e => e.Submonto).HasColumnName("submonto");

//                entity.HasOne(d => d.IdMatriculaNavigation)
//                    .WithMany(p => p.DetalleMatricula)
//                    .HasForeignKey(d => d.IdMatricula)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_DetalleMatricula_Matricula");

//                entity.HasOne(d => d.IdC)
//                    .WithMany(p => p.DetalleMatricula)
//                    .HasForeignKey(d => new { d.IdCurso, d.IdCarrera })
//                    .HasConstraintName("FK_DetalleMatricula_Cursos");
//            });

//            modelBuilder.Entity<DetalleNotas>(entity =>
//            {
//                entity.HasKey(e => e.IdDetalleNota);

//                entity.HasIndex(e => e.IdHistorico);

//                entity.HasIndex(e => e.IdRubro);

//                entity.Property(e => e.IdDetalleNota)
//                    .HasColumnName("id_DetalleNota")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.IdHistorico)
//                    .HasColumnName("id_historico")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdRubro)
//                    .HasColumnName("id_Rubro")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Porcentajeganado).HasColumnName("porcentajeganado");

//                entity.HasOne(d => d.IdHistoricoNavigation)
//                    .WithMany(p => p.DetalleNotas)
//                    .HasForeignKey(d => d.IdHistorico)
//                    .HasConstraintName("FK_DetalleNotas_Notas");

//                entity.HasOne(d => d.IdRubroNavigation)
//                    .WithMany(p => p.DetalleNotas)
//                    .HasForeignKey(d => d.IdRubro)
//                    .HasConstraintName("FK_DetalleNotas_Rubros");
//            });

//            modelBuilder.Entity<Grupos>(entity =>
//            {
//                entity.HasKey(e => e.IdGrupo);

//                entity.HasIndex(e => new { e.IdCarrera, e.IdCurso });

//                entity.Property(e => e.IdGrupo)
//                    .HasColumnName("Id_Grupo")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Descripcion).HasMaxLength(50);

//                entity.Property(e => e.IdCarrera)
//                    .HasColumnName("id_carrera")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdCurso)
//                    .HasColumnName("id_curso")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdHorario)
//                    .HasColumnName("id_horario")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdC)
//                    .WithMany(p => p.Grupos)
//                    .HasForeignKey(d => new { d.IdCarrera, d.IdCurso })
//                    .HasConstraintName("FK_Grupos_Cursos");
//            });

//            modelBuilder.Entity<Matricula>(entity =>
//            {
//                entity.HasKey(e => e.IdMatricula);

//                entity.HasIndex(e => e.IdEstudiante);

//                entity.HasIndex(e => e.IdMatriculante);

//                entity.Property(e => e.IdMatricula)
//                    .HasColumnName("id_matricula")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Creidtomatriculado)
//                    .HasColumnName("creidtomatriculado")
//                    .HasColumnType("nchar(10)");

//                entity.Property(e => e.Fecha)
//                    .HasColumnName("fecha")
//                    .HasColumnType("date");

//                entity.Property(e => e.IdEstudiante)
//                    .HasColumnName("id_estudiante")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdMatriculante)
//                    .HasColumnName("id_matriculante")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Monto)
//                    .HasColumnName("monto")
//                    .HasColumnType("nchar(10)");

//                entity.Property(e => e.Nota).HasColumnName("nota");

//                entity.Property(e => e.Periodo)
//                    .HasColumnName("periodo")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdEstudianteNavigation)
//                    .WithMany(p => p.MatriculaIdEstudianteNavigation)
//                    .HasForeignKey(d => d.IdEstudiante)
//                    .HasConstraintName("FK_Matricula_Persona2");

//                entity.HasOne(d => d.IdMatriculanteNavigation)
//                    .WithMany(p => p.MatriculaIdMatriculanteNavigation)
//                    .HasForeignKey(d => d.IdMatriculante)
//                    .HasConstraintName("FK_Matricula_Persona3");
//            });

//            modelBuilder.Entity<Notas>(entity =>
//            {
//                entity.HasKey(e => e.IdHistorico);

//                entity.HasIndex(e => e.IdPersona);

//                entity.HasIndex(e => new { e.IdCurso, e.Idcarrera });

//                entity.HasIndex(e => new { e.IdTipopersona, e.IdPersona });

//                entity.Property(e => e.IdHistorico)
//                    .HasColumnName("id_historico")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.IdCurso)
//                    .HasColumnName("id_curso")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("id_persona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdTipopersona)
//                    .HasColumnName("id_tipopersona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Idcarrera)
//                    .HasColumnName("idcarrera")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IndEstado)
//                    .HasColumnName("ind_estado")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Nota).HasColumnName("nota");

//                entity.Property(e => e.Periodo)
//                    .HasColumnName("periodo")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdPersonaNavigation)
//                    .WithMany(p => p.Notas)
//                    .HasForeignKey(d => d.IdPersona)
//                    .HasConstraintName("FK_Notas_Persona");

//                entity.HasOne(d => d.Id)
//                    .WithMany(p => p.Notas)
//                    .HasForeignKey(d => new { d.IdCurso, d.Idcarrera })
//                    .HasConstraintName("FK_Notas_Cursos");

//                entity.HasOne(d => d.IdNavigation)
//                    .WithMany(p => p.Notas)
//                    .HasForeignKey(d => new { d.IdTipopersona, d.IdPersona })
//                    .HasConstraintName("FK_Historico_PersonaXTipo");
//            });

//            modelBuilder.Entity<ApplicationUser>(entity =>
//            {
//                entity.HasKey(e => e.IdPersona);

//                entity.HasIndex(e => e.GrupoIdGrupo);

//                entity.HasIndex(e => e.IdTipoPersona);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("Id_Persona")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Carnet)
//                    .IsRequired()
//                    .HasColumnName("carnet")
//                    .HasMaxLength(50);

//                entity.Property(e => e.Ciudad).HasMaxLength(50);

//                entity.Property(e => e.Correo)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Genero)
//                    .HasColumnName("genero")
//                    .HasMaxLength(1);

//                entity.Property(e => e.GrupoIdGrupo).HasMaxLength(50);

//                entity.Property(e => e.IdTipoPersona)
//                    .HasColumnName("idTipoPersona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NombreCompleto)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Pais)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.Property(e => e.Password)
//                    .IsRequired()
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.GrupoIdGrupoNavigation)
//                    .WithMany(p => p.Persona)
//                    .HasForeignKey(d => d.GrupoIdGrupo);

//                entity.HasOne(d => d.IdTipoPersonaNavigation)
//                    .WithMany(p => p.Persona)
//                    .HasForeignKey(d => d.IdTipoPersona)
//                    .HasConstraintName("FK_Persona_TipoPersona");
//            });

//            modelBuilder.Entity<PersonaXtipo>(entity =>
//            {
//                entity.HasKey(e => new { e.IdPersona, e.IdTipoPersona });

//                entity.ToTable("PersonaXTipo");

//                entity.HasIndex(e => e.IdTipoPersona);

//                entity.Property(e => e.IdPersona)
//                    .HasColumnName("Id_Persona")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdTipoPersona)
//                    .HasColumnName("Id_TipoPersona")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdPersonaNavigation)
//                    .WithMany(p => p.PersonaXtipo)
//                    .HasForeignKey(d => d.IdPersona)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_PersonaXTipo_Persona");

//                entity.HasOne(d => d.IdTipoPersonaNavigation)
//                    .WithMany(p => p.PersonaXtipo)
//                    .HasForeignKey(d => d.IdTipoPersona)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_PersonaXTipo_TipoPersona");
//            });

//            modelBuilder.Entity<Roles>(entity =>
//            {
//                entity.Property(e => e.Id).ValueGeneratedNever();
//            });

//            modelBuilder.Entity<Rubros>(entity =>
//            {
//                entity.HasKey(e => e.IdRubro);

//                entity.HasIndex(e => e.GrupoIdGrupo);

//                entity.HasIndex(e => new { e.IdCurso, e.IdCarrera });

//                entity.Property(e => e.IdRubro)
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.GrupoIdGrupo).HasMaxLength(50);

//                entity.Property(e => e.IdCarrera)
//                    .HasColumnName("id_Carrera")
//                    .HasMaxLength(50);

//                entity.Property(e => e.IdCurso)
//                    .HasColumnName("id_Curso")
//                    .HasMaxLength(50);

//                entity.Property(e => e.NombreRubro).HasColumnType("nchar(10)");

//                entity.HasOne(d => d.GrupoIdGrupoNavigation)
//                    .WithMany(p => p.Rubros)
//                    .HasForeignKey(d => d.GrupoIdGrupo);

//                entity.HasOne(d => d.IdC)
//                    .WithMany(p => p.Rubros)
//                    .HasForeignKey(d => new { d.IdCurso, d.IdCarrera })
//                    .HasConstraintName("FK_Rubros_Cursos");
//            });

//            modelBuilder.Entity<Secuencias>(entity =>
//            {
//                entity.Property(e => e.Id).HasColumnName("id");
//            });

//            modelBuilder.Entity<TipoPersona>(entity =>
//            {
//                entity.HasKey(e => e.IdTipoPersona);

//                entity.Property(e => e.IdTipoPersona)
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Descripción).HasColumnType("nchar(10)");
//            });

//            modelBuilder.Entity<Ventanas>(entity =>
//            {
//                entity.HasKey(e => e.IdVentana);

//                entity.Property(e => e.IdVentana)
//                    .HasColumnName("Id_Ventana")
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.Descripcion).HasMaxLength(50);
//            });

//            modelBuilder.Entity<VentanasXperfil>(entity =>
//            {
//                entity.HasKey(e => e.TipoPersona);

//                entity.ToTable("VentanasXPerfil");

//                entity.HasIndex(e => e.IdVentana);

//                entity.Property(e => e.TipoPersona)
//                    .HasMaxLength(50)
//                    .ValueGeneratedNever();

//                entity.Property(e => e.IdVentana)
//                    .IsRequired()
//                    .HasColumnName("Id_Ventana")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.IdVentanaNavigation)
//                    .WithMany(p => p.VentanasXperfil)
//                    .HasForeignKey(d => d.IdVentana)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK_VentanasXPerfil_Ventanas");
//            });
//        }
//    }
}
