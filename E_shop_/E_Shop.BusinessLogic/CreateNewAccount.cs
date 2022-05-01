using E_Shop.Common;
using E_Shop.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Shop.BusinessLogic
{
    public class CreateNewAccount
    {
        public CreateNewAccount()
        { }

        public void E_ShopMenuRegistration()
        {
            Console.Clear();
            var customerRepository = new CustomerRepository();
            Console.WriteLine("Naujo vartotojo registracija. Įveskite: \n Vardą ir Pavardę:");
            string Name = Console.ReadLine();
            Random rnd = new Random();
            int OrderId = rnd.Next(16000, 17000);
            Console.WriteLine("Telefono Nr.: ");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adresą: ");
            string Address = Console.ReadLine();
            int ItemId = 0;                                          
            string Delivery = "Pastomatas";
            string Payment = "Pavedimu";
            Console.WriteLine("Vartotojo vardą: ");
            string LoginName = Console.ReadLine();
            Console.WriteLine("Slaptažodį: ");
            string LoginPasword = Console.ReadLine();
            RegistrationConfirmation();
            var addCustomerToCSV = new AddCustomerToCSV();

            addCustomerToCSV.AddCustomerToCsv(Name, OrderId, PhoneNumber, Address, ItemId, Delivery, Payment, LoginName, LoginPasword);
        }
        public static void RegistrationConfirmation()
        {
            Console.WriteLine("Spauskite [Enter] registracijos pabaigimui");
            Console.ReadLine();
        }
    }
}
