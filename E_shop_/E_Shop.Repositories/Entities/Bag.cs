using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.Repositories.Entities
{
    public class Bag                            //created new Bag class
    {
        public string Name { get; set; }
        public decimal ItemId { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Material { get; set; }
        public string Whom { get; set; }

        public Bag (string[] item)
        {
            Name = item[0];
            ItemId = Convert.ToDecimal(item[1]);
            Color = item[2];
            Type = item[3];
            Price = Convert.ToDecimal(item[4]);
            Material = item[5];
            Whom = item[6];

        }

    }
}
