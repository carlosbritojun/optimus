using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCustomersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5e432f65-902c-4ff5-a9b5-c9dfdc5afb72"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("614663b2-b579-4602-909f-d77602d26ac5"));

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    cpf = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    phone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    address_value = table.Column<string>(type: "text", nullable: false),
                    comments = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customers", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("5b895525-044c-455c-ac12-f7732991115c"), new DateTime(2024, 5, 17, 21, 58, 33, 356, DateTimeKind.Utc).AddTicks(5058), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("9655324a-141a-47b5-8006-420f6ee5cd19"), new DateTime(2024, 5, 17, 21, 58, 33, 89, DateTimeKind.Utc).AddTicks(1950), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_customers_cpf",
                table: "customers",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_customers_email",
                table: "customers",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_customers_name",
                table: "customers",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5b895525-044c-455c-ac12-f7732991115c"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("9655324a-141a-47b5-8006-420f6ee5cd19"));

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("5e432f65-902c-4ff5-a9b5-c9dfdc5afb72"), new DateTime(2024, 5, 17, 21, 49, 37, 172, DateTimeKind.Utc).AddTicks(3119), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("614663b2-b579-4602-909f-d77602d26ac5"), new DateTime(2024, 5, 17, 21, 49, 36, 800, DateTimeKind.Utc).AddTicks(4088), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 }
                });
        }
    }
}
