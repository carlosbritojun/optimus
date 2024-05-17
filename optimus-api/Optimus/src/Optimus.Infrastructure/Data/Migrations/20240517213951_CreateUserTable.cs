using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Optimus.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    email = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    profile = table.Column<int>(type: "integer", nullable: false),
                    password = table.Column<string>(type: "character varying(100)", maxLength: 10, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    inactivated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "email", "inactivated_at", "password", "profile" },
                values: new object[,]
                {
                    { new Guid("0985d355-7d6a-4ecb-8feb-1d3123aee5c5"), new DateTime(2024, 5, 17, 21, 39, 49, 623, DateTimeKind.Utc).AddTicks(7658), "admin@optimus.com", null, "$2b$10$QtMeC8P.cFXPRWmZjxzg4OoZrNv2B0/cZF2GzxyWHs55U6EPl2saO", 0 },
                    { new Guid("0eacaa2e-a7dd-4db9-8718-70ab363d46df"), new DateTime(2024, 5, 17, 21, 39, 49, 898, DateTimeKind.Utc).AddTicks(847), "operator@optimus.com", null, "$2b$10$PqjDwjjW7TgEvJVa4IkDh.9O/4FC5Ve543OQB2e/.vSLXi.AAwvJi", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "ix_users_email",
                table: "users",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
