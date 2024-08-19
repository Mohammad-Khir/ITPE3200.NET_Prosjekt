﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oblig1.DAL;

#nullable disable

namespace Oblig1.Migrations
{
    [DbContext(typeof(ItemDbContext))]
    [Migration("20231128113320_nullableLists2")]
    partial class nullableLists2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Oblig1.Models.Bilder", b =>
                {
                    b.Property<int>("bilderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("bilderUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("husId")
                        .HasColumnType("INTEGER");

                    b.HasKey("bilderId");

                    b.HasIndex("husId");

                    b.ToTable("Bilder");
                });

            modelBuilder.Entity("Oblig1.Models.Eier", b =>
                {
                    b.Property<long>("kontoNummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<int>("antallAnnonser")
                        .HasColumnType("INTEGER");

                    b.HasKey("kontoNummer");

                    b.HasIndex("PersonId");

                    b.ToTable("Eier", (string)null);
                });

            modelBuilder.Entity("Oblig1.Models.Hus", b =>
                {
                    b.Property<int>("husId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Addresse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Beskrivelse")
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Pris")
                        .HasColumnType("TEXT");

                    b.Property<double>("areal")
                        .HasColumnType("REAL");

                    b.Property<string>("by")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("eierkontoNummer")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("erMoblert")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("harParkering")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("kundeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("romAntall")
                        .HasColumnType("INTEGER");

                    b.HasKey("husId");

                    b.HasIndex("eierkontoNummer");

                    b.HasIndex("kundeID");

                    b.ToTable("Hus");
                });

            modelBuilder.Entity("Oblig1.Models.Kunde", b =>
                {
                    b.Property<int>("kundeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.HasKey("kundeID");

                    b.HasIndex("PersonId");

                    b.ToTable("Kunde", (string)null);
                });

            modelBuilder.Entity("Oblig1.Models.Ordre", b =>
                {
                    b.Property<int?>("ordreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("betaltGjennom")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("fullPris")
                        .HasColumnType("TEXT");

                    b.Property<int?>("husId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("kundeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("sluttDato")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("startDato")
                        .HasColumnType("TEXT");

                    b.HasKey("ordreId");

                    b.HasIndex("husId");

                    b.HasIndex("kundeID");

                    b.ToTable("Ordre");
                });

            modelBuilder.Entity("Oblig1.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Addresse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fodselsdato")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Navn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<long>("TelefonNmr")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Oblig1.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Oblig1.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oblig1.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Oblig1.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Oblig1.Models.Bilder", b =>
                {
                    b.HasOne("Oblig1.Models.Hus", "Hus")
                        .WithMany("bildeListe")
                        .HasForeignKey("husId");

                    b.Navigation("Hus");
                });

            modelBuilder.Entity("Oblig1.Models.Eier", b =>
                {
                    b.HasOne("Oblig1.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Oblig1.Models.Hus", b =>
                {
                    b.HasOne("Oblig1.Models.Eier", "eier")
                        .WithMany("husListe")
                        .HasForeignKey("eierkontoNummer");

                    b.HasOne("Oblig1.Models.Kunde", "kunde")
                        .WithMany()
                        .HasForeignKey("kundeID");

                    b.Navigation("eier");

                    b.Navigation("kunde");
                });

            modelBuilder.Entity("Oblig1.Models.Kunde", b =>
                {
                    b.HasOne("Oblig1.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Oblig1.Models.Ordre", b =>
                {
                    b.HasOne("Oblig1.Models.Hus", "hus")
                        .WithMany("ordreListe")
                        .HasForeignKey("husId");

                    b.HasOne("Oblig1.Models.Kunde", "kunde")
                        .WithMany()
                        .HasForeignKey("kundeID");

                    b.Navigation("hus");

                    b.Navigation("kunde");
                });

            modelBuilder.Entity("Oblig1.Models.Eier", b =>
                {
                    b.Navigation("husListe");
                });

            modelBuilder.Entity("Oblig1.Models.Hus", b =>
                {
                    b.Navigation("bildeListe");

                    b.Navigation("ordreListe");
                });
#pragma warning restore 612, 618
        }
    }
}
