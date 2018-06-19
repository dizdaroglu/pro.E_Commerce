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
        public HomeController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public ActionResult Index()
        {
             // List<Category>  categoryList = _categoryServices.GetCategoryList();
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
    }
}