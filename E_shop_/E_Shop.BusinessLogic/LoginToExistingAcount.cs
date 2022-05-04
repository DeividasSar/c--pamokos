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
        


        public bool E_ShopMenuLogin()
        {
            Console.Clear();
            Console.WriteLine("Prašome įvesti prisijungimo duomenis: \n Vartotojo vardas:");
            string name = Console.ReadLine();
            string LoginName = null;
            var customerRepository = new CustomerRepository();
            foreach (var item in customerRepository.GetByCustomerLoginName(name))
            {
                Globals._LoginName = LoginName = item.LoginName;
            }
            if (LoginName == name)
            {
                Console.WriteLine("Įveskite slaptažodį:  ");
                string pasword = Console.ReadLine();
                string LoginPasword = null;
                foreach (var item in customerRepository.GetByCustomerLoginPasword(pasword))
                {
                    LoginPasword = item.LoginPasword;
                }
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
     

    }
}
