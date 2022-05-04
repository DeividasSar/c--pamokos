using E_Shop.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.BusinessLogic
{
    public class AddNewBags
    {
        public AddNewBags()
        { }

        public static void IdetiNaujuKupriniuMenu()
        {
            Console.Clear();
            Console.WriteLine("Naujų kuprinių pridėjimas į E-Shop. Įveskite: \n Kuprinės pavadinimą:");
            string Name = Console.ReadLine();
            Console.WriteLine("Kuprinės ID:");
            int ItemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kuprinės spalva:");
            string Color = Console.ReadLine();
            Console.WriteLine("Kuprinės tipas: (Rankinė/Kuprinė ar kt.)");
            string Type = Console.ReadLine();
            Console.WriteLine("Kuprinės kaina: ");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kuprinės medžiaga: ");
            string Material = Console.ReadLine();
            Console.WriteLine("Kam skirta: (Jam/Jai)");
            string Whom = Console.ReadLine();
            Console.WriteLine("Kiekis: ");
            int InStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Spauskite [Enter] naujos kuprinės pridėjimui");
            Console.ReadLine();
            var addBagToCSV = new AddBagToCSV();

            addBagToCSV.AddBagToCsv(Name, ItemId, Color, Type, Price, Material, Whom, InStock);

        }
        
    }
}
