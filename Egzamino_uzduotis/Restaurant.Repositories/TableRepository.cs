using Restaurant.Common;
using Restaurant.Repositories.Entites;
using Restaurant.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Repositories
{
   public class TableRepository : IRepository
    {
     public List <Table> Tables { get; set; }
     public TableRepository()
        {
            FileReaderService reader = new FileReaderService();
            Tables = new List<Table>();

            var csvPath = @"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Tables.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Tables.Add(new Table(value));
                }
            }
        }
        public void ItemsList ()
        {
            Console.Clear();
            Console.WriteLine($"{"Staliuko Nr.",10}" + "\t" + $"{"Vietų sk.",10}" + "\t" + $"{"Užimtumas",10}");
            foreach (var item in Tables)
            {
                Console.WriteLine($"{item.Number,10}" + "\t" + $"{item.Seats,10}" + "\t" + $"{item.FreeOrTaken,10}");
            }
        }
        public List<Table> GetByItemId(decimal id)
        {
            return Tables.Where(x => x.Number == id).ToList();
        }

    }
}
