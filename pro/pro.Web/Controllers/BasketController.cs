using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.Controllers
{
    public class BasketController : Controller
    {
        private IProductServices _productServices;
        private IBasketServices _basketServices;
        public BasketController(IProductServices productServices, IBasketServices basketServices)
        {
            _basketServices = basketServices;
            _productServices = productServices;
        }
        // GET: Basket
        public ActionResult AddToBasket(int id)
        {
            Product findedProduct = _productServices.GetProductById(id);
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            Basket basket = new Basket()
            {
                CustomerId = loginCustomer.CustomerId,
                ProductId = findedProduct.ProductId,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                RemovedDate = DateTime.Now
            };
            _basketServices.AddToBasket(basket);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult RemoveBasket(int id)
        {
            Basket removedBasket = _basketServices.FindBasket(id);
            _basketServices.RemoveBasket(removedBasket);
            return RedirectToAction("Index", "Home");

        }


        public ActionResult ListBasket()
        {
            Customer loginCustomer = Session["loginCustomer"] as Customer;
            List<Basket> list = _basketServices.GetBasketListByCustomer(loginCustomer);
            return View();
        }

    }
}