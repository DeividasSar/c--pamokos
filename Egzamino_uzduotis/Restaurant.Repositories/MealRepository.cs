using Restaurant.Common;
using Restaurant.Repositories.Entites;
using Restaurant.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Repositories
{
    public class MealRepository : IRepository
    {
        public List<Meal> Meals { get; set; }
        public MealRepository()
        {
            FileReaderService reader = new FileReaderService();
            Meals = new List<Meal>();

            var csvPath = @"G:\.NET_mokymai\C#\Advanced_level\Egzamino_uzduotis\data\Meals.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Meals.Add(new Meal(value));
                }
            }
        }
        public void ItemsList()
        {
            Console.Clear();
            Console.WriteLine($"{"ID",10}" + "\t" + $"{"Pavadinimas",10}" + "\t" + $"{"Kaina",10}");
            foreach (var item in Meals)
            {
                Console.WriteLine($"{item.Id,10}" + "\t" + $"{item.Name,10}" + "\t" + $"{item.Price,10}");
            }

    }
        public List<Meal> GetByItemId(decimal id)
        {
            return Meals.Where(x => x.Id == id).ToList();
        }

    }
}
