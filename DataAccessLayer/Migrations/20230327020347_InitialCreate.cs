using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    added_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_dea_cust",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    contact = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    added_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_dea_cust", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    added_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_transaction_detail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    qty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    dea_cust_id = table.Column<int>(type: "int", nullable: true),
                    added_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_transaction_detail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dea_cust_id = table.Column<int>(type: "int", nullable: true),
                    grandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    transaction_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    tax = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_transactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    last_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contact = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    user_type = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    added_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    added_by = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_categories");

            migrationBuilder.DropTable(
                name: "tbl_dea_cust");

            migrationBuilder.DropTable(
                name: "tbl_products");

            migrationBuilder.DropTable(
                name: "tbl_transaction_detail");

            migrationBuilder.DropTable(
                name: "tbl_transactions");

            migrationBuilder.DropTable(
                name: "tbl_users");
        }
    }
}
