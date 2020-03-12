using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_3
{
    public class Filter
    {
        // voir pour passer cette en classe en abstract (ou interface) et faire une classe ShopFilter et JournalFilter qui en hériteront 
        //=> classe doit être extensible et non modifiable;
        //journalFilter par titre, date, éditeur,magasins

        public static void FilterByCity(City city)
        {
            using (var context = new ShopContext())
            {
                var shopList = from s in context.Shops.AsEnumerable()
                               join c in context.City
                               on s.City.CityId equals c.CityId
                               where c.CityId == city.CityId
                               select new { cityName = c.Name, s.ShopId,  shopName = s.Name };

                foreach (var Shop in shopList)
                {
                    Console.WriteLine(Shop);
                }
            }
        }

        public void FilterByCountry()
        {
            
        }

        public void FilterByDistrict()
        {
            throw new System.NotImplementedException();
        }

        public static void FilterByCounty(County county)
        {
            using (var context = new ShopContext())
            {
                var shopList = from s in context.Shops
                            join c in context.City
                            on s.City.CityId equals c.CityId
                            join co in context.County
                            on c.County.CountyId equals co.CountyId
                            where co.CountyId == county.CountyId
                            select new { CountyName = co.Name, c.Name, s.ShopId, shopName = s.Name };

                foreach (var Shop in shopList)
                {
                    Console.WriteLine(Shop);
                }
            }
        }
    }
}