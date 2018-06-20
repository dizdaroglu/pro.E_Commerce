
using pro.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pro.EntitiesLayer.Models;
using pro.DataAccessLayer.UnitOfWork.Abstract;
using pro.DataAccessLayer.UnitOfWork.Concreate;
using pro.DataAccessLayer.DAL;

namespace pro.BusinessLayer.Services
{
    public class ColorsManager : IColorsServices
    {
        private IUnitOfWork unitOfWork;
        public ColorsManager()
        {
            unitOfWork = new UnitOfWork(new DatabaseContext());
        }
        public List<Colors> GetColorsList()
        {
            return unitOfWork.ColorsDal.FindAll();   
        }
    }
}
