﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Predictions.Persistence;

namespace Predictions.Persistence.Migrations
{
    [DbContext(typeof(PredictionContext))]
    [Migration("20201203214637_PredictionIntialCreate")]
    partial class PredictionIntialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Predictions.Persistence.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Centric"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ness"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Endava"
                        });
                });

            modelBuilder.Entity("Predictions.Persistence.Entities.Prediction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Predictions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Date = new DateTime(2020, 12, 3, 23, 46, 36, 488, DateTimeKind.Local).AddTicks(6372),
                            Price = 100.0
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            Date = new DateTime(2020, 12, 3, 23, 46, 36, 490, DateTimeKind.Local).AddTicks(9685),
                            Price = 100.0
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 3,
                            Date = new DateTime(2020, 12, 3, 23, 46, 36, 490, DateTimeKind.Local).AddTicks(9759),
                            Price = 100.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
