using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using E_Shop;
using E_Shop.Common;

namespace E_Shop.BusinessLogic
{
    public class LoginToExistingAcount
    {
        public LoginToExistingAcount()
        { }
        private string LoginPasword;
        


        public bool E_ShopMenuLogin()
        {
            Console.Clear();
            Console.WriteLine("Prašome įvesti prisijungimo duomenis: \nVartotojo vardas:");
            string name = Console.ReadLine();
            Globals._LoginName = FindExistingCustomerLogin(name);
            if (Globals._LoginName == name)
            {
                Console.WriteLine("Įveskite slaptažodį:  ");
                string pasword = Console.ReadLine();
                LoginPasword = FindExistingCustomerLogin(pasword);

                if (LoginPasword == pasword)     //SĖKMINGAS PRISIJUNGIMAS
                {
                    GoodInput();
                    return true;
                }
                else
                {
                    BadInput();
                    return false;
                }
            }
            else
            {
                BadInput();
                return false;
            }
        }
        private static void BadInput()
        {
            Console.WriteLine("Neteisingas vartotojo vardas arba slaptažodis. Bandykite dar kartą.");
            Console.ReadLine();
        }
        private static void GoodInput()
        {
            Console.WriteLine("Sveikinu sėkmingai prisijungus prie kuprinių E-Shop ! [Enter] - tęsti");
            Console.ReadLine();
        }
        public static string FindExistingCustomerLogin(string name)
        {
            var customerRepository = new CustomerRepository();
            foreach (var item in customerRepository.GetByCustomerLoginName(name))
            {
                Globals._LoginName = item.LoginName;
            }
            return Globals._LoginName;
        }
     

    }
}
