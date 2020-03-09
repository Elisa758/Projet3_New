using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Shops
    {
        public int CodeShopId {get; set; }
        public string Name { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int Stock { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public List<Magazines> MagazinesList { get; set; }

        //public void FilterByCity()
        //{
        //    throw new System.NotImplementedException();
        //}
        //public void FilterByCountry()
        //{
        //    throw new System.NotImplementedException();
        //}
        //public void FilterByCounty()
        //{
        //    throw new System.NotImplementedException();
        //}
        //public void FilterByDistrict()
        //{
        //    throw new System.NotImplementedException();
        //}

        public void AddShop()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteShop()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayInfoShop()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayDefaultShopList()
        {
            //prend en argument une liste de magasins
            throw new System.NotImplementedException();
        }
    }
}