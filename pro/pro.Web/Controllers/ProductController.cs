using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        /// <summary>
        /// Dependecy Injection 
        /// </summary>
        private IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public ActionResult GetProduct()
        {
            List<Product> list = _productServices.GetList();
            return View(list);
        }
    }
}