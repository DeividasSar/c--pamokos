using E_Shop.Common;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> Customers { get; set; }
        public CustomerRepository()
        {
            FileReaderService reader = new FileReaderService();
            Customers = new List<Customer>();

            var csvPath = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Customers.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Customers.Add(new Customer(value));
                }
            }

        }
        public void CustomerList()
        {
            foreach (var item in Customers)
            {
                Console.WriteLine($"{item.Name} {item.OrderId} {item.PhoneNumber} {item.Address} {item.ItemId} {item.Delivery} {item.Payment}");
            
            }
        }
    }
}
