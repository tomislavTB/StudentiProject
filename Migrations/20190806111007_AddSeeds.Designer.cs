﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentiProject.DB;

namespace StudentiProject.Migrations
{
    [DbContext(typeof(StudentiProjectContext))]
    [Migration("20190806111007_AddSeeds")]
    partial class AddSeeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentiProject.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Velika Gorica",
                            Zip = "10000"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "New York",
                            Zip = "10001"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "London ",
                            Zip = "56273"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Paris",
                            Zip = "75000"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Amsterdam ",
                            Zip = "1011"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.College", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Colleges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Zagrebačka ul. 5",
                            CityId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "University of Applied Sciences Velika Gorica"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1585 Massachusetts Avenue",
                            CityId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Columbia University"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Vrbik 8",
                            CityId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Tehničko veleučilište u Zagrebu"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Senate House Malet Street London",
                            CityId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "University of London"
                        },
                        new
                        {
                            Id = 5,
                            Address = "5 Rue Thomas Mann",
                            CityId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Paris Diderot University"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Croatia"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "United States"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "France"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "England"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Netherlands"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<int>("DivisionId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Full Python Course",
                            DivisionId = 2,
                            IsDeleted = false,
                            Name = "Python Course"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Creating sql database",
                            DivisionId = 2,
                            IsDeleted = false,
                            Name = "SQL Course"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Creating web application",
                            DivisionId = 1,
                            IsDeleted = false,
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Full internet infrastructure",
                            DivisionId = 1,
                            IsDeleted = false,
                            Name = "Internet Infrastructure"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollegeId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CollegeId");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CollegeId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Computer System Maintenance"
                        },
                        new
                        {
                            Id = 2,
                            CollegeId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            Name = "Computer Science"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Executor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Executors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learning syntax",
                            IsDeleted = false,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Introductory lecture",
                            IsDeleted = false,
                            TeacherId = 2
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Evaluation");

                    b.Property<string>("ExamTime")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 5,
                            ExamTime = "01:30H",
                            IsDeleted = false,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 4,
                            ExamTime = "01:15H",
                            IsDeleted = false,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 4,
                            ExamTime = "01:30H",
                            IsDeleted = false,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 3,
                            ExamTime = "01:00H",
                            IsDeleted = false,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 2,
                            ExamTime = "01:45H",
                            IsDeleted = false,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 4,
                            ExamTime = "01:30H",
                            IsDeleted = false,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 5,
                            ExamTime = "01:15H",
                            IsDeleted = false,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 3,
                            ExamTime = "01:30H",
                            IsDeleted = false,
                            StudentId = 4
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 5,
                            ExamTime = "01:00H",
                            IsDeleted = false,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Evaluation = 5,
                            ExamTime = "01:45H",
                            IsDeleted = false,
                            StudentId = 5
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("DivisionId");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DivisionId");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DivisionId = 1,
                            FirstName = "Tomislav ",
                            IsDeleted = false,
                            LastName = "Buhovac"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DivisionId = 2,
                            FirstName = "Marko ",
                            IsDeleted = false,
                            LastName = "Markic"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DivisionId = 2,
                            FirstName = "Ivan ",
                            IsDeleted = false,
                            LastName = "Ivic"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DivisionId = 2,
                            FirstName = "Josip ",
                            IsDeleted = false,
                            LastName = "Nesto"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DivisionId = 2,
                            FirstName = "Filip ",
                            IsDeleted = false,
                            LastName = "Novi"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("CityId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModifiedAt");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("FirstName", "LastName")
                        .IsUnique();

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Nova Cesta 5",
                            CityId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Davor ",
                            IsDeleted = false,
                            LastName = "Znasve"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Stara Cesta 4",
                            CityId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Tomislav ",
                            IsDeleted = false,
                            LastName = "Nestovisezna"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Novi Put 3",
                            CityId = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Josip ",
                            IsDeleted = false,
                            LastName = "Neznabas"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Stari Put 2",
                            CityId = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ivan ",
                            IsDeleted = false,
                            LastName = "Mozeibolje"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Nova Ulica 1",
                            CityId = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Marko ",
                            IsDeleted = false,
                            LastName = "Voliucit"
                        });
                });

            modelBuilder.Entity("StudentiProject.Models.City", b =>
                {
                    b.HasOne("StudentiProject.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.College", b =>
                {
                    b.HasOne("StudentiProject.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Course", b =>
                {
                    b.HasOne("StudentiProject.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Division", b =>
                {
                    b.HasOne("StudentiProject.Models.College", "College")
                        .WithMany()
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Executor", b =>
                {
                    b.HasOne("StudentiProject.Models.Course", "Course")
                        .WithMany("Executors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentiProject.Models.Teacher", "Teacher")
                        .WithMany("Executors")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Grade", b =>
                {
                    b.HasOne("StudentiProject.Models.Course", "Course")
                        .WithMany("Grades")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentiProject.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Student", b =>
                {
                    b.HasOne("StudentiProject.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("StudentiProject.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("StudentiProject.Models.Teacher", b =>
                {
                    b.HasOne("StudentiProject.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
