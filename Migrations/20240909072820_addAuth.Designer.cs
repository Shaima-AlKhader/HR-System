﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.DSConn;

#nullable disable

namespace WebApplication4.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240909072820_addAuth")]
    partial class addAuth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication4.Models.Contract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ContractType")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("EmpRef")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("empsId")
                        .HasColumnType("int");

                    b.Property<string>("position")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<decimal?>("salary")
                        .HasColumnType("decimal (18, 0)");

                    b.HasKey("ID");

                    b.HasIndex("empsId");

                    b.ToTable("Contract", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("Budget")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentHead")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Department", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("DepRef")
                        .HasColumnType("int");

                    b.Property<int?>("DepsID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.HasIndex("DepsID");

                    b.ToTable("Employee", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal (18, 0)");

                    b.Property<int>("EmpRef")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<string>("InvoiceDescription")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("InvoiceDue")
                        .HasColumnType("datetime");

                    b.Property<string>("InvoiceName")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("empsId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("empsId");

                    b.ToTable("Invoice", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.LeaveRequest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("EmpRef")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("NoRequest")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("empsId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("empsId");

                    b.ToTable("LeaveRequest", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("EmplosId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("ProjectStatus")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("ProjectTitle")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("ProjectUrl")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("empFK")
                        .HasColumnType("int");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.HasIndex("EmplosId");

                    b.ToTable("Project", "EmpDet");
                });

            modelBuilder.Entity("WebApplication4.Models.Contract", b =>
                {
                    b.HasOne("WebApplication4.Models.Employee", "emps")
                        .WithMany()
                        .HasForeignKey("empsId");

                    b.Navigation("emps");
                });

            modelBuilder.Entity("WebApplication4.Models.Employee", b =>
                {
                    b.HasOne("WebApplication4.Models.Department", "Deps")
                        .WithMany()
                        .HasForeignKey("DepsID");

                    b.Navigation("Deps");
                });

            modelBuilder.Entity("WebApplication4.Models.Invoice", b =>
                {
                    b.HasOne("WebApplication4.Models.Employee", "emps")
                        .WithMany()
                        .HasForeignKey("empsId");

                    b.Navigation("emps");
                });

            modelBuilder.Entity("WebApplication4.Models.LeaveRequest", b =>
                {
                    b.HasOne("WebApplication4.Models.Employee", "emps")
                        .WithMany()
                        .HasForeignKey("empsId");

                    b.Navigation("emps");
                });

            modelBuilder.Entity("WebApplication4.Models.Project", b =>
                {
                    b.HasOne("WebApplication4.Models.Employee", "Emplos")
                        .WithMany()
                        .HasForeignKey("EmplosId");

                    b.Navigation("Emplos");
                });
#pragma warning restore 612, 618
        }
    }
}
