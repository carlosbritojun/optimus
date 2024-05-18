using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5b895525-044c-455c-ac12-f7732991115c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9655324a-141a-47b5-8006-420f6ee5cd19"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("5b895525-044c-455c-ac12-f7732991115c"), new DateTime(2024, 5, 17, 21, 58, 33, 356, DateTimeKind.Utc).AddTicks(5058), "operator@optimus.com", null, "$2b$10$aYowd0FoKN2wAyyrK0gYu.RTjNtmcwBT50jYJKdRCpl4zgDGgE.aC", 0 },
                    { new Guid("9655324a-141a-47b5-8006-420f6ee5cd19"), new DateTime(2024, 5, 17, 21, 58, 33, 89, DateTimeKind.Utc).AddTicks(1950), "admin@optimus.com", null, "$2b$10$R8YKD2ViFdUg/5b1gAnhy.8xJvjCaR.H6YHmhMZthOYjR7/h7sRXC", 0 }
                });
        }
    }
}
