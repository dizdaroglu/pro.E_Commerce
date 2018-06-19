using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Abstract
{
    public interface ICustomerServices
    {
        // Register

        // Kullainci adi veya email var mi 
        bool CheckCustomer(Customer customer);
        void Register(Customer customer);

        bool Login(Customer customer);
    }
}
