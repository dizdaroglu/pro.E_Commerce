using pro.BusinessLayer.Abstract;
using pro.DataAccessLayer.DAL;
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
    public class BasketManager : IBasketServices
    {

        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// Definition uOW
        /// </summary>
        public BasketManager()
        {
            _unitOfWork = new UnitOfWork(new DatabaseContext());
        }

        /// <summary>
        /// Sepete ürün ekleme!!
        /// </summary>
        /// <param name="basket"></param>
        public void AddToBasket(Basket basket)
        {
            if (basket!=null)
            {
                _unitOfWork.BasketDal.Add(basket);
                _unitOfWork.Complete();
            }
        }

        /// <summary>
        /// Sepeti idye gore cekme 
        /// </summary>
        /// <param name="basketId"></param>
        /// <returns></returns>
        public Basket FindBasket(int basketId)
        {
            return _unitOfWork.BasketDal.Find(m => m.BasketId == basketId);
        }

        /// <summary>
        ///  Her kullanicinin sepetini bulma
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public List<Basket> GetBasketListByCustomer(Customer customer)
        {
            return _unitOfWork.BasketDal.FindAll(m => m.Customer.CustomerId == customer.CustomerId);
        }

        /// <summary>
        ///  Sepetten ürün silme!
        /// </summary>
        /// <param name="basket"></param>
        public void RemoveBasket(Basket basket)
        {
            if (basket!=null)
            {
                _unitOfWork.BasketDal.Remove(basket);
                _unitOfWork.Complete();
            }
        }
    }
}
