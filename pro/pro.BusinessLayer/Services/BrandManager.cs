using pro.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.EntitiesLayer.Models;
using pro.DataAccessLayer.UnitOfWork.Abstract;
using pro.DataAccessLayer.DAL;
using pro.DataAccessLayer.UnitOfWork.Concreate;

namespace pro.BusinessLayer.Services
{
    public class BrandManager : IBrandServices
    {
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// Definition uOW
        /// </summary>
        public BrandManager()
        {
            _unitOfWork = new UnitOfWork(new DatabaseContext());
        }
        public List<Brand> GetBrandList()
        {
            return _unitOfWork.BrandDal.FindAll();
        }
    }
}
