using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class initialv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductColor",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "ProductSize",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductColor", "ProductSize" },
                values: new object[] { "[\"Back\",\"White\"]", "[\"S\",\"M\",\"L\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductColor", "ProductSize" },
                values: new object[] { "[\"Back\",\"White\"]", "[\"S\",\"M\",\"L\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductColor",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSize",
                table: "Products");
        }
    }
}
