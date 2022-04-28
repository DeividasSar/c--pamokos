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
            

            var bagRepository = new BagRepository();             // butina norint patestuoti BagRepository
            var customerRepository = new CustomerRepository();

            
            
            bagRepository.Retrieve();                           //Pasiimam is repo
            List<Bag> bags = new List<Bag>();                   




            //customerRepository.CustomerList();
            

        }

          

      







    }
       
    
}
