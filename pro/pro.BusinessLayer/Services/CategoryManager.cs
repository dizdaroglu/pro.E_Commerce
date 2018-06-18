using pro.BusinessLayer.Abstract;
using pro.DataAccessLayer.UnitOfWork.Abstract;
using pro.DataAccessLayer.UnitOfWork.Concreate;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Services
{
    public class CategoryManager : ICategoryServices
    {
        public IUnitOfWork _unitOfWork;
        public CategoryManager()
        {
            
            _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public List<Category> GetCategoryList()
        {
           return  _unitOfWork.CategoryDal.FindAll();
        }
    }

    //public class BaseClass
    //{
    //    public IUnitOfWork _unitOfWork;
    //    public BaseClass()
    //    {
    //        _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
    //    }
    //}
    
    
}
