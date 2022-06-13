using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;

namespace BooksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksStoreDbContext context =
            app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < BooksStoreDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
               new Book
               {
                   Title = "Samsung Galaxy S22 Ultra 5G",
                   Description = "https://cdn.tgdd.vn/Products/Images/42/235838/Galaxy-S22-Ultra-Burgundy-600x600.jpg",
                   Genre = "samsung",
                   Price = 28m
               },
                new Book
                {
                    Title = "iPhone 11",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/153856/iphone-xi-vang-600x600.jpg",
                    Genre = "Iphone",
                    Price = 13m
                },
                new Book
                {
                    Title = "OPPO Reno7 series",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/271717/oppo-reno7-z-5g-thumb-1-1-600x600.jpg",
                    Genre = "OPPO",
                    Price = 10m
                },
                new Book
                {
                    Title = "Xiaomi 11T",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/248293/TimerThumb/xiaomi-11t-(8).jpg",
                    Genre = "Xiaomi",
                    Price = 10m
                },
                new Book
                {
                    Title = "Samsung Galaxy A03",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/251856/samsung-galaxy-a03-xanh-thumb-600x600.jpg",
                    Genre = "Samsung",
                    Price = 2m
                },
                new Book
                {
                    Title = "Xiaomi Redmi Note 11 Series",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/270471/xiaomi-redmi-note-11-pro-trang-thumb-600x600.jpg",
                    Genre = "Xiaomi",
                    Price = 7m
                },
                new Book
                {
                    Title = "Xiaomi Redmi Note 11S series",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/272668/xiaomi-redmi-note-11s-5g-%20thumb-600x600.jpg",
                    Genre = "Xiaomi",
                    Price = 6m
                },
                new Book
                {
                    Title = "iPhone 13 Pro Max",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/230529/iphone-13-pro-max-gold-1-600x600.jpg",
                    Genre = "Iphone",
                    Price = 31m
                },
                new Book
                {
                    Title = "Samsung Galaxy A52s",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/247507/TimerThumb/samsung-galaxy-a52s-5g-(8).jpg",
                    Genre = "Samsung",
                    Price = 7m
                },
                new Book
                {
                    Title = "OPPO A55",
                    Description = "https://cdn.tgdd.vn/Products/Images/42/249944/TimerThumb/oppo-a55-4g-(6).jpg",
                    Genre = "OPPO",
                    Price = 4m
                }
                );

                context.SaveChanges();
            }
        }
    }
}