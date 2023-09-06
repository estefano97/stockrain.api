using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace stockrain.infrestructure.Models;

public partial class StockrainMainContext : DbContext
{
    public StockrainMainContext()
    {
    }

    public StockrainMainContext(DbContextOptions<StockrainMainContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MarketCapExtFinance> MarketCapExtFinances { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=stockrain_main; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MarketCapExtFinance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("MarketCapExtFinance_PK");

            entity.ToTable("MarketCapExtFinance");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.PreviousClose)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("previous_close");
            entity.Property(e => e.RegularPrice)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("regular_price");
            entity.Property(e => e.TimeRegistry)
                .HasColumnType("datetime")
                .HasColumnName("time_registry");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("Users_PK");

            entity.Property(e => e.IdUsuario).ValueGeneratedNever();
            entity.Property(e => e.Mail)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
