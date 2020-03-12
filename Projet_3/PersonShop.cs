using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class PersonShop
    {
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public Guid ShopId { get; set; }
        public Shop Shop { get;set; }
    }
}