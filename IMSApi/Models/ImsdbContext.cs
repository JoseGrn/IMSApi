using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IMSApi.Models;

public partial class ImsdbContext : DbContext
{
    public ImsdbContext()
    {
    }

    public ImsdbContext(DbContextOptions<ImsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessLevel> AccessLevels { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeWarehouse> EmployeeWarehouses { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-DBA5A9SN\\SQLEXPRESS; Database=IMSDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessLevel>(entity =>
        {
            entity.HasKey(e => e.AccessLevelId).HasName("PK__AccessLe__5E44DFD559F02675");

            entity.ToTable("AccessLevel");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__2D971CACF0FD9DCF");

            entity.ToTable("Company");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Direction)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F1178EBF3EC");

            entity.ToTable("Employee");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Identification)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AccessLevel).WithMany(p => p.Employees)
                .HasForeignKey(d => d.AccessLevelId)
                .HasConstraintName("FK__Employee__Access__31EC6D26");

            entity.HasOne(d => d.Company).WithMany(p => p.Employees)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Employee__Compan__32E0915F");

            entity.HasOne(d => d.Owner).WithMany(p => p.Employees)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK__Employee__OwnerI__33D4B598");
        });

        modelBuilder.Entity<EmployeeWarehouse>(entity =>
        {
            entity.HasKey(e => e.EmployeeWarehouseId).HasName("PK__Employee__68D3194A43A9998A");

            entity.ToTable("EmployeeWarehouse");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeWarehouses)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__EmployeeW__Emplo__36B12243");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.EmployeeWarehouses)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__EmployeeW__Wareh__37A5467C");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK__Owner__819385B8CC77369C");

            entity.ToTable("Owner");

            entity.Property(e => e.CreatedDate).HasColumnType("date");
            entity.Property(e => e.Identification)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Mail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AccessLevel).WithMany(p => p.Owners)
                .HasForeignKey(d => d.AccessLevelId)
                .HasConstraintName("FK__Owner__AccessLev__2E1BDC42");

            entity.HasOne(d => d.Company).WithMany(p => p.Owners)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Owner__CompanyId__2F10007B");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDE8739F89");

            entity.ToTable("Product");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Warehouse).WithMany(p => p.Products)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__Product__Warehou__2B3F6F97");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFF9F66CF770");

            entity.ToTable("Warehouse");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Direction)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK__Warehouse__Compa__286302EC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
