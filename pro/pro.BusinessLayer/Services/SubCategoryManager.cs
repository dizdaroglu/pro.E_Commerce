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
    class SubCategoryManager : ISubCategoryServices
    {
        public IUnitOfWork _unitOfWork;
        public SubCategoryManager()
        {
            _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
        }
        public List<SubCategory> GetSubCategoryList(int id)
        {
            return _unitOfWork.SubCategoryDal.FindAll(m => m.CategoryId == id);
        }

       
    }
}
