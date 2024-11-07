using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class initialv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "ProductDescription", "ProductImage", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 0, "Sản phẩm được thiết kế đặc biệt với chất kate Nhật dày dặn, thoáng, ít nhăn (Khi giặt xong không cần ủi). Sơ mi MBL có dáng oversize, kết hợp cổ áo sơ mi basic được ép nhiệt, chắc chắn, cứng và giữ được form sau nhiều lần giặt. Có thể kết hợp cho nhiều outfit đi chơi hay những dịp cần sự nghiêm túc. Điểm nhấn của mẫu áo là chi tiết logo được thêu chắc chắn ở phần túi áo. Đem đến sự lịch sự, kèm theo chút cá tính cho người mặc.", "https://imagena1.lacoste.com/dw/image/v2/AAUP_PRD/on/demandware.static/-/Sites-master/default/dw5dff745b/DH1961_KXE_20.jpg", "Lacoste", 200m },
                    { 2, 0, "Thiết kế ống quần rộng của chiếc quần kaki này không chỉ mang lại sự thoải mái tuyệt đối mà còn tạo điểm nhấn độc đáo cho phong cách của bạn. Chất liệu cao cấp được sử dụng kỹ lưỡng, đảm bảo độ bền và mềm mại, giúp bạn tự tin diện mọi nơi mà không gặp bất kỳ khó khăn nào.", "https://tse2.mm.bing.net/th?id=OIP.A4iHRff7SJMzQn1LIScwlwHaJ4&pid=Api&P=0&h=180", "Áo thun huy hiệu UNIVERSITY EMBLEM", 300m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);
        }
    }
}
