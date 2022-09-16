using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spider.Migrations
{
    /// <inheritdoc />
    public partial class IniticalCreate_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "imagelink",
                table: "Products",
                newName: "ImageLink");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Products",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "bottleSize",
                table: "Products",
                newName: "BottleSize");

            migrationBuilder.RenameColumn(
                name: "abv",
                table: "Products",
                newName: "Abv");

            migrationBuilder.RenameColumn(
                name: "sku",
                table: "Products",
                newName: "Sku");

            migrationBuilder.AddColumn<DateTime>(
                name: "collectionDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "collectionDate",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ImageLink",
                table: "Products",
                newName: "imagelink");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Products",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "BottleSize",
                table: "Products",
                newName: "bottleSize");

            migrationBuilder.RenameColumn(
                name: "Abv",
                table: "Products",
                newName: "abv");

            migrationBuilder.RenameColumn(
                name: "Sku",
                table: "Products",
                newName: "sku");
        }
    }
}
