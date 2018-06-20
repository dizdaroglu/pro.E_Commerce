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


<<<<<<< HEAD
        private ICategoryServices _categoryServices;
        private IBrandServices _brandServices;
        private IProductServices _productServices;
        public HomeController(ICategoryServices categoryServices, IBrandServices brandServices,IProductServices productServices)
        {
            _categoryServices = categoryServices;
            _brandServices = brandServices;
            _productServices = productServices;
        }
        public ActionResult Index()
        {
            List<Category> categoryList = _categoryServices.GetCategoryList();
            return View();
=======
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
>>>>>>> 45bab496480fdca1c6ab162527cce3b65dc480bf
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
<<<<<<< HEAD

       
=======
        //hazır
>>>>>>> 45bab496480fdca1c6ab162527cce3b65dc480bf
    }
}