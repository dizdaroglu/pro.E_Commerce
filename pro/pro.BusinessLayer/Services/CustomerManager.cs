using pro.BusinessLayer.Abstract;
using pro.DataAccessLayer.DAL;
using pro.DataAccessLayer.UnitOfWork.Abstract;
using pro.DataAccessLayer.UnitOfWork.Concreate;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Services
{
    public class CustomerManager : ICustomerServices
    {

        private IUnitOfWork unitOfWork;
        public CustomerManager()
        {
            unitOfWork = new UnitOfWork(new DatabaseContext());
        }

        #region custoemr işleri 

        /// <summary>
        /// Gelen kullaniinini kaydina bakarak bool doner 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns> true kayıt var demek ekelenemz false kayit yapbilir </returns>
        public bool CheckCustomer(Customer customer)
        {
            bool res = false;
            Customer findedCustomer = unitOfWork.CustomerDal.Find(m => m.UserName.Equals(customer.UserName) || m.Email.Equals(customer.Email));


            if (findedCustomer!=null)
            {
                res = true;
            }
            return res;
        }
        /// <summary>
        /// Kullanici adi ve şifreye gore login işlemi yapar!
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Login(Customer customer)
        {
            bool res = false;
            if (customer!=null)
            {
                Customer findedCustomer = unitOfWork.CustomerDal.Find(m => m.UserName.Equals(customer.UserName) && m.Password.Equals(customer.Password));
                if (findedCustomer!=null)
                {
                    res = true;
                }
            }
            return res;
        }

        /// <summary>
        /// Register işlemi yapar
        /// </summary>
        /// <param name="customer"> Register için gerekli nesne </param>
        public void Register(Customer customer)
        {
            if (customer!=null)
            {
                // Veritabanında kullanici adi ve şifresi varmi
                if (CheckCustomer(customer)==false)
                {
                    // Kayit yapiablir
                    unitOfWork.CustomerDal.Add(customer);
                    // Mail at ve mailde kullaniciya bir guid üret onu yolla
                    // Save changes
                    unitOfWork.Complete();
                }
            }
        }
        #endregion





    }
}
