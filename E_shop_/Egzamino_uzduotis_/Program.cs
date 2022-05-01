using E_Shop.Common;
using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using E_Shop.BusinessLogic;

namespace Egzamino_uzduotis_
{
  
    public class Program
    {
        static void Main(string[] args)
        {
            var loginToExistingAccount = new LoginToExistingAcount();
            var createNewAccount = new CreateNewAccount();
            var addNewBags = new AddNewBags();
            var ordersCreator = new OrdersCreator();

            bool done = true;
            do
            {
                E_ShopMenuStart();
                int choose_1 = OrdersCreator.InputIsNumber();
                switch (choose_1)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        if (loginToExistingAccount.E_ShopMenuLogin() == true)
                        {
                            ordersCreator.E_ShopMenuLoggedIn();        
                        }
                        break;
                    case 2:
                        createNewAccount.E_ShopMenuRegistration();
                        break;
                    case 3:
                        AdminMenu();
                        break;
                    default:
                        OrdersCreator.BadInput();
                        break;
                }
            }
            while (done);
        }

        public static void E_ShopMenuStart()
        {
            Console.Clear();
            Console.WriteLine("Sveiki atvykę į Rankų darbo kuprinių E-parduotuvę! \n [1] Prisijungi \n [2] Registruotis \n [3] Admin \n [0] Išeiti iš meniu ");
        }
        public static void  AdminMenu()
        {
            
            bool done = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Admin Menu: \n [1] Įdėti naujų kuprinių \n [0] Išeiti iš meniu ");
                int choose_2 = OrdersCreator.InputIsNumber();
                switch (choose_2)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        AddNewBags.IdetiNaujuKupriniuMenu();
                        break;
                    default:
                        OrdersCreator.BadInput();
                        break;
                }
            }
            while (done);
        }
    }
}
       
    

