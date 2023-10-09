using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ondc.Seller.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ondc_product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    Mrp = table.Column<double>(type: "double precision", nullable: false),
                    SalesPrice = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: true),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    LowStockThresholdValue = table.Column<double>(type: "double precision", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: false),
                    NoOfUnit = table.Column<double>(type: "double precision", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    CoverImageName = table.Column<string>(type: "text", nullable: true),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    UpdatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ondc_product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ondc_product_category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellerId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    OndcCategoryId = table.Column<string>(type: "text", nullable: true),
                    IsOnline = table.Column<bool>(type: "boolean", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    UpdatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ondc_product_category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ondc_seller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CompanyName = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    EmailAddress = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    xmin = table.Column<uint>(type: "xid", rowVersion: true, nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    UpdatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ondc_seller", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ondc_product_Name",
                table: "ondc_product",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ondc_product_category_Name",
                table: "ondc_product_category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ondc_seller_CompanyName_EmailAddress_PhoneNumber",
                table: "ondc_seller",
                columns: new[] { "CompanyName", "EmailAddress", "PhoneNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ondc_product");

            migrationBuilder.DropTable(
                name: "ondc_product_category");

            migrationBuilder.DropTable(
                name: "ondc_seller");
        }
    }
}
