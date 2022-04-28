using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.BusinessLogic
{
    public class ShoppingCart
    {
        BagRepository bagRepository = new BagRepository();
        private readonly List<Bag> Bags = new List<Bag>();

    }
}
