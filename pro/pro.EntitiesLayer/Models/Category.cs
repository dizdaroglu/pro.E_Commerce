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
    public class Category:BaseEntity,IEntity
    {
        // Test Edildi
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        
        public virtual List<SubCategory> SubCategory { get; set; } // birden fazla alt kategori

        public Category()
        {
            SubCategory = new List<Models.SubCategory>();
            Products = new List<Product>();
        }

        // Bir kategoriye ait birden fazla ürü olur 
        public virtual List<Product> Products { get; set; }

    }
}
