using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class KontaktDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KontaktDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ParentCategory> ParentCategories { get; set; }
        public DbSet<SecondParentCategory> SecondParentCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SliderPhoto> SliderPhotos { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderTracking> orderTrackings { get; set; }
        public DbSet<Parametrs> Parametrs { get; set; }

    }
}
