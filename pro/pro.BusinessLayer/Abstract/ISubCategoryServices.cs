using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Abstract
{
    public interface ISubCategoryServices
    {
        List<SubCategory> GetSubCategoryList(int id);
        List<SubCategory> GetSubCategoryList();
        
    }
}
