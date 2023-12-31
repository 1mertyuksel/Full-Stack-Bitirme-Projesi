﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROJEM.Data;

#nullable disable

namespace PROJEM.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("PROJEM.Data.KullaniciTestSonuc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KullaniciID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SoruID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VerilenCevap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Sonuc");
                });

            modelBuilder.Entity("PROJEM.Data.SecenekModel", b =>
                {
                    b.Property<string>("SecenekID")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecenekMetni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SoruID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SecenekID");

                    b.HasIndex("SoruID");

                    b.ToTable("Secenekler");
                });

            modelBuilder.Entity("PROJEM.Data.Soru", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DogruCevap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KullaniciCevabi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoruMetni")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TümSorular");
                });

            modelBuilder.Entity("PROJEM.Data.SecenekModel", b =>
                {
                    b.HasOne("PROJEM.Data.Soru", null)
                        .WithMany("Secenekler")
                        .HasForeignKey("SoruID");
                });

            modelBuilder.Entity("PROJEM.Data.Soru", b =>
                {
                    b.Navigation("Secenekler");
                });
#pragma warning restore 612, 618
        }
    }
}
