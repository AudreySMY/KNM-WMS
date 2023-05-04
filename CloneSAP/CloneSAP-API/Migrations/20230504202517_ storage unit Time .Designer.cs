﻿// <auto-generated />
using System;
using CloneSAP_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CloneSAP_API.Migrations
{
    [DbContext(typeof(SAPContext))]
    [Migration("20230504202517_ storage unit Time ")]
    partial class storageunitTime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CloneSAP_API.Models.Grid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CollorCod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SizeCod")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Grid");
                });

            modelBuilder.Entity("CloneSAP_API.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("material")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<float>("volume")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("CloneSAP_API.Models.StockID", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GridId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GridId");

                    b.HasIndex("MaterialId");

                    b.ToTable("StockID");
                });

            modelBuilder.Entity("CloneSAP_API.Models.StorageUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatingDating")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModif")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SIID")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SIID");

                    b.ToTable("StorageUnit");
                });

            modelBuilder.Entity("CloneSAP_API.Models.StockID", b =>
                {
                    b.HasOne("CloneSAP_API.Models.Grid", "Grid")
                        .WithMany("StockIDs")
                        .HasForeignKey("GridId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CloneSAP_API.Models.Material", "Material")
                        .WithMany("StockIDs")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grid");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("CloneSAP_API.Models.StorageUnit", b =>
                {
                    b.HasOne("CloneSAP_API.Models.StockID", "SI")
                        .WithMany()
                        .HasForeignKey("SIID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SI");
                });

            modelBuilder.Entity("CloneSAP_API.Models.Grid", b =>
                {
                    b.Navigation("StockIDs");
                });

            modelBuilder.Entity("CloneSAP_API.Models.Material", b =>
                {
                    b.Navigation("StockIDs");
                });
#pragma warning restore 612, 618
        }
    }
}
