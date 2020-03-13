using System;
using System.Linq;
using System.Collections.Generic;
namespace Projet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ShopContext())
            {
                
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                //Shop Creation
                var france = new Country
                {
                    Name = "France",
                };
                france.Districts = GenerateDistrict(france, 3);

                List<City> cities = new List<City>();

                foreach (var District in france.Districts)
                {
                    foreach (var County in District.Counties)
                    {
                        foreach (var city in County.Cities)
                        {
                            cities.Add(city);
                        }
                    }
                }
                for (int i = 1; i <= 3; i++)
                {
                    Random random = new Random();
                    int rdm = random.Next(1, cities.Count);
                    cities[rdm].Shops = GenerateShop(cities[rdm], 2);
                }



                //Employee Creation and association with all shop
                var manyPerson = from i in Enumerable.Range(0, 5)
                                 select new Person { Name = "John" + i, Password = 1234 };
                context.AddRange(manyPerson);

                List<PersonShop> manyPersonShop = new List<PersonShop>();
                List<Shop> manyShops = new List<Shop>();
                       
                foreach(var District in france.Districts)
                {
                    foreach(var County in District.Counties)
                    {
                        foreach(var City in County.Cities)
                        {
                            if (City.Shops != null)
                            {
                                foreach (var Shop in City.Shops)
                                {
                                    manyShops.Add(Shop);
                                }
                            }
                        }
                    }
                } 

                foreach(var shop in manyShops)
                {
                    foreach(var person in manyPerson)
                    {
                        var personShop = new PersonShop { PersonId = person.PersonId, Person = person, Shop = shop, ShopId = shop.ShopId };
                        manyPersonShop.Add(personShop);
                    }
                    
                }

                //Magazine Creation
                var editor1 = GenerateEditor("Faton");
                var editor2 = GenerateEditor("Link Digital Spirit");


                List<Magazine> magazines = GenerateMagazine(5);
                foreach(Magazine mag in magazines)
                {
                    mag.Editor = editor1;
                    mag.PeriodicityDays = 7;
                }

                List<Magazine> magazines1 = GenerateMagazine(5);
                foreach(Magazine mag in magazines1)
                {
                    mag.Editor = editor2;
                    mag.PeriodicityDays = 14;
                }
                magazines.AddRange(magazines1);

                List<ShopMagazine> manyShopMagazines = new List<ShopMagazine>();

                foreach(var mag in magazines)
                {
                    foreach(var shops in manyShops)
                    {
                        var shopsMagazines = new ShopMagazine { MagazineId = mag.MagazineId, Magazine = mag, Shop = shops, ShopId = shops.ShopId };
                        manyShopMagazines.Add(shopsMagazines);
                    }
                }


                List<Order> manyOrders = GenerateOrder(3);


                context.AddRange(magazines);
                context.AddRange(manyShopMagazines);
                context.AddRange(manyPersonShop);
                context.AddRange(france);
                context.SaveChanges();
                

                //Requete pour liste magasin par défaut et filtrer
                /*
                var cityName = (from c in context.City
                                where c.Name == "city1" && c.ZipCode == 19459
                                select c).FirstOrDefault();

                var countyName = (from co in context.County
                                where co.Name == "county1" 
                                select co).FirstOrDefault();

                var districtName = (from di in context.District
                                    where di.Name == "district1"
                                    select di).FirstOrDefault();

                var countryName = (from cou in context.Country
                                   where cou.Name == "France"
                                   select cou).FirstOrDefault();

                */
                //DisplayInformation.DisplayDefaultShop();
                //Filter.FilterByCity(cityName);
                //Filter.FilterByCounty(countyName);
                //Filter.FilterByDistrict(districtName);
                //Filter.FilterByCountry(countryName);
                

            }

        }

        static List<District> GenerateDistrict(Country country, int numbreOfDistrict)
        {
            List<District> districts = new List<District>();
            for(int i =1; i<= numbreOfDistrict; i++)
            {
                var newDistrict = new District();
                newDistrict.Name = "district" + i;
                newDistrict.Country = country;
                newDistrict.Counties = GenerateCounty(newDistrict,2);

                districts.Add(newDistrict);
            }

            return districts;
        }
        static List<County> GenerateCounty(District district, int numbreOfCounty)
        {
            List<County> counties = new List<County>();
            for (int i = 1; i <= numbreOfCounty; i++)
            {
                var newCounty = new County();
                newCounty.Name = "county" + i;
                newCounty.District = district;
                newCounty.Cities = GenerateCity(newCounty,2);

                counties.Add(newCounty);
            }
            return counties;
        }
        static List<City> GenerateCity(County county, int numbreOfCities)
        {
            List<City> cities = new List<City>();
            for (int i = 1; i <= numbreOfCities; i++)
            {
                var newCity = new City();
                newCity.Name = "city" + i;
                newCity.County = county;
                Random random = new Random();
                int zipcode = random.Next(10000,99999);
                newCity.ZipCode = zipcode;
                //newCity.Shops = GenerateShop(newCity, 1);

                cities.Add(newCity);
            }
            return cities;
        }

        static List<Shop> GenerateShop(City city, int numberOfShop)
        {
            List<Shop> shopList = new List<Shop>();

            for (int i = 1; i <= numberOfShop; i++)
            {
                var newShop = new Shop();
                Random random = new Random();
                int numberStreet = random.Next(1, 100);
                newShop.Name = "shop" + i + city.Name;
                newShop.StreetNumber = numberStreet;
                newShop.StreetName = "street" + i;
                newShop.City = city;
                newShop.ZipCode = city.ZipCode;
                shopList.Add(newShop);
            }
            return shopList;

        }
        /*
        static List<PersonShop> AssociatePersonToShop()
        {

        }

        static List<Shop> GetShops()
        {

        }
        static List<Person> GetPeople()
        {

        }*/

        static Editor GenerateEditor(string name)
        {
            using (var context = new ShopContext())
            {
                    var newEditor = new Editor();
                    newEditor.Name = name;
                    return newEditor;
            }
        }

        static List<Magazine> GenerateMagazine (int numberOfMagazine)
        {
            List<Magazine> magazines = new List<Magazine>();
            for(int i=1;i<=numberOfMagazine;i++)
            {
                var newMagazines = new Magazine();
                newMagazines.Name ="Magazine"+i;
                magazines.Add(newMagazines);

            }
            return magazines;
        }

        static List<Order> GenerateOrder(int numberOfOrder)
        {
            List<Order> orders = new List<Order>();
            for(int i =1;i<=numberOfOrder;i++)
            {
                var newOrder = new Order();
                newOrder.OrderDate = DateTime.Today.AddDays(i);
                newOrder.DeliveryDate = DateTime.Today.AddDays(i + 2);
                orders.Add(newOrder);
            }
            return orders;
        }

        static List<MagazineOrder> AssociationMagazineWithOrder(List<Magazine> manyMags, List<Order> manyOrders)
        {
            List<MagazineOrder> manyMagazineOrders = new List<MagazineOrder>();

            foreach (var order in manyOrders)
            {
                foreach (var mag in manyMags)
                {
                    var magazineOrder = new MagazineOrder { Order = order, OrderId = order.OrderId, Magazine = mag, MagazineId = mag.MagazineId };
                    manyMagazineOrders.Add(magazineOrder);
                }
            }
            return manyMagazineOrders;

        }




    }
}
