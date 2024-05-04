using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace trpo_bibl;

public partial class TrpoContext : DbContext
{
    public TrpoContext()
    {
    }

    public TrpoContext(DbContextOptions<TrpoContext> options)
        : base(options)
    {
    }
    public static Пользователи CurrentUser { get; set; }



    public virtual DbSet<Заказы> Заказыs { get; set; }

    public virtual DbSet<Книги> Книгиs { get; set; }

    public virtual DbSet<Пользователи> Пользователиs { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-USOH4GL;Database=trpo;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Заказы>(entity =>
        {
            entity.HasKey(e => e.IdЗаказы).HasName("PK__Заказы__097296364346EC6F");

            entity.ToTable("Заказы");

            entity.HasIndex(e => e.КнигиIdКнига, "IX_Заказы_Книги").IsUnique();

            entity.Property(e => e.IdЗаказы)
                .ValueGeneratedOnAdd()
                .HasColumnName("idЗаказы");
            entity.Property(e => e.КнигиIdКнига).HasColumnName("Книги_idКнига");
            entity.Property(e => e.ПользователиIdПользователя).HasColumnName("Пользователи_idПользователя");
            entity.Property(e => e.Срок).HasColumnType("datetime");

            entity.HasOne(d => d.IdЗаказыNavigation).WithOne(p => p.Заказы)
                .HasForeignKey<Заказы>(d => d.IdЗаказы)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Заказы_Книги");

            entity.HasOne(d => d.ПользователиIdПользователяNavigation).WithMany(p => p.Заказыs)
                .HasForeignKey(d => d.ПользователиIdПользователя)
                .HasConstraintName("fk_Заказы_Пользователи");
        });

        modelBuilder.Entity<Книги>(entity =>
        {
            entity.HasKey(e => e.IdКнига).HasName("PK__Книги__FDD670D3816D598C");

            entity.ToTable("Книги");

            entity.HasIndex(e => e.IdКнига, "idКнига_UNIQUE").IsUnique();

            entity.Property(e => e.IdКнига).HasColumnName("idКнига");
            entity.Property(e => e.Автор).HasMaxLength(45);
            entity.Property(e => e.ГодИздания)
                .HasMaxLength(45)
                .HasColumnName("Год издания");
            entity.Property(e => e.Жанр).HasMaxLength(45);
            entity.Property(e => e.КолВо).HasColumnName("Кол-во");
            entity.Property(e => e.Название).HasMaxLength(45);
            entity.Property(e => e.Статус).HasMaxLength(45);
        });

        modelBuilder.Entity<Пользователи>(entity =>
        {
            entity.HasKey(e => e.IdПользователя).HasName("PK__Пользова__6AFCD9346810BC34");

            entity.ToTable("Пользователи");

            entity.HasIndex(e => e.Email, "email_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Телефон, "Телефон_UNIQUE").IsUnique();

            entity.Property(e => e.IdПользователя).HasColumnName("idПользователя");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Имя).HasMaxLength(45);
            entity.Property(e => e.Отчество).HasMaxLength(45);
            entity.Property(e => e.Пароль).HasMaxLength(45);
            entity.Property(e => e.Статус).HasMaxLength(20);
            entity.Property(e => e.Телефон).HasMaxLength(12);
            entity.Property(e => e.Фамилия).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
