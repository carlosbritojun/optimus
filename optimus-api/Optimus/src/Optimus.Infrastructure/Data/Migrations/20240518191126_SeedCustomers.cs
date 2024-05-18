using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0f68ada0-f344-45e5-8a91-2903320547a3"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("21c0b092-6384-4a08-b296-498db9352441"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("2da4a307-749a-4c8d-9ec4-8920f2161de3"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("321fc52b-5f68-4713-970b-2bfd9ab7cc33"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3640637c-774f-4487-ad4d-2b6bb88f2140"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("38bf32a1-d51f-4a4b-b211-d95bc5d9bdd3"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3ba5b790-7087-474b-8c43-e61f881789b7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3d14b010-ae0b-45e3-b399-b1f25d956341"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("41611875-0380-4b29-9fb7-2c9ba81f037a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("5153124f-7840-4173-9680-1133c54adbf8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("6010cbb9-f598-4c58-af24-3c899d6c4aea"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("70def688-448e-4fb6-8396-45992e8b436e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("899a2078-5229-4be1-9967-8c82e93e469e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a0ab7f67-ec4f-4ba2-82ae-8a97d6d04c1e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a4d99481-7d48-4e6c-9dd5-a4d7a9b934db"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a9fc0d0a-b8c9-4b99-81e8-9c04aa0f8e65"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("be36be74-d90f-45c4-afe9-01512b702535"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("e9276f38-5214-4074-9dfe-ac30d3dad859"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ec7f9470-0fbf-4ff3-9ea2-534ba18d3078"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("fc867e41-6dc4-4d8a-95e4-6a48d91bd172"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("222bf5a6-ff6b-4506-a468-c2ecf0dbcba6"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("a2d39575-4488-4a35-a97a-fe92abafbcf7"));

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "address", "comments", "cpf", "email", "name", "phone" },
                values: new object[,]
                {
                    { new Guid("093cdddc-de3a-4ef1-af4f-9986acfe94f2"), "50639 Enzo Rua, Rio Branco, Georgia", "Corporis culpa dolorem ut at qui eum minima tenetur.", "755.799.886-30", "Suelen_Reis@yahoo.com", "Suélen Reis", "(70) 98925-9618" },
                    { new Guid("68a8c427-ad36-451f-8fc9-7abdbd9378fb"), "9789 Enzo Gabriel Marginal, Canoas, Japão", "consequatur", "896.071.104-71", "Silas.Costa99@gmail.com", "Silas Costa", "+55 (11) 7270-9025" },
                    { new Guid("7a0b3ce6-e3d7-4295-ad12-8af0232b1cb4"), "7598 Albuquerque Travessa, Pelotas, Romênia", "Accusamus excepturi dolorem qui sit officiis voluptatem qui vel voluptatem.", "235.401.473-22", "Marli73@bol.com.br", "Marli Santos", "(80) 35052-8106" },
                    { new Guid("b4b708eb-8ca6-435b-a8f9-4b2d6799a4f0"), "26553 Joana Travessa, Carapicuíba, Turquia", "Culpa quod non aliquam sed dolore.\nEt ab sapiente quis qui facilis.\nConsequatur delectus cupiditate sit in quam facilis.", "759.300.185-70", "Hugo.Macedo@gmail.com", "Hugo Macedo", "+55 (37) 6157-9538" },
                    { new Guid("b700dd87-a75d-41a8-bc30-193c482352ee"), "94621 Pereira Rua, Paulista, Quirguistão", "Rerum omnis sed ipsa sint.\nRecusandae eaque repudiandae sunt possimus et.", "334.356.884-83", "Sara69@yahoo.com", "Sara Carvalho", "+55 (09) 5981-2727" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "comments", "cost_price", "created_at", "name", "quantity_in_stock", "sale_price" },
                values: new object[,]
                {
                    { new Guid("0175caf8-75ac-47c8-a075-01e20b565af8"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonômico Borracha Carro", 8, 18m },
                    { new Guid("087471d1-f861-477f-96e2-5281991b57c6"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Aço Computador", 6, 12m },
                    { new Guid("2069fb09-a412-4bef-8f50-63788faf059d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genérico Algodão Bicicleta", 10, 16m },
                    { new Guid("272ac217-75da-436f-b854-c1447ee98cf8"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incrível Fresco Bacon", 7, 16m },
                    { new Guid("33edd1b9-a980-4eb4-b29b-bf6d25f57708"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rústico Plástico Computador", 4, 28m },
                    { new Guid("44c631e7-b0ab-420f-87c1-4255a3758d16"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lustroso Plástico Salsicha", 7, 16m },
                    { new Guid("58217e5b-b4b2-4a28-956f-6da9613f7277"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Borracha Bacon", 7, 20m },
                    { new Guid("6efce8a0-2451-40c1-9797-da83eb038c5e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Algodão Sapatos", 4, 28m },
                    { new Guid("7b242a19-ac18-45b9-ad04-cd8d0b80dbfd"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Aço Mouse", 10, 24m },
                    { new Guid("7c924c30-d59d-49ae-82e6-453a729b2df4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Macio Calças", 3, 10m },
                    { new Guid("83e250b8-9b60-456a-acd2-07d027cb3c19"), "The Football Is Good For Training And Recreational Purposes", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Granito Queijo", 2, 18m },
                    { new Guid("95b76947-104a-4fc2-8abe-f833838c1050"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genérico Concreto Camiseta", -2, 16m },
                    { new Guid("9ba98140-aac3-477e-adf5-111376462a58"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Concreto Carro", 0, 14m },
                    { new Guid("a573aa0b-746c-4678-a867-59c395f9e304"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Borracha Toalhas", 7, 18m },
                    { new Guid("b6eceb7c-e4f5-4426-aff3-0b87ba1f3e92"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Madeira Salgadinhos", 0, 24m },
                    { new Guid("c180b0a0-e72b-4ef9-ad20-d5d89c0492c9"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Borracha Sapatos", 7, 14m },
                    { new Guid("cae300b1-7f41-4250-8417-74617f0d576f"), "The Football Is Good For Training And Recreational Purposes", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonômico Borracha Bola", 3, 10m },
                    { new Guid("db687950-83ea-4ce8-99b2-5205aecda951"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Madeira Salgadinhos", 4, 20m },
                    { new Guid("f483fbfb-ed02-4fe9-be4f-d6078a99778b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Concreto Bicicleta", -2, 28m },
                    { new Guid("f83a0244-643c-42b5-9f89-8378d7d84940"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genérico Macio Frango", 5, 30m }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("58f232e5-4b0a-4676-abd8-5b50296ffe2f"), new DateTime(2024, 5, 18, 19, 11, 25, 318, DateTimeKind.Utc).AddTicks(5330), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("668bc36a-ebf8-475d-a6d6-a9512380d50e"), new DateTime(2024, 5, 18, 19, 11, 25, 318, DateTimeKind.Utc).AddTicks(5321), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("093cdddc-de3a-4ef1-af4f-9986acfe94f2"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("68a8c427-ad36-451f-8fc9-7abdbd9378fb"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("7a0b3ce6-e3d7-4295-ad12-8af0232b1cb4"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("b4b708eb-8ca6-435b-a8f9-4b2d6799a4f0"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("b700dd87-a75d-41a8-bc30-193c482352ee"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0175caf8-75ac-47c8-a075-01e20b565af8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("087471d1-f861-477f-96e2-5281991b57c6"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("2069fb09-a412-4bef-8f50-63788faf059d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("272ac217-75da-436f-b854-c1447ee98cf8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("33edd1b9-a980-4eb4-b29b-bf6d25f57708"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("44c631e7-b0ab-420f-87c1-4255a3758d16"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("58217e5b-b4b2-4a28-956f-6da9613f7277"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("6efce8a0-2451-40c1-9797-da83eb038c5e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7b242a19-ac18-45b9-ad04-cd8d0b80dbfd"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("7c924c30-d59d-49ae-82e6-453a729b2df4"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("83e250b8-9b60-456a-acd2-07d027cb3c19"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("95b76947-104a-4fc2-8abe-f833838c1050"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9ba98140-aac3-477e-adf5-111376462a58"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a573aa0b-746c-4678-a867-59c395f9e304"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b6eceb7c-e4f5-4426-aff3-0b87ba1f3e92"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("c180b0a0-e72b-4ef9-ad20-d5d89c0492c9"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("cae300b1-7f41-4250-8417-74617f0d576f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("db687950-83ea-4ce8-99b2-5205aecda951"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("f483fbfb-ed02-4fe9-be4f-d6078a99778b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("f83a0244-643c-42b5-9f89-8378d7d84940"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("58f232e5-4b0a-4676-abd8-5b50296ffe2f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("668bc36a-ebf8-475d-a6d6-a9512380d50e"));

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "comments", "cost_price", "created_at", "name", "quantity_in_stock", "sale_price" },
                values: new object[,]
                {
                    { new Guid("0f68ada0-f344-45e5-8a91-2903320547a3"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Fresco Bacon", -1, 22m },
                    { new Guid("21c0b092-6384-4a08-b296-498db9352441"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inteligente Borracha Salada", 9, 20m },
                    { new Guid("2da4a307-749a-4c8d-9ec4-8920f2161de3"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rústico Metal Atum", 7, 24m },
                    { new Guid("321fc52b-5f68-4713-970b-2bfd9ab7cc33"), "The Football Is Good For Training And Recreational Purposes", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Concreto Sabonete", 4, 28m },
                    { new Guid("3640637c-774f-4487-ad4d-2b6bb88f2140"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incrível Madeira Sabonete", 6, 24m },
                    { new Guid("38bf32a1-d51f-4a4b-b211-d95bc5d9bdd3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindo Algodão Teclado", 9, 20m },
                    { new Guid("3ba5b790-7087-474b-8c43-e61f881789b7"), "The Football Is Good For Training And Recreational Purposes", 13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Madeira Camiseta", 8, 26m },
                    { new Guid("3d14b010-ae0b-45e3-b399-b1f25d956341"), "The Football Is Good For Training And Recreational Purposes", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incrível Congelado Computador", 6, 28m },
                    { new Guid("41611875-0380-4b29-9fb7-2c9ba81f037a"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem marca Concreto Peixe", 3, 10m },
                    { new Guid("5153124f-7840-4173-9680-1133c54adbf8"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem marca Borracha Teclado", -1, 30m },
                    { new Guid("6010cbb9-f598-4c58-af24-3c899d6c4aea"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Algodão Salada", 3, 18m },
                    { new Guid("70def688-448e-4fb6-8396-45992e8b436e"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Madeira Cadeira", 8, 30m },
                    { new Guid("899a2078-5229-4be1-9967-8c82e93e469e"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Congelado Bola", -1, 30m },
                    { new Guid("a0ab7f67-ec4f-4ba2-82ae-8a97d6d04c1e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Aço Bola", 0, 26m },
                    { new Guid("a4d99481-7d48-4e6c-9dd5-a4d7a9b934db"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rústico Algodão Computador", 8, 24m },
                    { new Guid("a9fc0d0a-b8c9-4b99-81e8-9c04aa0f8e65"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Plástico Sapatos", 8, 10m },
                    { new Guid("be36be74-d90f-45c4-afe9-01512b702535"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequeno Fresco Sapatos", 8, 14m },
                    { new Guid("e9276f38-5214-4074-9dfe-ac30d3dad859"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rústico Congelado Teclado", 8, 14m },
                    { new Guid("ec7f9470-0fbf-4ff3-9ea2-534ba18d3078"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Aço Computador", -1, 20m },
                    { new Guid("fc867e41-6dc4-4d8a-95e4-6a48d91bd172"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Granito Chapéu", 1, 16m }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("222bf5a6-ff6b-4506-a468-c2ecf0dbcba6"), new DateTime(2024, 5, 18, 19, 3, 45, 593, DateTimeKind.Utc).AddTicks(6633), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 },
                    { new Guid("a2d39575-4488-4a35-a97a-fe92abafbcf7"), new DateTime(2024, 5, 18, 19, 3, 45, 593, DateTimeKind.Utc).AddTicks(6653), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 }
                });
        }
    }
}
