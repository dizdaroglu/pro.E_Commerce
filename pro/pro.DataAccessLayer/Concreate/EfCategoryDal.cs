using pro.CoreLayer.GenericRepository;
using pro.DataAccessLayer.Abstract;
using pro.DataAccessLayer.DAL;
using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.Concreate
{
    public class EfCategoryDal:GenericRepo<Category>,ICategoryDal
    {
        // protected alanı cast et 
        //  public DatabaseContext GetContext { get { return _context as DatabaseContext;} }
        public EfCategoryDal(DatabaseContext context):base(context)
        {

        }
    }
}
