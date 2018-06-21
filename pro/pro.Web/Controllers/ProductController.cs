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

        public ActionResult Details(int id)
        {
            Product findedProduct = _productServices.GetProductById(id);
            return View(findedProduct);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sort">Sort nesnesi sortBySelect ile jquery ile gelecektir. </param>
        /// <returns></returns>
        public ActionResult GetListSortBy(String sort)
        {
            List<Product> list = null;
            if (sort.Equals("Highest Rated"))
            {
                // En yksek puan şimdfilik kalsın 
            }

            else if (sort.Equals("Newest"))
            {
                list = _productServices.GetListNew();
            }


            else if (sort.Equals("Price: $$ - $"))
            {
                list = _productServices.GetListPriceByHigh();
            }


            else if (sort.Equals("Price: $ - $$"))
            {
                list = _productServices.GetListPriceByLow();
            }

            return View("GetProduct", list);


        }
    }
}