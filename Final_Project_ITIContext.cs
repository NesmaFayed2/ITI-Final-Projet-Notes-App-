using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinalProject_iti
{
    public partial class Final_Project_ITIContext : DbContext
    {
        public Final_Project_ITIContext()
        {
        }

        public Final_Project_ITIContext(DbContextOptions<Final_Project_ITIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= LAPTOP-21IFMMIJ;Database=Final_Project_ITI; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("category");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Catgid).HasColumnName("catgid");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.Note1)
                    .HasMaxLength(100)
                    .HasColumnName("note");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.HasOne(d => d.Catg)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.Catgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notes_Category");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
