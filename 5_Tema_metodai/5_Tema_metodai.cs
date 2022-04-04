using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tema_5_Methodai
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Klasės darbas
            //Console.WriteLine("Hello World!");

            //int num1 = 5;
            //int num2 = 10;

            //Return Methodai
            //int sum = AddTwoNumbers(5, 10);
            // int sum2 = AddTwoNumbers(num1, num2);

            //Void Methodai
            //List<string> stringList = new List<string>();
            //AddToList(stringList, "Vilnius");
            //AddToList(stringList, "Kaunas");
            //AddToList(stringList, "Klaipeda");

            //List<string> stringList1 = AddToList("Vilnius");
            //List<string> stringList2 = AddToList("Kaunas");
            //List<string> stringList3 = AddToList("Klaipeda");

            ////Public ir Private skirtumas
            ////var testClass = new Test();
            ////testClass.SayHelloPublic("Jonas");


            //MiniCalculator("+", 9, 1);
            //MiniCalculator("-", 8, 4);

            //MiniCalculator2("+", 9, 1);
            //MiniCalculator2("-", 8, 4);
            //}

            //public static int AddTwoNumbers(int x, int y)
            //{
            //    int sum = x + y;
            //    return sum;
            //}

            //public static int SubstractTwoNumbers(int x, int y)
            //{
            //    int diff = x - y;
            //    return diff;
            //}

            //public static void MiniCalculator(string simbolis, int x, int y)
            //{
            //    switch (simbolis)
            //    {
            //        case "+":
            //            int sum = AddTwoNumbers(x, y);
            //            Console.WriteLine($"Suma yra: {sum}");
            //            break;
            //        case "-":
            //            int diff = SubstractTwoNumbers(x, y);
            //            Console.WriteLine($"Skirtumas yra: {diff}");
            //            break;
            //        default:
            //            Console.WriteLine("Nezinomas simbolis");
            //            break;
            //    }
            //}

            ////C# 8 Swtich Expression
            //public static void MiniCalculator2(string simbolis, int x, int y)
            //{
            //    int result = simbolis switch
            //    {
            //        "+" => AddTwoNumbers(x, y),
            //        "-" => SubstractTwoNumbers(x, y),
            //        _ => 0
            //    };

            //    Console.WriteLine($"Resultas {x} {simbolis} {y} = {result}");
            //}




            //public static void AddToList(List<string> stringList, string stringToAdd)  //jei nurodytas void nereikia jokio kintamojo
            //{
            //    stringList.Add(stringToAdd);
            //}

            //public static List<string> AddToList(string stringToAdd)
            //{
            //    List<string> stringList = new List<string>();
            //    stringList.Add(stringToAdd);
            //    return stringList;
            #endregion

            // Užduotys

            #region 1. Uzduotis Parasyti funkcija kuri isveda varda i konsole
            //    IsvestasVardas("name");
            //}
            //private static string IsvestasVardas(string name)
            //{
            //    Console.WriteLine("Iveskite vardą: ");
            //    name = Console.ReadLine();
            //    Console.WriteLine($"Išvestas vardas į konsolę yra: {name}");
            //    return name;
            #endregion

            #region 2. Užduotis Išveda į konsolę bet kokį vardą tiek kartų kiek nurodo parametras 
            //    Console.WriteLine("Įveskite kiek kartų kartoti random vardą");
            //    RandomNameRepeat();



            //}
            //private static void RandomNameRepeat()
            //    // private static string GetNameByUserInput

            //{
            //    int sk = int.Parse(Console.ReadLine());
            //    var names = new string[] { "Petras", "Jonas", "Karolina", "Agnė", "Kotryna", "Paulius", "Alfonsas", "Algis", "Ona", "Irena" };
            //    for (int i = 0; i < sk; i++)
            //    {
            //        var rand = new Random();
            //        var randInd = rand.Next(names.Length);
            //        string RandomName = names[randInd];
            //        Console.WriteLine($"Išrinktas vardas: {RandomName}");
            //    }


            #endregion

            // 3. Uzduotis Parašyti funkciją, kuri gauna string tipo parametrą. Funkcija turi gražinti  eilutę su tiek „#“,kiek simbolių  gautame parametre.

            //    bool InputName = false;
            //    while (InputName == false)
            //    {
            //        Console.WriteLine("Įveskite tekstą:  ");
            //        string name = Console.ReadLine();
            //        if (Regex.IsMatch(name, @"^[a-zA-Z- ]+$"))
            //        {
            //            InputName = true;
            //            int ilgis = name.Length;
            //            for (int i = 0; i < ilgis; i++)
            //            {
            //                Console.WriteLine("#");
            //            }
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Bad input ! ");
            //            InputName = false;
            //        }
            //    }

            //}


            //private static string CorrectString();

            //    public static void KMI ()
            //{
            //        Console.WriteLine("Iveskite savo svori (kg)");
            //        double weight = Convert.ToDouble
            //}

            ConsoleKeyInfo ch;

            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                ch = Console.ReadKey();
                // do something with each key press until escape key is pressed
            } while (ch.Key != ConsoleKey.Escape);


        }

    }
}
    
