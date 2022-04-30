using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using E_Shop.Common;

namespace E_Shop.Repositories
{
   public class BagRepository
    {
       public List<Bag> Bags { get; set; }
       public BagRepository ()
        {
            FileReaderService reader = new FileReaderService();
            Bags = new List<Bag>();
    
            var csvPath = @"C:\Users\Win 10\Desktop\.NET_mokymai\C#\13_tema_egzaminas\bag's\Bags.csv";
            var data = reader.ReadFile(csvPath);
            {
                foreach (var value in data)
                {
                    Bags.Add(new Bag(value));
                }
            }
        }

        public void BagList()
        {
            foreach (var item in Bags)
            {
                Console.WriteLine($"{item.Name} {item.ItemId} {item.Color} {item.Type} {item.Price} {item.Material} {item.Whom}");
            }
        }

        public List<Bag> Retrieve ()
        {
            return Bags;
        }
        public List<Bag> GetByItemId(int id)
        {
            return Bags.Where(x => x.ItemId == id).ToList();
        }

       

    }
}
