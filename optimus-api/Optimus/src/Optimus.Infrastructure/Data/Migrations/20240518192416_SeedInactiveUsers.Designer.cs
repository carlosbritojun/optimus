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
    [Migration("20240518192416_SeedInactiveUsers")]
    partial class SeedInactiveUsers
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
                            Id = new Guid("47d2e0d1-6e5c-4d15-89aa-d4d198578402"),
                            Address = "7935 Alessandra Avenida, Ribeirão das Neves, Turcas e Caicos",
                            Comments = "Explicabo fuga aliquid id pariatur. Repellat perspiciatis culpa libero placeat sed aliquam aut excepturi autem. Labore magni corrupti a quod. Qui ut corporis quod. Ipsum asperiores id nulla voluptatum magnam sunt.",
                            Cpf = "259.819.587-66",
                            Email = "Vicente19@gmail.com",
                            Name = "Vicente Macedo",
                            Phone = "(62) 69553-5889"
                        },
                        new
                        {
                            Id = new Guid("6ca7ca6e-6a67-44bf-9186-6b849499fd5d"),
                            Address = "37525 Enzo Gabriel Rodovia, São Vicente, Reino Unido",
                            Comments = "Rerum ea adipisci laudantium at et error.",
                            Cpf = "875.196.748-00",
                            Email = "Frederico.Xavier43@yahoo.com",
                            Name = "Frederico Xavier",
                            Phone = "+55 (81) 2023-9988"
                        },
                        new
                        {
                            Id = new Guid("929cfbb3-ac1a-4054-b4e1-aa0817e76106"),
                            Address = "79394 Mariana Avenida, Manaus, Maiote",
                            Comments = "Id voluptatem error est molestias tempora quia quo hic.\nUt sit excepturi quia et.",
                            Cpf = "384.087.171-97",
                            Email = "Caio62@yahoo.com",
                            Name = "Caio Santos",
                            Phone = "(58) 63664-4406"
                        },
                        new
                        {
                            Id = new Guid("6beac74f-7eb5-494a-81df-c8c621e59d89"),
                            Address = "2472 Costa Travessa, Campinas, Lesoto",
                            Comments = "Quam voluptatem quisquam possimus quia explicabo omnis animi molestias. Debitis ducimus quis ut delectus consequatur. Qui corrupti id dignissimos est possimus et aliquid. Est animi mollitia rerum beatae id voluptatem ipsa. Porro nisi dolor commodi dolorem aliquid rem.",
                            Cpf = "415.228.413-77",
                            Email = "Theo81@live.com",
                            Name = "Théo Souza",
                            Phone = "(79) 7482-0066"
                        },
                        new
                        {
                            Id = new Guid("791a1d0e-a489-4161-a31b-2a85202c0359"),
                            Address = "106 Carla Rua, Jundiaí, Fiji",
                            Comments = "Natus molestiae qui possimus.",
                            Cpf = "820.460.341-04",
                            Email = "Bernardo.Saraiva49@yahoo.com",
                            Name = "Bernardo Saraiva",
                            Phone = "(72) 34259-3762"
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
                            Id = new Guid("67799474-4f7d-47ff-b961-92df633f08c4"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rústico Congelado Queijo",
                            QuantityInStock = 6,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("e7632092-4f52-4590-b184-d50ac251b390"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Incrível Plástico Teclado",
                            QuantityInStock = -1,
                            SalePrice = 18m
                        },
                        new
                        {
                            Id = new Guid("e03b57c4-7f71-474c-ad20-5123f3010456"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feito à mão Madeira Computador",
                            QuantityInStock = 9,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("65a8a352-7c69-475b-aff0-43865fbbab10"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 10m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sem marca Concreto Peixe",
                            QuantityInStock = 4,
                            SalePrice = 20m
                        },
                        new
                        {
                            Id = new Guid("775a6646-e3a2-4dd2-81b3-4c91ce483f23"),
                            Comments = "The Football Is Good For Training And Recreational Purposes",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fantástico Granito Peixe",
                            QuantityInStock = 10,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("64708b93-da69-40ec-926e-dd0dec5bb87f"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Licenciado Metal Frango",
                            QuantityInStock = -2,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("f7b7d737-6263-4034-a917-2ca09587db54"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Impressionante Granito Salgadinhos",
                            QuantityInStock = 6,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("0cb633e6-c642-4bc0-9b3f-ad590b281146"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gostoso Borracha Carro",
                            QuantityInStock = 4,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("83508167-c3eb-4856-abca-50a9bc77dc7a"),
                            Comments = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lustroso Macio Peixe",
                            QuantityInStock = 6,
                            SalePrice = 18m
                        },
                        new
                        {
                            Id = new Guid("facb4989-d2a8-45d1-a508-6a915c9be5a0"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lindo Madeira Carro",
                            QuantityInStock = -1,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("ba6f9950-c760-4f7a-ae2b-845ccf7cc73b"),
                            Comments = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gostoso Concreto Camiseta",
                            QuantityInStock = 0,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("da86b477-1ee4-424e-ba18-d96e8af63274"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Aço Bicicleta",
                            QuantityInStock = 5,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("9dc43f23-0d5e-45bd-812c-79500a2a555c"),
                            Comments = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            CostPrice = 5m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Licenciado Metal Calças",
                            QuantityInStock = 6,
                            SalePrice = 10m
                        },
                        new
                        {
                            Id = new Guid("43dfec6a-6fc5-4f61-8b1c-da0e27b27ec2"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ergonômico Congelado Sabonete",
                            QuantityInStock = 2,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("36e4d8f9-8a2b-4dad-a509-805c96c6c23a"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ergonômico Macio Bola",
                            QuantityInStock = 6,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("9bbdaf94-57bf-411d-9c42-9c7dfebb3266"),
                            Comments = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Licenciado Aço Salsicha",
                            QuantityInStock = -1,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("661da597-5620-4d70-9239-e3f76e0224d7"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 10m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lustroso Madeira Peixe",
                            QuantityInStock = 9,
                            SalePrice = 20m
                        },
                        new
                        {
                            Id = new Guid("bbbaf07a-95ac-46f5-9d7f-f855dccfbc17"),
                            Comments = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            CostPrice = 11m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Genérico Aço Pizza",
                            QuantityInStock = 2,
                            SalePrice = 22m
                        },
                        new
                        {
                            Id = new Guid("17061739-2b78-40d9-9846-b695f7e65f21"),
                            Comments = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pequeno Algodão Cadeira",
                            QuantityInStock = 0,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("cdcdec1b-c7c8-4cd4-96f1-7149f5a36095"),
                            Comments = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Plástico Frango",
                            QuantityInStock = 8,
                            SalePrice = 16m
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
                            Id = new Guid("44f14e33-49dd-4a5f-b651-f6515fe8659a"),
                            CreatedAt = new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9122),
                            Email = "admin@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 0
                        },
                        new
                        {
                            Id = new Guid("8861c502-8921-4ef4-b0c6-1e3c738d9f05"),
                            CreatedAt = new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9140),
                            Email = "operador@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 1
                        },
                        new
                        {
                            Id = new Guid("1fca1be4-e5e9-42c9-8111-8ca95eda60ff"),
                            CreatedAt = new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9110),
                            Email = "inativo@optimus.com",
                            InactivatedAt = new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9114),
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}