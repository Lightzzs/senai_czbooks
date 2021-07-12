using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai_czbooks_webApi.Domains;

#nullable disable

namespace senai_czbooks_webApi.Context
{
    public partial class CzbooksContext : DbContext
    {
        public CzbooksContext()
        {
        }

        public CzbooksContext(DbContextOptions<CzbooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Livraria> Livrarias { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAB08DESK115999\\SQLEXPRESS; Initial Catalog=CZBooks_; user id=sa; pwd=sa132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autore>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autores__DD33B031A0FA864A");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Autores__IdUsuar__3C69FB99");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A10AB31EE7E");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Livraria>(entity =>
            {
                entity.HasKey(e => e.IdLivraria)
                    .HasName("PK__Livraria__AC9443CB0C98306C");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PK__Livros__3B69D85A73B61D7D");

                entity.Property(e => e.DataPublicacao).HasColumnType("date");

                entity.Property(e => e.Preco)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__Livros__IdAutor__6A30C649");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Livros__IdCatego__6B24EA82");

                entity.HasOne(d => d.IdLivrariaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdLivraria)
                    .HasConstraintName("FK__Livros__IdLivrar__6C190EBB");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TiposUsu__CA04062B4879F36A");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF97A198ECE0");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
