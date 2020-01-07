﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200107140618_ChangeChineseGenerateRules")]
    partial class ChangeChineseGenerateRules
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Fix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Domain.Models.CompanyDepartment", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyDepartment");
                });

            modelBuilder.Entity("Domain.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Emplyee");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Account = "1065970980",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 782, DateTimeKind.Local).AddTicks(2541),
                            Name = "韩 酥",
                            NickName = "闵 松荷",
                            Password = "1715516260",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            Account = "912083853",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1204),
                            Name = "米 循",
                            NickName = "令狐 还",
                            Password = "2110850260",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            Account = "2122574946",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1458),
                            Name = "边 的",
                            NickName = "钭 膜愤",
                            Password = "656653544",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            Account = "716017819",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1678),
                            Name = "郦 炒",
                            NickName = "糜 灰",
                            Password = "1395862892",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            Account = "1812268470",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1829),
                            Name = "万俟 觉善",
                            NickName = "边 风",
                            Password = "1383087770",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            Account = "483393011",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1996),
                            Name = "常 骆",
                            NickName = "蔺 顾羌",
                            Password = "710706611",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            Account = "134625408",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2199),
                            Name = "蓝 生",
                            NickName = "扈 谨毛",
                            Password = "874642833",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            Account = "773083816",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2361),
                            Name = "郝 涸萧",
                            NickName = "融 吮掺",
                            Password = "1126919246",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            Account = "1806051293",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2573),
                            Name = "雍 来新",
                            NickName = "经 侦",
                            Password = "1135347123",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            Account = "473509110",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2737),
                            Name = "周 蹬曳",
                            NickName = "欧阳 狈期",
                            Password = "1740400667",
                            Status = 0,
                            UpdateBy = "System"
                        });
                });

            modelBuilder.Entity("Domain.Models.Company", b =>
                {
                    b.OwnsOne("Domain.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("DetailAddress")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Province")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Region")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });
                });

            modelBuilder.Entity("Domain.Models.CompanyDepartment", b =>
                {
                    b.HasOne("Domain.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Employee", b =>
                {
                    b.HasOne("Domain.Models.Company", "Company")
                        .WithMany("Emplyees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Domain.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}