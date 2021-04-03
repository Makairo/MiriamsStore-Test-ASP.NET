 using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MiriamsStoreSln.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDBContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange
                (
                    new Product
                    {
                        ProductName = "Rumi Doughnut", 
                        ProductDesc = "Fills you up slightly, gives lots of energy!",
                        ProductPrice = 2.00m,
                        Category = "Consumables"
                    },
                    new Product
                    {
                        ProductName = "Rumi Cake",
                        ProductDesc = "Fills you up completely! Very sweet.",
                        ProductPrice = 10.00m,
                        Category = "Consumables"
                    },
                    new Product
                    {
                        ProductName = "Carrot",
                        ProductDesc = "Home grown, freshly harvested.",
                        ProductPrice = 1.00m,
                        Category = "Consumables"
                    },
                    new Product
                    {
                        ProductName = "Bunny Game",
                        ProductDesc = "This store is a reference to a video game, see if you can find it!",
                        ProductPrice = 2.00m,
                        Category = "Misc"
                    },
                    new Product
                    {
                        ProductName = "Attack Up",
                        ProductDesc = "Makes you hit harder!",
                        ProductPrice = 50.00m,
                        Category = "Upgrades"
                    },
                    new Product
                    {
                        ProductName = "Health Up",
                        ProductDesc = "Makes you a bit harder to take out!",
                        ProductPrice = 75.00m,
                        Category = "Upgrades"
                    }
                );
                context.SaveChanges();
            }   
        }
    }
}
