using Autofac;
using Autofac.Integration.Mvc;
using pro.BusinessLayer.Abstract;
using pro.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace pro.Web.AutofacHelper
{
    public  static class IoC_Autofac
    {
        public static void Configuration()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            
            builder.RegisterType<CategoryManager>().As<ICategoryServices>();

           


            IContainer container = builder.Build();

            // Controller seviyesinde
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}