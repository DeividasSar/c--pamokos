using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.BusinessLogic
{
    public class ShoppingCart
    {
        public BagRepository BagRepository { get; set; }
        public CustomerRepository CustomerRepository { get; set; }
        public ShoppingCart() { }
        public ShoppingCart (BagRepository bagRepository, CustomerRepository customerRepository)
        {
            BagRepository = bagRepository;
            CustomerRepository = customerRepository;
        }


        


    }
}
