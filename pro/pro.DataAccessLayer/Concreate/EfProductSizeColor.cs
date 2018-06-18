using pro.CoreLayer.GenericRepository;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace pro.DataAccessLayer.Concreate
{
    public class EfProductSizeColor : GenericRepo<ProductSizeColor>, IProductSizeColor
    {
        public EfProductSizeColor(DbContext context) : base(context)
        {
        }
    }
}
