using System;
using System.Collections.Generic;

namespace Pamoka_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value type
            //Floatai ir doublai
            //float numFloat = 1F / 3;
            //double numDouble = 1D / 3;

            //if(numFloat == numDouble)
            //{
            //    Console.WriteLine($"skaiciusFloat: {numFloat}, skaiciusDouble {numDouble}");

            //}
            //else
            //{
            //    Console.WriteLine($"skaiciusFloat: {numFloat}, nera lygus skaicius: {numDouble}");
            //}


            //string name = "Jonas";
            //char simbolis = '/';  //charui naudoti viengubas kabutes t.y. vienas simbolis


            ////Stringai ir Char's
            //string name1 = "Jonas";
            //char s = '5';

            ////byte 0 => 255 
            //byte a = 0;
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            //a = 254;
            //a++;

            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);

            ////sbyte -128 => 127
            //sbyte x = 126;
            //x++;
            //x++;
            //x++;

            ////Reference type
            //string lastname = "Jonas";
            //string lastname1 = null;
            //lastname1 = "petras";

            //Human human1 = new Human();
            //human1.Name = "Jonas";

            //List<string> vardai = new List<string>();


            ////Implicit casting
            //byte b = 57;
            //int i = b;
            //long l = i;
            //float f = l;

            //Console.WriteLine($"BYTE: {b}");
            //Console.WriteLine($"INT: {i}");
            //Console.WriteLine($"LONG: {l}");
            //Console.WriteLine($"FLOAT: {f}");


            ////Explicit casting
            //double y = 1234.7D;
            //int o = (int)y;


            //Console.WriteLine(o);


            ////Convert klase
            //int k = 12;
            //double d = 765.12D;
            //float f1 = 56.123F;

            //string convertedString = Convert.ToString(f);
            //int convertedInt = Convert.ToInt32(d);
            //double convertedDouble = Convert.ToDouble(f1);


            // 1. Uzduotis

            //Console.WriteLine("Iveskite atstuma (metrais):");
            //string input1 = Console.ReadLine();
            //double atstumas = Convert.ToDouble(input1);

            //Console.WriteLine("Iveskite laika (sekundemis):");
            //string input2 = Console.ReadLine();
            //double laikas = Convert.ToDouble(input2);

            //double greitis = atstumas / laikas;
            //double kmh = greitis * 3.6;
            //Console.WriteLine($"Greitis km/h: {kmh}");

            // 2. Uzduotis

            //Console.WriteLine("Iveskite kvadrato krastine m (Isveda plota ir turi)");
            //string input1 = Console.ReadLine();
            //double krastine = Convert.ToDouble(input1);

            //double plotas =(krastine*krastine);
            //double plotas2 = Math.Round(plotas,2);
            //double turis = plotas * krastine;
            //double turis2 = Math.Round(turis,2);
            //Console.WriteLine($"Plotas m2: {plotas2}, Turis m3: {turis2}");

            // 3. Uzduotis

            //Console.WriteLine("Iveskite 2 skaicius (Jei abu lyginiai TRUE, jei ne FALSE");

            //Console.WriteLine("1 skaicius:");
            //string input1 = Console.ReadLine();
            //double skaicius1 = Convert.ToDouble(input1);

            //Console.WriteLine("2 skaicius:");
            //string input2 = Console.ReadLine();
            //double skaicius2 = Convert.ToDouble(input2);

            //if (skaicius1 % 2 == 0 && skaicius2 % 2 == 0)
            //{
            //    Console.WriteLine("Abu lyginiai TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("Vienas iš skaičių nelyginis");
            //}

            // 4. Uzduotis

            //Console.WriteLine("Iveskite vartotojo varda (Jonas)");
            //string vardas = Console.ReadLine();


            //string IvestasVardas = "Jonas";
            //string IvestasSlaptazodis = "Stalas123";


            //if (vardas.Equals(IvestasVardas))
            //{
            //    Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //    string input2 = Console.ReadLine();
            //    string slaptazodis = Convert.ToString(input2);
            //    if (slaptazodis.Equals(IvestasSlaptazodis))
            //    {
            //        Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Liko 2 bandymai");
            //        Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //        string input3 = Console.ReadLine();
            //        string slaptazodis2 = Convert.ToString(input3);
            //        if (slaptazodis2.Equals(IvestasSlaptazodis))
            //        {
            //            Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Liko 1 bandymas");
            //            Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //            string input4 = Console.ReadLine();
            //            string slaptazodis3 = Convert.ToString(input4);
            //            if (slaptazodis3.Equals(IvestasSlaptazodis))
            //            {
            //                Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Bandykite kitą kartą...");
            //            }
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Liko 2 bandymai");
            //    Console.WriteLine("Iveskite vartotojo varda (Jonas)");
            //    string input5 = Console.ReadLine();
            //    string vardas2 = Convert.ToString(input5);
            //    if (vardas2.Equals(IvestasVardas))
            //    {
            //        {
            //            Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //            string input2 = Console.ReadLine();
            //            string slaptazodis = Convert.ToString(input2);
            //            if (slaptazodis.Equals(IvestasSlaptazodis))
            //            {
            //                Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Liko 2 bandymai");
            //                string input3 = Console.ReadLine();
            //                string slaptazodis2 = Convert.ToString(input3);
            //                Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //                if (slaptazodis.Equals(IvestasSlaptazodis))
            //                {
            //                    Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Liko 1 bandymas");
            //                    string input4 = Console.ReadLine();
            //                    string slaptazodis3 = Convert.ToString(input4);
            //                    Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //                    if (slaptazodis.Equals(IvestasSlaptazodis))
            //                    {
            //                        Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Bandykite kitą kartą...");
            //                    }
            //                }
            //            }

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Liko 1 bandymas");
            //        Console.WriteLine("Iveskite vartotojo varda (Jonas)");
            //        string input6 = Console.ReadLine();
            //        string vardas3 = Convert.ToString(input6);
            //        if (vardas.Equals(IvestasVardas))
            //        {
            //            {
            //                Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //                string input2 = Console.ReadLine();
            //                string slaptazodis = Convert.ToString(input2);
            //                if (slaptazodis.Equals(IvestasSlaptazodis))
            //                {
            //                    Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Liko 2 bandymai");
            //                    Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //                    if (slaptazodis.Equals(IvestasSlaptazodis))
            //                    {
            //                        Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Liko 1 bandymas");
            //                        Console.WriteLine("Iveskite slaptazodi (Stalas123)");
            //                        if (slaptazodis.Equals(IvestasSlaptazodis))
            //                        {
            //                            Console.WriteLine("Sveikinu, ivedete teisingus prisijungimus");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Bandykite kitą kartą...");
            //                        }
            //                    }
            //                }

            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bandykite kitą kartą...");
            //        }
            //    }
            //}


            // 5 Uzduotis
            //Console.WriteLine("10-zenklio skaiciaus konvertavimas i INT, SHORT ir BYTE");
            //string input1 = Console.ReadLine();
            //double skaicius1 = Convert.ToDouble(input1);
            //int skaicius2 = Convert.ToInt32(skaicius1);
            //short skaicius3 = Convert.ToInt16(skaicius1);
            //byte skaicius4 = Convert.ToByte(skaicius1);
            //Console.WriteLine($"DOUBLE{skaicius1}, INT {skaicius2}, SHORT {skaicius3}, BYTE {skaicius4}");



            // CONDITIONS

            //Console.WriteLine("Iveskite grupes pavadinima");
            //string grupesPavadinimas = Console.ReadLine();

            //Console.WriteLine("Iveskite grupes nariu skaiciu:");
            //string inputas = Console.ReadLine();
            //int nariuSk;
            //bool isValidNum = int.TryParse(inputas, out int nariuSk);
            //int nariuSkaicius = int.Parse(Console.ReadLine());
            //if (!isValidNum)
            //{
            //    Console.WriteLine("Skaicius yra neteisingas");
            //}

            //if(!int.TryParse(Console.ReadLine(), out int nariuSkaicius))
            //{
            //    Console.WriteLine("Ivestas nekorektiskas skaicius");
            //    Environment.Exit(0);
            //}

            //string spalva = Console.ReadLine();

            //if (spalva == "geltona")
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else if (spalva == "zalia")
            //{
            //    Console.WriteLine("Normali spalva");
            //}
            //else if(spalva == "raudona")
            //{
            //    Console.WriteLine("Labai grazi splava");
            //}
            //else
            //{
            //    Console.WriteLine("Nesuprantu, kas cia per spalva");
            //}


            //Console.WriteLine("Koki veiksma norite atlikti?");
            //Console.WriteLine("[1] - istrinti vartotoja, [2] - sukurti vartotoja, [3] - redaguoti esama vartotoja");

            //int veiksmas = int.Parse(Console.ReadLine());

            //if(veiksmas == 1)
            //{
            //    Console.WriteLine("Vartotojas yra istrintas");
            //}
            //else if (veiksmas == 2)
            //{
            //    Console.WriteLine("Vartotojas yra sukurtas");
            //}
            //else if (veiksmas == 3)
            //{
            //    Console.WriteLine("Vartotojas yra paredaguotas");
            //}
            //else
            //{
            //    Console.WriteLine("Nesuprantu komandos");
            //}

            //switch(veiksmas)
            //{
            //    case 1:
            //        Console.WriteLine("Vartotojas yra istrintas");
            //        break;
            //    case 2:
            //        Console.WriteLine("Vartotojas yra sukurtas");
            //        break;
            //    case 3:
            //        Console.WriteLine("Vartotojas yra paredaguotas");
            //        break;
            //    default:
            //        Console.WriteLine("Nesuprantu komandos");
            //        break;
            //}

            //TERNARY OPERATOR


            //string vardas = "Marija";

            //if (vardas == "Marija")
            //{
            //    Console.WriteLine("Marija yra moteris");
            //}
            //else
            //{
            //    Console.WriteLine($"{vardas} yra vyras");
            //}

            //Console.WriteLine(vardas == "Marija" ? "Marija yra moteris" : $"{ vardas} yra vyras");

            // KINTAMIEJI/OPERATORIAI
            // 1 Uzduotis
            //Console.WriteLine("Iveskite grupes nariu kieki");
            //int kiekis = int.Parse(Console.ReadLine());
            //switch (kiekis)
            //{
            //    case 1:
            //        Console.WriteLine("Tai solo atlikejas");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tai duetas");
            //        break;
            //    case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10:
            //        Console.WriteLine("Tai ansamblis");
            //        break;
            //    default:
            //        Console.WriteLine("Tai kamerinis ansamblis");
            //        break;
            //}


            // 2 Uzduotis
            //Console.WriteLine("Iveskite isdirbtas valandas");
            //int valandos = int.Parse(Console.ReadLine());
            //if (valandos < 160)
            //{
            //    var h1 = 160 - valandos;
            //    Console.WriteLine($"Reikia isdirbti {h1}");
            //}
            //else if (valandos == 160)
            //{
            //    Console.WriteLine("Isdirbtas pilnas etatas");
            //}
            //else if (valandos > 160)
            //{
            //    var h2 = valandos - 160;
            //    Console.WriteLine($"Isdirbta virsvalandziu {h2}");
            //}
            //else
            //{
            //    Console.WriteLine("KLAIDA");
            //}


            // 3 Uzduotis
            Console.WriteLine("Iveskite egzamino pazymi");
            int pazymys = int.Parse(Console.ReadLine());

            switch(pazymys)
            {
                case 1: case 2: case 3: case 4:
                    Console.WriteLine("NEPATENKINAMAS");
                    break;
                case 5:
                    Console.WriteLine("SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("VIDUTINISKAI");
                    break;
                case 8:
                    Console.WriteLine("GERAI");
                    break;
                case 9:
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("PUIKIAI");
                    break;
                default:
                    Console.WriteLine("Ivedete neteisinga pazymi");
                    break;

            }




        }

        public class Human
        {
            public string Name;

        }



    }
}
