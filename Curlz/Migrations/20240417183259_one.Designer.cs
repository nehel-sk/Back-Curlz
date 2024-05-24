﻿// <auto-generated />
using System;
using Curlz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curlz.Migrations
{
    [DbContext(typeof(CurlzDbContext))]
    [Migration("20240417183259_one")]
    partial class one
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Curlz.Models.Booking", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"));

                    b.Property<DateTime>("Booked_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Booking_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Reg_Id")
                        .HasColumnType("int");

                    b.Property<int>("Service_Id")
                        .HasColumnType("int");

                    b.Property<int>("Slot_Id")
                        .HasColumnType("int");

                    b.HasKey("Booking_Id");

                    b.HasIndex("Reg_Id");

                    b.HasIndex("Service_Id");

                    b.HasIndex("Slot_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Curlz.Models.Feedback", b =>
                {
                    b.Property<int>("Feedback_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Feedback_Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Commenting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reg_Id")
                        .HasColumnType("int");

                    b.Property<int>("Service_Id")
                        .HasColumnType("int");

                    b.HasKey("Feedback_Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Curlz.Models.Registration", b =>
                {
                    b.Property<int>("Reg_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reg_Id"));

                    b.Property<string>("Confirm_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("Phone_No")
                        .HasColumnType("bigint");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("User");

                    b.HasKey("Reg_Id");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Curlz.Models.Service", b =>
                {
                    b.Property<int>("Service_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Service_Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Service_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Service_Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Curlz.Models.Slot", b =>
                {
                    b.Property<int>("Slot_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Slot_Id"));

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Slot_Id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("Curlz.Models.Status", b =>
                {
                    b.Property<int>("Status_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Status_Id"));

                    b.Property<int>("Booking_Id")
                        .HasColumnType("int");

                    b.Property<string>("Status_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Status_Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Curlz.Models.Booking", b =>
                {
                    b.HasOne("Curlz.Models.Registration", "Registration")
                        .WithMany()
                        .HasForeignKey("Reg_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Curlz.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("Service_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Curlz.Models.Slot", "Slot")
                        .WithMany()
                        .HasForeignKey("Slot_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");

                    b.Navigation("Service");

                    b.Navigation("Slot");
                });
#pragma warning restore 612, 618
        }
    }
}
