using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class ShopMagazine
    {
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
        public Guid MagazineId { get; set; }
        public Magazine Magazine { get; set; }
    }
}