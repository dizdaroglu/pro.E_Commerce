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

        public List<Product> GetListPriceByHigh()
        {
            return _unitOfWork.ProductDal.FindAll().OrderByDescending(m => m.UnitPrice).ToList();
        }

        public List<Product> GetListPriceByLow()
        {
            return _unitOfWork.ProductDal.FindAll().OrderBy(m => m.UnitPrice).ToList();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SubCategoryId">Alt kategori id </param>
        /// <returns> Gelen alt ateogriye gore ürünleri çeker </returns>
        public List<Product> GetProductsBySubCategory(int SubCategoryId)
        {

            //if (SubCategoryId == null)
            //{
            //    throw new ArgumentNullException("SubCategroyId null ");

            //}

            List<Product> result = _unitOfWork.ProductDal.FindAll(m => m.SubCategoryId == SubCategoryId);
            if (result != null)
            {
                return result;
            }



            return null;
        }


    }
}
