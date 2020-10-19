using Microsoft.EntityFrameworkCore.Migrations;

namespace Dokan.Migrations
{
    public partial class updatephone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Customers_customerID",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "cutomerID",
                table: "Phones");

            migrationBuilder.AlterColumn<int>(
                name: "customerID",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Customers_customerID",
                table: "Phones",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Customers_customerID",
                table: "Phones");

            migrationBuilder.AlterColumn<int>(
                name: "customerID",
                table: "Phones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "cutomerID",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Customers_customerID",
                table: "Phones",
                column: "customerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
