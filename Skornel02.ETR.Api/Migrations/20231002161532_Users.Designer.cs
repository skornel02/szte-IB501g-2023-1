﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skornel02.ETR.Api;

#nullable disable

namespace Skornel02.ETR.Api.Migrations
{
    [DbContext(typeof(ETRContext))]
    [Migration("20231002161532_Users")]
    partial class Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Skornel02.ETR.Api.Entities.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("BirthLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Username", "UserType");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
