using pro.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.EntitiesLayer.Models
{
   public class Basket:BaseEntity,IEntity
    {
        public int BasketId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
       
    }
}
