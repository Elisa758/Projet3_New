using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Filter
    {
        public List<Shops> ListToFilter { get; set; }
        // voir pour passer cette en classe en abstract (ou interface) et faire une classe ShopFilter et JournalFilter qui en hériteront 
        //=> classe doit être extensible et non modifiable;
        //journalFilter par titre, date, éditeur,magasins

        public void FilterBy(string filterType)
        {
            //faire une suele méthode de filtre et on passe en argument le type de filtre (city,date,titre,name,...) et la list à filtrer (propriétés?)
            //Ienumérable Where
            throw new System.NotImplementedException();
        }

        public void FilterByCountry()
        {
            throw new System.NotImplementedException();
        }

        public void FilterByCounty()
        {
            throw new System.NotImplementedException();
        }

        public void FilterByDistrict()
        {
            throw new System.NotImplementedException();
        }
    }
}