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
    public class SubCategory:BaseEntity, IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubCategoryId { get; set; }

        public int CategoryId { get; set; } // categoryId FK

        public String Name { get; set; }


        // Her alt kategorinin bir kategorisi vardır 
        public virtual Category Category { get; set; }

        public virtual List<Product> Products  { get; set; }

        public SubCategory()
        {
            Products = new List<Product>();
        }


    }
}
