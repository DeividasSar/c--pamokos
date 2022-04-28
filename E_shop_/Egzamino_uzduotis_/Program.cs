using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace Egzamino_uzduotis_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Kaip pasitikrinti bad list repo cia?

            var bagRepository = new BagRepository();             // butina norint patestuoti BagRepository
            var CustomerRepository = new CustomerRepository();
            bagRepository.BagList();
            

        }

          

      







    }
       
    
}
