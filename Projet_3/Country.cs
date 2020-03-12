using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Country
    {
        public Guid CountryId { get; set; }

        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}