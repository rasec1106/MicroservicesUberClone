﻿// <auto-generated />
using System;
using ApiTrip.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiTrip.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230521052654_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiTrip.Models.Driver", b =>
                {
                    b.Property<int>("driverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("driverId"), 1L, 1);

                    b.Property<string>("licenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("driverId");

                    b.ToTable("drivers");
                });

            modelBuilder.Entity("ApiTrip.Models.Trip", b =>
                {
                    b.Property<int>("tripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tripId"), 1L, 1);

                    b.Property<string>("destinationLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("driverId")
                        .HasColumnType("int");

                    b.Property<string>("pickupLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("pickupTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("tripId");

                    b.HasIndex("driverId");

                    b.HasIndex("userId");

                    b.ToTable("trips");
                });

            modelBuilder.Entity("ApiTrip.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ApiTrip.Models.Trip", b =>
                {
                    b.HasOne("ApiTrip.Models.Driver", "driver")
                        .WithMany("trips")
                        .HasForeignKey("driverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiTrip.Models.User", "user")
                        .WithMany("trips")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("driver");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ApiTrip.Models.Driver", b =>
                {
                    b.Navigation("trips");
                });

            modelBuilder.Entity("ApiTrip.Models.User", b =>
                {
                    b.Navigation("trips");
                });
#pragma warning restore 612, 618
        }
    }
}
