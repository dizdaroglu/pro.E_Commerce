using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.EntitiesLayer.Models
{
   public  class BaseEntity
    {
        // Burası herkesin ortak kullandıgı yerdir.
        public DateTime CreatedDate  { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime RemovedDate { get; set; }

    }
}
