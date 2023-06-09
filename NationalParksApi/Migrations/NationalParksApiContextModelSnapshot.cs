﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParksApi.Models;

#nullable disable

namespace NationalParksApi.Migrations
{
    [DbContext(typeof(NationalParksApiContext))]
    partial class NationalParksApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParksApi.NatlPark", b =>
                {
                    b.Property<int>("NatlParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("NatlParkId");

                    b.HasIndex("StateId");

                    b.ToTable("NatlParks");
                });

            modelBuilder.Entity("NationalParksApi.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("NationalParksApi.StatePark", b =>
                {
                    b.Property<int>("StateParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("StateId1")
                        .HasColumnType("int");

                    b.HasKey("StateParkId");

                    b.HasIndex("StateId1");

                    b.ToTable("StateParks");
                });

            modelBuilder.Entity("NationalParksApi.NatlPark", b =>
                {
                    b.HasOne("NationalParksApi.State", null)
                        .WithMany("NatlParks")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NationalParksApi.StatePark", b =>
                {
                    b.HasOne("NationalParksApi.State", null)
                        .WithMany("StateParks")
                        .HasForeignKey("StateId1");
                });

            modelBuilder.Entity("NationalParksApi.State", b =>
                {
                    b.Navigation("NatlParks");

                    b.Navigation("StateParks");
                });
#pragma warning restore 612, 618
        }
    }
}
