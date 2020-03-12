using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Shop
    {
        public Guid ShopId {get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public City City { get; set; }
        public int ZipCode { get; set; }
        public ICollection<ShopMagazine> ManyShopMagazines { get; set; }
        public ICollection<PersonShop> ManyPersonShops { get; set; }
        public ICollection<OrderShop> ManyOrderShops { get; set; }

    }
}