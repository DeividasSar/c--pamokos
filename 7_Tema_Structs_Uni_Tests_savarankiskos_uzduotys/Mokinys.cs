using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Tema_Structs_Uni_Tests_savarankiskos_uzduotys
{
    struct Mokinys
    {
        public string Name;
        public string LastName;
        public int CourseBegins;
        public int CourseEnds;

        public Mokinys (string name, string lastname, int courseBegins, int courseEnds)
        {
            Name = name;
            LastName = lastname;
            CourseBegins = courseBegins;
            CourseEnds = courseEnds;
        }


        public void ShowMokinys()
        {
            Console.WriteLine($"Mokinio vardas ir pavardė : {Name} {LastName}.\n " +
                $"Kursų pradžia: {CourseBegins}, \n " +
                $"Kursų pabaiga {CourseEnds}");
                
        }

    }
}
