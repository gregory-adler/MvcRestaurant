﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcRestaurant.Data;

namespace MvcRestaurant.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcRestaurant.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Employee");
                });

            modelBuilder.Entity("MvcRestaurant.Models.Host", b =>
                {
                    b.HasBaseType("MvcRestaurant.Models.Employee");

                    b.Property<string>("greeting");

                    b.ToTable("Host");

                    b.HasDiscriminator().HasValue("Host");
                });

            modelBuilder.Entity("MvcRestaurant.Models.Server", b =>
                {
                    b.HasBaseType("MvcRestaurant.Models.Employee");

                    b.Property<double>("tips");

                    b.ToTable("Server");

                    b.HasDiscriminator().HasValue("Server");
                });
        }
    }
}
