using Lucene.Net.Support;
using Restaurant.Common;
using Restaurant.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BusinessLogic
{
    public class TableCheckIn
    {
        public TableCheckIn()
        {}
        public static void TableMenu()
        {
            bool done = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Jūs pasirinkote staliuką:");
                Console.WriteLine($"{"Staliuko Nr.",10}" + "\t" + $"{"Vietų sk.",10}" + "\t" + $"{"Užimtumas",10}");
                ChoosenTable();
                Console.WriteLine("Staliuko MENIU: \n [1] Rezervuoti \n [2] Atlaisvinti/Atsiskaitymas \n [3] Patiekalų meniu \n [4] Gėrimų meniu \n [5] Užsakymo informacija \n [0] Išeiti");
                int choose_1 = OrdersCreator.InputIsNumber();
                switch (choose_1)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        TableReservation.TableReservations(Globals._TableNumber, Globals._TableSeats, "Rezervuotas"); //Rezervuoti
                        break;
                    case 2:
                        TableReservation.TableReservations(Globals._TableNumber, Globals._TableSeats, "Laisvas"); //Atlaisvinimas atsiskaitymas
                        break;
                    case 3:
                        var mealRepository = new MealRepository();
                        mealRepository.MealList(); //Patiekalu meniu
                        MealOutput();              //Uzsakytas maistas kiekis
                        OrderDatabase.AddOrder(Globals._MealId, Globals._MealName, Globals._MealPrice, Globals._MealPcs); //Iraso į database
                        break;
                    case 4:
                        //Gėrimu meniu
                        break;
                    case 5:
                        //Uzsakymo informacija
                        break;
                    default:
                        OrdersCreator.BadInput();
                        break;
                }

            } while (done);
        }
        public static void ChoosenTable()
        {
            ChoosenTableOutput();
            Console.WriteLine($"{Globals._TableNumber,10}" + "\t" + $"{Globals._TableSeats,10}" + "\t" + $"{Globals._TableFreeOrTaken,10}");
        }
       public static void ChoosenTableOutput()
        {
            var tableRepository = new TableRepository();
            foreach (var item in tableRepository.GetByItemId(Globals._TableNumber))
            {
                Globals._TableNumber = item.Number;
                Globals._TableSeats = item.Seats;
                Globals._TableFreeOrTaken = item.FreeOrTaken;
            }
        }
        public static void MealOutput()
        {
            Console.WriteLine("Pasirinkite patiekalą: ");
            Globals._MealId = OrdersCreator.InputIsNumber();
            var mealRepository = new MealRepository();
            Console.WriteLine("Jūsų pasirinktas patiekalas:");
            foreach (var item in mealRepository.GetByItemId(Globals._MealId))
            {
                Globals._MealName = item.Name;
                Globals._MealPrice = item.Price;
                Console.WriteLine($"{Globals._MealId,10}" + "\t" + $"{Globals._MealName,10}" + "\t" + $"{Globals._MealPrice,10}");
            }
            Console.WriteLine("Įveskite kiekį:");
            Globals._MealPcs = OrdersCreator.InputIsNumber();
        }
    }
}
