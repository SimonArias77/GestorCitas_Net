﻿// <auto-generated />
using System;
using Assessment2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241120130509_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assessment2.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("administrators");
                });

            modelBuilder.Entity("Assessment2.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("reason");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("status");

                    b.Property<int>("doctor_id")
                        .HasColumnType("int");

                    b.Property<int>("patient_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("doctor_id");

                    b.HasIndex("patient_id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("Assessment2.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<int>("doctor_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("doctor_id");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("Assessment2.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<string>("Specialty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("specialty");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Assessment2.Models.HistoryDates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int")
                        .HasColumnName("appointment_id");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_time");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("reason");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("HistoryDates");
                });

            modelBuilder.Entity("Assessment2.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBorn")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_born");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("last_name");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBorn = new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luis.perez@example.com",
                            LastName = "Pérez",
                            Name = "Luis",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            DateBorn = new DateTime(1990, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "antonia.garcia@example.com",
                            LastName = "García",
                            Name = "Antonia",
                            PhoneNumber = "9876543210"
                        },
                        new
                        {
                            Id = 3,
                            DateBorn = new DateTime(1978, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "arturo.lopez@example.com",
                            LastName = "López",
                            Name = "Arturo",
                            PhoneNumber = "4567891230"
                        },
                        new
                        {
                            Id = 4,
                            DateBorn = new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "maria.martinez@example.com",
                            LastName = "Martínez",
                            Name = "Maria",
                            PhoneNumber = "3216549870"
                        },
                        new
                        {
                            Id = 5,
                            DateBorn = new DateTime(1982, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "guillo.rodriguez@example.com",
                            LastName = "Rodríguez",
                            Name = "Guillo",
                            PhoneNumber = "7890123456"
                        });
                });

            modelBuilder.Entity("Assessment2.Models.Appointment", b =>
                {
                    b.HasOne("Assessment2.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("doctor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assessment2.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("patient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Assessment2.Models.Availability", b =>
                {
                    b.HasOne("Assessment2.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("doctor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Assessment2.Models.HistoryDates", b =>
                {
                    b.HasOne("Assessment2.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });
#pragma warning restore 612, 618
        }
    }
}
