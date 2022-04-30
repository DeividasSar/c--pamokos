using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.Repositories.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public int OrderId { get; set;}
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ItemId { get; set; }
        public string Delivery { get; set; }
        public string Payment { get; set; }
        public string LoginName { get; set; }
        public string LoginPasword { get; set; }

        public Customer (string [] item)
        {
            Name = item[0];
            OrderId = Convert.ToInt32(item[1]);
            PhoneNumber = Convert.ToInt32(item[2]);
            Address = item[3];
            ItemId = Convert.ToInt32(item[4]);
            Delivery = item[5];
            Payment = item[6];
            LoginName = item[7];
            LoginPasword = item[8];
        }

    }
}
