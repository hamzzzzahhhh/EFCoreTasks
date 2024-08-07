﻿// <auto-generated />
using System;
using EFCoreTasks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreTasks.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240704101748_m4")]
    partial class m4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreTasks.Models.Assistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("teacherId")
                        .IsUnique();

                    b.ToTable("Assistants");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ManagerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerID");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alice"
                        },
                        new
                        {
                            Id = 2,
                            ManagerID = 1,
                            Name = "Bob"
                        },
                        new
                        {
                            Id = 3,
                            ManagerID = 1,
                            Name = "Charlie"
                        },
                        new
                        {
                            Id = 4,
                            ManagerID = 2,
                            Name = "David"
                        });
                });

            modelBuilder.Entity("EFCoreTasks.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rank")
                        .HasColumnType("int");

                    b.Property<int>("teacher_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("teacher_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreTasks.Models.StudentProjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentProjects");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherId"), 1L, 1);

                    b.Property<string>("educationlevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teacherDescription")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("teacherName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("teacherStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("teacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("EFCoreTasks.Models.View1", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToView("view1");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Assistant", b =>
                {
                    b.HasOne("EFCoreTasks.Models.Teacher", "teacher")
                        .WithOne("assistant")
                        .HasForeignKey("EFCoreTasks.Models.Assistant", "teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Employee", b =>
                {
                    b.HasOne("EFCoreTasks.Models.Employee", "Manager")
                        .WithMany("subordinates")
                        .HasForeignKey("ManagerID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Student", b =>
                {
                    b.HasOne("EFCoreTasks.Models.Teacher", "teacher")
                        .WithMany("students")
                        .HasForeignKey("teacher_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("EFCoreTasks.Models.StudentProjects", b =>
                {
                    b.HasOne("EFCoreTasks.Models.Project", "Project")
                        .WithMany("StudentProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreTasks.Models.Student", "Student")
                        .WithMany("StudentProjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Employee", b =>
                {
                    b.Navigation("subordinates");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Project", b =>
                {
                    b.Navigation("StudentProjects");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Student", b =>
                {
                    b.Navigation("StudentProjects");
                });

            modelBuilder.Entity("EFCoreTasks.Models.Teacher", b =>
                {
                    b.Navigation("assistant")
                        .IsRequired();

                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
