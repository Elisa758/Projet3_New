using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
        public ICollection<PersonShop> ManyPersonShops { get; set; }
    }
}