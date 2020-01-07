﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Account = "623306801",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 524, DateTimeKind.Local).AddTicks(2752),
                            Name = "沙嵌",
                            NickName = "滕 样",
                            Password = "972264640",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 2,
                            Account = "1102875294",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 529, DateTimeKind.Local).AddTicks(9737),
                            Name = "殷哺攫",
                            NickName = "傅 其",
                            Password = "122197059",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 3,
                            Account = "1263351210",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(75),
                            Name = "蔚炎瘁",
                            NickName = "邹 臼装",
                            Password = "2140270244",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 4,
                            Account = "271858634",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(269),
                            Name = "宇文埂",
                            NickName = "魏 掀耀",
                            Password = "737628214",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 5,
                            Account = "801082279",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(435),
                            Name = "游鸣",
                            NickName = "衡 珐",
                            Password = "1637160057",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 6,
                            Account = "1361782065",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(606),
                            Name = "毛凤",
                            NickName = "羿 蕾",
                            Password = "388166285",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 7,
                            Account = "2127501513",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(750),
                            Name = "严滩",
                            NickName = "双 高",
                            Password = "762573810",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 8,
                            Account = "1686467441",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(936),
                            Name = "空荒",
                            NickName = "巫 腆坑",
                            Password = "1037347409",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 9,
                            Account = "1398929570",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(1124),
                            Name = "邓独",
                            NickName = "冯 宅",
                            Password = "869681718",
                            Status = 0,
                            UpdateBy = "System"
                        },
                        new
                        {
                            Id = 10,
                            Account = "447450067",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(1331),
                            Name = "阎肛",
                            NickName = "刁 经",
                            Password = "2075286181",
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
