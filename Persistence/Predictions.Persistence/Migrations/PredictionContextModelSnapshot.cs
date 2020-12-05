﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Predictions.Persistence;

namespace Predictions.Persistence.Migrations
{
    [DbContext(typeof(PredictionContext))]
    partial class PredictionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("ClosePrice")
                        .HasColumnType("float");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("HighPrice")
                        .HasColumnType("float");

                    b.Property<double>("LowPrice")
                        .HasColumnType("float");

                    b.Property<double>("OpenPrice")
                        .HasColumnType("float");

                    b.Property<long>("Volume")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Predictions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClosePrice = 110.0,
                            CompanyId = 1,
                            Date = new DateTime(2020, 12, 5, 11, 46, 13, 756, DateTimeKind.Local).AddTicks(4382),
                            HighPrice = 222.0,
                            LowPrice = 33.0,
                            OpenPrice = 100.0,
                            Volume = 2323L
                        },
                        new
                        {
                            Id = 2,
                            ClosePrice = 110.0,
                            CompanyId = 2,
                            Date = new DateTime(2020, 12, 5, 11, 46, 13, 758, DateTimeKind.Local).AddTicks(812),
                            HighPrice = 422.0,
                            LowPrice = 33.0,
                            OpenPrice = 100.0,
                            Volume = 4321L
                        },
                        new
                        {
                            Id = 3,
                            ClosePrice = 110.0,
                            CompanyId = 3,
                            Date = new DateTime(2020, 12, 5, 11, 46, 13, 758, DateTimeKind.Local).AddTicks(839),
                            HighPrice = 5622.0,
                            LowPrice = 100.0,
                            OpenPrice = 100.0,
                            Volume = 5212L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
