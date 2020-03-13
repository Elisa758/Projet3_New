using System;
using System.Linq;
using System.Collections.Generic;

namespace Projet_3
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            Person currentPerson = new Person();
            Authentification.AuthentifyUser(currentPerson);

            //using (var context = new ShopContext())
            {/*
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                
                var france = new Country
                {
                    Name = "France",
                };
                france.Districts = GenerateDistrict(france, 3);


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
                            foreach(var Shop in City.Shops)
                            {
                                manyShops.Add(Shop); 
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

                context.AddRange(manyPersonShop);
                //List<PersonShop> manyPersonShop = new List<PersonShop>();
                //foreach(var shop in )

                context.AddRange(france);
                context.SaveChanges(); */

               /* var cityName = (from c in context.City
                                where c.Name == "city1" && c.ZipCode == 14943
                                select c).FirstOrDefault();

                var countyName = (from co in context.County
                                where co.Name == "county1" 
                                select co).FirstOrDefault();

                var districtName = (from di in context.District
                                    where di.Name == "district1"
                                    select di).FirstOrDefault();

                var countryName = (from cou in context.Country
                                   where cou.Name == "France"
                                   select cou).FirstOrDefault(); */
                              

                //DisplayInformation.DisplayDefaultShop();
                //Filter.FilterByCity(cityName);
                //Filter.FilterByCounty(countyName);

                //Filter.FilterByDistrict(districtName);

               // Filter.FilterByCountry(countryName);



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
                newDistrict.Counties = GenerateCounty(newDistrict,3);

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
                newCounty.Cities = GenerateCity(newCounty,3);

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
                newCity.Shops = GenerateShop(newCity, 3);

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

    }
}
