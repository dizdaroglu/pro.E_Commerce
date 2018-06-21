using pro.BusinessLayer.Abstract;
using pro.EntitiesLayer.Models;
using pro.Web.Models;
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
        public ActionResult Login(CustomerDto customer)
        {
            Customer findCustomer = _customerServices.FindCustomerByName(customer.Username);
            if (ModelState.IsValid)
            {


                // Kullanici Active olmuşmu 
                bool res = _customerServices.Login(findCustomer);
                if (res == true)
                {
                   // ModelState.AddModelError("", "Giriş Başarılı");
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

        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                // Kullanıcı adı  kullanılmamış ise 
                customer.ActivationCode = Guid.NewGuid();
                customer.isActive = false;
                customer.CreatedDate = DateTime.Now;
                customer.RemovedDate = DateTime.Now;
                customer.ModifiedDate = DateTime.Now;
                customer.RoleId = 2;
                customer.ProfileImage = "/Content/bay.png";
                // Kişinin kullanici adi varmi  ? 
                bool userIsAlready = _customerServices.CheckCustomerByUsername(customer.UserName);
                bool userHasEmail = _customerServices.CheckCustomerByEmail(customer.Email);
                if (userIsAlready==true)
                {
                    ModelState.AddModelError("", $"Bu {customer.UserName} kullanici adi kullaniliyor");
                }
                else if (userHasEmail == true)
                {
                    ModelState.AddModelError("", $"Bu {customer.Email} email kullaniliyor ");
                }
                else if(userHasEmail==false && userIsAlready == false)
                {
                    _customerServices.Register(customer);
                    return RedirectToAction("Login", "Customer");
                }
            }

            return View(customer);
        }

        #endregion



    }
}