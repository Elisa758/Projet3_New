using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class OrderShop
    {
        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}