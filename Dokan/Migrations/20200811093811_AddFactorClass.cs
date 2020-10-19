using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dokan.Migrations
{
    public partial class AddFactorClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactorId",
                table: "Sales",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SalesFactors",
                columns: table => new
                {
                    FactorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    Balance = table.Column<int>(nullable: false),
                    Cash = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesFactors", x => x.FactorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_FactorId",
                table: "Sales",
                column: "FactorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_SalesFactors_FactorId",
                table: "Sales",
                column: "FactorId",
                principalTable: "SalesFactors",
                principalColumn: "FactorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_SalesFactors_FactorId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "SalesFactors");

            migrationBuilder.DropIndex(
                name: "IX_Sales_FactorId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "FactorId",
                table: "Sales");
        }
    }
}
