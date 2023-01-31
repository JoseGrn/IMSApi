﻿// <auto-generated />
using System;
using IMSApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMSApi.Migrations
{
    [DbContext(typeof(ImsdbContext))]
    [Migration("20230131021358_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IMSApi.Models.AccessLevel", b =>
                {
                    b.Property<int>("AccessLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessLevelId"));

                    b.HasKey("AccessLevelId")
                        .HasName("PK__AccessLe__5E44DFD559F02675");

                    b.ToTable("AccessLevel", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Direction")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Mail")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("CompanyId")
                        .HasName("PK__Company__2D971CACF0FD9DCF");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int?>("AccessLevelId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Identification")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Mail")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("EmployeeId")
                        .HasName("PK__Employee__7AD04F1178EBF3EC");

                    b.HasIndex("AccessLevelId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.EmployeeWarehouse", b =>
                {
                    b.Property<int>("EmployeeWarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeWarehouseId"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeWarehouseId")
                        .HasName("PK__Employee__68D3194A43A9998A");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("EmployeeWarehouse", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"));

                    b.Property<int?>("AccessLevelId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Identification")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Mail")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("OwnerId")
                        .HasName("PK__Owner__819385B8CC77369C");

                    b.HasIndex("AccessLevelId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Owner", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("PK__Product__B40CC6CDE8739F89");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Direction")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("WarehouseId")
                        .HasName("PK__Warehous__2608AFF9F66CF770");

                    b.HasIndex("CompanyId");

                    b.ToTable("Warehouse", (string)null);
                });

            modelBuilder.Entity("IMSApi.Models.Employee", b =>
                {
                    b.HasOne("IMSApi.Models.AccessLevel", "AccessLevel")
                        .WithMany("Employees")
                        .HasForeignKey("AccessLevelId")
                        .HasConstraintName("FK__Employee__Access__31EC6D26");

                    b.HasOne("IMSApi.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Employee__Compan__32E0915F");

                    b.HasOne("IMSApi.Models.Owner", "Owner")
                        .WithMany("Employees")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("FK__Employee__OwnerI__33D4B598");

                    b.Navigation("AccessLevel");

                    b.Navigation("Company");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("IMSApi.Models.EmployeeWarehouse", b =>
                {
                    b.HasOne("IMSApi.Models.Employee", "Employee")
                        .WithMany("EmployeeWarehouses")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__EmployeeW__Emplo__36B12243");

                    b.HasOne("IMSApi.Models.Warehouse", "Warehouse")
                        .WithMany("EmployeeWarehouses")
                        .HasForeignKey("WarehouseId")
                        .HasConstraintName("FK__EmployeeW__Wareh__37A5467C");

                    b.Navigation("Employee");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("IMSApi.Models.Owner", b =>
                {
                    b.HasOne("IMSApi.Models.AccessLevel", "AccessLevel")
                        .WithMany("Owners")
                        .HasForeignKey("AccessLevelId")
                        .HasConstraintName("FK__Owner__AccessLev__2E1BDC42");

                    b.HasOne("IMSApi.Models.Company", "Company")
                        .WithMany("Owners")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Owner__CompanyId__2F10007B");

                    b.Navigation("AccessLevel");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("IMSApi.Models.Product", b =>
                {
                    b.HasOne("IMSApi.Models.Warehouse", "Warehouse")
                        .WithMany("Products")
                        .HasForeignKey("WarehouseId")
                        .HasConstraintName("FK__Product__Warehou__2B3F6F97");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("IMSApi.Models.Warehouse", b =>
                {
                    b.HasOne("IMSApi.Models.Company", "Company")
                        .WithMany("Warehouses")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Warehouse__Compa__286302EC");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("IMSApi.Models.AccessLevel", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Owners");
                });

            modelBuilder.Entity("IMSApi.Models.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Owners");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("IMSApi.Models.Employee", b =>
                {
                    b.Navigation("EmployeeWarehouses");
                });

            modelBuilder.Entity("IMSApi.Models.Owner", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("IMSApi.Models.Warehouse", b =>
                {
                    b.Navigation("EmployeeWarehouses");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
