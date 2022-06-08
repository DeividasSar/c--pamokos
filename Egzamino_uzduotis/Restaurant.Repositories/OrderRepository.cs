using Restaurant.Common;
using Restaurant.Repositories.Entites;
using Restaurant.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Repositories
{
    public class OrderRepository : IRepository
    {
        public List<Order> Orders { get; set; }
        public OrderRepository()
        {
            FileReaderService reader = new FileReaderService();
            Orders = new List<Order>();

            string table = Convert.ToString(Globals._TableNumber);
            var csvPath = @$"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables\{table}.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                   Orders.Add(new Order(value));
                   Globals._TableSum = Orders.Sum(x => x.Price*x.Pcs);

                }
            }
        }

        public void ItemsList()
        {
            Console.Clear();
            Console.WriteLine($"{"ID",10}" + "\t" + $"{"Pavadinimas",10}" + "\t" + $"{"Kaina",10}" + "\t" + $"{"Kiekis",10}" + "\t" + $"{"Statusas",10}");
            foreach (var item in Orders)
            {
                Console.WriteLine($"{item.Id,10}" + "\t" + $"{item.Name,10}" + "\t" + $"{item.Price,10}" + "\t" + $"{item.Pcs,10}" + "\t" + $"{item.Status,10}");
                Globals._OrderId = item.Id;
                Globals._OrderName = item.Name;
                Globals._OrderPrice = item.Price;
                Globals._OrderPcs = item.Pcs;
                Globals._OrderStatus = item.Status;

            }
    
    }
    }
}
