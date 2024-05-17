﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Optimus.Infrastructure.Data;

#nullable disable

namespace Optimus.Infrastructure.Data.Migrations
{
    [DbContext(typeof(OptimusDbContext))]
    [Migration("20240517213951_CreateUserTable")]
    partial class CreateUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Optimus.Domain.Entities.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("email");

                    b.Property<DateTime?>("InactivatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("inactivated_at");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("password");

                    b.Property<int>("Profile")
                        .HasColumnType("integer")
                        .HasColumnName("profile");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_users_email");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0985d355-7d6a-4ecb-8feb-1d3123aee5c5"),
                            CreatedAt = new DateTime(2024, 5, 17, 21, 39, 49, 623, DateTimeKind.Utc).AddTicks(7658),
                            Email = "admin@optimus.com",
                            Password = "$2b$10$QtMeC8P.cFXPRWmZjxzg4OoZrNv2B0/cZF2GzxyWHs55U6EPl2saO",
                            Profile = 0
                        },
                        new
                        {
                            Id = new Guid("0eacaa2e-a7dd-4db9-8718-70ab363d46df"),
                            CreatedAt = new DateTime(2024, 5, 17, 21, 39, 49, 898, DateTimeKind.Utc).AddTicks(847),
                            Email = "operator@optimus.com",
                            Password = "$2b$10$PqjDwjjW7TgEvJVa4IkDh.9O/4FC5Ve543OQB2e/.vSLXi.AAwvJi",
                            Profile = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
