using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class City
    {
        public Guid CityId { get; set; }

        public string Name { get; set; }

        public int ZipCode { get; set; }

        public County County { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}