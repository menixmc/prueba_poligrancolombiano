using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Libros.Models
{
    public partial class libreriaContext : DbContext
    {
        public libreriaContext()
        {
        }

        public libreriaContext(DbContextOptions<libreriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Idioma> Idioma { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=libreria;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__autor__5FC3872D053D7A26");

                entity.ToTable("autor");

                entity.Property(e => e.IdAutor).HasColumnName("id_autor");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.GeneroId).HasColumnName("genero_id");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__autor__genero_id__3B75D760");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__autor__pais_id__3A81B327");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK__genero__99A8E4F90AE9DF31");

                entity.ToTable("genero");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Genero1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genero");
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.HasKey(e => e.Id_Idioma)
                    .HasName("PK__idioma__0BA1525F459B5665");

                entity.ToTable("idioma");

                entity.Property(e => e.Id_Idioma).HasColumnName("id_idioma");

                entity.Property(e => e.Idioma1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idioma");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibro)
                    .HasName("PK__libro__EC09C24EE11A516D");

                entity.ToTable("libro");

                entity.Property(e => e.IdLibro).HasColumnName("id_libro");

                entity.Property(e => e.AutorId).HasColumnName("autor_id");

                entity.Property(e => e.Año).HasColumnName("año");

                entity.Property(e => e.Editorial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("editorial");

                entity.Property(e => e.idioma_id).HasColumnName("idioma_id");

                entity.Property(e => e.NumPaginas).HasColumnName("num_paginas");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.AutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__libro__autor_id__412EB0B6");

                entity.HasOne(d => d.Idioma)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.idioma_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__libro__idioma_id__403A8C7D");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__pais__0941A3A7821304C4");

                entity.ToTable("pais");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.NombrePais)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_pais");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
