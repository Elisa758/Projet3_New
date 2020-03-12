using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projet_3
{
    public class DisplayInformation
    {
        public static void DisplayDefaultShop()
        {
            using (var context = new ShopContext())
            {
                var defaultList = from s in context.Shops.AsEnumerable()
                                  join c in context.City
                                  on s.City.CityId equals c.CityId
                                  select new { s.ShopId, s.Name };

                foreach (var Shop in defaultList)
                {
                    Console.WriteLine(Shop);
                }

            }
        }
    }
}