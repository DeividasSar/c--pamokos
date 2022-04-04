using System;

namespace Pinigu_konvertavimo_sistema
{
    class Global
    {
        public static string[] _valiutuNames = { "EUR", "USD", "PLN", "BYR" };  
        public static decimal[] _valiutuKursai = { 1m, 1.11m, 4.66m, 3.61m };  
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Valiutu kursai online
            //List<Rate> rates = new List<Rate>();
            //var doc = new XmlDocument();
            //doc.Load(@"http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            //XmlNodeList nodes = doc.SelectNodes("//*[@currency]");

            //if (nodes != null)
            //{
            //    foreach (XmlNode node in nodes)
            //    {
            //        var rate = new Rate()
            //        {
            //            Currency = node.Attributes["currency"].Value,
            //            Value = Decimal.Parse(node.Attributes["rate"].Value, NumberStyles.Any, new CultureInfo("en-Us"))
            //        };
            //        rates.Add(rate);
            //    }
            //}
            #endregion
           
            string valiutuKeitimasIs;
            string valiutuKeitimasI;
            decimal keitimoKursasPirmas;
            decimal keitimoKursasAntras;
            do
            {
                Console.WriteLine("Įveskite kokią valiutą norite konvertuoti (EUR, USD, PLN, BYR)");
                valiutuKeitimasIs = Console.ReadLine();
                keitimoKursasPirmas = ValiutuKursuPavadinimai(valiutuKeitimasIs);
                Console.Clear();
            } 
            while (keitimoKursasPirmas == 0);
            do
            {
                Console.WriteLine("Įveskite į kokią valiutą norite konvertuoti (EUR, USD, PLN, BYR)");
                valiutuKeitimasI = Console.ReadLine();
                keitimoKursasAntras = ValiutuKursuPavadinimai(valiutuKeitimasI);
                if (valiutuKeitimasIs == valiutuKeitimasI)
                {
                    Console.WriteLine("Negalima konvertuoti tų pačių valiutų. Bandykite dar kartą");
                    return;
                }
                Console.Clear();
            }
            while (keitimoKursasAntras == 0);
            {
                decimal keitimoKursas = keitimoKursasAntras / keitimoKursasPirmas;
                decimal keiciamuPiniguKiekis = ValiutuKursuKiekis(valiutuKeitimasIs);
                Console.WriteLine($"Jūs turite:  {keiciamuPiniguKiekis * keitimoKursas} {valiutuKeitimasI}");
            }
        }
            private static decimal ValiutuKursuPavadinimai(string valiutuKeitimasIs)
            {
                for (int i = 0; i < Global._valiutuNames.Length; i++)
                {
                    if (valiutuKeitimasIs.ToUpper() == Global._valiutuNames[i])
                    {
                        return Global._valiutuKursai[i];
                    }
                }
                return 0;
            }
            private static decimal ValiutuKursuKiekis(string valiutuKeitimasIs)
        {
            Console.WriteLine($"Įveskite kiek norite pakeisti {valiutuKeitimasIs}: ");
            return Convert.ToDecimal(Console.ReadLine());

        }

        
    }
}
