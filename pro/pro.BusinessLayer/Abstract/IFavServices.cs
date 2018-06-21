using pro.EntitiesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.BusinessLayer.Abstract
{
    public interface IFavServices
    {
        List<Favs> GetFavlist(Customer customer);

        void AddToFav(Favs favs);

        void RemoveFav(Favs favs);

        Favs FindFav(int favId);


    }
}
