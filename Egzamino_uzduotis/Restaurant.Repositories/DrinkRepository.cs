using Restaurant.Common;
using Restaurant.Repositories.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Repositories
{
    public class DrinkRepository
    {
        public List<Drink> Drinks { get; set; }
        public DrinkRepository()
        {
            FileReaderService reader = new FileReaderService();
            Drinks = new List<Drink>();

            var csvPath = @"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Drinks.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Drinks.Add(new Drink(value));
                }
            }
        }
        public void MealList()
        {
            Console.Clear();
            Console.WriteLine($"{"ID",10}" + "\t" + $"{"Pavadinimas",10}" + "\t" + $"{"Kaina",10}");
            foreach (var item in Drinks)
            {
                Console.WriteLine($"{item.Id,10}" + "\t" + $"{item.Name,10}" + "\t" + $"{item.Price,10}");
            }

        }
        public List<Drink> GetByItemId(decimal id)
        {
            return Drinks.Where(x => x.Id == id).ToList();
        }

    }
}
