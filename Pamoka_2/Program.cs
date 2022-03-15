using System;

namespace Pamoka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Uzduotis kintamieji
            //int x = 10;
            //int y = 20;
            //int temp;

            //Console.WriteLine("PRIES");
            //Console.WriteLine($"X: {x}");
            //Console.WriteLine($"Y: {y}");


            ////temp = x;
            //// x = y;
            //// y = temp;

            //Console.WriteLine("PO");
            //Console.WriteLine($"X: {x}");
            //Console.WriteLine($"Y: {y}");




            //2 Uzduotis 
            //string schoolName = "CodeAcademy";
            //string courseName = "C# kursas";
            //DateTime dateNow = DateTime.Now;
            //string dateNowFormatted = dateNow.ToString("MM/dd/yyyy");


            //3.Uzduotis
            //DateTime courseStartDate = new DateTime(2022, 03, 01);
            //DateTime courseEndDate = new DateTime(2022, 10, 25);
            //double totalDaysDiff = (courseEndDate - courseStartDate).TotalDays;
            //double totalWeeksDiff = totalDaysDiff / 7;





            //Inicializacija
            //int yearOfBirth;
            //string firstName;

            //Deklaravimas
            //var lastName = "Pavardenis";
            //decimal salary = 10m;    //m realizuoja kad čia yra 10; Darbui su pinigais
            //double income = 5000d; // darbui skaičiams su liekana

            //Reikšmės priskyrimas
            //yearOfBirth = 1990;
            //firstName = "Vardenis";

            //DateTime lastPayDay = new DateTime(2022, 03, 07);  //new kai nori parasyti savo
            //DateTime lastPayDay2 = DateTime.Today.AddDays(-1);

            //Console.WriteLine($"Vardas:{firstName}, pavarde: {lastName}");
            //Console.WriteLine("Gimimo metai: {0}, {1}", yearOfBirth, firstName);
            //Console.WriteLine($"Paskutini karta ismoketa alga {lastPayDay2}");






            //LOGINIAI OPERATORIAI

            //bool A1 = false;
            //bool B1 = false;

            //bool A1_OR_B1 = A1 || B1;    //=> FALSE
            //bool A1_AND_B1 = A1 && B1;   //=> FALSE
            //bool A1_NOT = !A1; // => TRUE

            //bool A2 = true;
            //bool B2 = false;

            //bool A2_OR_B2 = A1 || B1;    //=> TRUE
            //bool A2_AND_B2 = A1 && B1;   //=> FALSE
            //bool A1_NOT = !A1; // => FALSE

            //bool A3 = true;
            //bool B3 = true;

            //bool A3_OR_B3 = A1 || B1;    //=> TRUE
            //bool A3_AND_B3 = A3 && B3;   //=> TRUE
            //bool A3_NOT = !A3; // => FALSE


            //string userInput = "Raudona";
            //string raudona = "Raudona";
            //string juoda = "Juoda";
            //string ruzava = "Ruzava";

            //if (userInput == raudona || userInput == juoda || userInput == ruzava)
            //{
            //    Console.WriteLine("Grazi spalva");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            ////pvz
            //string userInput2 = "AB";

            //bool isValidNumber = Int32.TryParse(userInput2, out int number2);

            //if(isValidNumber)
            //{
            //    Console.WriteLine(number2 * 5);
            //}
            //else
            //{
            //    Console.WriteLine("Blogas inputas.");
            //}


            // 4. Uzduotis.
            //Console.WriteLine("Sveiki, iveskite pirma skaiciu");
            //string input1 = Console.ReadLine();

            //bool isValidNumber = Int32.TryParse(input1, out int number1);

            //if (isValidNumber)
            //{
            //    Console.WriteLine("iveskite antra skaiciu");
            //    string input2 = Console.ReadLine();

            //    isValidNumber = Int32.TryParse(input2, out int number2);

            //    if (isValidNumber)
            //    {
            //        bool isEqual = number1 == number2;
            //        Console.WriteLine($"Sie skaiciai: {number1}, { number2} yra { isEqual}");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Blogas ivestas inputas");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Blogas ivestas inputas");
            //}

            // 5. Uzduotis.

            //bool valid;
            //do
            //{
            //    Console.WriteLine("Ivesti pirma skaiciu: ");

            //    string A1 = Console.ReadLine();
            //    valid = Int32.TryParse(A1, out int number1);

            //    if (valid)
            //    {
            //        Console.WriteLine("Ivesti antra skaiciu: ");
            //        string A2 = Console.ReadLine();
            //        valid = Int32.TryParse(A2, out int number2);
            //        if (valid)
            //        {
            //            Console.WriteLine($"{++number1},{--number2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("bad input");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bad input");
            //    }
            //} while (!valid);


            // 6. Uzduotis.

            //Console.WriteLine("Iveskite teksto eilute (eilute tuscia FALSE)");
            //string input1 = Console.ReadLine();

            //bool TestForEmpty(string input)
            //{

            //    return
            //    string.IsNullOrWhiteSpace(input1);
            //}


            //Console.WriteLine(TestForEmpty(input1));




            //Console.WriteLine("Iveskite teksta");
            //string input = Console.ReadLine();
            //bull isValid = string.IsNullOrWhiteSpace(input);

            //if (isValid)
            //{
            //    Console.ReadLine();
            //}







            // 7. Uzduotis.

            //Console.WriteLine("Iveskite skaiciu");
            //string input = Console.ReadLine();

            //int number2;
            //double numberDouble;
            //bool isValidNumber = Int32.TryParse(input, out number2);               //galima int ir viduj tryparse deklaruot
            //bool isValidDouble = Double.TryParse(input, out numberDouble);

            //if (isValidDouble)

            //{
            //    Console.WriteLine($"Sis skaicius: {numberDouble} yra su kableliu");
            //}


            //if (isValidNumber)
            //{
            //    bool arMazesnisUzNuli = number2 < 0;
            //    bool arDidesnisUzNuli = number2 > 0;

            //    if (arMazesnisUzNuli)
            //    {
            //        Console.WriteLine("Skaicius yra nazesnis uz nuli");
            //    }

            //    if (arDidesnisUzNuli)
            //    {
            //        Console.WriteLine("Skaicius yra didesnis uz nuli");
            //    }


            //}


            //8. Uzduotis

            string inputVardas = "jONas";
            string vardas = "Jonas";

            string inputPavarde = "jONauskas";
            string pavarde = "Jonauskas";


            bool arSutampa = inputVardas == vardas;
            bool arSutampaVardas = string.Equals(inputVardas, vardas);
            bool arSutampaPavarde = string.Equals(inputVardas, vardas, StringComparison.OrdinalIgnoreCase);

            if (arSutampaPavarde)
            {
                Console.WriteLine("Vardas sutampa");

            }

            if(arSutampaPavarde)
            {
                Console.WriteLine("Pavarde sutampa");
            }


            //8. Uzduotis.

            //Console.WriteLine("Parasykite savo Varda ir Pavarde palyginimui");
            //string userName;
            //string userLastName;
            //do
            //{
            //    Console.Write("\r\nJūsų vardas: ");
            //    userLastName = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(userName));
            //do
            //{
            //    Console.Write("\r\nJūsų pavardė:");
            //    userLastName = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(userLastName));

            //Console.WriteLine($"\r\nJusu (case insensitive) vardas ir pavarde: {ToName(userName)} {ToName(userLastName)}");
            //Console.ReadKey();
            //Console.Clear();
            //string ToName(string value)
            //{
            //    return value.Substring(0, 1).ToUpper() + "" + value.Substring(1, value.Length - 1).ToLower();
            //}


        }




        //Console.WriteLine("Sveiki, iveskite pirma skaiciu");
        //string input1 = Console.ReadLine();

        //bool isValidNumber1 = Int32.TryParse(input1, out int number1);

        //if (isValidNumber1)
        //{
        //    Console.WriteLine("Iveskite antra skaiciu");
        //    string input2 = Console.ReadLine();

        //    bool isValidNumber2 = Int32.TryParse(input2, out int number2);
        //    if (isValidNumber2)
        //    {
        //        number1++;
        //        number2--;

        //        Console.WriteLine($"number1:{number1}, number2 {number2}");

        //    }







    }
}
