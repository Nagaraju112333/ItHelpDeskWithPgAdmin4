using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ondc.Seller.Api.Migrations
{
    /// <inheritdoc />
    public partial class ItHelpDeskFirstMigration11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_it_help_desk_companies_Name",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "CoverImageName",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "ImageSasUri",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "LowStockThresholdValue",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "Mrp",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "NoOfUnit",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "SalesPrice",
                table: "it_help_desk_companies");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "it_help_desk_companies",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "it_help_desk_companies",
                newName: "CompanyLogoPath");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "it_help_desk_companies",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "it_help_desk_companies",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "it_help_desk_companies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessEmail",
                table: "it_help_desk_companies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "it_help_desk_companies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PinCode",
                table: "it_help_desk_companies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_it_help_desk_companies_BusinessEmail_PhoneNumber",
                table: "it_help_desk_companies",
                columns: new[] { "BusinessEmail", "PhoneNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_it_help_desk_companies_BusinessEmail_PhoneNumber",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "BusinessEmail",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "City",
                table: "it_help_desk_companies");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "it_help_desk_companies");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "it_help_desk_companies",
                newName: "SellerId");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "it_help_desk_companies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "it_help_desk_companies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CompanyLogoPath",
                table: "it_help_desk_companies",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "it_help_desk_companies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CoverImageName",
                table: "it_help_desk_companies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "it_help_desk_companies",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "it_help_desk_companies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageSasUri",
                table: "it_help_desk_companies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "it_help_desk_companies",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "LowStockThresholdValue",
                table: "it_help_desk_companies",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Mrp",
                table: "it_help_desk_companies",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "NoOfUnit",
                table: "it_help_desk_companies",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalesPrice",
                table: "it_help_desk_companies",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_it_help_desk_companies_Name",
                table: "it_help_desk_companies",
                column: "Name",
                unique: true);
        }
    }
}
