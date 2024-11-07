using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ShopDbContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<ProductDetail> ProductDetails { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Order>().HasKey(p => p.OrderId);
            modelBuilder.Entity<ProductDetail>().HasKey(pd => pd.ProductDetailId);
            modelBuilder.Entity<OrderDetail>().HasKey(od => od.OrderDetailId);

            modelBuilder.Entity<ProductDetail>()
                .HasOne(pd => pd.Product)
                .WithMany(p => p.ProductDetails)
                .HasForeignKey(pd => pd.ProductId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.ProductDetail)
                .WithMany(pd => pd.OrderDetails)
                .HasForeignKey(od => od.ProductDetailId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Lacoste",
                    ProductDescription = "Sản phẩm được thiết kế đặc biệt với chất kate Nhật dày dặn, thoáng, ít nhăn (Khi giặt xong không cần ủi). Sơ mi MBL có dáng oversize, kết hợp cổ áo sơ mi basic được ép nhiệt, chắc chắn, cứng và giữ được form sau nhiều lần giặt. Có thể kết hợp cho nhiều outfit đi chơi hay những dịp cần sự nghiêm túc. Điểm nhấn của mẫu áo là chi tiết logo được thêu chắc chắn ở phần túi áo. Đem đến sự lịch sự, kèm theo chút cá tính cho người mặc.",
                    ProductImage = "https://imagena1.lacoste.com/dw/image/v2/AAUP_PRD/on/demandware.static/-/Sites-master/default/dw5dff745b/DH1961_KXE_20.jpg",
                    ProductPrice = 200,
                    ProductColor = new List<String>() { "Back", "White" },
                    ProductSize = new List<String>() { "S", "M", "L" },
                    Category = Category.Shirt,
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Áo thun huy hiệu UNIVERSITY EMBLEM",
                    ProductDescription = "Thiết kế ống quần rộng của chiếc quần kaki này không chỉ mang lại sự thoải mái tuyệt đối mà còn tạo điểm nhấn độc đáo cho phong cách của bạn. Chất liệu cao cấp được sử dụng kỹ lưỡng, đảm bảo độ bền và mềm mại, giúp bạn tự tin diện mọi nơi mà không gặp bất kỳ khó khăn nào.",
                    ProductImage = "https://tse2.mm.bing.net/th?id=OIP.A4iHRff7SJMzQn1LIScwlwHaJ4&pid=Api&P=0&h=180",
                    ProductPrice = 300,
                    ProductColor = new List<String>() { "Back", "White" },
                    ProductSize = new List<String>() { "S", "M", "L" },
                    Category = Category.Shirt,
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Nguyen Van A",
                    Password = "123",
                    Phone = "0123456789",
                    Email = "test1@example.com",
                    Address = "Quang An",
                    CustomerStatus = CustomerStatus.Active,
                },
                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Nguyen Van B",
                    Password = "123",
                    Phone = "0123456789",
                    Email = "test2@example.com",
                    Address = "Quang Be",
                    CustomerStatus = CustomerStatus.Active,

                },

                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Nguyen Van C",
                    Password = "123",
                    Phone = "0123456789",
                    Email = "test3@example.com",
                    Address = "Quang Ce",
                    CustomerStatus = CustomerStatus.Active,

                }
            );

        }
    }
}
