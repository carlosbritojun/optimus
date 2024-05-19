using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCustomersDataWithCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("54d539a0-5c79-4f00-a132-4224a4955889"), "57113 Eduardo Marginal, Rio de Janeiro, Ilha do Natal", "Ratione libero laudantium nulla asperiores praesentium voluptas aut cupiditate id.\nEnim vero illo veritatis sed consequatur facilis ut sit ut.\nIpsum placeat aut quos qui sit.", "10722915764", "Celia_Costa@bol.com.br", "Célia Costa", "(43) 9422-0740" },
                    { new Guid("5c56fada-527e-425e-9e64-a86a7a594605"), "46647 Washington Rodovia, Ananindeua, México", "Ut omnis fuga.\nEum reprehenderit veritatis quae.\nDistinctio amet vel et ab consequatur.\nEst aut dolorem esse.\nExplicabo cupiditate harum sapiente velit similique est provident vel omnis.\nInventore sit rerum mollitia iste.", "27524525516", "Isabel80@live.com", "Isabel Carvalho", "(59) 4196-2468" },
                    { new Guid("69351cc3-daf4-4995-8e4d-bcdce845c784"), "267 Souza Rodovia, Sumaré, República da África Central", "provident", "20143250817", "Fabio_Albuquerque57@hotmail.com", "Fábio Albuquerque", "(01) 41504-8249" },
                    { new Guid("9cc9d4bf-3ce0-460c-818a-9b0b972f70c0"), "3546 Macedo Rua, Serra, Sao Tomé e Príncipe", "Molestiae fuga eveniet sed et.", "77508490509", "DaviLucca_Franco@hotmail.com", "Davi Lucca Franco", "(34) 1967-2908" },
                    { new Guid("eb3b5213-638e-478d-8ff7-25f46f57315d"), "742 Oliveira Rua, Goiânia, Eslovênia", "Ut quia ut laudantium et.\nVoluptatibus id totam illo aut placeat.\nQuia suscipit provident nam ut magnam eligendi blanditiis dolorum.\nEum necessitatibus animi voluptatem dolorem rerum rem qui officiis.\nVoluptatum a itaque magni consectetur.\nEarum animi ratione magni eius repellendus excepturi.", "17761421447", "Isis54@hotmail.com", "Isis Souza", "(76) 8399-1465" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "comments", "cost_price", "created_at", "name", "quantity_in_stock", "sale_price" },
                values: new object[,]
                {
                    { new Guid("0255639b-1e03-417a-b83f-2acb5ccdcec8"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 7m, new DateTime(2024, 5, 18, 20, 1, 1, 659, DateTimeKind.Utc).AddTicks(4770), "Rústico Plástico Atum", -2, 14m },
                    { new Guid("0365c970-0628-4a8d-b8d0-17b98d44b235"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9m, new DateTime(2024, 5, 18, 20, 1, 1, 663, DateTimeKind.Utc).AddTicks(229), "Incrível Algodão Sabonete", 8, 18m },
                    { new Guid("1ea9310f-67d9-4cd6-a0e1-f5c7fe959826"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9m, new DateTime(2024, 5, 18, 20, 1, 1, 687, DateTimeKind.Utc).AddTicks(6706), "Licenciado Plástico Sapatos", 1, 18m },
                    { new Guid("2be4a24f-941b-4987-9a6a-db2fa05c34ae"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 8m, new DateTime(2024, 5, 18, 20, 1, 1, 766, DateTimeKind.Utc).AddTicks(760), "Feito à mão Madeira Queijo", 1, 16m },
                    { new Guid("371b243c-858e-4fc1-a8a5-384657e7a6b0"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6m, new DateTime(2024, 5, 18, 20, 1, 1, 668, DateTimeKind.Utc).AddTicks(1866), "Lustroso Granito Salgadinhos", 10, 12m },
                    { new Guid("3be94411-e781-4b41-9809-56e3ec5d5bf4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 14m, new DateTime(2024, 5, 18, 20, 1, 1, 742, DateTimeKind.Utc).AddTicks(6239), "Ergonômico Fresco Atum", 0, 28m },
                    { new Guid("3c5d4924-9111-40bb-8ed7-d5838ce507af"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6m, new DateTime(2024, 5, 18, 20, 1, 1, 691, DateTimeKind.Utc).AddTicks(1821), "Licenciado Congelado Camiseta", 1, 12m },
                    { new Guid("3cb36462-24de-4f47-b35d-44b1393e233d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 11m, new DateTime(2024, 5, 18, 20, 1, 1, 702, DateTimeKind.Utc).AddTicks(2225), "Ergonômico Concreto Computador", 7, 22m },
                    { new Guid("3f2b3c6e-fd66-440c-b8e8-31026ffa94ab"), "The Football Is Good For Training And Recreational Purposes", 12m, new DateTime(2024, 5, 18, 20, 1, 1, 772, DateTimeKind.Utc).AddTicks(3488), "Fantástico Concreto Carro", 3, 24m },
                    { new Guid("524a1ff0-933a-4d92-a040-3b3ea5ee03fe"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 11m, new DateTime(2024, 5, 18, 20, 1, 1, 675, DateTimeKind.Utc).AddTicks(1011), "Inteligente Macio Mesa", 8, 22m },
                    { new Guid("557e6cd5-56eb-4966-be5b-75c347738240"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 11m, new DateTime(2024, 5, 18, 20, 1, 1, 694, DateTimeKind.Utc).AddTicks(7754), "Genérico Algodão Chapéu", -2, 22m },
                    { new Guid("5a800f44-c266-4c98-b31e-a2990ee829fd"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 7m, new DateTime(2024, 5, 18, 20, 1, 1, 722, DateTimeKind.Utc).AddTicks(8648), "Sem marca Macio Sabonete", 3, 14m },
                    { new Guid("5ad25089-add4-4f69-abf4-e0a66d35ccf9"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8m, new DateTime(2024, 5, 18, 20, 1, 1, 729, DateTimeKind.Utc).AddTicks(4143), "Fantástico Algodão Bola", -1, 16m },
                    { new Guid("6856914a-254c-4d76-9c00-47562cc0b0af"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5m, new DateTime(2024, 5, 18, 20, 1, 1, 715, DateTimeKind.Utc).AddTicks(7156), "Lustroso Granito Teclado", 3, 10m },
                    { new Guid("89626c1f-928a-4417-8ca3-7da555b5355a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 11m, new DateTime(2024, 5, 18, 20, 1, 1, 698, DateTimeKind.Utc).AddTicks(4440), "Refinado Metal Bicicleta", 10, 22m },
                    { new Guid("8ed6cc17-ac57-4895-90ef-51636c2e6e5f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8m, new DateTime(2024, 5, 18, 20, 1, 1, 778, DateTimeKind.Utc).AddTicks(8628), "Fantástico Granito Mesa", 3, 16m },
                    { new Guid("a0c58cf2-c1d2-472a-b287-391809827b36"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 12m, new DateTime(2024, 5, 18, 20, 1, 1, 749, DateTimeKind.Utc).AddTicks(2986), "Genérico Algodão Computador", -2, 24m },
                    { new Guid("a1b119d1-98c3-49b0-b2e8-9880d17ea288"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 9m, new DateTime(2024, 5, 18, 20, 1, 1, 709, DateTimeKind.Utc).AddTicks(2012), "Feito à mão Aço Queijo", 1, 18m },
                    { new Guid("b1baa0bd-00d8-4bad-b607-35062136b84f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 13m, new DateTime(2024, 5, 18, 20, 1, 1, 681, DateTimeKind.Utc).AddTicks(7131), "Rústico Aço Calças", 2, 26m },
                    { new Guid("c89151f5-a849-4e38-81e6-33d85933817a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10m, new DateTime(2024, 5, 18, 20, 1, 1, 736, DateTimeKind.Utc).AddTicks(1945), "Refinado Algodão Pizza", 1, 20m }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("119f93aa-0c62-4ddd-98fe-e2d76bc9016c"), new DateTime(2024, 5, 18, 20, 1, 1, 653, DateTimeKind.Utc).AddTicks(6181), "inativo@optimus.com", new DateTime(2024, 5, 18, 20, 1, 1, 653, DateTimeKind.Utc).AddTicks(6184), "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("a3607ec4-c0fc-41d4-9255-f02bf2e26468"), new DateTime(2024, 5, 18, 20, 1, 1, 653, DateTimeKind.Utc).AddTicks(6190), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 },
                    { new Guid("a5d68ac9-7736-41d3-a34f-77af8f27efb7"), new DateTime(2024, 5, 18, 20, 1, 1, 653, DateTimeKind.Utc).AddTicks(6193), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("54d539a0-5c79-4f00-a132-4224a4955889"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("5c56fada-527e-425e-9e64-a86a7a594605"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("69351cc3-daf4-4995-8e4d-bcdce845c784"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("9cc9d4bf-3ce0-460c-818a-9b0b972f70c0"));

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "id",
                keyValue: new Guid("eb3b5213-638e-478d-8ff7-25f46f57315d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0255639b-1e03-417a-b83f-2acb5ccdcec8"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("0365c970-0628-4a8d-b8d0-17b98d44b235"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("1ea9310f-67d9-4cd6-a0e1-f5c7fe959826"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("2be4a24f-941b-4987-9a6a-db2fa05c34ae"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("371b243c-858e-4fc1-a8a5-384657e7a6b0"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3be94411-e781-4b41-9809-56e3ec5d5bf4"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3c5d4924-9111-40bb-8ed7-d5838ce507af"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3cb36462-24de-4f47-b35d-44b1393e233d"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("3f2b3c6e-fd66-440c-b8e8-31026ffa94ab"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("524a1ff0-933a-4d92-a040-3b3ea5ee03fe"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("557e6cd5-56eb-4966-be5b-75c347738240"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("5a800f44-c266-4c98-b31e-a2990ee829fd"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("5ad25089-add4-4f69-abf4-e0a66d35ccf9"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("6856914a-254c-4d76-9c00-47562cc0b0af"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("89626c1f-928a-4417-8ca3-7da555b5355a"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("8ed6cc17-ac57-4895-90ef-51636c2e6e5f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a0c58cf2-c1d2-472a-b287-391809827b36"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("a1b119d1-98c3-49b0-b2e8-9880d17ea288"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("b1baa0bd-00d8-4bad-b607-35062136b84f"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: new Guid("c89151f5-a849-4e38-81e6-33d85933817a"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("119f93aa-0c62-4ddd-98fe-e2d76bc9016c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("a3607ec4-c0fc-41d4-9255-f02bf2e26468"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("a5d68ac9-7736-41d3-a34f-77af8f27efb7"));

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
    }
}
