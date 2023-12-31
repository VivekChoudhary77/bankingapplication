﻿// <auto-generated />
using System;
using BankApplication.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankApplication.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    [Migration("20230611164643_InitalDatabase")]
    partial class InitalDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BankApplication.Model.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustId"));

                    b.Property<int>("AccID")
                        .HasColumnType("integer")
                        .HasColumnOrder(1);

                    b.Property<string>("Astatus")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(9);

                    b.Property<string>("Atype")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(8);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("Date")
                        .HasColumnOrder(6);

                    b.Property<int>("Mobileno")
                        .HasColumnType("integer")
                        .HasColumnOrder(4);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(2);

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(5);

                    b.Property<int>("Open_bal")
                        .HasColumnType("integer")
                        .HasColumnOrder(7);

                    b.HasKey("CustId");

                    b.ToTable("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
