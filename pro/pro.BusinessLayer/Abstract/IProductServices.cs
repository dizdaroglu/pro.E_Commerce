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

        List<Product> GetListPriceByHigh();
        List<Product> GetListPriceByLow();
        List<Product> GetListNew();

        List<Product> GetProductsBySubCategory(int SubCategoryId);
    }
}
