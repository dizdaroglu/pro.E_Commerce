using pro.DataAccessLayer.Abstract;
using pro.DataAccessLayer.Concreate;
using pro.DataAccessLayer.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.DataAccessLayer.UnitOfWork.Concreate
{
    public class UnitOfWork : IUnitOfWork
    {

        private DataAccessLayer.DAL.DatabaseContext _context;
        public UnitOfWork(DataAccessLayer.DAL.DatabaseContext context)
        {
            _context = context;
            // ONEMLI!!
            BasketDal = new EfBasketDal(_context);
            BuyDal = new EfBuyDal(_context);
            CategoryDal = new EfCategoryDal(_context);
            ColorsDal = new EfColorsDal(_context);
            CustomerDal = new EfCustomerDal(_context);
            FavsDal = new EfFavsDal(_context);
            ImagesDal = new EfImagesDal(_context);
            ProductDal = new EfProductDal(_context);
            RolesDal = new EfRolesDal(_context);
            SizeDal = new EfSizeDal(_context);
            SubCategoryDal = new EfSubCategoryDal(_context);

        }


        public IBasketDal BasketDal { get; private set; }

        public IBuyDal BuyDal { get; private set; }

        public ICategoryDal CategoryDal { get; private set; }

        public IColorsDal ColorsDal { get; private set; }

        public ICustomerDal CustomerDal { get; private set; }

        public IFavsDal FavsDal { get; private set; }

        public IImagesDal ImagesDal { get; private set; }

        public IProductDal ProductDal { get; private set; }

        public IProductSizeColorDal ProductSizeColorDal { get; private set; }

        public IRolesDal RolesDal { get; private set; }

        public ISizeDal SizeDal { get; private set; }

        public ISubCategoryDal SubCategoryDal { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
