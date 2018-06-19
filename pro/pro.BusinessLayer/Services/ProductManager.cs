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
    public class ProductManager : IProductServices
    {
        public IUnitOfWork _unitOfWork;
        public ProductManager()
        {

            _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public int CountProduct()
        {
            return _unitOfWork.ProductDal.FindAll().Count();
        }

        public List<Product> GetList()
        {
            return _unitOfWork.ProductDal.FindAll();
        }

        public List<Product> GetListNew()
        {
            return _unitOfWork.ProductDal.FindAll().OrderByDescending(m => m.CreatedDate).ToList();
        }

        public List<Product> GetListPrice()
        {
            return _unitOfWork.ProductDal.FindAll().OrderByDescending(m => m.UnitPrice).ToList();
        }
    }
}
