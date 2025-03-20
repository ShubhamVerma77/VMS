using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VMS.Domain.Entities;

namespace VMS.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                 new Villa { ID = 1, Name = "Beachfront Villa", Description = "A stunning villa with a private beach view.", Price = 1200.00, Sqft = 2500, Occupancy = 6, ImageUrl = "https://villascroatia.com/storage/2020/08/modern-luxury-villa-pool-medulin-croatia-13-1.jpg" },
    new Villa { ID = 2, Name = "Luxury Hillside Villa", Description = "A modern villa located on a scenic hillside.", Price = 1500.00, Sqft = 3000, Occupancy = 8, ImageUrl = "https://www.exceptionalvillas.com/public/upload/carousel/USA-Isola-Reunion-Resort-Orlando.jpg" },
    new Villa { ID = 3, Name = "Tropical Garden Villa", Description = "A peaceful villa surrounded by lush greenery.", Price = 1000.00, Sqft = 2200, Occupancy = 5, ImageUrl = "https://img.jamesedition.com/listing_images/2019/11/22/15/56/26/81626a90-7b02-4a2c-b2f4-4fa897f54395/je/2000xxs.jpg" },
    new Villa { ID = 4, Name = "Private Pool Villa", Description = "A secluded villa with a private pool.", Price = 1800.00, Sqft = 3500, Occupancy = 10, ImageUrl = "https://imperiobanus.com/wp/wp-content/uploads/2018/04/1-1.jpg" },
    new Villa { ID = 5, Name = "Mountain Retreat Villa", Description = "A cozy villa with breathtaking mountain views.", Price = 1300.00, Sqft = 2800, Occupancy = 7, ImageUrl = "https://wallpapercave.com/wp/wp10292952.jpg" }

                );
        }
    }
}
