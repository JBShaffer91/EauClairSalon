﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EauClairSalon.Migrations
{
    [DbContext(typeof(EauClairSalonContext))]
    [Migration("20230601175956_UpdateClientsTable")]
    partial class UpdateClientsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EauClairSalon.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("StylistId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.HasIndex("StylistId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("EauClairSalon.Models.Stylist", b =>
                {
                    b.Property<int>("StylistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Specialty")
                        .HasColumnType("longtext");

                    b.HasKey("StylistId");

                    b.ToTable("Stylists");
                });

            modelBuilder.Entity("EauClairSalon.Models.Client", b =>
                {
                    b.HasOne("EauClairSalon.Models.Stylist", "Stylist")
                        .WithMany("Clients")
                        .HasForeignKey("StylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stylist");
                });

            modelBuilder.Entity("EauClairSalon.Models.Stylist", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}