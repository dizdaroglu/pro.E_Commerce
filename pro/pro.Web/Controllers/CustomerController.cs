using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer->Login
        #region Services D_I

        private ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        #endregion


        /// <summary>
        /// Login View 
        /// </summary>
        /// <returns></returns>

        #region Login
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(Customer customer)
        {
            if (ModelState.IsValid)
            {


                // Kullanici Active olmuşmu 
                bool res = _customerServices.Login(customer);
                if (res == true)
                {
                    ModelState.AddModelError("", "Giriş Başarılı");
                    Session["loginCustomer"] = customer;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen kullanıcı adınızı ve şifrenizi kontrol ediniz.");
                }
            }
            return View(customer);
        }
        #endregion 


        // Register
        #region Register 
        public ActionResult Register()
        {
            return View();
        }
        #endregion



    }
}