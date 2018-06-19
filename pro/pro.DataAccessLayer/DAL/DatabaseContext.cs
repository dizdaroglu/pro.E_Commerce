using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.DAL
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext():base("connStr")
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Buy> Buy { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<ProductSizeColor> ProductSizeColor { get; set; }
        public DbSet<Favs> Favs { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Category>().ToTable("Category", "access");
        }
    }
}
