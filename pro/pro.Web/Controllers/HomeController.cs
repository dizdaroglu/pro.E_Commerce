using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.Controllers
{
    public class HomeController : Controller
    {


        private ICategoryServices _categoryServices;
        private IBrandServices _brandServices;
        public HomeController(ICategoryServices categoryServices,IBrandServices brandServices)
        {
            _categoryServices = categoryServices;
            _brandServices = brandServices;
        }
        public ActionResult Index()
        {
              List<Category>  categoryList = _categoryServices.GetCategoryList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult _CategoriesPartial()
        {
            List<Category> liste = _categoryServices.GetCategoryList();
            return View(liste);
        }

        public ActionResult _BrandPartial()
        {
            List<Brand> brandList = _brandServices.GetBrands();
            return View(brandList);
        }
    }
}