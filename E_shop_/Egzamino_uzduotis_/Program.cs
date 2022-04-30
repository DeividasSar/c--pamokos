using E_Shop.Repositories;
using E_Shop.Repositories.Entities;
using System;
using System.Collections.Generic;

namespace Egzamino_uzduotis_
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region testai
            var bagRepository = new BagRepository();             // butina norint patestuoti BagRepository pasiimti pradinius duomenis is excel
            var customerRepository = new CustomerRepository();

            //bagRepository.GetByItemId(2);                           //Pasiimam is repo

            //List<Bag> bags = new List<Bag>();

            //foreach (var item in customerRepository.GetByItemId(2))
            //{
            //    Console.WriteLine($"{item.Name} {item.OrderId} {item.PhoneNumber} {item.Address} {item.ItemId} {item.Delivery} {item.Payment} {item.LoginName} {item.LoginPasword} ");
            //}
            #endregion

            
            //foreach (var item in customerRepository.GetByCustomerLoginName("Jonas"))
            //{
            //    Console.WriteLine($"{item.Name} {item.OrderId} {item.PhoneNumber} {item.Address} {item.ItemId} {item.Delivery} {item.Payment} {item.LoginName} {item.LoginPasword} ");
            //}
            //Console.ReadLine();

            bool done = true;
            do
            {
                

                E_ShopMenuStart();
                int choose_1 = InputIsNumber();
                switch (choose_1)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        if (E_ShopMenuLogin() == true)
                        {
                            Console.WriteLine("Sveikinu sėkmingai prisijungus prie kuprinių E-Shop !");
                            //MENIU KAI ESI PRISIJUNGES
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        E_ShopMenuRegistration();
                        //registracija
                        break;
                    case 3:
                        AdminMenu();
                        // admin meniu
                        break;
                    default:
                        BadInput();
                        break;
                }

            }
            while (done);





        }









        public static void E_ShopMenuStart()
        {
            Console.Clear();
            Console.WriteLine("Sveiki atvykę į Rankų darbo kuprinių E-parduotuvę!");
            Console.WriteLine("[1] Prisijungi");
            Console.WriteLine("[2] Registruotis");
            Console.WriteLine("[3] Admin");
            Console.WriteLine("[0] Išeiti iš meniu ");
        }
        public static bool E_ShopMenuLogin()
        {
            Console.Clear();
            Console.WriteLine("Prašome įvesti prisijungimo duomenis:");
            Console.WriteLine("Vartotojo vardas:");
            string name = Console.ReadLine();
            string LoginName = null;
            var customerRepository = new CustomerRepository();
            foreach (var item in customerRepository.GetByCustomerLoginName(name))
            {
                LoginName = item.LoginName;
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
                    return true;
                }
                else
                {
                    Console.WriteLine("Neteisingas vartotojo vardas arba slaptažodis. Bandykite dar kartą.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Neteisingas vartotojo vardas arba slaptažodis. Bandykite dar kartą.");
                Console.ReadLine();
                return false;
            }
        }
        public static void E_ShopMenuRegistration ()
        {
            Console.Clear();
            Console.WriteLine("Naujo vartotojo registracija ");
            Console.WriteLine("Vardas ir Pavardė: ");
            Console.WriteLine("Generated Id: ");
            Console.WriteLine("Telefono Nr.: ");
            Console.WriteLine("Adresas: ");
            Console.WriteLine("Default item Id: 0 ");
            Console.WriteLine("Default pristatymas: Pastomatas");
            Console.WriteLine("Default apmokėjimas: Pavedimu");
            Console.WriteLine("Vartotojo vardas: ");
            Console.WriteLine("Slaptažodis: ");

        }
        public static void E_ShopMenuLoggedIn()
        {
            Console.Clear();
            Console.WriteLine("E-parduotuvė - Rankų darbo kuprinės");
            Console.WriteLine("[1] Parduodamos kuprinės");
            Console.WriteLine("[2] Pirkinių krepšelis");
            Console.WriteLine("[3] Mano užsakymai");
            Console.WriteLine("[4] Admin");
            Console.WriteLine("[0] Išeiti iš meniu ");
        }
        public static void ManoUzsakymaiMenu()
        {
            Console.Clear();
            
        }
        public static void  AdminMenu()
        {
            Console.Clear();
            Console.WriteLine("Admin Menu: ");
            Console.WriteLine("[1] Įdėti naujų kuprinių" );
            Console.WriteLine("[2] Ištrinti kuprines iš E-parduotuvės");
            Console.WriteLine("[3] Atnaujinti resource excelius");
            Console.WriteLine("[4] Ataskaita");
            Console.WriteLine("[0] Išeiti iš meniu ");

        }
        public static void BadInput()
        {
            Console.WriteLine("Blogas input, bandykite dar kartą");
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
    }
       
    
}
