using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Bilietavimo_sistema
{
    class Global
    {
        public static int visoSukurta10 = 0;
        public static int visoSukurta20 = 0;
        public static int visoSukurta30 = 0;
        public static int visoParduota10 = 0;
        public static int visoParduota20 = 0;
        public static int visoParduota30 = 0;
        public static int likutis10 = 0;
        public static int likutis20 = 0;
        public static int likutis30 = 0;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> bilietai10 = new List<int>();
            List<int> bilietai20 = new List<int>();
            List<int> bilietai30 = new List<int>();

            bool done = true;
            do
            {
                BilietuMenu();
                int pasirinkimas1 = InputIsNumber1();
                switch (pasirinkimas1)
                {
                    case 0:
                        done = false;
                        break;
                    case 1:
                        BilietuPirkimas(); 
                        BilietuPirkimasSwitch(bilietai10, bilietai20, bilietai30);
                        break;
                    case 2:
                        BilietuKurimas();
                        BilietuKurimasSwitch(bilietai10, bilietai20, bilietai30);
                        break;
                    case 3:
                        AtaskaitaMenu();
                        AtaskaitaSwitch();
                        break;
                    default:
                        BadInput();
                        break;
                }

                Global.likutis10 = bilietai10.Count;
                Global.likutis20 = bilietai20.Count;
                Global.likutis30 = bilietai30.Count;
                Console.ReadLine();
            }
            while (done);

        }
        public static void BilietuMenu()
        {
            Console.Clear();
            Console.WriteLine("Bilietų menu:");
            Console.WriteLine("[1] Pirkti bilietus");
            Console.WriteLine("[2] Kurti bilietus");
            Console.WriteLine("[3] Ataskaita");
            Console.WriteLine("[0] Išeiti iš meniu ");
        }
        public static void BadInput()
        {
            Console.WriteLine("Blogas input, bandykite dar kartą");
            
        }

        public static void BilietuPirkimas()
        {
            Console.Clear();
            Console.WriteLine("Bilietų pirkimas");
            Console.WriteLine("[1] Eko (10eu)");
            Console.WriteLine("[2] Standart (20eu)");
            Console.WriteLine("[3] Premium (30eu)"); 
        }
        public static void BilietuKurimas()
        {
            Console.Clear();
            Console.WriteLine("Bilietų kūrimas");
            Console.WriteLine("[1] Eko (10eu)");
            Console.WriteLine("[2] Standart (20eu)");
            Console.WriteLine("[3] Premium (30eu)");
        }
        public static void AtaskaitaMenu()
        {
            Console.Clear();
            Console.WriteLine("ATASKAITA");
            Console.WriteLine("[1] Bilietų pardavimo ataskaita");
            Console.WriteLine("[2] Bilietų kūrimo ataskaita");
            Console.WriteLine("[3] Nepanaudoti bilietai");
        }
        public static void AtaskaitaSwitch()
        {
            int pasirinkimas2 = InputIsNumber2();
            switch (pasirinkimas2)
            {
                case 1:
                    BilietuPardavimuAtaskaita();
                    break;
                case 2:
                    BilietuKurimuAtaskaita();
                    break;
                case 3:
                    NepanaudotiBilietai();
                    break;
                default:
                    BadInput();
                    break;
            }
        }
        public static void BilietuPardavimuAtaskaita ()
        {
            Console.Clear();
            Console.WriteLine("Viso parduota bilietų: ");
            Console.WriteLine("");
            Console.WriteLine($"Eko (10eu): {Global.visoParduota10}");
            Console.WriteLine($"Standart (20eu): {Global.visoParduota20}");
            Console.WriteLine($"Premium (30eu): {Global.visoParduota30}");
            Console.WriteLine("");
            Console.WriteLine($"Total: {Global.visoParduota10 + Global.visoParduota20 + Global.visoParduota30}");
            Console.WriteLine("[ENTER] Tęsti ");
        }
        public static void BilietuKurimuAtaskaita()
        {
            Console.Clear();
            Console.WriteLine("Viso sukurta bilietų: ");
            Console.WriteLine("");
            Console.WriteLine($"Eko (10eu): {Global.visoSukurta10}");
            Console.WriteLine($"Standart (20eu): {Global.visoSukurta20}");
            Console.WriteLine($"Premium (30eu): {Global.visoSukurta30}");
            Console.WriteLine("");
            Console.WriteLine($"Total: {Global.visoSukurta10 + Global.visoSukurta20 + Global.visoSukurta30}");
            Console.WriteLine("[ENTER] Tęsti ");
        }
        public static void NepanaudotiBilietai ()
        {
            Console.Clear();
            Console.WriteLine("Nepanaudoti bilietai: ");
            Console.WriteLine("");
            Console.WriteLine($"Eko (10eu): {Global.likutis10}");
            Console.WriteLine($"Standart (20eu): {Global.likutis20}");
            Console.WriteLine($"Premium (30eu): {Global.likutis30}");
            Console.WriteLine("");
            Console.WriteLine($"Total: {Global.likutis10 + Global.likutis20 + Global.likutis30}");
            Console.WriteLine("[ENTER] Tęsti ");
        }

        public static int InputIsNumber1()     
        {
            int sk;
            do
            {
             

            }
            while (!int.TryParse(Console.ReadLine(), out sk));
            {
                int tikSkaiciai = sk;
                return tikSkaiciai;
            }
        }
        public static int InputIsNumber2()     
        {
            int sk;
            do
            {
                
            }
            while (!int.TryParse(Console.ReadLine(), out sk));
            {
                int tikSkaiciai = sk;
                return tikSkaiciai;
            }

        }
        public static int InputIsNumber3()     
        {
            int sk;
            do
            {
                
            }
            while (!int.TryParse(Console.ReadLine(), out sk));
            {
                int tikSkaiciai = sk;
                return tikSkaiciai;
            }

        }

        public static void KurtiBilietus10( List<int> bilietai10)
        {
            Console.WriteLine("Kiek sukurti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            for (int i = 0; i < bilietuKiekis; i++)
            {
                bilietai10.Add(1);
            }
            Global.visoSukurta10 = Global.visoSukurta10 + bilietuKiekis;
            Console.Clear();
        }
        public static void KurtiBilietus20( List<int> bilietai20)
        {
            Console.WriteLine("Kiek sukurti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            for (int i = 0; i < bilietuKiekis; i++)
            {
                Console.WriteLine("Kiek sukurti bilietų?:  ");
                bilietai20.Add(1);
            }
            Global.visoSukurta20 = Global.visoSukurta20 + bilietuKiekis;
            Console.Clear();

        }
        public static void KurtiBilietus30( List<int> bilietai30)
        {
            Console.WriteLine("Kiek sukurti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            for (int i = 0; i < bilietuKiekis; i++)
            {
                Console.WriteLine("Kiek sukurti bilietų?:  ");
                bilietai30.Add(1);
            }
            Global.visoSukurta30 = Global.visoSukurta30 + bilietuKiekis;
            Console.Clear();

        }

        public static void PirktiBilietus10( List<int> bilietai10)
        {
            Console.WriteLine("Kiek nupirkti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            if (Global.likutis10 >= bilietuKiekis)
            {
                for (int i = 0; i < bilietuKiekis; i++)
                {
                    bilietai10.Remove(1);
                }
                Global.visoParduota10 = Global.visoParduota10 + bilietuKiekis;
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Bilietų likutis {Global.likutis10} per mažas. Prašome sukurti papildomų bilietų");
            }
        }
        public static void PirktiBilietus20(List<int> bilietai20)
        {
            Console.WriteLine("Kiek nupirkti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            if (Global.likutis20 >= bilietuKiekis)
            {
                for (int i = 0; i < bilietuKiekis; i++)
            {
                Console.WriteLine("Kiek nupirkti bilietų?:  ");
                bilietai20.Remove(1);
            }
                Global.visoParduota20 = Global.visoParduota20 + bilietuKiekis;
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Bilietų likutis {Global.likutis20} per mažas. Prašome sukurti papildomų bilietų");
            }

        }
        public static void PirktiBilietus30(List<int> bilietai30)
        {
            Console.WriteLine("Kiek nupirkti bilietų?:  ");
            int bilietuKiekis = int.Parse(Console.ReadLine());
            if (Global.likutis30 >= bilietuKiekis)
            {
                for (int i = 0; i < bilietuKiekis; i++)
                        {
                            Console.WriteLine("Kiek nupirkti bilietų?:  ");
                            bilietai30.Remove(1);
                        }
                Global.visoParduota30 = Global.visoParduota30 + bilietuKiekis;
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"Bilietų likutis {Global.likutis30} per mažas. Prašome sukurti papildomų bilietų");
            }
            
        }

        public static void BilietuPirkimasSwitch(List<int> bilietai10, List<int> bilietai20, List<int> bilietai30)
        {
            int pasirinkimas2 = InputIsNumber2();
            switch (pasirinkimas2)
            {
                case 1:
                    PirktiBilietus10(bilietai10);
                    break;
                case 2:
                    PirktiBilietus20(bilietai20);
                    break;
                case 3:
                    PirktiBilietus30(bilietai30);
                    break;
                default:
                    BadInput();
                    break;
            }
            
        }
        public static void BilietuKurimasSwitch(List<int> bilietai10, List<int> bilietai20, List<int> bilietai30)
        {
            
            int pasirinkimas2 = InputIsNumber2();
            switch (pasirinkimas2)
            {
                case 1:
                    KurtiBilietus10(bilietai10);
                    break;
                case 2:
                    KurtiBilietus20(bilietai20);
                    break;
                case 3:
                    KurtiBilietus30(bilietai30);
                    break;
                default:
                    BadInput();
                    break;
            }

        }

        
    }
}
