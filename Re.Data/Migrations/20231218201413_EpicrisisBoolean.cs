using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class EpicrisisBoolean : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAddition",
                table: "ReceptionEpicrises",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDrainage",
                table: "ReceptionEpicrises",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsIVL",
                table: "ReceptionEpicrises",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInotropes",
                table: "ReceptionEpicrises",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVash",
                table: "ReceptionEpicrises",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAddition",
                table: "ReceptionEpicrises");

            migrationBuilder.DropColumn(
                name: "IsDrainage",
                table: "ReceptionEpicrises");

            migrationBuilder.DropColumn(
                name: "IsIVL",
                table: "ReceptionEpicrises");

            migrationBuilder.DropColumn(
                name: "IsInotropes",
                table: "ReceptionEpicrises");

            migrationBuilder.DropColumn(
                name: "IsVash",
                table: "ReceptionEpicrises");
        }
    }
}
