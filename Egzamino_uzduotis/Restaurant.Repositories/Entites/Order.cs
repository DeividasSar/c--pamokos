using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Repositories.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Pcs { get; set; }
        public string Status { get; set; }
        public Order(string[] item)
        {
            Id = Convert.ToInt32(item[0]);
            Name = item[1];
            Price = Convert.ToDecimal(item[2]);
            Pcs = Convert.ToInt32(item[3]);
            Status = item[4];

        }
    }
}
