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

                    b.HasData(
                        new
                        {
                            Id = new Guid("162f49ea-5d70-4f19-ad7c-134fe394837a"),
                            Comments = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            CostPrice = 13m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Granito Computador",
                            QuantityInStock = 0,
                            SalePrice = 26m
                        },
                        new
                        {
                            Id = new Guid("bc53aee3-11bf-4db0-b030-8697f58cf911"),
                            Comments = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lindo Madeira Carro",
                            QuantityInStock = 8,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("d0a7509d-b0e8-405a-b74d-f2f609e85e97"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Metal Pizza",
                            QuantityInStock = 6,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("5aa95d13-818f-4f0d-8a25-9e1003496f01"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 15m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lustroso Granito Sabonete",
                            QuantityInStock = 10,
                            SalePrice = 30m
                        },
                        new
                        {
                            Id = new Guid("b559432b-d510-4114-8255-6fa959a697a8"),
                            Comments = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lustroso Metal Bicicleta",
                            QuantityInStock = 4,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("d9fd529e-2d9f-48ec-a9af-0e10a02dc8e7"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Refinado Aço Queijo",
                            QuantityInStock = 2,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("9f5f8a83-3d17-4b80-b91d-a972a2012ba7"),
                            Comments = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Borracha Salada",
                            QuantityInStock = 10,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("843a930e-13aa-4af4-817b-a118c76052e6"),
                            Comments = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            CostPrice = 5m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gostoso Madeira Toalhas",
                            QuantityInStock = -1,
                            SalePrice = 10m
                        },
                        new
                        {
                            Id = new Guid("0df2e295-583e-4db0-b429-56b4c269a1e3"),
                            Comments = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            CostPrice = 9m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Refinado Granito Toalhas",
                            QuantityInStock = 2,
                            SalePrice = 18m
                        },
                        new
                        {
                            Id = new Guid("b3465358-0569-4121-889f-29ee338f8441"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 11m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sem marca Madeira Frango",
                            QuantityInStock = -2,
                            SalePrice = 22m
                        },
                        new
                        {
                            Id = new Guid("ea67b7c3-9f1b-4a95-9bf0-247369c0f55d"),
                            Comments = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            CostPrice = 8m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feito à mão Algodão Bicicleta",
                            QuantityInStock = 7,
                            SalePrice = 16m
                        },
                        new
                        {
                            Id = new Guid("62f8c0f7-7acc-4a08-b1ed-93ce49371f45"),
                            Comments = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            CostPrice = 6m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feito à mão Congelado Calças",
                            QuantityInStock = -1,
                            SalePrice = 12m
                        },
                        new
                        {
                            Id = new Guid("0e0a918c-70cf-4c1b-8a12-bb58fd61ab62"),
                            Comments = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Incrível Plástico Peixe",
                            QuantityInStock = 8,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("bd592b4c-f125-4a86-bc7f-96f962b2d0e7"),
                            Comments = "The Football Is Good For Training And Recreational Purposes",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Refinado Borracha Frango",
                            QuantityInStock = 1,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("9c2e6e77-37de-4c72-b11f-a0dae6e5d6ba"),
                            Comments = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ergonômico Madeira Mesa",
                            QuantityInStock = 9,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("0b8ceba1-63cc-41f5-b839-9730c28ee61e"),
                            Comments = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            CostPrice = 12m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lindo Fresco Computador",
                            QuantityInStock = -2,
                            SalePrice = 24m
                        },
                        new
                        {
                            Id = new Guid("2a87fd93-5905-4997-aa89-73b00bc173a3"),
                            Comments = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            CostPrice = 7m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Inteligente Metal Bicicleta",
                            QuantityInStock = 1,
                            SalePrice = 14m
                        },
                        new
                        {
                            Id = new Guid("753390bb-494a-4f3a-b758-9f2ef62409d9"),
                            Comments = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            CostPrice = 11m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Feito à mão Granito Camiseta",
                            QuantityInStock = -2,
                            SalePrice = 22m
                        },
                        new
                        {
                            Id = new Guid("380e9a54-6237-4351-848d-9c6d80b69ce1"),
                            Comments = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lindo Metal Atum",
                            QuantityInStock = 10,
                            SalePrice = 28m
                        },
                        new
                        {
                            Id = new Guid("28c4de03-a46f-461b-94ec-4ea12819b947"),
                            Comments = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            CostPrice = 14m,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prático Madeira Toalhas",
                            QuantityInStock = 7,
                            SalePrice = 28m
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
                            Id = new Guid("a214cf5e-b0ae-4b48-999a-2407dab20870"),
                            CreatedAt = new DateTime(2024, 5, 18, 18, 52, 56, 889, DateTimeKind.Utc).AddTicks(9290),
                            Email = "admin@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 0
                        },
                        new
                        {
                            Id = new Guid("ccadc5ce-ba80-465b-a26b-26c1ee0f0779"),
                            CreatedAt = new DateTime(2024, 5, 18, 18, 52, 56, 889, DateTimeKind.Utc).AddTicks(9297),
                            Email = "operador@optimus.com",
                            Password = "7110eda4d09e062aa5e4a390b0a572ac0d2c0220",
                            Profile = 1
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
