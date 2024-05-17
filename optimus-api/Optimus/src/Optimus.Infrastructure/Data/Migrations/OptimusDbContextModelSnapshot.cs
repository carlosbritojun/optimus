﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Optimus.Infrastructure.Data;

#nullable disable

namespace Optimus.Infrastructure.Data.Migrations
{
    [DbContext(typeof(OptimusDbContext))]
    partial class OptimusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Optimus.Domain.Entities.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Comments")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("comments");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasDatabaseName("ix_customers_cpf");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_customers_email");

                    b.HasIndex("Name")
                        .HasDatabaseName("ix_customers_name");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("Optimus.Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Comments")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("comments");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("cost_price");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("integer")
                        .HasColumnName("quantity_in_stock");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("numeric")
                        .HasColumnName("sale_price");

                    b.Property<uint>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid")
                        .HasColumnName("xmin");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("Name")
                        .HasDatabaseName("ix_products_name");

                    b.ToTable("products", (string)null);
                });

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
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
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
                            Id = new Guid("9655324a-141a-47b5-8006-420f6ee5cd19"),
                            CreatedAt = new DateTime(2024, 5, 17, 21, 58, 33, 89, DateTimeKind.Utc).AddTicks(1950),
                            Email = "admin@optimus.com",
                            Password = "$2b$10$R8YKD2ViFdUg/5b1gAnhy.8xJvjCaR.H6YHmhMZthOYjR7/h7sRXC",
                            Profile = 0
                        },
                        new
                        {
                            Id = new Guid("5b895525-044c-455c-ac12-f7732991115c"),
                            CreatedAt = new DateTime(2024, 5, 17, 21, 58, 33, 356, DateTimeKind.Utc).AddTicks(5058),
                            Email = "operator@optimus.com",
                            Password = "$2b$10$aYowd0FoKN2wAyyrK0gYu.RTjNtmcwBT50jYJKdRCpl4zgDGgE.aC",
                            Profile = 0
                        });
                });

            modelBuilder.Entity("Optimus.Domain.Entities.Customers.Customer", b =>
                {
                    b.OwnsOne("Optimus.Domain.Entities.Customers.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("address_value");

                            b1.HasKey("CustomerId");

                            b1.ToTable("customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId")
                                .HasConstraintName("fk_customers_customers_id");
                        });

                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
