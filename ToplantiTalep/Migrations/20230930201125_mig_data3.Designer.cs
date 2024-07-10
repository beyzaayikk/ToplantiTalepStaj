﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToplantiTalep.DataAccess.Concrete;

#nullable disable

namespace ToplantiTalep.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230930201125_mig_data3")]
    partial class mig_data3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToplantiTalep.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"), 1L, 1);

                    b.Property<string>("AdminAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdminMail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdminParola")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdminSoyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdminTelNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminID");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Departman", b =>
                {
                    b.Property<int>("DepartmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanID"), 1L, 1);

                    b.Property<string>("DepartmanAd")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("DepartmanID");

                    b.ToTable("departmen");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"), 1L, 1);

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciMail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KullaniciParola")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KullaniciSoyad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciTelNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciUnvan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("KurumID")
                        .HasColumnType("int");

                    b.HasKey("KullaniciID");

                    b.HasIndex("KurumID");

                    b.ToTable("kullanicis");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Kurum", b =>
                {
                    b.Property<int>("KurumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KurumID"), 1L, 1);

                    b.Property<string>("KurumAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("KurumID");

                    b.ToTable("kurums");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Oda", b =>
                {
                    b.Property<int>("OdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdaID"), 1L, 1);

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<string>("OdaKat")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("OdaNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("OdaID");

                    b.HasIndex("DepartmanID");

                    b.ToTable("odas");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Talep", b =>
                {
                    b.Property<int>("TalepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TalepID"), 1L, 1);

                    b.Property<int>("DepartmanID")
                        .HasColumnType("int");

                    b.Property<string>("EnvanterAciklama")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("EnvanterTalep")
                        .HasColumnType("bit");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OdaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("TalepAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ToplantiTurID")
                        .HasColumnType("int");

                    b.HasKey("TalepID");

                    b.HasIndex("DepartmanID");

                    b.HasIndex("KullaniciID");

                    b.HasIndex("OdaID");

                    b.HasIndex("ToplantiTurID");

                    b.ToTable("taleps");
                });

            modelBuilder.Entity("ToplantiTalep.Models.ToplantiTur", b =>
                {
                    b.Property<int>("ToplantiTurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToplantiTurID"), 1L, 1);

                    b.Property<string>("ToplantiTurAciklama")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ToplantiTurID");

                    b.ToTable("toplantiTurs");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Kullanici", b =>
                {
                    b.HasOne("ToplantiTalep.Models.Kurum", "Kurum")
                        .WithMany("Kullanicis")
                        .HasForeignKey("KurumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurum");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Oda", b =>
                {
                    b.HasOne("ToplantiTalep.Models.Departman", "Departman")
                        .WithMany("Odas")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Talep", b =>
                {
                    b.HasOne("ToplantiTalep.Models.Departman", "Departman")
                        .WithMany("Taleps")
                        .HasForeignKey("DepartmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToplantiTalep.Models.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToplantiTalep.Models.Oda", "Oda")
                        .WithMany("Taleps")
                        .HasForeignKey("OdaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToplantiTalep.Models.ToplantiTur", "ToplantiTur")
                        .WithMany("Taleps")
                        .HasForeignKey("ToplantiTurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");

                    b.Navigation("Kullanici");

                    b.Navigation("Oda");

                    b.Navigation("ToplantiTur");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Departman", b =>
                {
                    b.Navigation("Odas");

                    b.Navigation("Taleps");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Kurum", b =>
                {
                    b.Navigation("Kullanicis");
                });

            modelBuilder.Entity("ToplantiTalep.Models.Oda", b =>
                {
                    b.Navigation("Taleps");
                });

            modelBuilder.Entity("ToplantiTalep.Models.ToplantiTur", b =>
                {
                    b.Navigation("Taleps");
                });
#pragma warning restore 612, 618
        }
    }
}
