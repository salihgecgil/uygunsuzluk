﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UygunsuzlukRaporuProjesi.Models;

#nullable disable

namespace UygunsuzlukRaporuProjesi.Migrations
{
    [DbContext(typeof(UnsuitabilityDbContext))]
    partial class UnsuitabilityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UygunsuzlukRaporuProjesi.Models.Unsuitability", b =>
                {
                    b.Property<int>("UnsuitabilityNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UnsuitabilityNumber"));

                    b.Property<int>("AcceptedQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ActionForRefusingUnsuitability")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActionForRefusingUnsuitabilityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActionForRefusingUnsuitabilityPersonelInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("AuditResult")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmergencySolution")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmergencySolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmergencySolutionWriterInfo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsCustomerProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDfActivityRequired")
                        .HasColumnType("bit");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PartRevisionNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ProductionQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProjectNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilePersonel")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabileSection")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilityCodeAndDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilityConfirmerInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UnsuitabilityConfirmingInfo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UnsuitabilityData")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnsuitabilityDefinition")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilityDetectedCenterNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilityDetectedOperationNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UnsuitabilityDetectionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnsuitabilityDetectorPersonelInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UnsuitabilityIdentifierInfo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UnsuitabilityIdentifiingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnsuitabilityQuantity")
                        .HasColumnType("int");

                    b.Property<int>("UnsuitabilityType")
                        .HasColumnType("int");

                    b.Property<string>("WorkOrderNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UnsuitabilityNumber");

                    b.ToTable("Unsuitabilities");
                });
#pragma warning restore 612, 618
        }
    }
}
