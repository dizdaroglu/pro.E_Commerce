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
    public class FavManager : IFavServices
    {
        private IUnitOfWork _unitOfWork;
        
        public FavManager()
        {
            _unitOfWork = new UnitOfWork(new DataAccessLayer.DAL.DatabaseContext());
        }

        public void AddToFav(Favs favs)
        {
            if (favs!=null)
            {
                _unitOfWork.FavsDal.Add(favs);
                _unitOfWork.Complete();
            }
        }

        public Favs FindFav(int favId)
        {
            return _unitOfWork.FavsDal.Find(m => m.FavId == favId);
        }

        public List<Favs> GetFavlist(Customer customer)
        {
            return _unitOfWork.FavsDal.FindAll(m => m.Customer.CustomerId == customer.CustomerId);
        }

        public void RemoveFav(Favs favs)
        {
            _unitOfWork.FavsDal.Remove(favs);
            _unitOfWork.Complete();
        }
    }
}
