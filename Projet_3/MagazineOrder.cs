using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class MagazineOrder
    {
        public Guid MagazineId { get; set; }
        public Magazine Magazine { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }

}