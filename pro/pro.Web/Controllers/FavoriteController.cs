using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.Controllers
{
    public class FavoriteController : Controller
    {
        // GET: Favorite
        private IFavServices _favServices;
        private IProductServices _productServices;
        public FavoriteController(IFavServices favServices,IProductServices productServices)
        {
            _favServices = favServices;
            _productServices = productServices;
        }

        /// <summary>
        /// Favorilere ekleyen kod parcası
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // Favorilere ekleme 
        public ActionResult AddToFavorite(int id)
        {
            // find product
            Product product = _productServices.GetProductById(id);
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Favs favs = new Favs()
            {
                CustomerId = loginCustomer.CustomerId,
                ProductId = product.ProductId,
                CreatedDate = DateTime.Now,
                RemovedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            _favServices.AddToFav(favs);
            return RedirectToAction("GetProduct", "Product");
        }
        /// <summary>
        /// Favorilerden cıkarılan kod paracaıs
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // Favorilerden cıkarma 
        public ActionResult RemoveFavorite(int id)
        {
            Favs removedFavs = _favServices.FindFav(id);
            _favServices.RemoveFav(removedFavs);
            return View();
        }
        /// <summary>
        /// Fav listesinin gosteren kod
        /// </summary>
        /// <returns></returns>
        public ActionResult GetFavList()
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            List<Favs> list = _favServices.GetFavlist(loginCustomer);
            return View(list);
        }

    }
}