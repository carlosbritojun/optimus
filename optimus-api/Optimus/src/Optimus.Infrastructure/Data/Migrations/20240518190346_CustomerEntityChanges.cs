using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerEntityChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0b8ceba1-63cc-41f5-b839-9730c28ee61e"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0df2e295-583e-4db0-b429-56b4c269a1e3"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0e0a918c-70cf-4c1b-8a12-bb58fd61ab62"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("162f49ea-5d70-4f19-ad7c-134fe394837a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("28c4de03-a46f-461b-94ec-4ea12819b947"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("2a87fd93-5905-4997-aa89-73b00bc173a3"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("380e9a54-6237-4351-848d-9c6d80b69ce1"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("5aa95d13-818f-4f0d-8a25-9e1003496f01"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("62f8c0f7-7acc-4a08-b1ed-93ce49371f45"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("753390bb-494a-4f3a-b758-9f2ef62409d9"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("843a930e-13aa-4af4-817b-a118c76052e6"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9c2e6e77-37de-4c72-b11f-a0dae6e5d6ba"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9f5f8a83-3d17-4b80-b91d-a972a2012ba7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b3465358-0569-4121-889f-29ee338f8441"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b559432b-d510-4114-8255-6fa959a697a8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bc53aee3-11bf-4db0-b030-8697f58cf911"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bd592b4c-f125-4a86-bc7f-96f962b2d0e7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("d0a7509d-b0e8-405a-b74d-f2f609e85e97"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("d9fd529e-2d9f-48ec-a9af-0e10a02dc8e7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ea67b7c3-9f1b-4a95-9bf0-247369c0f55d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("a214cf5e-b0ae-4b48-999a-2407dab20870"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ccadc5ce-ba80-465b-a26b-26c1ee0f0779"));

            migrationBuilder.DropColumn(
                name: "address_value",
                table: "customers");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "customers",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "customers",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(400)",
                oldMaxLength: 400);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "customers",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "address",
                table: "customers");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "customers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "customers",
                type: "character varying(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "address_value",
                table: "customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "comments", "cost_price", "created_at", "name", "quantity_in_stock", "sale_price" },
                values: new object[,]
                {
                    { new Guid("0b8ceba1-63cc-41f5-b839-9730c28ee61e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindo Fresco Computador", -2, 24m },
                    { new Guid("0df2e295-583e-4db0-b429-56b4c269a1e3"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Granito Toalhas", 2, 18m },
                    { new Guid("0e0a918c-70cf-4c1b-8a12-bb58fd61ab62"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incrível Plástico Peixe", 8, 14m },
                    { new Guid("162f49ea-5d70-4f19-ad7c-134fe394837a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 13m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Granito Computador", 0, 26m },
                    { new Guid("28c4de03-a46f-461b-94ec-4ea12819b947"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Madeira Toalhas", 7, 28m },
                    { new Guid("2a87fd93-5905-4997-aa89-73b00bc173a3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inteligente Metal Bicicleta", 1, 14m },
                    { new Guid("380e9a54-6237-4351-848d-9c6d80b69ce1"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindo Metal Atum", 10, 28m },
                    { new Guid("5aa95d13-818f-4f0d-8a25-9e1003496f01"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 15m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lustroso Granito Sabonete", 10, 30m },
                    { new Guid("62f8c0f7-7acc-4a08-b1ed-93ce49371f45"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Congelado Calças", -1, 12m },
                    { new Guid("753390bb-494a-4f3a-b758-9f2ef62409d9"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Granito Camiseta", -2, 22m },
                    { new Guid("843a930e-13aa-4af4-817b-a118c76052e6"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Madeira Toalhas", -1, 10m },
                    { new Guid("9c2e6e77-37de-4c72-b11f-a0dae6e5d6ba"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonômico Madeira Mesa", 9, 14m },
                    { new Guid("9f5f8a83-3d17-4b80-b91d-a972a2012ba7"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Borracha Salada", 10, 28m },
                    { new Guid("b3465358-0569-4121-889f-29ee338f8441"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem marca Madeira Frango", -2, 22m },
                    { new Guid("b559432b-d510-4114-8255-6fa959a697a8"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lustroso Metal Bicicleta", 4, 24m },
                    { new Guid("bc53aee3-11bf-4db0-b030-8697f58cf911"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindo Madeira Carro", 8, 16m },
                    { new Guid("bd592b4c-f125-4a86-bc7f-96f962b2d0e7"), "The Football Is Good For Training And Recreational Purposes", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Borracha Frango", 1, 24m },
                    { new Guid("d0a7509d-b0e8-405a-b74d-f2f609e85e97"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Metal Pizza", 6, 28m },
                    { new Guid("d9fd529e-2d9f-48ec-a9af-0e10a02dc8e7"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refinado Aço Queijo", 2, 12m },
                    { new Guid("ea67b7c3-9f1b-4a95-9bf0-247369c0f55d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Algodão Bicicleta", 7, 16m }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("a214cf5e-b0ae-4b48-999a-2407dab20870"), new DateTime(2024, 5, 18, 18, 52, 56, 889, DateTimeKind.Utc).AddTicks(9290), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 },
                    { new Guid("ccadc5ce-ba80-465b-a26b-26c1ee0f0779"), new DateTime(2024, 5, 18, 18, 52, 56, 889, DateTimeKind.Utc).AddTicks(9297), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 }
                });
        }
    }
}
