﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MvcRestaurant.Data;

namespace MvcRestaurant.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170404231752_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcRestaurant.Models.Server", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<double>("tips");

                    b.HasKey("ID");

                    b.ToTable("Server");
                });
        }
    }
}
