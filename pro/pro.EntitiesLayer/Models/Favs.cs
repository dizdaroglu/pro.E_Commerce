using pro.CoreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.EntitiesLayer.Models
{
   public class Favs:BaseEntity,IEntity
    {

        public int FavId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
