using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class District
    {
        public Guid DistrictId { get; set; }

        public string Name { get; set; }

        public ICollection<County> Counties { get; set; }

        public Country Country { get; set; }
    }
}