using Microsoft.EntityFrameworkCore.Migrations;

namespace Dokan.Migrations
{
    public partial class AddCustomerID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cutomerID",
                table: "Phones",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cutomerID",
                table: "Phones");
        }
    }
}
