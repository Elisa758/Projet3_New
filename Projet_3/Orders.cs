using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public abstract class Orders
    {
        public int Id
        {
            get => default;
            set
            {
            }
        }

        public List<Magazines> MagazinesList
        {
            get => default;
            set
            {
            }
        }

        public int Quantity
        {
            get => default;
            set
            {
            }
        }

        public DateTime OrderDate
        {
            get => default;
            set
            {
            }
        }

        public DateTime DeliveryDate
        {
            get => default;
            set
            {
            }
        }

        public Shops Shop
        {
            get => default;
            set
            {
            }
        }

        public string Status
        {
            get => default;
            set
            {
            }
        }

        public virtual void CreateOrder()
        {
            throw new System.NotImplementedException();
        }
    }
}