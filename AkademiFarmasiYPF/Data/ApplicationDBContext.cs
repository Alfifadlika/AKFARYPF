using System;
using System.Collections.Generic;
using AkademiFarmasiYPF.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace AkademiFarmasiYPF.Data;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MstBanner> MstBanner { get; set; }

    public virtual DbSet<MstBerita> MstBerita { get; set; }

    public virtual DbSet<User> User { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MstBanner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BANNER");

            entity.ToTable("MST_BANNER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.ImagePath)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("IMAGE_PATH");
            entity.Property(e => e.Index).HasColumnName("INDEX");
            entity.Property(e => e.TglKadaluarsa).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<MstBerita>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BERITA");

            entity.ToTable("MST_BERITA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Category)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CATEGORY");
            entity.Property(e => e.Content)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnType("text")
                .HasColumnName("CONTENT");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Image)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("IMAGE");
            entity.Property(e => e.TglTerbit)
                .HasColumnType("datetime")
                .HasColumnName("TGL_TERBIT");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("TITLE");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("USER");

            entity.Property(e => e.IdUser)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID_USER");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("CREATE_BY");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fullname)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("UPDATE_BY");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("UPDATE_DATE");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("USERNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
