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
        private IColorsServices _colorsServices;
        public HomeController(ISubCategoryServices subcategoryServices,IColorsServices colorsServices)
        {
            _subcategoryServices = subcategoryServices;
            _colorsServices = colorsServices;
        }
        public ActionResult Index()
        {
              List<SubCategory>  subcategoryList = _subcategoryServices.GetSubCategoryList();
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
        public ActionResult _SubCategoriesPartial()
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