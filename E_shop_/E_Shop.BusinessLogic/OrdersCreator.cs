using E_Shop.Common;
using E_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.BusinessLogic
{
   public class OrdersCreator
    {
        public OrdersCreator()
        { }
        public void E_ShopMenuLoggedIn()
        {
            bool done = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"E-parduotuvė - Rankų darbo kuprinės.   Prisijungęs: {Globals._LoginName}");
                Console.WriteLine("[1] Parduodamos kuprinės \n[2] Užsakymo report \n[0] Išeiti iš meniu ");
                int choose_3 = InputIsNumber();
                switch (choose_3)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        ParduodamosKuprines();
                        break;
                    case 2:
                        Uzsakymai();
                        break;
                    default:
                        BadInput();
                        break;
                }
            }
            while (done);
        }
        private static void ParduodamosKuprines()
        {
            Console.Clear();
            Console.WriteLine("Parduodamos kuprinės:");
            Console.WriteLine("Pavadinimas | Prekės Id | Spalva | Tipas | Kaina | Medžiaga | Kam | Kiekis");
            var bagRepository = new BagRepository();
            bagRepository.BagList();
            Console.WriteLine("Įveskite norimos kuprinės Prekės Id: ");
            Globals._ItemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūs pasirinkote:");
            decimal InStock = 0;
            string Name = null;
            decimal Price = 0;
            foreach (var item in bagRepository.GetByItemId(Globals._ItemId))
            {
                Console.WriteLine($"{item.Name} {item.ItemId} {item.Color} {item.Type} {item.Price} {item.Material} {item.Whom} {item.InStock}");
                InStock = item.InStock;
                Name = item.Name;
                Price = item.Price;
            }
            Console.WriteLine("Kiek vnt norite užsakyti:");
            Globals._order = Convert.ToDecimal(Console.ReadLine());
            if (InStock >= Globals._order)
            {

                Console.WriteLine($"Sveikiname, jūs įsigijote {Globals._order} vnt. {Name} kuprinių, po {Price} eur. ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Kuprinių likutis {InStock} nepakankamas. [Enter] - grizti i pradini menu");
                Console.ReadLine();
            }



        }
        private static void Uzsakymai()
        {
            string Name = null;
            string Color = null;
            decimal Price = 0;
            int OrderId = 0;
            string Address = null;
            string Delivery = null;
            string Payment = null;

            if (Globals._order != 0)
            {
                var bagRepository = new BagRepository();
                foreach (var item in bagRepository.GetByItemId(Globals._ItemId))
                {
                    Name = item.Name;
                    Color = item.Color;
                    Price = item.Price;
                }
                Console.WriteLine("Jūs užsakėte:  ");
                Console.WriteLine($"Kuprinės pavadinimas: {Name}");
                Console.WriteLine($"Kuprinės spalva: {Color}");
                Console.WriteLine($"Kuprinės kaina: {Price}");
                var customerRepository = new CustomerRepository();
                foreach (var item in customerRepository.GetByCustomerLoginName(Globals._LoginName))
                {
                    OrderId = item.OrderId;
                    Address = item.Address;
                    Delivery = item.Delivery;
                    Payment = item.Payment;
                }
                Console.WriteLine($"Užsakymo numeris: {OrderId}");
                Console.WriteLine($"Pristatymo adresas: {Address}");
                Console.WriteLine($"Pristatymo būdas: {Delivery}");
                Console.WriteLine($"Mokėjimas: {Payment}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Užsakymų šiuo metu nėra...");
                Console.ReadLine();
            }

        }
        public static int InputIsNumber()
        {
            int num;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out num));
            {
                int OnlyNum = num;
                return OnlyNum;
            }
        }
        public static void BadInput()
        {
            Console.WriteLine("Blogas input, bandykite dar kartą");
        }
    }
}
