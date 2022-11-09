﻿// <auto-generated />
using System;
using Klinika.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Klinika.Data.Migrations
{
    [DbContext(typeof(KlinikaContext))]
    [Migration("20221108124449_1")]
    partial class _1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Klinika.Data.Data.Acount.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRole");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Klinika.Data.Data.Acount.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleIdRole")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.HasIndex("RoleIdRole");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Klinika.Data.Data.CMS.Adres", b =>
                {
                    b.Property<int>("IdAdresu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<string>("KodPocztowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(7);

                    b.Property<string>("Miasto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PozycjaWyswietlania")
                        .HasColumnType("int");

                    b.Property<string>("Ulica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdresu");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("Klinika.Data.Data.CMS.GodzinyOtwarcia", b =>
                {
                    b.Property<int>("IdGodzinyOtwarcia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<string>("Dzien")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("GodzinaOtwarciaDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("GodzinaOtwarciaOd")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("PozycjaWyswietlania")
                        .HasColumnType("int");

                    b.HasKey("IdGodzinyOtwarcia");

                    b.ToTable("GodzinyOtwarcia");
                });

            modelBuilder.Entity("Klinika.Data.Data.CMS.Kontakt", b =>
                {
                    b.Property<int>("IdKontaktu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<string>("NazwaKontaktu")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("NumerTelefonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<int>("PozycjaWyswietlania")
                        .HasColumnType("int");

                    b.Property<string>("TytułKontakt")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("IdKontaktu");

                    b.ToTable("Kontakt");
                });

            modelBuilder.Entity("Klinika.Data.Data.CMS.Parametry", b =>
                {
                    b.Property<int>("IdParametru")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CzyAktywny")
                        .HasColumnType("bit");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdParametru");

                    b.ToTable("Parametry");
                });

            modelBuilder.Entity("Klinika.Data.Data.Wizyty.RodzajeWizyt", b =>
                {
                    b.Property<int>("IdRodzajeWizyty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRodzajeWizyty");

                    b.ToTable("RodzajeWizyt");
                });

            modelBuilder.Entity("Klinika.Data.Data.Acount.User", b =>
                {
                    b.HasOne("Klinika.Data.Data.Acount.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleIdRole");
                });
#pragma warning restore 612, 618
        }
    }
}