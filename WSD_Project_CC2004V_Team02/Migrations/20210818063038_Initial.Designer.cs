﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSD_Project_CC2004V_Team02.Models;

namespace WSD_Project_CC2004V_Team02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210818063038_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSD_Project_CC2004V_Team02.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("CustomerName");

                    b.Property<DateTime>("Delivery_Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("Order_Date");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}