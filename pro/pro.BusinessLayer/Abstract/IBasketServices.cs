using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Abstract
{
    public interface IBasketServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="basket">Hangi customer hangi ürünü ekleyecekse diger servisler ile bul </param>
        void AddToBasket(Basket basket);

        /// <summary>
        /// Hangi customer hang ürününü sepetiniden kaldırmak istiyor
        /// </summary>
        /// <param name="basket"></param>
        void RemoveBasket(Basket basket);
        /// <summary>
        /// BasketIdye gore basketi bulma!
        /// </summary>
        /// <param name="basketId"></param>
        /// <returns></returns>
        Basket FindBasket(int basketId);
        /// <summary>
        /// Gelen customerin septinin çeken liste!
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        List<Basket> GetBasketListByCustomer(Customer customer);

        
    }
}
