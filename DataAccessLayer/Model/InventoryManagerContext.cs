using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Model;

public partial class InventoryManagerContext : DbContext
{
    public InventoryManagerContext()
    {
    }

    public InventoryManagerContext(DbContextOptions<InventoryManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCategory> TblCategories { get; set; }

    public virtual DbSet<TblDeaCust> TblDeaCusts { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblTransactionDetail> TblTransactionDetails { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=inventory_manager;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCategory>(entity =>
        {
            entity.ToTable("tbl_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<TblDeaCust>(entity =>
        {
            entity.ToTable("tbl_dea_cust");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.ToTable("tbl_products");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.ToTable("tbl_transactions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.DeaCustId).HasColumnName("dea_cust_id");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("discount");
            entity.Property(e => e.GrandTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("grandTotal");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tax");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblTransactionDetail>(entity =>
        {
            entity.ToTable("tbl_transaction_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.DeaCustId).HasColumnName("dea_cust_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("qty");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rate");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.ToTable("tbl_users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddedBy).HasColumnName("added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("added_date");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("contact");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("user_type");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
