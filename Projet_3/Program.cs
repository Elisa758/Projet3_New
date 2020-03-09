using System;

namespace Projet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //créer plusieurs magasins et tester la méthode filtre dans programmes et le faire dans un test unitaire

            Shops shop1 = new Shops();
            shop1.Name = "Shop1";
            shop1.StreetName = "rue de l'Armoire";
            shop1.StreetNumber = 1;
            shop1.ZipCode = 57000;
            shop1.City = "Metz";
            shop1.Country = "France";
            shop1.County = "57";
            shop1.District = "Grand-Est";
        }
    }
}
