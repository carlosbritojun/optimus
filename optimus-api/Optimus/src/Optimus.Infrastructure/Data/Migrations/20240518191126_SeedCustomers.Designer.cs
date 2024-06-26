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
    [Migration("20240518191126_SeedCustomers")]
    partial class SeedCustomers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("address");

                    b.Property<string>("Comments")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("comments");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
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
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("68a8c427-ad36-451f-8fc9-7abdbd9378fb"),
                            Address = "9789 Enzo Gabriel Marginal, Canoas, Japão",
                            Comments = "consequatur",
                            Cpf = "896.071.104-71",
                            Email = "Silas.Costa99@gmail.com",
                            Name = "Silas Costa",
                            Phone = "+55 (11) 7270-9025"
                        },
                        new
                        {
                            Id = new Guid("b700dd87-a75d-41a8-bc30-193c482352ee"),
                            Address = "94621 Pereira Rua, Paulista, Quirguistão",
                            Comments = "Rerum omnis sed ipsa sint.\nRecusandae eaque repudiandae sunt possimus et.",
                            Cpf = "334.356.884-83",
                            Email = "Sara69@yahoo.com",
                            Name = "Sara Carvalho",
                            Phone = "+55 (09) 5981-2727"
                        },
                        new
                        {
                            Id = new Guid("7a0b3ce6-e3d7-4295-ad12-8af0232b1cb4"),
                            Address = "7598 Albuquerque Travessa, Pelotas, Romênia",
                            Comments = "Accusamus excepturi dolorem qui sit officiis voluptatem qui vel voluptatem.",
                            Cpf = "235.401.473-22",
                            Email = "Marli73@bol.com.br",
                            Name = "Marli Santos",
                            Phone = "(80) 35052-8106"
                        },
                        new
                        {
                            Id = new Guid("b4b708eb-8ca6-435b-a8f9-4b2d6799a4f0"),
                            Address = "26553 Joana Travessa, Carapicuíba, Turquia",
                            Comments = "Culpa quod non aliquam sed dolore.\nEt ab sapiente quis qui facilis.\nConsequatur delectus cupiditate sit in quam facilis.",
                            Cpf = "759.300.185-70",
                            Email = "Hugo.Macedo@gmail.com",
                            Name = "Hugo Macedo",
                            Phone = "+55 (37) 6157-9538"
                        },
                        new
                        {
                            Id = new Guid("093cdddc-de3a-4ef1-af4f-9986acfe94f2"),
                            Address = "50639 Enzo Rua, Rio Branco, Georgia",
                            Comments = "Corporis culpa dolorem ut at qui eum minima tenetur.",
                            Cpf = "755.799.886-30",
                            Email = "Suelen_Reis@yahoo.com",
                            Name = "Suélen Reis",
                            Phone = "(70) 98925-9618"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("2069fb09-a412-4bef-8f50-63788faf059d"),
                            Comments = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Genérico Algodão Bicicleta",
                            QuantityInStock = 10,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("087471d1-f861-477f-96e2-5281991b57c6"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Aço Computador",
                            QuantityInStock = 6,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("f83a0244-643c-42b5-9f89-8378d7d84940"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 15m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Genérico Macio Frango",
                            QuantityInStock = 5,
                            SalePrice = 30m
                        },
                        new
                        {
                            Id = new Guid("7b242a19-ac18-45b9-ad04-cd8d0b80dbfd"),
                            Comments = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Aço Mouse",
                            QuantityInStock = 10,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("7c924c30-d59d-49ae-82e6-453a729b2df4"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 5m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Licenciado Macio Calças",
                            QuantityInStock = 3,
                            SalePrice = 10m
                        },
                        new
                        {
                            Id = new Guid("db687950-83ea-4ce8-99b2-5205aecda951"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 10m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Madeira Salgadinhos",
                            QuantityInStock = 4,
                            SalePrice = 20m
                        },
                        new
                        {
                            Id = new Guid("b6eceb7c-e4f5-4426-aff3-0b87ba1f3e92"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gostoso Madeira Salgadinhos",
                            QuantityInStock = 0,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("58217e5b-b4b2-4a28-956f-6da9613f7277"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 10m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feito à mão Borracha Bacon",
                            QuantityInStock = 7,
                            SalePrice = 20m
                        },
                        new
                        {
                            Id = new Guid("272ac217-75da-436f-b854-c1447ee98cf8"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Incrível Fresco Bacon",
                            QuantityInStock = 7,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("cae300b1-7f41-4250-8417-74617f0d576f"),
                            Comments = "The Football Is Good For Training And Recreational Purposes",
                            CostPrice = 5m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ergonômico Borracha Bola",
                            QuantityInStock = 3,
                            SalePrice = 10m
                        },
                        new
                        {
                            Id = new Guid("9ba98140-aac3-477e-adf5-111376462a58"),
                            Comments = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gostoso Concreto Carro",
                            QuantityInStock = 0,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("6efce8a0-2451-40c1-9797-da83eb038c5e"),
                            Comments = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Algodão Sapatos",
                            QuantityInStock = 4,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("44c631e7-b0ab-420f-87c1-4255a3758d16"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lustroso Plástico Salsicha",
                            QuantityInStock = 7,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("c180b0a0-e72b-4ef9-ad20-d5d89c0492c9"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Licenciado Borracha Sapatos",
                            QuantityInStock = 7,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("95b76947-104a-4fc2-8abe-f833838c1050"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Genérico Concreto Camiseta",
                            QuantityInStock = -2,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("0175caf8-75ac-47c8-a075-01e20b565af8"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ergonômico Borracha Carro",
                            QuantityInStock = 8,
                            SalePrice = 18m
                        },
                        new
                        {
                            Id = new Guid("a573aa0b-746c-4678-a867-59c395f9e304"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Borracha Toalhas",
                            QuantityInStock = 7,
                            SalePrice = 18m
                        },
                        new
                        {
                            Id = new Guid("33edd1b9-a980-4eb4-b29b-bf6d25f57708"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rústico Plástico Computador",
                            QuantityInStock = 4,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("f483fbfb-ed02-4fe9-be4f-d6078a99778b"),
                            Comments = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Refinado Concreto Bicicleta",
                            QuantityInStock = -2,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("83e250b8-9b60-456a-acd2-07d027cb3c19"),
                            Comments = "The Football Is Good For Training And Recreational Purposes",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Granito Queijo",
                            QuantityInStock = 2,
                            SalePrice = 18m
                        });
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
                            Id = new Guid("668bc36a-ebf8-475d-a6d6-a9512380d50e"),
                            CreatedAt = new DateTime(2024, 5, 18, 19, 11, 25, 318, DateTimeKind.Utc).AddTicks(5321),
                            Email = "admin@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 0
                        },
                        new
                        {
                            Id = new Guid("58f232e5-4b0a-4676-abd8-5b50296ffe2f"),
                            CreatedAt = new DateTime(2024, 5, 18, 19, 11, 25, 318, DateTimeKind.Utc).AddTicks(5330),
                            Email = "operador@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
