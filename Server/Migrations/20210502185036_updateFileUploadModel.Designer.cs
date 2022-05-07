﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsApplicationProj.Server.Models;

namespace StudentsApplicationProj.Server.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20210502185036_updateFileUploadModel")]
    partial class updateFileUploadModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseInstructorId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CourseInstructorId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.CourseApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("ApplicationDateTime")
                        .HasColumnType("date");

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StudentCourseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentCourseId")
                        .IsUnique();

                    b.ToTable("CourseApplication");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentHeadId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentName = "Computer Science and Engineering"
                        });
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.FileUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificatePath")
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("CourseApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("GradeSheetPath")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("SyllabusPath")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CourseApplicationId")
                        .IsUnique();

                    b.ToTable("FileUrl");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.InstructorCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("InstructorCourse");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.SystemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AccountStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("SystemUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = true,
                            DepartmentId = 1,
                            Email = "admin@gmail.com",
                            FirstName = "Admin First",
                            LastName = "Admin Last",
                            Password = "342IHFCmkWx+4Auu8lDJhQoxcv3QA/pfVNsGeKqEGFo=",
                            UserRole = 4
                        });
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.Course", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.SystemUser", "CourseInstructor")
                        .WithMany()
                        .HasForeignKey("CourseInstructorId");

                    b.HasOne("StudentsApplicationProj.Server.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseInstructor");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.CourseApplication", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.StudentCourse", "StudentCourse")
                        .WithOne("CourseApplication")
                        .HasForeignKey("StudentsApplicationProj.Server.Models.CourseApplication", "StudentCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.FileUrl", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.CourseApplication", "CourseApplication")
                        .WithOne("FileUrls")
                        .HasForeignKey("StudentsApplicationProj.Server.Models.FileUrl", "CourseApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseApplication");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.InstructorCourse", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsApplicationProj.Server.Models.SystemUser", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.Course", "Course")
                        .WithMany("StudentCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsApplicationProj.Server.Models.SystemUser", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.SystemUser", b =>
                {
                    b.HasOne("StudentsApplicationProj.Server.Models.Department", "Department")
                        .WithMany("DepartmentUsers")
                        .HasForeignKey("DepartmentId")
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.Course", b =>
                {
                    b.Navigation("StudentCourse");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.CourseApplication", b =>
                {
                    b.Navigation("FileUrls");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("DepartmentUsers");
                });

            modelBuilder.Entity("StudentsApplicationProj.Server.Models.StudentCourse", b =>
                {
                    b.Navigation("CourseApplication");
                });
#pragma warning restore 612, 618
        }
    }
}
