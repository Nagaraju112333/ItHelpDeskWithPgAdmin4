using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ondc.Seller.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedComapanyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComapnyName",
                table: "it_help_desk_companies",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComapnyName",
                table: "it_help_desk_companies");
        }
    }
}
