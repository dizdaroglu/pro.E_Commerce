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
    public class BrandManager : IBrandServices
    {
        private IUnitOfWork _unitOfWork;
        public BrandManager()
        {
            _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public List<Brand> GetBrands()
        {
            return _unitOfWork.BrandDal.FindAll();
        }
    }
}
