﻿// <auto-generated />
using System;
using Ice_Cream.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ice_Cream.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Ice_Cream.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Block")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreateAt")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<string>("SubcriptionEnd")
                        .HasColumnType("longtext");

                    b.Property<string>("SubcriptionStart")
                        .HasColumnType("longtext");

                    b.Property<string>("SubscriptionId")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("contactDetails")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Ice_Cream.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactDetails")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int?>("OrderAmount")
                        .HasColumnType("int");

                    b.Property<float?>("OrderPrice")
                        .HasColumnType("float");

                    b.Property<string>("OrderType")
                        .HasColumnType("longtext");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}