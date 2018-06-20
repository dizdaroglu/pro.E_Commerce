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


        private ISubCategoryServices _subcategoryServices;
        private IBrandServices _brandServices;
        private IProductServices _productServices;
        private IColorsServices _colorsServices;
        public HomeController(ISubCategoryServices subcategoryServices, IBrandServices brandServices,IProductServices productServices,IColorsServices colorsServices)
        {
            _subcategoryServices = subcategoryServices;
            _brandServices = brandServices;
            _productServices = productServices;
            _colorsServices = colorsServices;
        }
        public ActionResult Index()
        {
            //List<SubCategory> categoryList = _subcategoryServices.GetSubCategoryList();
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
            List<SubCategory> liste = _subcategoryServices.GetSubCategoryList();
            return View(liste);
        }
        public ActionResult _ColorsPartial()
        {
            List<Colors> liste = _colorsServices.GetColorsList();
            return View(liste);
        }
       

    }
}