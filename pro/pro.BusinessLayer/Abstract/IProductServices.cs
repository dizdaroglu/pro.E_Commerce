using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Abstract
{
    public interface IProductServices
    {
        List<Product> GetList();
        int CountProduct();

        List<Product> GetListPrice();
        List<Product> GetListNew();

        List<Product> GetProductsBySubCategory(int SubCategoryId);
    }
}
