﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public ICollection<MagazineOrder> ManyMagazineOrders { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public ICollection<OrderShop> ManyOrderShops { get; set; }
    }
}