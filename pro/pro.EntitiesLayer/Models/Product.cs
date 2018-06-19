using pro.CoreLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.EntitiesLayer.Models
{
    public class Product:BaseEntity,IEntity
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid ProductCode { get; set; }
        public double UnitsInStock { get; set; }
        public int BrandId { get; set; }
        public double UnitPrice { get; set; }
        // public int CategoryId { get; set; } // FK
        public int SubCategoryId { get; set; } // FK 

        // Her ürün bir kategoriye aittir.
        // public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Brand Brand { get; set; }

        // Bir ürünün birden fazla colorı ve size olur resmi olr  
        public virtual List<Colors> Colors { get; set; }
        public virtual List<Size> Size { get; set; }
        public virtual List<Images> Images { get; set; }
        public Product()
        {
            Colors = new List<Models.Colors>();
            Size = new List<Models.Size>();
            Images = new List<Models.Images>();
        }


    }
}
