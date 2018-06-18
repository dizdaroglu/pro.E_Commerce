using pro.CoreLayer.GenericRepository;
using pro.DataAccessLayer.Abstract;
using pro.DataAccessLayer.DAL;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.Concreate
{
    public class EfSubCategoryDal : GenericRepo<SubCategory>, ISubCategoryDal
    {
        // protected alanı cast et 
        //  public DatabaseContext GetContext { get { return _context as DatabaseContext;} }
        public EfSubCategoryDal(DatabaseContext context) : base(context)
        {
            
        }

        

        
    }
}
