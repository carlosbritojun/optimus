using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInactiveUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "customers",
                columns: new[] { "id", "address", "comments", "cpf", "email", "name", "phone" },
                values: new object[,]
                {
                    { new Guid("47d2e0d1-6e5c-4d15-89aa-d4d198578402"), "7935 Alessandra Avenida, Ribeirão das Neves, Turcas e Caicos", "Explicabo fuga aliquid id pariatur. Repellat perspiciatis culpa libero placeat sed aliquam aut excepturi autem. Labore magni corrupti a quod. Qui ut corporis quod. Ipsum asperiores id nulla voluptatum magnam sunt.", "259.819.587-66", "Vicente19@gmail.com", "Vicente Macedo", "(62) 69553-5889" },
                    { new Guid("6beac74f-7eb5-494a-81df-c8c621e59d89"), "2472 Costa Travessa, Campinas, Lesoto", "Quam voluptatem quisquam possimus quia explicabo omnis animi molestias. Debitis ducimus quis ut delectus consequatur. Qui corrupti id dignissimos est possimus et aliquid. Est animi mollitia rerum beatae id voluptatem ipsa. Porro nisi dolor commodi dolorem aliquid rem.", "415.228.413-77", "Theo81@live.com", "Théo Souza", "(79) 7482-0066" },
                    { new Guid("6ca7ca6e-6a67-44bf-9186-6b849499fd5d"), "37525 Enzo Gabriel Rodovia, São Vicente, Reino Unido", "Rerum ea adipisci laudantium at et error.", "875.196.748-00", "Frederico.Xavier43@yahoo.com", "Frederico Xavier", "+55 (81) 2023-9988" },
                    { new Guid("791a1d0e-a489-4161-a31b-2a85202c0359"), "106 Carla Rua, Jundiaí, Fiji", "Natus molestiae qui possimus.", "820.460.341-04", "Bernardo.Saraiva49@yahoo.com", "Bernardo Saraiva", "(72) 34259-3762" },
                    { new Guid("929cfbb3-ac1a-4054-b4e1-aa0817e76106"), "79394 Mariana Avenida, Manaus, Maiote", "Id voluptatem error est molestias tempora quia quo hic.\nUt sit excepturi quia et.", "384.087.171-97", "Caio62@yahoo.com", "Caio Santos", "(58) 63664-4406" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "comments", "cost_price", "created_at", "name", "quantity_in_stock", "sale_price" },
                values: new object[,]
                {
                    { new Guid("0cb633e6-c642-4bc0-9b3f-ad590b281146"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Borracha Carro", 4, 28m },
                    { new Guid("17061739-2b78-40d9-9846-b695f7e65f21"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequeno Algodão Cadeira", 0, 14m },
                    { new Guid("36e4d8f9-8a2b-4dad-a509-805c96c6c23a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonômico Macio Bola", 6, 12m },
                    { new Guid("43dfec6a-6fc5-4f61-8b1c-da0e27b27ec2"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonômico Congelado Sabonete", 2, 14m },
                    { new Guid("64708b93-da69-40ec-926e-dd0dec5bb87f"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Metal Frango", -2, 12m },
                    { new Guid("65a8a352-7c69-475b-aff0-43865fbbab10"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sem marca Concreto Peixe", 4, 20m },
                    { new Guid("661da597-5620-4d70-9239-e3f76e0224d7"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lustroso Madeira Peixe", 9, 20m },
                    { new Guid("67799474-4f7d-47ff-b961-92df633f08c4"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rústico Congelado Queijo", 6, 16m },
                    { new Guid("775a6646-e3a2-4dd2-81b3-4c91ce483f23"), "The Football Is Good For Training And Recreational Purposes", 12m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantástico Granito Peixe", 10, 24m },
                    { new Guid("83508167-c3eb-4856-abca-50a9bc77dc7a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lustroso Macio Peixe", 6, 18m },
                    { new Guid("9bbdaf94-57bf-411d-9c42-9c7dfebb3266"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 7m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Aço Salsicha", -1, 14m },
                    { new Guid("9dc43f23-0d5e-45bd-812c-79500a2a555c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licenciado Metal Calças", 6, 10m },
                    { new Guid("ba6f9950-c760-4f7a-ae2b-845ccf7cc73b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gostoso Concreto Camiseta", 0, 28m },
                    { new Guid("bbbaf07a-95ac-46f5-9d7f-f855dccfbc17"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 11m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Genérico Aço Pizza", 2, 22m },
                    { new Guid("cdcdec1b-c7c8-4cd4-96f1-7149f5a36095"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Plástico Frango", 8, 16m },
                    { new Guid("da86b477-1ee4-424e-ba18-d96e8af63274"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prático Aço Bicicleta", 5, 16m },
                    { new Guid("e03b57c4-7f71-474c-ad20-5123f3010456"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 14m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Feito à mão Madeira Computador", 9, 28m },
                    { new Guid("e7632092-4f52-4590-b184-d50ac251b390"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incrível Plástico Teclado", -1, 18m },
                    { new Guid("f7b7d737-6263-4034-a917-2ca09587db54"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Impressionante Granito Salgadinhos", 6, 12m },
                    { new Guid("facb4989-d2a8-45d1-a508-6a915c9be5a0"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 8m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindo Madeira Carro", -1, 16m }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("1fca1be4-e5e9-42c9-8111-8ca95eda60ff"), new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9110), "inativo@optimus.com", new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9114), "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("44f14e33-49dd-4a5f-b651-f6515fe8659a"), new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9122), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 },
                    { new Guid("8861c502-8921-4ef4-b0c6-1e3c738d9f05"), new DateTime(2024, 5, 18, 19, 24, 15, 474, DateTimeKind.Utc).AddTicks(9140), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("47d2e0d1-6e5c-4d15-89aa-d4d198578402"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("6beac74f-7eb5-494a-81df-c8c621e59d89"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("6ca7ca6e-6a67-44bf-9186-6b849499fd5d"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("791a1d0e-a489-4161-a31b-2a85202c0359"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("929cfbb3-ac1a-4054-b4e1-aa0817e76106"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0cb633e6-c642-4bc0-9b3f-ad590b281146"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("17061739-2b78-40d9-9846-b695f7e65f21"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("36e4d8f9-8a2b-4dad-a509-805c96c6c23a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("43dfec6a-6fc5-4f61-8b1c-da0e27b27ec2"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("64708b93-da69-40ec-926e-dd0dec5bb87f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("65a8a352-7c69-475b-aff0-43865fbbab10"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("661da597-5620-4d70-9239-e3f76e0224d7"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("67799474-4f7d-47ff-b961-92df633f08c4"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("775a6646-e3a2-4dd2-81b3-4c91ce483f23"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("83508167-c3eb-4856-abca-50a9bc77dc7a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9bbdaf94-57bf-411d-9c42-9c7dfebb3266"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("9dc43f23-0d5e-45bd-812c-79500a2a555c"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("ba6f9950-c760-4f7a-ae2b-845ccf7cc73b"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("bbbaf07a-95ac-46f5-9d7f-f855dccfbc17"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("cdcdec1b-c7c8-4cd4-96f1-7149f5a36095"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("da86b477-1ee4-424e-ba18-d96e8af63274"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("e03b57c4-7f71-474c-ad20-5123f3010456"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("e7632092-4f52-4590-b184-d50ac251b390"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("f7b7d737-6263-4034-a917-2ca09587db54"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("facb4989-d2a8-45d1-a508-6a915c9be5a0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("1fca1be4-e5e9-42c9-8111-8ca95eda60ff"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("44f14e33-49dd-4a5f-b651-f6515fe8659a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("8861c502-8921-4ef4-b0c6-1e3c738d9f05"));

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "id", "address", "comments", "cpf", "email", "name", "phone" },
                values: new object[,]
                {
                    { new Guid("093cdddc-de3a-4ef1-af4f-9986acfe94f2"), "50639 Enzo Rua, Rio Branco, Georgia", "Corporis culpa dolorem ut at qui eum minima tenetur.", "75579988630", "Suelen_Reis@yahoo.com", "Suélen Reis", "(70) 98925-9618" },
                    { new Guid("68a8c427-ad36-451f-8fc9-7abdbd9378fb"), "9789 Enzo Gabriel Marginal, Canoas, Japão", "consequatur", "89607110471", "Silas.Costa99@gmail.com", "Silas Costa", "(11) 7270-9025" },
                    { new Guid("7a0b3ce6-e3d7-4295-ad12-8af0232b1cb4"), "7598 Albuquerque Travessa, Pelotas, Romênia", "Accusamus excepturi dolorem qui sit officiis voluptatem qui vel voluptatem.", "23540147322", "Marli73@bol.com.br", "Marli Santos", "(80) 35052-8106" },
                    { new Guid("b4b708eb-8ca6-435b-a8f9-4b2d6799a4f0"), "26553 Joana Travessa, Carapicuíba, Turquia", "Culpa quod non aliquam sed dolore.\nEt ab sapiente quis qui facilis.\nConsequatur delectus cupiditate sit in quam facilis.", "75930018570", "Hugo.Macedo@gmail.com", "Hugo Macedo", "(37) 6157-9538" },
                    { new Guid("b700dd87-a75d-41a8-bc30-193c482352ee"), "94621 Pereira Rua, Paulista, Quirguistão", "Rerum omnis sed ipsa sint.\nRecusandae eaque repudiandae sunt possimus et.", "33435688483", "Sara69@yahoo.com", "Sara Carvalho", "(09) 5981-2727" }
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
    }
}
