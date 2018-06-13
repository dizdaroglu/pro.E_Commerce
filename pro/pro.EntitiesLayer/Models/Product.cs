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
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
       
    }
}
