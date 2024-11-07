using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class initialv5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ActualPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "Email", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Quang An", "Nguyen Van A", "test1@example.com", "123", "0123456789" },
                    { 2, "Quang Be", "Nguyen Van B", "test2@example.com", "123", "0123456789" },
                    { 3, "Quang Ce", "Nguyen Van C", "test3@example.com", "123", "0123456789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "ActualPrice",
                table: "OrderDetails");
        }
    }
}
