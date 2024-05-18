using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0985d355-7d6a-4ecb-8feb-1d3123aee5c5"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0eacaa2e-a7dd-4db9-8718-70ab363d46df"));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    quantity_in_stock = table.Column<int>(type: "integer", nullable: false),
                    cost_price = table.Column<decimal>(type: "numeric", nullable: false),
                    sale_price = table.Column<decimal>(type: "numeric", nullable: false),
                    comments = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("5e432f65-902c-4ff5-a9b5-c9dfdc5afb72"), new DateTime(2024, 5, 17, 21, 49, 37, 172, DateTimeKind.Utc).AddTicks(3119), "operador@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 },
                    { new Guid("614663b2-b579-4602-909f-d77602d26ac5"), new DateTime(2024, 5, 17, 21, 49, 36, 800, DateTimeKind.Utc).AddTicks(4088), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_products_name",
                table: "products",
                column: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5e432f65-902c-4ff5-a9b5-c9dfdc5afb72"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("614663b2-b579-4602-909f-d77602d26ac5"));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("0985d355-7d6a-4ecb-8feb-1d3123aee5c5"), new DateTime(2024, 5, 17, 21, 39, 49, 623, DateTimeKind.Utc).AddTicks(7658), "admin@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 0 },
                    { new Guid("0eacaa2e-a7dd-4db9-8718-70ab363d46df"), new DateTime(2024, 5, 17, 21, 39, 49, 898, DateTimeKind.Utc).AddTicks(847), "operator@optimus.com", null, "7110eda4d09e062aa5e4a390b0a572ac0d2c0220", 1 }
                });
        }
    }
}
